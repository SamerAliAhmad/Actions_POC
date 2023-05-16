#!/bin/bash

#region Functions
indent_resource() {
  declare -n config=$1
  declare -n processed_config=$2
  declare -n processed_config_internal=$3
  local indent=$4
  local no_indent=$5

  if ((${#config[@]} > 0)); then
    for key in "${!config[@]}"; do
      processed_config[$key]="${config[$key]//INDENT_PLACEHOLDER/$indent}"
      processed_config_internal[$key]="${config[$key]//INDENT_PLACEHOLDER/$no_indent}"
    done
  else
    processed_config="${config//INDENT_PLACEHOLDER/$indent}"
    processed_config_internal="${config//INDENT_PLACEHOLDER/$no_indent}"
  fi
}
#endregion
#region Values
#region Static Values
GP3="gp3"
MGOB="mgob"
EFS="efs-sc"
PD_SSD="pd-ssd"
BASE_DIR="helm"
INDENTATION="  "
NO_INDENTATION=""
ADMIN_UI="admin-ui"
DOMAIN="picacity.ai"
TEMPLATES="templates"
CLIENT_UI="client-ui"
GOLDILOCKS="goldilocks"
GLOBAL_TAG="*globalTag"
PROJECT_NAME="districtnex"
ORGANIZATION_NAME="picacity"
INGRESS_CONTROLLER="ingress-controller"
MONGODB_DATA_DATABASE_NAME="DistrictNex"
MONGODB_LOGS_DATABASE_NAME="DistrictNex_Logs"
ALB_CONTROLLER_NAME="aws-load-balancer-controller"
MONGODB_BACKUP_BUCKET="$PROJECT_NAME-backups-bucket/MongoDB"
MONGODB_HOST="{{ .Release.Name }}-mongodb-0.{{ .Release.Name }}-mongodb-headless.{{ .Values.global.namespace }}.svc.cluster.local,{{ .Release.Name }}-mongodb-1.{{ .Release.Name }}-mongodb-headless.{{ .Values.global.namespace }}.svc.cluster.local,{{ .Release.Name }}-mongodb-2.{{ .Release.Name }}-mongodb-headless.{{ .Values.global.namespace }}.svc.cluster.local"
#endregion
#region Placeholders
TAG_PLACEHOLDER="TAG_PLACEHOLDER"
ENV_PLACEHOLDER="ENV_PLACEHOLDER"
PORT_PLACEHOLDER="PORT_PLACEHOLDER"
ENV_NAME_PLACEHOLDER="ENV_NAME_PLACEHOLDER"
CRON_DLL_PLACEHOLDER="CRON_DLL_PLACEHOLDER"
NAMESPACE_PLACEHOLDER="NAMESPACE_PLACEHOLDER"
IMAGE_NAME_PLACEHOLDER="IMAGE_NAME_PLACEHOLDER"
SERVICE_NAME_PLACEHOLDER="SERVICE_NAME_PLACEHOLDER"
RELEASE_NAME_PLACEHOLDER="RELEASE_NAME_PLACEHOLDER"
API_ENDPOINT_PLACEHOLDER="API_ENDPOINT_PLACEHOLDER"
CRON_SCHEDULE_PLACEHOLDER="CRON_SCHEDULE_PLACEHOLDER"
ADMIN_UI_ENDPOINT_PLACEHOLDER="ADMIN_UI_ENDPOINT_PLACEHOLDER"
CLIENT_UI_ENDPOINT_PLACEHOLDER="CLIENT_UI_ENDPOINT_PLACEHOLDER"
WEBSOCKETS_ENDPOINT_PLACEHOLDER="WEBSOCKETS_ENDPOINT_PLACEHOLDER"
API_SSL_CERTIFICATE_PLACEHOLDER="API_SSL_CERTIFICATE_PLACEHOLDER"
ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER="ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER"
CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER="CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER"
WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER="WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER"
#endregion
#region Setups
CHARTS_DIR="$BASE_DIR/charts"
TARGETS_DIR="$BASE_DIR/targets"
mgobChartDir=$CHARTS_DIR/$MGOB
DOCKERHUB_REPO_NAME="picacityai"
TEMPLATES_DIR="$BASE_DIR/$TEMPLATES"
GCP_PROJECT_ID="$PROJECT_NAME-340415"
K8S_CLUSTER_NAME="$PROJECT_NAME-cluster"
IMAGE_PREFIX="$PROJECT_NAME-$ORGANIZATION_NAME"
ingressChartDir=$CHARTS_DIR/$INGRESS_CONTROLLER
SETUP_CLUSTER="aws eks --region me-central-1 update-kubeconfig --name $K8S_CLUSTER_NAME"
AUTOSCALER_ROLE_ARN=$(aws iam get-role --role-name eks-cluster-autoscaler --query 'Role.Arn' --output text)
FS_ID=$(aws efs describe-file-systems --query "FileSystems[?Name=='$PROJECT_NAME-efs'].FileSystemId | [0]" --output text)
#endregion
#region Emails
DEV_EMAIL="dev.lead@$DOMAIN"
ALEC_EMAIL="alec.lai@$DOMAIN"
#endregion
#region Endpoints
API_BASE_ENDPOINT="api.$DOMAIN"
WEBSOCKETS_BASE_ENDPOINT="websockets.$DOMAIN"
CLIENT_UI_BASE_ENDPOINT="districtnex.$DOMAIN"
ADMIN_UI_BASE_ENDPOINT="admin.districtnex.$DOMAIN"

API_ENDPOINT="https://$API_ENDPOINT_PLACEHOLDER"
ASSETS_ENDPOINT="$API_ENDPOINT/Api/FileManagement/Files"
API_GW_INTERNAL_ENDPOINT="http://$PROJECT_NAME-api-gateway"
WEBSOCKETS_ENDPOINT="https://$WEBSOCKETS_ENDPOINT_PLACEHOLDER"
SHARE_ENDPOINT="https://$CLIENT_UI_ENDPOINT_PLACEHOLDER/shared/"
SIGNALR_INTERNAL_ENDPOINT="http://$PROJECT_NAME-signalr-realtime-server"
ENTITY_SHAREVIEW_ENDPOINT="https://$CLIENT_UI_ENDPOINT_PLACEHOLDER/entity-share-view"
#region Paths
VIDEOAI_ASSETS_PATH="$ASSETS_ENDPOINT/VideoAi"
VIDEOAI_JSON_PATH="$VIDEOAI_ASSETS_PATH/JSON/"
VIDEOAI_IMAGE_PATH="$VIDEOAI_ASSETS_PATH/Images/"
#endregion
#endregion
#region App Config
SMTP_EMAIL="$RELEASE_NAME_PLACEHOLDER-smtp-mail"
SMTP_PASSWORD="$RELEASE_NAME_PLACEHOLDER-smtp-password"
SUPPORT_SMTP_EMAIL="$RELEASE_NAME_PLACEHOLDER-smtp-support-mail"
SUPPORT_SMTP_PASSWORD="$RELEASE_NAME_PLACEHOLDER-smtp-support-password"
TELUS_SCOPE="$RELEASE_NAME_PLACEHOLDER-telus-scope"
TELUS_CLIENT_ID="$RELEASE_NAME_PLACEHOLDER-telus-client-id"
TELUS_CUSTOMER_ID="$RELEASE_NAME_PLACEHOLDER-telus-customer-id"
TELUS_CLIENT_SECRET="$RELEASE_NAME_PLACEHOLDER-telus-client-secret"
EDMONTON_API_KEY="$RELEASE_NAME_PLACEHOLDER-edmonton-api-app-token"
MONGODB_CONN_STR="$RELEASE_NAME_PLACEHOLDER-mongodb-instance-connection-string"
SQLSERVER_CONN_STR="$RELEASE_NAME_PLACEHOLDER-sqlserver-instance-connection-string"
#endregion
#region Initializations
devEnvIngressConfig=""
demoEnvIngressConfig=""
devEnvIngressConfigInternal=""
demoEnvIngressConfigInternal=""

mgobValues=""
mgobValuesInternal=""

sharedIngressProperties=""
sharedIngressPropertiesInternal=""

declare -A microservicesConfigs
declare -A microservicesConfigsInternal

declare -A cronJobsConfigs
declare -A cronJobsConfigsInternal
#endregion
#region Environment Specific
DEV_ENV_IDENTIIFIER="dev"
DEMO_ENV_IDENTIIFIER="demo"
DEMO_ENV_DESCRIPTION_BASE64="RGlzdHJpY3ROZXggQVdTIERlbW8gRW52aXJvbm1lbnQ="
DEV_ENV_DESCRIPTION_BASE64="RGlzdHJpY3ROZXggQVdTIERldmVsb3BtZW50IEVudmlyb25tZW50"

DEV_NAMESPACE="$PROJECT_NAME-$DEV_ENV_IDENTIIFIER"
DEV_ENV_RELEASE_NAME="$PROJECT_NAME-$DEV_ENV_IDENTIIFIER"

DEMO_NAMESPACE="$PROJECT_NAME-$DEMO_ENV_IDENTIIFIER"
DEMO_ENV_RELEASE_NAME="$PROJECT_NAME-$DEMO_ENV_IDENTIIFIER"

DEV_ENV_SUBDOMAIN="$DEV_ENV_IDENTIIFIER.aws"
DEMO_ENV_SUBDOMAIN="$DEMO_ENV_IDENTIIFIER"

DEV_API_ENDPOINT="$DEV_ENV_SUBDOMAIN.$API_BASE_ENDPOINT"
DEV_ADMIN_UI_ENDPOINT="$DEV_ENV_SUBDOMAIN.$ADMIN_UI_BASE_ENDPOINT"
DEV_CLIENT_UI_ENDPOINT="$DEV_ENV_SUBDOMAIN.$CLIENT_UI_BASE_ENDPOINT"
DEV_WEBSOCKETS_ENDPOINT="$DEV_ENV_SUBDOMAIN.$WEBSOCKETS_BASE_ENDPOINT"

DEMO_API_ENDPOINT="$DEMO_ENV_SUBDOMAIN.$API_BASE_ENDPOINT"
DEMO_ADMIN_UI_ENDPOINT="$DEMO_ENV_SUBDOMAIN.$ADMIN_UI_BASE_ENDPOINT"
DEMO_CLIENT_UI_ENDPOINT="$DEMO_ENV_SUBDOMAIN.$CLIENT_UI_BASE_ENDPOINT"
DEMO_WEBSOCKETS_ENDPOINT="$DEMO_ENV_SUBDOMAIN.$WEBSOCKETS_BASE_ENDPOINT"

DEV_API_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEV_API_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEV_WEBSOCKETS_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEV_WEBSOCKETS_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEV_CLIENT_UI_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEV_CLIENT_UI_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEV_ADMIN_UI_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEV_ADMIN_UI_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEMO_API_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEMO_API_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEMO_WEBSOCKETS_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEMO_WEBSOCKETS_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEMO_CLIENT_UI_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEMO_CLIENT_UI_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
DEMO_ADMIN_UI_SSL_CERTIFICATE_ARN=$(aws acm list-certificates --query "CertificateSummaryList[?DomainName=='$DEMO_ADMIN_UI_ENDPOINT'].CertificateArn | [0]" --output text --region me-central-1)
#endregion
#endregion
#region Templates Data
#region General
HELM_IGNORE="# Patterns to ignore when building packages.
# This supports shell glob matching, relative path matching, and
# negation (prefixed with !). Only one pattern per line.
.DS_Store
# Common VCS dirs
.git/
.gitignore
.bzr/
.bzrignore
.hg/
.hgignore
.svn/
# Common backup files
*.swp
*.bak
*.tmp
*.orig
*~
# Various IDEs
.project
.idea/
*.tmproj
.vscode/"
microservice_volume_mounts=$(
  cat <<EOF

        volumeMounts:
        - name: messages-volume
          mountPath: /app/Messages.xml
          subPath: Messages.xml
        - name: {{ .Values.name }}-config-volume
          mountPath: /app/App.config
          subPath: App.config
        - name: {{ .Values.name }}-config-volume
          mountPath: /app/WebApi.dll.config
          subPath: App.config
EOF
)
microservice_volumes=$(
  cat <<EOF

      volumes:
      - name: messages-volume
        configMap:
          name: messages
      - name: {{ .Values.name }}-config-volume
        configMap:
          name: {{ .Values.name }}-config
EOF
)
secrets_conf=$(
  cat <<EOF
secrets:
  dockerhub:
    name: "$PROJECT_NAME-dockerhub-registry-key"
    type: "kubernetes.io/dockerconfigjson"
    data:
      dockerconfigjson: "ewoJImF1dGhzIjogewoJCSJodHRwczovL2luZGV4LmRvY2tlci5pby92MS8iOiB7CgkJCSJhdXRoIjogImNHbGpZV05wZEhsaGFUcGtZMnR5WDNCaGRGOURkVWhHWW0weFFWVlhka0ZGVEdOWFZXczJUVVZJU2tGUlRraz0iCgkJfQoJfQp9"
  redis:
    name: "redis-password"
    type: "Opaque"
    data:
      redis_passwords: "OGtaamM5OWtpNThNYkhDTmpi"
  mongodb:
    name: "mongodb-secrets"
    type: "Opaque"
    data:
      mongodb_passwords: "b0xuUHZIUVE4MWlMbVEyVFpUNDc="
      mongodb_root_password: "b0xuUHZIUVE4MWlMbVEyVFpUNDc="
      mongodb_metrics_password: "b0xuUHZIUVE4MWlMbVEyVFpUNDc="
      mongodb_replica_set_key: "YlhrdGMyVmpjbVYwTFhKbGNHeHBZMkZ6WlhRdGEyVjU="
  aws_auth:
    name: "cloud-interface-aws-auth-secrets"
    type: "Opaque"
    data:
      Aws_Access_Key_ID: QUtJQVJCN1I3VFVJSko3V0VWTzY=
      Aws_Secret_Access_Key: MkszTkdFdzUxVm5ERHVuaXA2aWQ3ZTlrTndKK1RyZXFzck44eVBTMw==
EOF
)
storageclass_conf=$(
  cat <<EOF
storageclass:
  $GP3:
    fsType: xfs
    encrypted: "true"
    reclaimPolicy: Retain
    allowVolumeExpansion: true
    volumeBindingMode: WaitForFirstConsumer
  efs:
    fs_id: "$FS_ID"
    reclaimPolicy: Retain
    allowVolumeExpansion: true
    volumeBindingMode: WaitForFirstConsumer
EOF
)
METRICS_SERVER_RELEASE=$(
  cat <<EOF
      - name: metrics-server
        remoteChart: metrics-server
        repo: https://kubernetes-sigs.github.io/metrics-server
        createNamespace: true
        namespace: metrics-server
EOF
)
AWS_EFS_CSI_DRIVER_RELEASE=$(
  cat <<EOF
      - name: aws-efs-csi-driver
        remoteChart: aws-efs-csi-driver
        repo: https://kubernetes-sigs.github.io/aws-efs-csi-driver
        namespace: kube-system
EOF
)
AWS_EBS_CSI_DRIVER_RELEASE=$(
  cat <<EOF
      - name: aws-ebs-csi-driver
        remoteChart: aws-ebs-csi-driver
        repo: https://kubernetes-sigs.github.io/aws-ebs-csi-driver
        namespace: kube-system
EOF
)
GOLDILOCKS_RELEASE=$(
  cat <<EOF
      - name: $GOLDILOCKS
        remoteChart: $GOLDILOCKS
        repo: https://charts.fairwinds.com/stable
        namespace: $GOLDILOCKS
        createNamespace: true
        setValues:
          vpa:
            enabled: true
EOF
)
messages=$(
  cat <<EOM
  messages:
    name: messages
    messagesXml: |-
      <?xml version="1.0" encoding="utf-8"?>
      <MESSAGES>
          <ENGLISH>
              <MESSAGE CODE="ER_0001" CONTENT="ACCESS_DENIED" />
              <MESSAGE CODE="ER_0002" CONTENT="SESSION_INVALID" />
              <MESSAGE CODE="ER_0003" CONTENT="SESSION_EXPIRED" />
              <MESSAGE CODE="BR_0000" CONTENT="%1 already exists!" />
              <MESSAGE CODE="BR_0001" CONTENT="%1 With ID %2 Does not Exist!" />
              <MESSAGE CODE="BR_0002" CONTENT="Invalid Ticket!" />
              <MESSAGE CODE="BR_0003" CONTENT="Invalid Email" />
              <MESSAGE CODE="BR_0004" CONTENT="Report Not Found" />
              <MESSAGE CODE="BR_0005" CONTENT="User Not Found" />
              <MESSAGE CODE="BR_0006" CONTENT="Invalid Password! Re-enter and Try Again" />
              <MESSAGE CODE="BR_0007" CONTENT="User Inactive. Please contact support." />
              <MESSAGE CODE="BR_0008" CONTENT="Email Sending Failed! Check your Email and Try Again." />
              <MESSAGE CODE="BR_0009" CONTENT="Report Not Found!" />
              <MESSAGE CODE="BR_0010" CONTENT="The chosen organization does not exist." />
              <MESSAGE CODE="BR_0011" CONTENT="One of the sites chosen does not exist." />
              <MESSAGE CODE="BR_0012" CONTENT="One of the dimensions chosen does not exist." />
              <MESSAGE CODE="BR_0013" CONTENT="One of the entities chosen does not exist." />
              <MESSAGE CODE="BR_0014" CONTENT="The organization does not have access to this site." />
              <MESSAGE CODE="BR_0015" CONTENT="Invalid Input" />
              <MESSAGE CODE="BR_0016" CONTENT="User does not belong to an organization" />
              <MESSAGE CODE="BR_0017" CONTENT="Organization does not have access to this site." />
              <MESSAGE CODE="BR_0018" CONTENT="Organization does not have access to this dimension in the site." />
              <MESSAGE CODE="BR_0019" CONTENT="The organization does not have access to this entity." />
              <MESSAGE CODE="BR_0020" CONTENT="The user does not have access to this entity." />
              <MESSAGE CODE="BR_0021" CONTENT="Organization not found." />
              <MESSAGE CODE="BR_0022" CONTENT="You do not have access to this content." />
              <MESSAGE CODE="BR_0023" CONTENT="You do not belong to an active organization. Please contact support.." />
              <MESSAGE CODE="BR_0024" CONTENT="Site already belongs to an organization." />
              <MESSAGE CODE="BR_0025" CONTENT="Super Admins can't be deleted." />
              <MESSAGE CODE="BR_0026" CONTENT="Upload Failed." />
              <MESSAGE CODE="BR_0027" CONTENT="Delete Failed." />
              <MESSAGE CODE="BR_0028" CONTENT="Invalid Credentials" />
              <MESSAGE CODE="BR_0029" CONTENT="User ID Cannot be Null!" />
              <MESSAGE CODE="BR_0030" CONTENT="An Error has Occured! Contact Support." />
              <MESSAGE CODE="BR_0031" CONTENT="No OTP exists for this username. Try again." />
              <MESSAGE CODE="BR_0032" CONTENT="Codes do not match! Try Again." />
              <MESSAGE CODE="BR_0033" CONTENT="Only Admins Can Log In." />
              <MESSAGE CODE="BR_0034" CONTENT="This feature is currently unavailable" />
              <MESSAGE CODE="BR_0035" CONTENT="Max user quota reached" />
              <MESSAGE CODE="BR_0036" CONTENT="Max admin quota reached" />
              <MESSAGE CODE="BR_0037" CONTENT="No LPR Engine Active" />
              <MESSAGE CODE="BR_0038" CONTENT="Invalid Credentials or Connection Url" />
              <MESSAGE CODE="BR_0039" CONTENT="Cannot Access Video AI" />
              <MESSAGE CODE="BR_0040" CONTENT="Video ai asset with Space asset ID %2 not found" />
              <MESSAGE CODE="BR_0041" CONTENT="Your account is deactivated. Please contact support." />
              <MESSAGE CODE="BR_0042" CONTENT="No FR Engine Active" />
              <MESSAGE CODE="BR_0043" CONTENT="Request is being processed, try again later" />
              <MESSAGE CODE="BR_0044" CONTENT="Data for %1 on date %2 already exists" />
              <MESSAGE CODE="BR_0045" CONTENT="%1 Setup Not Found." />
              <MESSAGE CODE="BR_0046" CONTENT="%1 Does Not Exist!" />
              <MESSAGE CODE="BR_0047" CONTENT="The user does not have access to any level." />
              <MESSAGE CODE="BR_0048" CONTENT="Request resulting in error, jobId has been deleted, try again" />
              <MESSAGE CODE="BR_0049" CONTENT="Invalid Cloud Provider" />
              <MESSAGE CODE="BR_0050" CONTENT="Couldn't Retrieve Secret" />
              <MESSAGE CODE="BR_0051" CONTENT="Google API Token not found" />
              <MESSAGE CODE="BR_0052" CONTENT="An error has occured, please try again later" />
              <MESSAGE CODE="BR_0053" CONTENT="Failed to Assign Dates: %1" />
              <MESSAGE CODE="BR_0054" CONTENT="Delete failed for Kpi_chart_configuration: %1" />
              <MESSAGE CODE="BR_0055" CONTENT="Delete failed for Dimension_chart_configuration: %1" />
              <MESSAGE CODE="BR_0056" CONTENT="Delete failed for Specialized_chart_configuration: %1" />
              <MESSAGE CODE="BR_0057" CONTENT="Unable to send OTP. Please contact support." />
          </ENGLISH>
      </MESSAGES>
EOM
)
shared_values=$(
  cat <<EOF
$messages
$storageclass_conf
$secrets_conf
tag: &globalTag "$DISTRICTNEX_VERSION"
EOF
)
basePvcValues=$(
  cat <<EOF

INDENT_PLACEHOLDERpvc:
INDENT_PLACEHOLDER  storage: "100Gi"
INDENT_PLACEHOLDER  access_mode: "ReadWriteMany"
INDENT_PLACEHOLDER  storage_class_name: "$EFS"
INDENT_PLACEHOLDER  name: "$PROJECT_NAME-file-management-webapi-pvc"

EOF
)
baseSecretRefName=$(
  cat <<EOF

INDENT_PLACEHOLDERsecrets:
INDENT_PLACEHOLDER  aws_auth:
INDENT_PLACEHOLDER    name: "cloud-interface-aws-auth-secrets"
EOF
)

baseMicroserviceValues=$(
  cat <<EOF
INDENT_PLACEHOLDERname: "$SERVICE_NAME_PLACEHOLDER"
INDENT_PLACEHOLDERimage: "$IMAGE_NAME_PLACEHOLDER"
INDENT_PLACEHOLDERtag: $TAG_PLACEHOLDER
INDENT_PLACEHOLDERk8s_cluster_name: "$K8S_CLUSTER_NAME"
INDENT_PLACEHOLDERreplicas: 1
INDENT_PLACEHOLDERisRedisClient: "true"
INDENT_PLACEHOLDERresourceLimitation: false
INDENT_PLACEHOLDERcontainerPort: $PORT_PLACEHOLDER
INDENT_PLACEHOLDERresources:
INDENT_PLACEHOLDER  limits:
INDENT_PLACEHOLDER    cpu: "100m"
INDENT_PLACEHOLDER    memory: "150Mi"
INDENT_PLACEHOLDER  requests:
INDENT_PLACEHOLDER    cpu: "100m"
INDENT_PLACEHOLDER    memory: "150Mi"
INDENT_PLACEHOLDERhpa:
INDENT_PLACEHOLDER  min: 1
INDENT_PLACEHOLDER  max: 6
INDENT_PLACEHOLDER  cpu: 80
INDENT_PLACEHOLDER  memory: 90
INDENT_PLACEHOLDER  enabled: true
INDENT_PLACEHOLDERservice:
INDENT_PLACEHOLDER  port: 80
INDENT_PLACEHOLDER  protocol: "TCP"
INDENT_PLACEHOLDER  type: "NodePort"
EOF
)
baseCronJobsValues=$(
  cat <<EOF
INDENT_PLACEHOLDERname: "$SERVICE_NAME_PLACEHOLDER"
INDENT_PLACEHOLDERimage: "$IMAGE_NAME_PLACEHOLDER"
INDENT_PLACEHOLDERtag: $TAG_PLACEHOLDER
INDENT_PLACEHOLDERk8s_cluster_name: "$K8S_CLUSTER_NAME"
INDENT_PLACEHOLDERcron_dll: "$CRON_DLL_PLACEHOLDER"
INDENT_PLACEHOLDERisRedisClient: "true"
INDENT_PLACEHOLDERresourceLimitation: false
INDENT_PLACEHOLDERfailedJobsHistoryLimit: 1
INDENT_PLACEHOLDERconcurrencyPolicy: Forbid
INDENT_PLACEHOLDERsuccessfulJobsHistoryLimit: 1
INDENT_PLACEHOLDERttlSecondsAfterFinished: 3600
INDENT_PLACEHOLDERcron_schedule: "$CRON_SCHEDULE_PLACEHOLDER"
INDENT_PLACEHOLDERresources:
INDENT_PLACEHOLDER  limits:
INDENT_PLACEHOLDER    cpu: "100m"
INDENT_PLACEHOLDER    memory: "150Mi"
INDENT_PLACEHOLDER  requests:
INDENT_PLACEHOLDER    cpu: "100m"
INDENT_PLACEHOLDER    memory: "150Mi"
EOF
)
#endregion
#region MongoDB
mongodb_conf=$(
  cat <<EOF
mongodb:
  # Global settings
  global:
    storageClass: "$GP3"
    namespaceOverride: $NAMESPACE_PLACEHOLDER
  # MongoDB settings
  architecture: "replicaset"
  replicaSetName: "rs0"
  replicaCount: 3
  auth:
    rootUser: Scbh3Jk7fxfbS8fZ4D84
    existingSecret: "mongodb-secrets"
  # Persistence settings
  persistence:
    enabled: true
    size: 250Gi
    accessModes:
    - ReadWriteOnce
    storageClassName: "$GP3"
    annotations:
      ebs.csi.aws.com/fsType: "xfs"
    iops: 13750
    throughput: 250
  # Network settings
  # Security settings
  livenessProbe:
    initialDelaySeconds: 20
  readinessProbe:
    initialDelaySeconds: 20
  # TLS
  tls:
    enabled: false
    autoGenerated: false
  # Affinity
  affinity:
    podAntiAffinity:
      requiredDuringSchedulingIgnoredDuringExecution:
      - labelSelector:
          matchLabels:
            app.kubernetes.io/component: mongodb
            app.kubernetes.io/instance: $RELEASE_NAME_PLACEHOLDER
        topologyKey: "kubernetes.io/hostname"
  # Autoscaling
  autoscaling:
    enabled: true
    minReplicas: 3
    maxReplicas: 6
  # MongoDB Extra Flags
  extraFlags:
  - "--wiredTigerCacheSizeGB=2"
EOF
)

mongodb_dev_conf=$(
  echo "${mongodb_conf}" |
    sed \
      -e "s|$NAMESPACE_PLACEHOLDER|$DEV_NAMESPACE|g" \
      -e "s|$RELEASE_NAME_PLACEHOLDER|$DEV_ENV_RELEASE_NAME|g"
)
mongodb_demo_conf=$(
  echo "${mongodb_conf}" |
    sed \
      -e "s|$NAMESPACE_PLACEHOLDER|$DEMO_NAMESPACE|g" \
      -e "s|$RELEASE_NAME_PLACEHOLDER|$DEMO_ENV_RELEASE_NAME|g"
)
#endregion
#region Redis
redis_conf=$(
  cat <<EOF
redis:
  enabled: true
  # Global settings
  global:
    storageClass: "$GP3"
    redis:
      existingSecret: redis-password
  # Master configuration
  master:
    persistence:
      enabled: true
      size: 64Gi
      storageClassName: "$GP3"
      accessModes:
      - ReadWriteOnce
      annotations:
        ebs.csi.aws.com/fsType: "xfs"
    affinity:
      podAntiAffinity:
        requiredDuringSchedulingIgnoredDuringExecution:
        - labelSelector:
            matchLabels:
              app.kubernetes.io/component: node
              app.kubernetes.io/instance: $RELEASE_NAME_PLACEHOLDER
          topologyKey: "kubernetes.io/hostname"
    livenessProbe:
      enabled: true
      initialDelaySeconds: 30
      periodSeconds: 10
      timeoutSeconds: 5
      successThreshold: 1
      failureThreshold: 5
    readinessProbe:
      enabled: true
      initialDelaySeconds: 20
      periodSeconds: 10
      timeoutSeconds: 5
      successThreshold: 1
      failureThreshold: 5
  # Replica configuration
  replica:
    replicaCount: 3
    persistence:
      enabled: true
      size: 64Gi
      storageClassName: "$GP3"
      accessModes:
      - ReadWriteOnce
      annotations:
        ebs.csi.aws.com/fsType: "xfs"
    affinity:
      podAntiAffinity:
        requiredDuringSchedulingIgnoredDuringExecution:
        - labelSelector:
            matchLabels:
              app.kubernetes.io/component: node
              app.kubernetes.io/instance: $RELEASE_NAME_PLACEHOLDER
          topologyKey: "kubernetes.io/hostname"
    livenessProbe:
      enabled: true
      initialDelaySeconds: 30
      periodSeconds: 10
      timeoutSeconds: 5
      successThreshold: 1
      failureThreshold: 5
    readinessProbe:
      enabled: true
      initialDelaySeconds: 20
      periodSeconds: 10
      timeoutSeconds: 5
      successThreshold: 1
      failureThreshold: 5
  # Redis Sentinel configuration
  sentinel:
    enabled: true
    masterSet: redis-master
    sentinelCount: 3
    usePassword: true
  # Network policies
  networkPolicy:
    enabled: true
    allowExternal: false
  # Redis service configuration
  service:
    type: ClusterIP
    port: 6379
    clusterIP: None
  # Additional configuration
  securityContext:
    enabled: true
    fsGroup: 1001
    runAsUser: 1001
EOF
)

redis_dev_conf="${redis_conf//$RELEASE_NAME_PLACEHOLDER/$DEV_ENV_RELEASE_NAME}"
redis_demo_conf="${redis_conf//$RELEASE_NAME_PLACEHOLDER/$DEMO_ENV_RELEASE_NAME}"
#endregion
#region MGOB
baseMgobValues=$(
  cat <<EOF
INDENT_PLACEHOLDERimage: "$MGOB"
INDENT_PLACEHOLDERtag: $TAG_PLACEHOLDER
INDENT_PLACEHOLDERcontainerPort: 8090
INDENT_PLACEHOLDERvolumeClaims:
INDENT_PLACEHOLDER  mgobData:
INDENT_PLACEHOLDER    requests:
INDENT_PLACEHOLDER      storage: 250Gi
INDENT_PLACEHOLDER      storageClassName: "$GP3"
INDENT_PLACEHOLDER      accessMode: "ReadWriteOnce"
INDENT_PLACEHOLDER  mgobStorage:
INDENT_PLACEHOLDER    requests:
INDENT_PLACEHOLDER      storage: 250Gi
INDENT_PLACEHOLDER      storageClassName: "$GP3"
INDENT_PLACEHOLDER      accessMode: "ReadWriteOnce"
INDENT_PLACEHOLDERsecrets:
INDENT_PLACEHOLDER  smtpPassword: "UG9xNTU4OTM="
INDENT_PLACEHOLDER  smtpUsername: "ZGlzdHJpY3RuZXhAcGljYWNpdHkuYWk="
INDENT_PLACEHOLDER  mongodbUsername: "U2NiaDNKazdmeGZiUzhmWjREODQ="
INDENT_PLACEHOLDER  mongodbPassword: "b0xuUHZIUVE4MWlMbVEyVFpUNDc="
INDENT_PLACEHOLDER  awsAccessKey: "QUtJQVJCN1I3VFVJSko3V0VWTzY="
INDENT_PLACEHOLDER  awsSecretKey: "MkszTkdFdzUxVm5ERHVuaXA2aWQ3ZTlrTndKK1RyZXFzck44eVBTMw=="
INDENT_PLACEHOLDER  envName: "$ENV_NAME_PLACEHOLDER"
INDENT_PLACEHOLDERmainDatabase:
INDENT_PLACEHOLDER  port: 27017
INDENT_PLACEHOLDER  timeout: "60"
INDENT_PLACEHOLDER  retention: "10"
INDENT_PLACEHOLDER  cronSchedule: "0 0 * * *"
INDENT_PLACEHOLDER  name: "$MONGODB_DATA_DATABASE_NAME"
INDENT_PLACEHOLDER  bucket: "$MONGODB_BACKUP_BUCKET/$ENV_PLACEHOLDER/$MONGODB_DATA_DATABASE_NAME"
INDENT_PLACEHOLDER  retry:
INDENT_PLACEHOLDER    attempts: 3
INDENT_PLACEHOLDER    backoffFactor: 60
INDENT_PLACEHOLDER  smtp:
INDENT_PLACEHOLDER    port: 587
INDENT_PLACEHOLDER    warnOnly: false
INDENT_PLACEHOLDER    tlsEnabled: true
INDENT_PLACEHOLDER    emailSendRetries: 5
INDENT_PLACEHOLDER    emailSendRetryDelay: 1
INDENT_PLACEHOLDER    emailSendDelayUnit: "Minute"
INDENT_PLACEHOLDER    server: "smtp.office365.com"
INDENT_PLACEHOLDER    encryptionType: EncryptionSTARTTLS
INDENT_PLACEHOLDER    to:
INDENT_PLACEHOLDER    - "$DEV_EMAIL"
INDENT_PLACEHOLDER    - "$ALEC_EMAIL"
INDENT_PLACEHOLDERlogsDatabase:
INDENT_PLACEHOLDER  port: 27017
INDENT_PLACEHOLDER  timeout: "60"
INDENT_PLACEHOLDER  retention: "10"
INDENT_PLACEHOLDER  cronSchedule: "0 0 * * *"
INDENT_PLACEHOLDER  name: "$MONGODB_LOGS_DATABASE_NAME"
INDENT_PLACEHOLDER  bucket: "$MONGODB_BACKUP_BUCKET/$ENV_PLACEHOLDER/$MONGODB_LOGS_DATABASE_NAME"
INDENT_PLACEHOLDER  retry:
INDENT_PLACEHOLDER    attempts: 3
INDENT_PLACEHOLDER    backoffFactor: 60
INDENT_PLACEHOLDER  smtp:
INDENT_PLACEHOLDER    port: 587
INDENT_PLACEHOLDER    warnOnly: false
INDENT_PLACEHOLDER    tlsEnabled: true
INDENT_PLACEHOLDER    emailSendRetries: 5
INDENT_PLACEHOLDER    emailSendRetryDelay: 1
INDENT_PLACEHOLDER    emailSendDelayUnit: "Minute"
INDENT_PLACEHOLDER    server: "smtp.office365.com"
INDENT_PLACEHOLDER    encryptionType: EncryptionSTARTTLS
INDENT_PLACEHOLDER    to:
INDENT_PLACEHOLDER    - "$DEV_EMAIL"
INDENT_PLACEHOLDER    - "$ALEC_EMAIL"
EOF
)

indent_resource baseMgobValues mgobValues mgobValuesInternal "$INDENTATION" "$NO_INDENTATION"

mgobValues=$(
  cat <<EOF
$MGOB:
$mgobValues
EOF
)

mgobValuesDemo=$(
  echo "${mgobValues}" |
    sed \
      -e "s|$TAG_PLACEHOLDER|$GLOBAL_TAG|g" \
      -e "s|$ENV_PLACEHOLDER|$DEMO_ENV_IDENTIIFIER|g" \
      -e "s|$ENV_NAME_PLACEHOLDER|$DEMO_ENV_DESCRIPTION_BASE64|g"
)
mgobValues=$(
  echo "${mgobValues}" |
    sed \
      -e "s|$TAG_PLACEHOLDER|$GLOBAL_TAG|g" \
      -e "s|$ENV_PLACEHOLDER|$DEV_ENV_IDENTIIFIER|g" \
      -e "s|$ENV_NAME_PLACEHOLDER|$DEV_ENV_DESCRIPTION_BASE64|g"
)
mgobValuesInternal=$(
  echo "${mgobValuesInternal}" |
    sed \
      -e "s|$TAG_PLACEHOLDER|$DISTRICTNEX_VERSION|g" \
      -e "s|$ENV_PLACEHOLDER|$DEV_ENV_IDENTIIFIER|g" \
      -e "s|$ENV_NAME_PLACEHOLDER|$DEV_ENV_DESCRIPTION_BASE64|g"
)
#endregion
#region Ingress Controller
baseIngressConfig=$(
  cat <<EOF
INDENT_PLACEHOLDERapi:
INDENT_PLACEHOLDER  endpoint: "$API_ENDPOINT_PLACEHOLDER"
INDENT_PLACEHOLDER  backendServiceName: "$PROJECT_NAME-api-gateway"
INDENT_PLACEHOLDER  backendServicePort: 80
INDENT_PLACEHOLDER  certificateARN: "$API_SSL_CERTIFICATE_PLACEHOLDER"
INDENT_PLACEHOLDERwebsockets:
INDENT_PLACEHOLDER  endpoint: "$WEBSOCKETS_ENDPOINT_PLACEHOLDER"
INDENT_PLACEHOLDER  backendServiceName: "$PROJECT_NAME-signalr-realtime-server"
INDENT_PLACEHOLDER  backendServicePort: 80
INDENT_PLACEHOLDER  certificateARN: "$WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER"
INDENT_PLACEHOLDERclientsUI:
INDENT_PLACEHOLDER  endpoint: "$CLIENT_UI_ENDPOINT_PLACEHOLDER"
INDENT_PLACEHOLDER  backendServiceName: "$PROJECT_NAME-$CLIENT_UI"
INDENT_PLACEHOLDER  backendServicePort: 80
INDENT_PLACEHOLDER  certificateARN: "$CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER"
INDENT_PLACEHOLDERadminUI:
INDENT_PLACEHOLDER  endpoint: "$ADMIN_UI_ENDPOINT_PLACEHOLDER"
INDENT_PLACEHOLDER  backendServiceName: "$PROJECT_NAME-$ADMIN_UI"
INDENT_PLACEHOLDER  backendServicePort: 80
INDENT_PLACEHOLDER  certificateARN: "$ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER"
EOF
)

baseSharedIngressProperties=$(
  cat <<EOF
INDENT_PLACEHOLDERingressClass: "alb"
INDENT_PLACEHOLDERscheme: "internet-facing"
INDENT_PLACEHOLDERlisten_ports: '[{"HTTP": 80}, {"HTTPS":443}]'
INDENT_PLACEHOLDERssl_redirect: '{"Type": "redirect", "RedirectConfig": { "Protocol": "HTTPS", "Port": "443", "StatusCode": "HTTP_301"}}'
EOF
)

indent_resource baseSharedIngressProperties sharedIngressProperties sharedIngressPropertiesInternal "$INDENTATION" "$NO_INDENTATION"

indent_resource baseIngressConfig devEnvIngressConfig devEnvIngressConfigInternal "$INDENTATION" "$NO_INDENTATION"
indent_resource baseIngressConfig demoEnvIngressConfig demoEnvIngressConfigInternal "$INDENTATION" "$NO_INDENTATION"

devEnvIngressConfig=$(
  echo "${devEnvIngressConfig}" |
    sed \
      -e "s|$API_SSL_CERTIFICATE_PLACEHOLDER|$DEV_API_SSL_CERTIFICATE_ARN|g" \
      -e "s|$WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER|$DEV_WEBSOCKETS_SSL_CERTIFICATE_ARN|g" \
      -e "s|$CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEV_CLIENT_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEV_ADMIN_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$API_ENDPOINT_PLACEHOLDER|$DEV_API_ENDPOINT|g" \
      -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEV_ADMIN_UI_ENDPOINT|g" \
      -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEV_CLIENT_UI_ENDPOINT|g" \
      -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEV_WEBSOCKETS_ENDPOINT|g"
)
demoEnvIngressConfig=$(
  echo "${demoEnvIngressConfig}" |
    sed \
      -e "s|$API_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_API_SSL_CERTIFICATE_ARN|g" \
      -e "s|$WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_WEBSOCKETS_SSL_CERTIFICATE_ARN|g" \
      -e "s|$CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_CLIENT_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_ADMIN_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$API_ENDPOINT_PLACEHOLDER|$DEMO_API_ENDPOINT|g" \
      -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEMO_ADMIN_UI_ENDPOINT|g" \
      -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEMO_CLIENT_UI_ENDPOINT|g" \
      -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEMO_WEBSOCKETS_ENDPOINT|g"
)
devEnvIngressConfigInternal=$(
  echo "${devEnvIngressConfigInternal}" |
    sed \
      -e "s|$API_SSL_CERTIFICATE_PLACEHOLDER|$DEV_API_SSL_CERTIFICATE_ARN|g" \
      -e "s|$WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER|$DEV_WEBSOCKETS_SSL_CERTIFICATE_ARN|g" \
      -e "s|$CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEV_CLIENT_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEV_ADMIN_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$API_ENDPOINT_PLACEHOLDER|$DEV_API_ENDPOINT|g" \
      -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEV_ADMIN_UI_ENDPOINT|g" \
      -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEV_CLIENT_UI_ENDPOINT|g" \
      -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEV_WEBSOCKETS_ENDPOINT|g"
)
demoEnvIngressConfigInternal=$(
  echo "${demoEnvIngressConfigInternal}" |
    sed \
      -e "s|$API_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_API_SSL_CERTIFICATE_ARN|g" \
      -e "s|$WEBSOCKETS_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_WEBSOCKETS_SSL_CERTIFICATE_ARN|g" \
      -e "s|$CLIENT_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_CLIENT_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$ADMIN_UI_SSL_CERTIFICATE_PLACEHOLDER|$DEMO_ADMIN_UI_SSL_CERTIFICATE_ARN|g" \
      -e "s|$API_ENDPOINT_PLACEHOLDER|$DEMO_API_ENDPOINT|g" \
      -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEMO_ADMIN_UI_ENDPOINT|g" \
      -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEMO_CLIENT_UI_ENDPOINT|g" \
      -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEMO_WEBSOCKETS_ENDPOINT|g"
)

ingressControllerValues=$(
  cat <<EOM
$INGRESS_CONTROLLER:
  enabled: true
$sharedIngressProperties
EOM
)
ingressValuesDev=$(
  cat <<EOF
$ingressControllerValues
$devEnvIngressConfig
EOF
)
ingressValuesDemo=$(
  cat <<EOF
$ingressControllerValues
$demoEnvIngressConfig
EOF
)
ingressValuesDevInternal=$(
  cat <<EOF
$sharedIngressPropertiesInternal
$devEnvIngressConfigInternal
EOF
)
#endregion
#region Skaffold
SKAFFOLD_PROFILES=(
  "$DEV_ENV_IDENTIIFIER:$DEV_ENV_RELEASE_NAME:$DEV_NAMESPACE"
  "$DEMO_ENV_IDENTIIFIER:$DEMO_ENV_RELEASE_NAME:$DEMO_NAMESPACE"
)

declare -A PROFILE_EXTRA_RELEASES=(
  [$DEV_ENV_IDENTIIFIER]=$(
    cat <<EOM

$METRICS_SERVER_RELEASE
$AWS_EFS_CSI_DRIVER_RELEASE
$AWS_EBS_CSI_DRIVER_RELEASE
$GOLDILOCKS_RELEASE
EOM
  )
  [$DEMO_ENV_IDENTIIFIER]=$(
    cat <<EOM

$METRICS_SERVER_RELEASE
$AWS_EFS_CSI_DRIVER_RELEASE
$AWS_EBS_CSI_DRIVER_RELEASE
$GOLDILOCKS_RELEASE
EOM
  )
)

declare -A PROFILE_VALUES=(
  [$DEV_ENV_IDENTIIFIER]=$(
    cat <<EOM
global:
  env: "Development"
  repository: "$DOCKERHUB_REPO_NAME"
  project_name: "$PROJECT_NAME"
  namespace: "$DEV_NAMESPACE"
  autoscaler_role_arn: "$AUTOSCALER_ROLE_ARN"
  k8s_cluster_name: "$K8S_CLUSTER_NAME"
$shared_values
$mongodb_dev_conf
$redis_dev_conf
$ingressValuesDev
$mgobValues
EOM
  )
  [$DEMO_ENV_IDENTIIFIER]=$(
    cat <<EOM
global:
  env: "Demo"
  repository: "$DOCKERHUB_REPO_NAME"
  project_name: "$PROJECT_NAME"
  namespace: "$DEMO_NAMESPACE"
  autoscaler_role_arn: "$AUTOSCALER_ROLE_ARN"
  k8s_cluster_name: "$K8S_CLUSTER_NAME"
$shared_values
$mongodb_demo_conf
$redis_demo_conf
$ingressValuesDemo
$mgobValuesDemo
EOM
  )
)
#endregion
#region Templates
declare -A templates=(
  #region Global Templates
  ["$TEMPLATES_DIR/cluster-autoscaler.yaml"]=$(
    cat <<EOM
{{- \$existingServiceAccount := lookup "v1" "ServiceAccount" "kube-system" "cluster-autoscaler" }}
{{- if not \$existingServiceAccount }}
apiVersion: v1
kind: ServiceAccount
metadata:
  name: cluster-autoscaler
  namespace: kube-system
  labels:
    chartVersion: {{ .Chart.Version }}
    k8s-app: cluster-autoscaler
    k8s-addon: cluster-autoscaler.addons.k8s.io
  annotations:
    eks.amazonaws.com/role-arn: {{ .Values.global.autoscaler_role_arn }}
---
{{- end }}
{{- \$existingRole := lookup "rbac.authorization.k8s.io/v1" "Role" "kube-system" "cluster-autoscaler" }}
{{- if not \$existingRole }}
apiVersion: rbac.authorization.k8s.io/v1
kind: Role
metadata:
  name: cluster-autoscaler
  namespace: kube-system
  labels:
    chartVersion: {{ .Chart.Version }}
    k8s-addon: cluster-autoscaler.addons.k8s.io
    k8s-app: cluster-autoscaler
rules:
  - apiGroups: [""]
    resources: ["configmaps"]
    verbs: ["create", "list", "watch"]
  - apiGroups: [""]
    resources: ["configmaps"]
    resourceNames:
      ["cluster-autoscaler-status", "cluster-autoscaler-priority-expander"]
    verbs: ["delete", "get", "update", "watch"]
---
{{- end }}
{{- \$existingRoleBinding := lookup "rbac.authorization.k8s.io/v1" "RoleBinding" "kube-system" "cluster-autoscaler" }}
{{- if not \$existingRoleBinding }}
apiVersion: rbac.authorization.k8s.io/v1
kind: RoleBinding
metadata:
  name: cluster-autoscaler
  namespace: kube-system
  labels:
    chartVersion: {{ .Chart.Version }}
    k8s-addon: cluster-autoscaler.addons.k8s.io
    k8s-app: cluster-autoscaler
roleRef:
  apiGroup: rbac.authorization.k8s.io
  kind: Role
  name: cluster-autoscaler
subjects:
  - kind: ServiceAccount
    name: cluster-autoscaler
    namespace: kube-system
---
{{- end }}
{{- \$existingClusterRole := lookup "rbac.authorization.k8s.io/v1" "ClusterRole" "" "cluster-autoscaler" }}
{{- if not \$existingClusterRole }}
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRole
metadata:
  name: cluster-autoscaler
  labels:
    chartVersion: {{ .Chart.Version }}
    k8s-addon: cluster-autoscaler.addons.k8s.io
    k8s-app: cluster-autoscaler
rules:
  - apiGroups: [""]
    resources: ["events", "endpoints"]
    verbs: ["create", "patch"]
  - apiGroups: [""]
    resources: ["pods/eviction"]
    verbs: ["create"]
  - apiGroups: [""]
    resources: ["pods/status"]
    verbs: ["update"]
  - apiGroups: [""]
    resources: ["endpoints"]
    resourceNames: ["cluster-autoscaler"]
    verbs: ["get", "update"]
  - apiGroups: [""]
    resources: ["nodes"]
    verbs: ["watch", "list", "get", "update"]
  - apiGroups: [""]
    resources:
      - "namespaces"
      - "pods"
      - "services"
      - "replicationcontrollers"
      - "persistentvolumeclaims"
      - "persistentvolumes"
    verbs: ["watch", "list", "get"]
  - apiGroups: ["extensions"]
    resources: ["replicasets", "daemonsets"]
    verbs: ["watch", "list", "get"]
  - apiGroups: ["policy"]
    resources: ["poddisruptionbudgets"]
    verbs: ["watch", "list"]
  - apiGroups: ["apps"]
    resources: ["statefulsets", "replicasets", "daemonsets"]
    verbs: ["watch", "list", "get"]
  - apiGroups: ["storage.k8s.io"]
    resources:
      ["storageclasses", "csinodes", "csidrivers", "csistoragecapacities"]
    verbs: ["watch", "list", "get"]
  - apiGroups: ["batch", "extensions"]
    resources: ["jobs"]
    verbs: ["get", "list", "watch", "patch"]
  - apiGroups: ["coordination.k8s.io"]
    resources: ["leases"]
    verbs: ["create"]
  - apiGroups: ["coordination.k8s.io"]
    resourceNames: ["cluster-autoscaler"]
    resources: ["leases"]
    verbs: ["get", "update"]
---
{{- end }}
{{- \$existingClusterRoleBinding := lookup "rbac.authorization.k8s.io/v1" "ClusterRoleBinding" "" "cluster-autoscaler" }}
{{- if not \$existingClusterRoleBinding }}
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRoleBinding
metadata:
  name: cluster-autoscaler
  labels:
    chartVersion: {{ .Chart.Version }}
    k8s-addon: cluster-autoscaler.addons.k8s.io
    k8s-app: cluster-autoscaler
roleRef:
  apiGroup: rbac.authorization.k8s.io
  kind: ClusterRole
  name: cluster-autoscaler
subjects:
  - kind: ServiceAccount
    name: cluster-autoscaler
    namespace: kube-system
---
{{- end }}
{{- \$existingDeployment := lookup "apps/v1" "Deployment" "kube-system" "cluster-autoscaler" }}
{{- if not \$existingDeployment }}
apiVersion: apps/v1
kind: Deployment
metadata:
  name: cluster-autoscaler
  namespace: kube-system
  labels:
    chartVersion: {{ .Chart.Version }}
    app: cluster-autoscaler
spec:
  replicas: 1
  selector:
    matchLabels:
      app: cluster-autoscaler
  template:
    metadata:
      labels:
        app: cluster-autoscaler
    spec:
      priorityClassName: system-cluster-critical
      securityContext:
        runAsNonRoot: true
        runAsUser: 65534
        fsGroup: 65534
      serviceAccountName: cluster-autoscaler
      containers:
        - image: registry.k8s.io/autoscaling/cluster-autoscaler:v1.26.2
          name: cluster-autoscaler
          resources:
            limits:
              cpu: 100m
              memory: 600Mi
            requests:
              cpu: 100m
              memory: 600Mi
          command:
            - ./cluster-autoscaler
            - --v=4
            - --stderrthreshold=info
            - --cloud-provider=aws
            - --skip-nodes-with-local-storage=false
            - --expander=least-waste
            - --node-group-auto-discovery=asg:tag=k8s.io/cluster-autoscaler/enabled,k8s.io/cluster-autoscaler/{{ .Values.global.k8s_cluster_name }}
          volumeMounts:
            - name: ssl-certs
              mountPath: /etc/ssl/certs/ca-certificates.crt
              readOnly: true
      volumes:
        - name: ssl-certs
          hostPath:
            path: "/etc/ssl/certs/ca-bundle.crt"
{{- end }}
EOM
  )
  ["$TEMPLATES_DIR/configmaps.yaml"]=$(
    cat <<EOM
apiVersion: v1
kind: ConfigMap
metadata:
  name: {{ .Values.global.messages.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
data:
  Messages.xml: {{ .Values.global.messages.messagesXml | toYaml | indent 1 }}
EOM
  )
  ["$TEMPLATES_DIR/rbac.yaml"]=$(
    cat <<EOM
{{- \$existingRole := lookup "rbac.authorization.k8s.io/v1" "Role" "$GOLDILOCKS" "$GOLDILOCKS-role" }}
{{- if not \$existingRole }}
apiVersion: rbac.authorization.k8s.io/v1
kind: Role
metadata:
  name: $GOLDILOCKS-role
  namespace: $GOLDILOCKS
  labels:
    chartVersion: {{ .Chart.Version }}
rules:
- apiGroups: ["batch"]
  resources: ["jobs", "cronjobs"]
  verbs: ["list"]
---
{{- end }}
{{- \$existingRoleBinding := lookup "rbac.authorization.k8s.io/v1" "RoleBinding" "$GOLDILOCKS" "$GOLDILOCKS-rolebinding" }}
{{- if not \$existingRoleBinding }}
apiVersion: rbac.authorization.k8s.io/v1
kind: RoleBinding
metadata:
  name: $GOLDILOCKS-rolebinding
  namespace: $GOLDILOCKS
  labels:
    chartVersion: {{ .Chart.Version }}
roleRef:
  apiGroup: rbac.authorization.k8s.io
  kind: Role
  name: $GOLDILOCKS-role
subjects:
- kind: ServiceAccount
  name: $PROJECT_NAME-$GOLDILOCKS-controller
  namespace: $GOLDILOCKS
{{- end }}
EOM
  )
  ["$TEMPLATES_DIR/secrets.yaml"]=$(
    cat <<EOM
apiVersion: v1
kind: Secret
metadata:
  name: {{ .Values.secrets.dockerhub.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
data:
  .dockerconfigjson: {{ .Values.secrets.dockerhub.data.dockerconfigjson }}
type: {{ .Values.secrets.dockerhub.type }}
---
apiVersion: v1
kind: Secret
metadata:
  name: {{ .Values.secrets.redis.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
type: {{ .Values.secrets.redis.type }}
data:
  redis-password: {{ .Values.secrets.redis.data.redis_passwords }}
---
apiVersion: v1
kind: Secret
metadata:
  name: {{ .Values.secrets.mongodb.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
type: {{ .Values.secrets.mongodb.type }}
data:
  mongodb-passwords: {{ .Values.secrets.mongodb.data.mongodb_passwords }}
  mongodb-root-password: {{ .Values.secrets.mongodb.data.mongodb_root_password }}
  mongodb-metrics-password: {{ .Values.secrets.mongodb.data.mongodb_metrics_password }}
  mongodb-replica-set-key: {{ .Values.secrets.mongodb.data.mongodb_replica_set_key }}
---
apiVersion: v1
kind: Secret
metadata:
  name: {{ .Values.secrets.aws_auth.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
type: {{ .Values.secrets.aws_auth.type }}
data:
  AWS_ACCESS_KEY_ID: {{ .Values.secrets.aws_auth.data.Aws_Access_Key_ID }}
  AWS_SECRET_ACCESS_KEY: {{ .Values.secrets.aws_auth.data.Aws_Secret_Access_Key }}
EOM
  )
  ["$TEMPLATES_DIR/storageclass.yaml"]=$(
    cat <<EOM
{{- \$existingStorageClass := lookup "storage.k8s.io/v1" "StorageClass" "" "$GP3" }}
{{- if not \$existingStorageClass }}
kind: StorageClass
apiVersion: storage.k8s.io/v1
metadata:
  name: $GP3
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    "helm.sh/resource-policy": keep
    "helm.sh/hook-weight": "1"
    "helm.sh/hook": post-install,post-upgrade
parameters:
  type: $GP3
  fsType: {{ .Values.storageclass.$GP3.fsType }}
  encrypted: "{{ .Values.storageclass.$GP3.encrypted }}"
provisioner: ebs.csi.aws.com
reclaimPolicy: {{ .Values.storageclass.$GP3.reclaimPolicy }}
volumeBindingMode: {{ .Values.storageclass.$GP3.volumeBindingMode }}
allowVolumeExpansion: {{ .Values.storageclass.$GP3.allowVolumeExpansion }}
---
{{- end }}
{{- \$existingStorageClass := lookup "storage.k8s.io/v1" "StorageClass" "" "$EFS" }}
{{- if not \$existingStorageClass }}
kind: StorageClass
apiVersion: storage.k8s.io/v1
metadata:
  name: $EFS
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    "helm.sh/resource-policy": keep
    "helm.sh/hook-weight": "1"
    "helm.sh/hook": post-install,post-upgrade
parameters:
  directoryPerms: "700"
  provisioningMode: efs-ap
  fileSystemId: {{ .Values.storageclass.efs.fs_id }}
provisioner: efs.csi.aws.com
reclaimPolicy: {{ .Values.storageclass.efs.reclaimPolicy }}
volumeBindingMode: {{ .Values.storageclass.efs.volumeBindingMode }}
allowVolumeExpansion: {{ .Values.storageclass.efs.allowVolumeExpansion }}
{{- end }}
EOM
  )
  #endregion
  #region Ingres Controller Templates
  ["$ingressChartDir/$TEMPLATES/$INGRESS_CONTROLLER.yaml"]=$(
    cat <<EOM
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: {{ .Values.api.backendServiceName }}-reverse-proxy-ingress
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    kubernetes.io/ingress.class: "{{ .Values.ingressClass }}"
    alb.ingress.kubernetes.io/scheme: "{{ .Values.scheme }}"
    alb.ingress.kubernetes.io/listen-ports: '{{ .Values.listen_ports }}'
    alb.ingress.kubernetes.io/certificate-arn: "{{ .Values.api.certificateARN }}"
    alb.ingress.kubernetes.io/actions.ssl-redirect: '{{ .Values.ssl_redirect }}'
spec:
  rules:
  - http:
      paths:
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: ssl-redirect
            port:
              name: use-annotation
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: {{ .Values.api.backendServiceName }}-reverse-proxy
            port:
              number: {{ .Values.api.backendServicePort }}
---
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: {{ .Values.websockets.backendServiceName }}-reverse-proxy-ingress
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    kubernetes.io/ingress.class: "{{ .Values.ingressClass }}"
    alb.ingress.kubernetes.io/scheme: "{{ .Values.scheme }}"
    alb.ingress.kubernetes.io/listen-ports: '{{ .Values.listen_ports }}'
    alb.ingress.kubernetes.io/certificate-arn: "{{ .Values.websockets.certificateARN }}"
    alb.ingress.kubernetes.io/actions.ssl-redirect: '{{ .Values.ssl_redirect }}'
spec:
  rules:
  - http:
      paths:
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: ssl-redirect
            port:
              name: use-annotation
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: {{ .Values.websockets.backendServiceName }}-reverse-proxy
            port:
              number: {{ .Values.websockets.backendServicePort }}
---
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: {{ .Values.clientsUI.backendServiceName }}-ingress
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    kubernetes.io/ingress.class: "{{ .Values.ingressClass }}"
    alb.ingress.kubernetes.io/scheme: "{{ .Values.scheme }}"
    alb.ingress.kubernetes.io/listen-ports: '{{ .Values.listen_ports }}'
    alb.ingress.kubernetes.io/certificate-arn: "{{ .Values.clientsUI.certificateARN }}"
    alb.ingress.kubernetes.io/actions.ssl-redirect: '{{ .Values.ssl_redirect }}'
spec:
  rules:
  - http:
      paths:
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: ssl-redirect
            port:
              name: use-annotation
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: {{ .Values.clientsUI.backendServiceName }}
            port:
              number: {{ .Values.clientsUI.backendServicePort }}
---
apiVersion: networking.k8s.io/v1
kind: Ingress
metadata:
  name: {{ .Values.adminUI.backendServiceName }}-ingress
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    kubernetes.io/ingress.class: "{{ .Values.ingressClass }}"
    alb.ingress.kubernetes.io/scheme: "{{ .Values.scheme }}"
    alb.ingress.kubernetes.io/listen-ports: '{{ .Values.listen_ports }}'
    alb.ingress.kubernetes.io/certificate-arn: "{{ .Values.adminUI.certificateARN }}"
    alb.ingress.kubernetes.io/actions.ssl-redirect: '{{ .Values.ssl_redirect }}'
spec:
  rules:
  - http:
      paths:
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: ssl-redirect
            port:
              name: use-annotation
      - path: /*
        pathType: ImplementationSpecific
        backend:
          service:
            name: {{ .Values.adminUI.backendServiceName }}
            port:
              number: {{ .Values.adminUI.backendServicePort }}
EOM
  )
  ["$ingressChartDir/.helmignore"]=$(
    cat <<EOM
$HELM_IGNORE
EOM
  )
  ["$ingressChartDir/Chart.yaml"]=$(
    cat <<EOM
apiVersion: v2
name: $INGRESS_CONTROLLER
description: A Helm chart for $INGRESS_CONTROLLER
type: application
version: $DISTRICTNEX_VERSION
EOM
  )
  ["$ingressChartDir/values.yaml"]=$(
    cat <<EOM
$ingressValuesDevInternal
EOM
  )
  #endregion
  #region MGOB
  ["$mgobChartDir/$TEMPLATES/$MGOB.yaml"]=$(
    cat <<EOM
apiVersion: v1
kind: Secret
metadata:
  name: $MGOB-secrets
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
type: Opaque
data:
  smtp_password: {{ .Values.secrets.smtpPassword }}
  smtp_username: {{ .Values.secrets.smtpUsername }}
  aws_access_key: {{ .Values.secrets.awsAccessKey }}
  aws_secret_key: {{ .Values.secrets.awsSecretKey }}
  mongodb_username: {{ .Values.secrets.mongodbUsername }}
  mongodb_password: {{ .Values.secrets.mongodbPassword }}
  env_name: {{ .Values.secrets.envName }}
---
apiVersion: v1
kind: ConfigMap
metadata:
  name: $MGOB-gstore-config
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
    role: mongo-backup
data:
  {{ .Values.logsDatabase.name }}.yml: |
    target:
      host: "$MONGODB_HOST"
      port: {{ .Values.logsDatabase.port }}
      database: "{{ .Values.logsDatabase.name }}"
      username: "mongodb_username"
      password: "mongodb_password"
      params: "--authenticationDatabase admin"
    scheduler:
      cron: "{{ .Values.logsDatabase.cronSchedule }}"
      retention: {{ .Values.logsDatabase.retention }}
      timeout: {{ .Values.logsDatabase.timeout }}
    s3:
      api: "S3v4"
      url: "https://s3.amazonaws.com"
      bucket: "{{ .Values.logsDatabase.bucket }}"
      accessKey: "aws_access_key"
      secretKey: "aws_secret_key"
    smtp:
      server: {{ .Values.logsDatabase.smtp.server }}
      port: {{ .Values.logsDatabase.smtp.port }}
      emailSendRetries: {{ .Values.logsDatabase.smtp.emailSendRetries }}
      emailSendRetryDelay: {{ .Values.logsDatabase.smtp.emailSendRetryDelay }}
      emailSendDelayUnit: {{ .Values.logsDatabase.smtp.emailSendDelayUnit }}
      username: "smtp_username"
      password: "smtp_password"
      from: "smtp_username"
      to:
      {{- range .Values.logsDatabase.smtp.to }}
        - {{ . | quote }}
      {{- end }}
      warnOnly: {{ .Values.logsDatabase.smtp.warnOnly }}
      tlsEnabled: {{ .Values.logsDatabase.smtp.tlsEnabled }}
      encryptionType: {{ .Values.logsDatabase.smtp.encryptionType }}
    retry:
      attempts: {{ .Values.logsDatabase.retry.attempts }}
      backoffFactor: {{ .Values.logsDatabase.retry.backoffFactor }}
  {{ .Values.mainDatabase.name }}.yml: |
    target:
      host: "$MONGODB_HOST"
      port: {{ .Values.mainDatabase.port }}
      database: "{{ .Values.mainDatabase.name }}"
      username: "mongodb_username"
      password: "mongodb_password"
      params: "--authenticationDatabase admin"
    scheduler:
      cron: "{{ .Values.mainDatabase.cronSchedule }}"
      retention: {{ .Values.mainDatabase.retention }}
      timeout: {{ .Values.mainDatabase.timeout }}
    s3:
      api: "S3v4"
      url: "https://s3.amazonaws.com"
      bucket: "{{ .Values.mainDatabase.bucket }}"
      accessKey: "aws_access_key"
      secretKey: "aws_secret_key"
    smtp:
      server: {{ .Values.mainDatabase.smtp.server }}
      port: {{ .Values.mainDatabase.smtp.port }}
      emailSendRetries: {{ .Values.mainDatabase.smtp.emailSendRetries }}
      emailSendRetryDelay: {{ .Values.mainDatabase.smtp.emailSendRetryDelay }}
      emailSendDelayUnit: {{ .Values.mainDatabase.smtp.emailSendDelayUnit }}
      username: "smtp_username"
      password: "smtp_password"
      from: "smtp_username"
      to:
      {{- range .Values.mainDatabase.smtp.to }}
        - {{ . | quote }}
      {{- end }}
      warnOnly: {{ .Values.mainDatabase.smtp.warnOnly }}
      tlsEnabled: {{ .Values.mainDatabase.smtp.tlsEnabled }}
      encryptionType: {{ .Values.mainDatabase.smtp.encryptionType }}
    retry:
      attempts: {{ .Values.mainDatabase.retry.attempts }}
      backoffFactor: {{ .Values.mainDatabase.retry.backoffFactor }}
---
apiVersion: v1
kind: Service
metadata:
  name: $MGOB
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
    name: $MGOB
spec:
  ports:
  - port: {{ .Values.containerPort }}
    targetPort: {{ .Values.containerPort }}
  clusterIP: None
  selector:
    role: mongo-backup
---
apiVersion: apps/v1
kind: StatefulSet
metadata:
  name: $MGOB
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
spec:
  serviceName: "$MGOB"
  replicas: 1
  selector:
    matchLabels:
      role: mongo-backup
  template:
    metadata:
      labels:
        role: mongo-backup
    spec:
      imagePullSecrets:
      - name: {{ .Values.global.project_name }}-dockerhub-registry-key
      containers:
      - name: mgobd
        image: {{ .Values.global.repository }}/{{ .Values.image }}:{{ .Values.tag }}
        imagePullPolicy: Always
        ports:
        - containerPort: {{ .Values.containerPort }}
          protocol: TCP
        volumeMounts:
        - name: $MGOB-storage
          mountPath: /storage
        - name: $MGOB-data
          mountPath: /data
        - name: $MGOB-data
          mountPath: /tmp
        - name: $MGOB-gstore-config
          mountPath: /config/{{ .Values.logsDatabase.name }}.yml
          subPath: {{ .Values.logsDatabase.name }}.yml
        - name: $MGOB-gstore-config
          mountPath: /config/{{ .Values.mainDatabase.name }}.yml
          subPath: {{ .Values.mainDatabase.name }}.yml
        env:
        - name: mongodb_username
          valueFrom:
            secretKeyRef:
              name: $MGOB-secrets
              key: mongodb_username
        - name: mongodb_password
          valueFrom:
            secretKeyRef:
              name: $MGOB-secrets
              key: mongodb_password
        - name: smtp_username
          valueFrom:
            secretKeyRef:
              name: $MGOB-secrets
              key: smtp_username
        - name: smtp_password
          valueFrom:
            secretKeyRef:
              name: $MGOB-secrets
              key: smtp_password
        - name: aws_access_key
          valueFrom:
            secretKeyRef:
              name: mgob-secrets
              key: aws_access_key
        - name: aws_secret_key
          valueFrom:
            secretKeyRef:
              name: mgob-secrets
              key: aws_secret_key
        - name: env_name
          valueFrom:
            secretKeyRef:
              name: $MGOB-secrets
              key: env_name
      volumes:
      - name: $MGOB-gstore-config
        configMap:
          name: $MGOB-gstore-config
          items:
          - key: {{ .Values.logsDatabase.name }}.yml
            path: {{ .Values.logsDatabase.name }}.yml
          - key: {{ .Values.mainDatabase.name }}.yml
            path: {{ .Values.mainDatabase.name }}.yml
  volumeClaimTemplates:
  - metadata:
      name: $MGOB-storage
    spec:
      accessModes: ["{{ .Values.volumeClaims.mgobData.requests.accessMode }}"]
      storageClassName: "{{ .Values.volumeClaims.mgobData.requests.storageClassName }}"
      resources:
        requests:
          storage: {{ .Values.volumeClaims.mgobData.requests.storage }}
  - metadata:
      name: $MGOB-data
    spec:
      accessModes: ["{{ .Values.volumeClaims.mgobData.requests.accessMode }}"]
      storageClassName: "{{ .Values.volumeClaims.mgobStorage.requests.storageClassName }}"
      resources:
        requests:
          storage: {{ .Values.volumeClaims.mgobStorage.requests.storage }}
EOM
  )
  ["$mgobChartDir/.helmignore"]=$(
    cat <<EOM
$HELM_IGNORE
EOM
  )
  ["$mgobChartDir/Chart.yaml"]=$(
    cat <<EOM
apiVersion: v2
name: $MGOB
description: A Helm chart for $MGOB
type: application
version: $DISTRICTNEX_VERSION
EOM
  )
  ["$mgobChartDir/values.yaml"]=$(
    cat <<EOM
$mgobValuesInternal
EOM
  )
  #endregion
  #region Bash Scripts
  ["./upgrade.sh"]=$(
    cat <<EOM
#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "\$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=\$1

$SETUP_CLUSTER

helm dependency update ./Helm
helm dependency build ./Helm

MONGODB_ROOT_PASSWORD=\$(kubectl get secret mongodb-secrets -o jsonpath="{.data.mongodb-root-password}" | base64 -d)

if [ "\$ENVIRONMENT" == "$DEMO_ENV_IDENTIIFIER" ]; then
    helm upgrade -f $TARGETS_DIR/$DEMO_ENV_IDENTIIFIER.yaml $DEMO_ENV_RELEASE_NAME ./Helm --set auth.rootPassword=\$MONGODB_ROOT_PASSWORD
else
    helm upgrade -f $TARGETS_DIR/$DEV_ENV_IDENTIIFIER.yaml $DEV_ENV_RELEASE_NAME ./Helm --set auth.rootPassword=\$MONGODB_ROOT_PASSWORD
fi
EOM
  )
  ["./cleanup.sh"]=$(
    cat <<EOM
#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "\$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=\$1

$SETUP_CLUSTER

helm uninstall $GOLDILOCKS --namespace $GOLDILOCKS
helm uninstall metrics-server --namespace metrics-server
helm uninstall aws-efs-csi-driver --namespace kube-system
helm uninstall aws-ebs-csi-driver --namespace kube-system


if [ "\$ENVIRONMENT" == "$DEMO_ENV_IDENTIIFIER" ]; then
    kubectl delete pods mgob-0 $DEMO_ENV_RELEASE_NAME-mongodb-0 $DEMO_ENV_RELEASE_NAME-mongodb-1 $DEMO_ENV_RELEASE_NAME-mongodb-2 $DEMO_ENV_RELEASE_NAME-redis-node-0 $DEMO_ENV_RELEASE_NAME-redis-node-1 $DEMO_ENV_RELEASE_NAME-redis-node-2 --force
    helm uninstall redis --namespace $DEMO_NAMESPACE
    helm uninstall mongodb --namespace $DEMO_NAMESPACE
    helm uninstall $DEMO_ENV_RELEASE_NAME
    kubectl delete all --all -n $DEMO_NAMESPACE
    kubectl delete namespace $DEMO_NAMESPACE
else
    kubectl delete pods mgob-0 $DEV_ENV_RELEASE_NAME-mongodb-0 $DEV_ENV_RELEASE_NAME-mongodb-1 $DEV_ENV_RELEASE_NAME-mongodb-2 $DEV_ENV_RELEASE_NAME-redis-node-0 $DEV_ENV_RELEASE_NAME-redis-node-1 $DEV_ENV_RELEASE_NAME-redis-node-2 --force
    helm uninstall redis --namespace $DEV_NAMESPACE
    helm uninstall mongodb --namespace $DEV_NAMESPACE
    helm uninstall $DEV_ENV_RELEASE_NAME
    kubectl delete all --all -n $DEV_NAMESPACE
    kubectl delete namespace $DEV_NAMESPACE
fi

helm repo remove bitnami
helm repo remove fairwinds
helm repo remove metrics-server
helm repo remove aws-efs-csi-driver
helm repo remove aws-ebs-csi-driver

helm repo update
EOM
  )
  ["./delete.sh"]=$(
    cat <<EOM
#!/bin/bash

$SETUP_CLUSTER

rm -R Helm cleanup.sh skaffold.sh skaffold.yaml uninstall.sh upgrade.sh setup_cluster.sh delete.sh
EOM
  )
  ["./setup_cluster.sh"]=$(
    cat <<EOM
#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "\$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=\$1

$SETUP_CLUSTER

if [ "\$ENVIRONMENT" == "$DEMO_ENV_IDENTIIFIER" ]; then
    kubectl config set-context --current --namespace=$DEMO_NAMESPACE
else
    kubectl config set-context --current --namespace=$DEV_NAMESPACE
fi
EOM
  )
  ["./uninstall.sh"]=$(
    cat <<EOM
#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "\$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=\$1

$SETUP_CLUSTER

if [ "\$ENVIRONMENT" == "$DEMO_ENV_IDENTIIFIER" ]; then
    helm uninstall $DEMO_ENV_RELEASE_NAME -n $DEMO_NAMESPACE
else
    helm uninstall $DEV_ENV_RELEASE_NAME -n $DEV_NAMESPACE
fi
EOM
  )
  ["./skaffold.sh"]=$(
    cat <<EOM
#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "\$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=\$1

$SETUP_CLUSTER


helm repo add eks https://aws.github.io/eks-charts
helm repo add bitnami https://charts.bitnami.com/bitnami
helm repo add fairwinds https://charts.fairwinds.com/stable
helm repo add metrics-server https://kubernetes-sigs.github.io/metrics-server
helm repo add aws-efs-csi-driver https://kubernetes-sigs.github.io/aws-efs-csi-driver
helm repo add aws-ebs-csi-driver https://kubernetes-sigs.github.io/aws-ebs-csi-driver

helm repo update

helm install $ALB_CONTROLLER_NAME eks/$ALB_CONTROLLER_NAME --set clusterName=$K8S_CLUSTER_NAME -n kube-system

helm dependency build ./$BASE_DIR
helm dependency update ./$BASE_DIR

# Run Skaffold with the specified environment
skaffold run -p "\$ENVIRONMENT"

if [ "\$ENVIRONMENT" == "$DEMO_ENV_IDENTIIFIER" ]; then
    NAMESPACE=$DEMO_NAMESPACE
else
    NAMESPACE=$DEV_NAMESPACE
fi

kubectl config set-context --current --namespace=\$NAMESPACE
EOM
  )
  #endregion
)
#endregion
#endregion
#region Create Functional Directories
mkdir -p $TARGETS_DIR
mkdir -p $TEMPLATES_DIR
mkdir -p "$ingressChartDir/$TEMPLATES"
mkdir -p "$mgobChartDir/$TEMPLATES"
#endregion
#region Apps Data
#region Microservices
declare -A microservices=(
  ["$ADMIN_UI"]="80"
  ["api-gateway"]="5000"
  ["api-gateway-reverse-proxy"]="80"
  ["area-management-webapi"]="5003"
  ["asset-management-webapi"]="5004"
  ["$CLIENT_UI"]="80"
  ["cloud-interface-webapi"]="5010"
  ["correlation-calculation-webapi"]="5000"
  ["dimension-management-webapi"]="5005"
  ["district-management-webapi"]="5006"
  ["entity-management-webapi"]="5007"
  ["file-management-webapi"]="5008"
  ["floor-management-webapi"]="5009"
  ["insights-management-webapi"]="5011"
  ["kpi-extraction-engine-webapi"]="5012"
  ["kpi-management-webapi"]="5013"
  ["method-monitoring-webapi"]="5001"
  ["mobility-dimension-webapi"]="5014"
  ["organization-management-webapi"]="5016"
  ["platform-logging-webapi"]="5017"
  ["region-management-webapi"]="5018"
  ["reporting-webapi"]="5019"
  ["security-dimension-webapi"]="5020"
  ["settings-management-webapi"]="5021"
  ["shareview-webapi"]="5022"
  ["signalr-realtime-server"]="5870"
  ["signalr-realtime-server-reverse-proxy"]="80"
  ["site-management-webapi"]="5023"
  ["smart-living-dimension-webapi"]="5024"
  ["space-management-webapi"]="5025"
  ["sustainability-dimension-webapi"]="5026"
  ["top-level-management-webapi"]="5027"
  ["user-authentication-webapi"]="5028"
  ["user-management-webapi"]="5029"
  ["video-ai-engine-management-webapi"]="5030"
)
declare -A baseMicroservicesConfigs=(
  ["$ADMIN_UI"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  {
INDENT_PLACEHOLDER      "Environment": "Production",
INDENT_PLACEHOLDER      "APIUrl": "$API_ENDPOINT",
INDENT_PLACEHOLDER      "SignalR_Realtime_Server_Endpoint": "$WEBSOCKETS_ENDPOINT"
INDENT_PLACEHOLDER  }
EOM
  )
  ["$CLIENT_UI"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  {
INDENT_PLACEHOLDER      "Environment": "Production",
INDENT_PLACEHOLDER      "APIUrl": "$API_ENDPOINT",
INDENT_PLACEHOLDER      "SignalR_Realtime_Server_Endpoint": "$WEBSOCKETS_ENDPOINT",
INDENT_PLACEHOLDER      "List_Preset_time": [
INDENT_PLACEHOLDER          {
INDENT_PLACEHOLDER              "NAME": "Past Week",
INDENT_PLACEHOLDER              "DAYS_BEHIND": 7,
INDENT_PLACEHOLDER              "ENUM_TIMESPAN_LIST": [
INDENT_PLACEHOLDER                  1
INDENT_PLACEHOLDER              ]
INDENT_PLACEHOLDER          },
INDENT_PLACEHOLDER          {
INDENT_PLACEHOLDER              "NAME": "Past Month",
INDENT_PLACEHOLDER              "DAYS_BEHIND": 30,
INDENT_PLACEHOLDER              "ENUM_TIMESPAN_LIST": [
INDENT_PLACEHOLDER                  1,
INDENT_PLACEHOLDER                  2
INDENT_PLACEHOLDER              ]
INDENT_PLACEHOLDER          },
INDENT_PLACEHOLDER          {
INDENT_PLACEHOLDER              "NAME": "Past 6 Months",
INDENT_PLACEHOLDER              "DAYS_BEHIND": 180,
INDENT_PLACEHOLDER              "ENUM_TIMESPAN_LIST": [
INDENT_PLACEHOLDER                  2,
INDENT_PLACEHOLDER                  3
INDENT_PLACEHOLDER              ]
INDENT_PLACEHOLDER          },
INDENT_PLACEHOLDER          {
INDENT_PLACEHOLDER              "NAME": "All Time",
INDENT_PLACEHOLDER              "DAYS_BEHIND": 9999,
INDENT_PLACEHOLDER              "ENUM_TIMESPAN_LIST": [
INDENT_PLACEHOLDER                  3
INDENT_PLACEHOLDER              ]
INDENT_PLACEHOLDER          }
INDENT_PLACEHOLDER      ]
INDENT_PLACEHOLDER  }
EOM
  )
  ["area-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["asset-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["cloud-interface-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="CLOUD_PROVIDER" value="AWS" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="GCP_PROJECT_ID" value="$GCP_PROJECT_ID" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["dimension-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["district-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["entity-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["file-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ASSETS_LOCATION" value="/data" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["floor-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["insights-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["kpi-extraction-engine-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="LIST_DWELL_TIME" value="15-30,30-60,60-120,120-1440" />
INDENT_PLACEHOLDER          <add key="IS_SEND_EMAIL_ON_CRON_EXCEPTION" value="1" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="EDMONTON_API_KEY" value="$EDMONTON_API_KEY" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER          <!-- Telus API Secrets -->
INDENT_PLACEHOLDER          <add key="TELUS_SCOPE" value="$TELUS_SCOPE" />
INDENT_PLACEHOLDER          <add key="TELUS_CLIENT_ID" value="$TELUS_CLIENT_ID" />
INDENT_PLACEHOLDER          <add key="TELUS_CUSTOMER_ID" value="$TELUS_CUSTOMER_ID" />
INDENT_PLACEHOLDER          <add key="TELUS_CLIENT_SECRET" value="$TELUS_CLIENT_SECRET" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["kpi-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["method-monitoring-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["mobility-dimension-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["organization-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="ASSETS_ORG_IMAGE_PATH" value="Organization_Images" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_EMAIL" value="$SUPPORT_SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_PASSWORD" value="$SUPPORT_SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["platform-logging-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_LOGS_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="ASSETS_EXCEL_REPORT_PATH" value="Excel_Reports" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["region-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["reporting-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="SMTP_EMAIL" value="$SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SMTP_PASSWORD" value="$SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="ASSETS_REPORTS_PATH" value="Static_Reports" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="LINK_SHARE_TEMPLATE_PATH" value="./LinkShareTemplate.html" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["security-dimension-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["settings-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="CLOUD_PROVIDER" value="AWS" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="ASSETS_DEFAULT_IMAGE_PATH" value="Default_Images" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_EMAIL" value="$SUPPORT_SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_PASSWORD" value="$SUPPORT_SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["shareview-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="SMTP_EMAIL" value="$SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SMTP_PASSWORD" value="$SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="LINK_SHARE_TEMPLATE_PATH" value="./LinkShareTemplate.html" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="SHARE_ENDPOINT" value="$SHARE_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="SHARED_FILES_PATH" value="Shared" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="ENTITY_SHAREVIEW_ENDPOINT" value="$ENTITY_SHAREVIEW_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["site-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["smart-living-dimension-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["space-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["sustainability-dimension-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["top-level-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["user-authentication-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="SMTP_EMAIL" value="$SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SMTP_PASSWORD" value="$SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="OTP_TEMPLATE_PATH" value="./OTPTemplate.html" />
INDENT_PLACEHOLDER          <add key="ASSETS_ORG_IMAGE_PATH" value="Organization_Images" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_EMAIL" value="$SUPPORT_SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_PASSWORD" value="$SUPPORT_SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["user-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="MONGODB_DATABASE_NAME" value="$MONGODB_DATA_DATABASE_NAME" />
INDENT_PLACEHOLDER          <add key="ASSETS_ORG_IMAGE_PATH" value="Organization_Images" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_EMAIL" value="$SUPPORT_SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SUPPORT_SMTP_PASSWORD" value="$SUPPORT_SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="MONGODB_CONN_STR" value="$MONGODB_CONN_STR" />
INDENT_PLACEHOLDER          <add key="ASSETS_ENDPOINT" value="$ASSETS_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["video-ai-engine-management-webapi"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="ENABLE_TICKET" value="1" />
INDENT_PLACEHOLDER          <add key="IS_DEBUG_MODE" value="1" />
INDENT_PLACEHOLDER          <add key="CACHING_ENABLED" value="0" />
INDENT_PLACEHOLDER          <add key="ENABLE_MONITORING" value="0" />
INDENT_PLACEHOLDER          <add key="BLC_MESSAGES" value="./Messages.xml" />
INDENT_PLACEHOLDER          <add key="SMTP_EMAIL" value="$SMTP_EMAIL" />
INDENT_PLACEHOLDER          <add key="SMTP_PASSWORD" value="$SMTP_PASSWORD" />
INDENT_PLACEHOLDER          <add key="ALERTS_TEMPLATE" value="./AlertsTemplate.html" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="CONN_STR" value="$SQLSERVER_CONN_STR" />
INDENT_PLACEHOLDER          <add key="JSON_PATH" value="$VIDEOAI_JSON_PATH" />
INDENT_PLACEHOLDER          <add key="IMAGE_PATH" value="$VIDEOAI_IMAGE_PATH" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
)

indent_resource baseMicroservicesConfigs microservicesConfigs microservicesConfigsInternal "$INDENTATION" "$NO_INDENTATION"
#endregion
#region Cronjobs
data_creation_cron_app_config=$(
  cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="BUSINESSES_CRON_TIME" value="0 2 * * *" />
INDENT_PLACEHOLDER          <add key="PUBLIC_EVENTS_CRON_TIME" value="0 1 * * *" />
INDENT_PLACEHOLDER          <add key="DATA_CREATION_CRON_TIME" value="0 * * * *" />
INDENT_PLACEHOLDER          <add key="IS_SEND_EMAIL_ON_CRONJOB_START" value="0" />
INDENT_PLACEHOLDER          <add key="IS_SEND_EMAIL_ON_CRON_EXCEPTION" value="1" />
INDENT_PLACEHOLDER          <add key="BYLAW_COMPLAINTS_CRON_TIME" value="0 0 * * *" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="TELUS_API_DATA_1_CRON_TIME" value="0,5,10,15,20,25 4 * * *" />
INDENT_PLACEHOLDER          <add key="TELUS_API_DATA_2_CRON_TIME" value="30,35,40,45,50,55 4 * * *" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
)
declare -A cronJobs=(
  ["public-events-cron"]="0 1 * * *"
  ["data-creation-cron"]="0 * * * *"
  ["businesses-cron"]="0 2 * * *"
  ["bylaw-complaints-cron"]="0 0 * * *"
  ["telus-api-data-1-cron"]="0,5,10,15,20,25 4 * * *"
  ["telus-api-data-2-cron"]="30,35,40,45,50,55 4 * * *"
  ["data-retention-cron"]="0 0 * * *"
  ["mobility-dimension-cron"]="0 0 * * *"
  ["security-dimension-cron"]="0 0 * * *"
  ["smart-living-dimension-cron"]="0 0 * * *"
  ["sustainability-dimension-cron"]="0 0 * * *"
  ["video-ai-engine-management-cron"]="0 */12 * * *"
  ["wifi-signal-cron"]="*/3 * * * *"
)
declare -A cronJobsDlls=(
  ["public-events-cron"]="Data_Creation_Cron.dll.config"
  ["data-creation-cron"]="Data_Creation_Cron.dll.config"
  ["businesses-cron"]="Data_Creation_Cron.dll.config"
  ["bylaw-complaints-cron"]="Data_Creation_Cron.dll.config"
  ["telus-api-data-1-cron"]="Data_Creation_Cron.dll.config"
  ["telus-api-data-2-cron"]="Data_Creation_Cron.dll.config"
  ["data-retention-cron"]="Data_Retention_Cron.dll.config"
  ["mobility-dimension-cron"]="Mobility_Dimension_Cron.dll.config"
  ["security-dimension-cron"]="Security_Dimension_Cron.dll.config"
  ["smart-living-dimension-cron"]="Smart_Living_Dimension_Cron.dll.config"
  ["sustainability-dimension-cron"]="Sustainability_Dimension_Cron.dll.config"
  ["video-ai-engine-management-cron"]="Video_AI_Engine_Management_Cron.dll.config"
  ["wifi-signal-cron"]="Wifi_Signal_Cron.dll.config"
)
declare -A cronJobsImages=(
  ["public-events-cron"]="data-creation-cron"
  ["data-creation-cron"]="data-creation-cron"
  ["businesses-cron"]="data-creation-cron"
  ["bylaw-complaints-cron"]="data-creation-cron"
  ["telus-api-data-1-cron"]="data-creation-cron"
  ["telus-api-data-2-cron"]="data-creation-cron"
  ["data-retention-cron"]="data-retention-cron"
  ["mobility-dimension-cron"]="mobility-dimension-cron"
  ["security-dimension-cron"]="security-dimension-cron"
  ["smart-living-dimension-cron"]="smart-living-dimension-cron"
  ["sustainability-dimension-cron"]="sustainability-dimension-cron"
  ["video-ai-engine-management-cron"]="video-ai-engine-management-cron"
  ["wifi-signal-cron"]="wifi-signal-cron"
)
declare -A baseCronJobsConfigs=(
  ["public-events-cron"]=$data_creation_cron_app_config
  ["data-creation-cron"]=$data_creation_cron_app_config
  ["businesses-cron"]=$data_creation_cron_app_config
  ["bylaw-complaints-cron"]=$data_creation_cron_app_config
  ["telus-api-data-1-cron"]=$data_creation_cron_app_config
  ["telus-api-data-2-cron"]=$data_creation_cron_app_config
  ["data-retention-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="DATA_RETENTION_CRON_TIME" value="0 0 * * *" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["mobility-dimension-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["security-dimension-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["smart-living-dimension-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["sustainability-dimension-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["video-ai-engine-management-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="VIDEO_AI_ENGINE_MANAGEMENT_CRON_TIME" value="0 */12 * * *" />
INDENT_PLACEHOLDER          <add key="REALTIME_SERVER_URL" value="$SIGNALR_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
  ["wifi-signal-cron"]=$(
    cat <<EOM
INDENT_PLACEHOLDERconfig: |-
INDENT_PLACEHOLDER  <?xml version="1.0" encoding="utf-8"?>
INDENT_PLACEHOLDER  <configuration>
INDENT_PLACEHOLDER      <appSettings>
INDENT_PLACEHOLDER          <add key="SCHEDULING_METHOD" value="HostedService" />
INDENT_PLACEHOLDER          <add key="WIFI_SIGNAL_CRON_TIME" value="*/3 * * * *" />
INDENT_PLACEHOLDER          <add key="API_GATEWAY_URL" value="$API_GW_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER          <add key="REALTIME_SERVER_URL" value="$SIGNALR_INTERNAL_ENDPOINT" />
INDENT_PLACEHOLDER      </appSettings>
INDENT_PLACEHOLDER  </configuration>
EOM
  )
)
indent_resource baseCronJobsConfigs cronJobsConfigs cronJobsConfigsInternal "$INDENTATION" "$NO_INDENTATION"
#endregion
services=("${!microservices[@]}" "${!cronJobs[@]}" "$MGOB" "$INGRESS_CONTROLLER")
#endregion
#region Generation
#region Skaffold
cat <<EOF >"./skaffold.yaml"
apiVersion: skaffold/v4beta2
kind: Config

profiles:
EOF

for profile in "${SKAFFOLD_PROFILES[@]}"; do
  IFS=':' read -ra PROFILE_DATA <<<"$profile"

  ENV_NAME="${PROFILE_DATA[0]}"
  ENV_RELEASE_NAME="${PROFILE_DATA[1]}"
  ENV_NAMESPACE="${PROFILE_DATA[2]}"

  cat <<EOF >>"./skaffold.yaml"
- name: $ENV_NAME
  deploy:
    statusCheck: false
    helm:
      releases:
EOF

  if [ -n "${PROFILE_EXTRA_RELEASES[$ENV_NAME]}" ]; then
    echo "${PROFILE_EXTRA_RELEASES[$ENV_NAME]}" | sed '/./,$!d' >>"./skaffold.yaml"
  fi

  cat <<EOF >>"./skaffold.yaml"
      - name: $ENV_RELEASE_NAME
        chartPath: $BASE_DIR
        createNamespace: true
        namespace: $ENV_NAMESPACE
        valuesFiles:
        - $TARGETS_DIR/$ENV_NAME.yaml
        packaged:
          version: "$DISTRICTNEX_VERSION"
          appVersion: "$DISTRICTNEX_VERSION"
EOF

  cat <<EOF >"$TARGETS_DIR/$ENV_NAME.yaml"
${PROFILE_VALUES[$ENV_NAME]}
EOF

done
#endregion
#region Templates
for template in "${!templates[@]}"; do
  cat <<EOF >"$template"
${templates[$template]}
EOF

  # Check if the template is a bash script
  if [[ "${template##*.}" == "sh" ]]; then
    chmod +x "$template"
  fi
done
#endregion
#region Chart and Values
cat <<EOF >"$BASE_DIR/values.yaml"
# Values for the Umbrella chart
global:
  env: "Production"
  repository: "$DOCKERHUB_REPO_NAME"
  project_name: "$PROJECT_NAME"
  namespace: "$DEV_NAMESPACE"
  autoscaler_role_arn: "$AUTOSCALER_ROLE_ARN"
  k8s_cluster_name: "$K8S_CLUSTER_NAME"
$shared_values
$mongodb_dev_conf
$redis_dev_conf
$ingressValuesDev
$mgobValues

EOF

# Write the header to Chart.yaml
cat <<EOF >"$BASE_DIR/Chart.yaml"
apiVersion: v2
name: $PROJECT_NAME
description: Umbrella chart for $PROJECT_NAME microservices
type: application
version: $DISTRICTNEX_VERSION

dependencies:

############## dependencies ##############

- name: mongodb
  repository: https://charts.bitnami.com/bitnami
  version: 13.9.4
  condition: mongodb.enabled
# - name: redis
#   repository: https://charts.bitnami.com/bitnami
#   version: 17.9.4
#   condition: redis.enabled

############## microservices ##############

EOF

# Loop through the services array and append each service definition to Chart.yaml
for service in "${services[@]}"; do
  cat <<EOF >>"$BASE_DIR/Chart.yaml"
- name: $service
  repository: "file://charts/$service"
  version: $DISTRICTNEX_VERSION
  condition: $service.enabled
EOF
done

cat <<EOF >"$BASE_DIR/.helmignore"
$HELM_IGNORE
EOF
#endregion
#region Microservices
for microservice in "${!microservices[@]}"; do
  pvc=""
  secretRef=""
  pvcValues=""
  secretRefName=""
  pvcValuesInternal=""
  secretRefNameInternal=""
  Chart_Dir=$CHARTS_DIR/$microservice
  port=${microservices[$microservice]}
  microservice_image="$IMAGE_PREFIX-$microservice"
  config=${microservicesConfigs[$microservice]}
  configInternal=${microservicesConfigsInternal[$microservice]}
  devConfig=$(
    echo "${config}" |
      sed \
        -e "s|$API_ENDPOINT_PLACEHOLDER|$DEV_API_ENDPOINT|g" \
        -e "s|$RELEASE_NAME_PLACEHOLDER|$DEV_ENV_RELEASE_NAME|g" \
        -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEV_ADMIN_UI_ENDPOINT|g" \
        -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEV_CLIENT_UI_ENDPOINT|g" \
        -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEV_WEBSOCKETS_ENDPOINT|g"
  )
  devConfigInternal=$(
    echo "${configInternal}" |
      sed \
        -e "s|$API_ENDPOINT_PLACEHOLDER|$DEV_API_ENDPOINT|g" \
        -e "s|$RELEASE_NAME_PLACEHOLDER|$DEV_ENV_RELEASE_NAME|g" \
        -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEV_ADMIN_UI_ENDPOINT|g" \
        -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEV_CLIENT_UI_ENDPOINT|g" \
        -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEV_WEBSOCKETS_ENDPOINT|g"
  )
  demoConfig=$(
    echo "${config}" |
      sed \
        -e "s|$API_ENDPOINT_PLACEHOLDER|$DEMO_API_ENDPOINT|g" \
        -e "s|$RELEASE_NAME_PLACEHOLDER|$DEMO_ENV_RELEASE_NAME|g" \
        -e "s|$ADMIN_UI_ENDPOINT_PLACEHOLDER|$DEMO_ADMIN_UI_ENDPOINT|g" \
        -e "s|$CLIENT_UI_ENDPOINT_PLACEHOLDER|$DEMO_CLIENT_UI_ENDPOINT|g" \
        -e "s|$WEBSOCKETS_ENDPOINT_PLACEHOLDER|$DEMO_WEBSOCKETS_ENDPOINT|g"
  )

  # Create directories
  mkdir -p "$Chart_Dir/$TEMPLATES"
  if [[ $microservice == *-ui ]]; then
    configFileName="app.config.json"
    volume_mounts=$(
      cat <<EOF

        volumeMounts:
        - name: {{ .Values.name }}-config-volume
          mountPath: /usr/share/nginx/html/assets/config
EOF
    )
    volumes=$(
      cat <<EOF

      volumes:
      - name: {{ .Values.name }}-config-volume
        configMap:
          name: {{ .Values.name }}-config
EOF
    )
  else
    configFileName="App.config"
    if [ "$microservice" == "file-management-webapi" ]; then
      volume_mounts=$(
        cat <<EOF
$microservice_volume_mounts
        - name: {{ .Values.global.project_name }}-{{ .Values.name }}-pv-storage
          mountPath: /data
EOF
      )
      volumes=$(
        cat <<EOF
$microservice_volumes
      - name: {{ .Values.global.project_name }}-{{ .Values.name }}-pv-storage
        persistentVolumeClaim:
          claimName: {{ .Values.global.project_name }}-{{ .Values.name }}-pvc
EOF
      )
      pvc=$(
        cat <<EOF

apiVersion: v1
kind: PersistentVolumeClaim
metadata:
  name: {{ .Values.pvc.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
  annotations:
    "helm.sh/resource-policy": keep
spec:
  accessModes:
    - {{ .Values.pvc.access_mode }}
  resources:
    requests:
      storage: {{ .Values.pvc.storage }}
  storageClassName: {{ .Values.pvc.storage_class_name }}
---
EOF
      )
      indent_resource basePvcValues pvcValues pvcValuesInternal "$INDENTATION" "$NO_INDENTATION"
    else
      if [ "$microservice" != "api-gateway" ] && [ "$microservice" != "api-gateway-reverse-proxy" ] && [ "$microservice" != "correlation-calculation-webapi" ] && [ "$microservice" != "signalr-realtime-server" ] && [ "$microservice" != "signalr-realtime-server-reverse-proxy" ]; then
        volume_mounts=$microservice_volume_mounts
        volumes=$microservice_volumes
      else
        volumes=""
        volume_mounts=""
      fi
    fi
  fi
  if [ "$microservice" != "api-gateway" ] && [ "$microservice" != "api-gateway-reverse-proxy" ] && [ "$microservice" != "correlation-calculation-webapi" ] && [ "$microservice" != "signalr-realtime-server" ] && [ "$microservice" != "signalr-realtime-server-reverse-proxy" ]; then
    configMap=$(
      cat <<EOF

---
apiVersion: v1
kind: ConfigMap
metadata:
  name: {{ .Values.name }}-config
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
data:
  $configFileName: {{ .Values.config | toYaml | indent 1 }}
EOF
    )
  else
    configMap=""
  fi

  if [ "$microservice" == "cloud-interface-webapi" ]; then
    secretRef=$(
      cat <<EOF

        envFrom:
        - secretRef:
            name: {{ .Values.secrets.aws_auth.name }}
EOF
    )
    indent_resource baseSecretRefName secretRefName secretRefNameInternal "$INDENTATION" "$NO_INDENTATION"
  fi

  # Create files with placeholder content
  cat <<EOF >"$Chart_Dir/$TEMPLATES/$microservice.yaml"
apiVersion: apps/v1
kind: Deployment
metadata:
  name: {{ .Values.global.project_name }}-{{ .Values.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
    service: {{ .Values.global.project_name }}-{{ .Values.name }}
spec:
  replicas: {{ .Values.replicas }}
  selector:
    matchLabels:
      service: {{ .Values.global.project_name }}-{{ .Values.name }}
  template:
    metadata:
      labels:
        redis-client: "{{ .Values.isRedisClient }}"
        service: {{ .Values.global.project_name }}-{{ .Values.name }}
    spec:$(if [ -n "$volumes" ]; then echo "$volumes"; fi)
      imagePullSecrets:
      - name: {{ .Values.global.project_name }}-dockerhub-registry-key
      containers:
      - image: {{ .Values.global.repository }}/{{ .Values.image }}:{{ .Values.tag }}
        name: {{ .Values.global.project_name }}-{{ .Values.name }}
        imagePullPolicy: Always$(if [ -n "$volume_mounts" ]; then echo "$volume_mounts"; fi)
        {{- if .Values.resourceLimitation }}
        resources:
          limits:
            cpu: {{ .Values.resources.limits.cpu }}
            memory: {{ .Values.resources.limits.memory }}
          requests:
            cpu: {{ .Values.resources.requests.cpu }}
            memory: {{ .Values.resources.requests.memory }}
        {{- end }}
        readinessProbe:
          tcpSocket:
            port: {{ .Values.containerPort }}
          initialDelaySeconds: 20
          periodSeconds: 10
        livenessProbe:
          tcpSocket:
            port: {{ .Values.containerPort }}
          initialDelaySeconds: 20
          periodSeconds: 20
        ports:
        - containerPort: {{ .Values.containerPort }}$(if [ -n "$secretRef" ]; then echo "$secretRef"; fi)
      hostname: {{ .Values.global.project_name }}-{{ .Values.name }}
      restartPolicy: Always
---$(if [ -n "$pvc" ]; then echo -e "$pvc"; fi)
{{- if .Values.hpa.enabled }}
apiVersion: autoscaling/v2
kind: HorizontalPodAutoscaler
metadata:
  name: {{ .Values.global.project_name }}-{{ .Values.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
spec:
  scaleTargetRef:
    apiVersion: apps/v1
    kind: Deployment
    name: {{ .Values.global.project_name }}-{{ .Values.name }}
  minReplicas: {{ .Values.hpa.min }}
  maxReplicas: {{ .Values.hpa.max }}
  metrics:
  - type: Resource
    resource:
      name: cpu
      target:
        type: Utilization
        averageUtilization: {{ .Values.hpa.cpu }}
  - type: Resource
    resource:
      name: memory
      target:
        type: Utilization
        averageUtilization: {{ .Values.hpa.memory }}
---
{{- end }}
apiVersion: v1
kind: Service
metadata:
  name: {{ .Values.global.project_name }}-{{ .Values.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
    service: {{ .Values.global.project_name }}-{{ .Values.name }}
spec:
  type: {{ .Values.service.type }}
  ports:
  - protocol: {{ .Values.service.protocol }}
    port: {{ .Values.service.port }}
    targetPort: {{ .Values.containerPort }}
  selector:
    service: {{ .Values.global.project_name }}-{{ .Values.name }}$(if [ -n "$configMap" ]; then echo "$configMap"; fi)
EOF

  cat <<EOF >"$Chart_Dir/.helmignore"
$HELM_IGNORE
EOF

  cat <<EOF >"$Chart_Dir/Chart.yaml"
apiVersion: v2
name: $microservice
description: A Helm chart for ${microservice//-/ }
type: application
version: $DISTRICTNEX_VERSION
EOF

  indent_resource baseMicroserviceValues microserviceValues microserviceValuesInternal "$INDENTATION" "$NO_INDENTATION"

  microserviceValues=$(
    echo "${microserviceValues}" |
      sed \
        -e "s|$PORT_PLACEHOLDER|$port|g" \
        -e "s|$TAG_PLACEHOLDER|$GLOBAL_TAG|g" \
        -e "s|$SERVICE_NAME_PLACEHOLDER|$microservice|g" \
        -e "s|$IMAGE_NAME_PLACEHOLDER|$microservice_image|g"
  )
  microserviceValuesInternal=$(
    echo "${microserviceValuesInternal}" |
      sed \
        -e "s|$PORT_PLACEHOLDER|$port|g" \
        -e "s|$TAG_PLACEHOLDER|$DISTRICTNEX_VERSION|g" \
        -e "s|$SERVICE_NAME_PLACEHOLDER|$microservice|g" \
        -e "s|$IMAGE_NAME_PLACEHOLDER|$microservice_image|g"
  )

  microserviceValues=$(
    cat <<EOF
$microservice:
  enabled: true
$microserviceValues$(if [ -n "$pvcValues" ]; then echo -e "$pvcValues"; fi)$(if [ -n "$secretRefName" ]; then echo -e "$secretRefName"; fi)
EOF
  )

  cat <<EOF >"$Chart_Dir/values.yaml"
$microserviceValuesInternal$(if [ -n "$pvcValuesInternal" ]; then echo -e "$pvcValuesInternal"; fi)$(if [ -n "$secretRefNameInternal" ]; then echo -e "$secretRefNameInternal"; fi)
$devConfigInternal
EOF

  cat <<EOF >>"$BASE_DIR/values.yaml"
$microserviceValues
$devConfig

EOF
  cat <<EOF >>"$TARGETS_DIR/$DEV_ENV_IDENTIIFIER.yaml"

$microserviceValues
$devConfig
EOF
  cat <<EOF >>"$TARGETS_DIR/$DEMO_ENV_IDENTIIFIER.yaml"

$microserviceValues
$demoConfig
EOF
done
#endregion
#region CronJobs
for cronjob in "${!cronJobs[@]}"; do
  Chart_Dir=$CHARTS_DIR/$cronjob
  cron_dll=${cronJobsDlls[$cronjob]}
  cron_schedule=${cronJobs[$cronjob]}
  config=${cronJobsConfigs[$cronjob]}
  cronjob_image="$IMAGE_PREFIX-${cronJobsImages[$cronjob]}"
  configInternal=${cronJobsConfigsInternal[$cronjob]}

  mkdir -p "$Chart_Dir/$TEMPLATES"

  # Create files with placeholder content
  cat <<EOF >"$Chart_Dir/$TEMPLATES/$cronjob.yaml"
apiVersion: v1
kind: ConfigMap
metadata:
  name: {{ .Values.name }}-config
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
data:
  App.config: {{ .Values.config | toYaml | indent 1 }}
---
apiVersion: batch/v1
kind: CronJob
metadata:
  name: {{ .Values.global.project_name }}-{{ .Values.name }}
  namespace: {{ .Values.global.namespace }}
  labels:
    chartVersion: {{ .Chart.Version }}
spec:
  schedule: "{{ .Values.cron_schedule }}"
  concurrencyPolicy: {{ .Values.concurrencyPolicy }}
  failedJobsHistoryLimit: {{ .Values.failedJobsHistoryLimit }}
  successfulJobsHistoryLimit: {{ .Values.successfulJobsHistoryLimit }}
  jobTemplate:
    spec:
      ttlSecondsAfterFinished: {{ .Values.ttlSecondsAfterFinished }}
      template:
        metadata:
          labels:
            redis-client: "{{ .Values.isRedisClient }}"
        spec:
          volumes:
          - name: {{ .Values.name }}-config-volume
            configMap:
              name: {{ .Values.name }}-config
          imagePullSecrets:
          - name: {{ .Values.global.project_name }}-dockerhub-registry-key
          containers:
          - image: {{ .Values.global.repository }}/{{ .Values.image }}:{{ .Values.tag }}
            name: {{ .Values.global.project_name }}-{{ .Values.name }}
            imagePullPolicy: Always
            {{- if .Values.resourceLimitation }}
            resources:
              limits:
                cpu: {{ .Values.resources.limits.cpu }}
                memory: {{ .Values.resources.limits.memory }}
              requests:
                cpu: {{ .Values.resources.requests.cpu }}
                memory: {{ .Values.resources.requests.memory }}
            {{- end }}
            env:
            - name: CURRENT_CRON_SCHEDULE
              value: "{{ .Values.cron_schedule }}"
            volumeMounts:
            - name: {{ .Values.name }}-config-volume
              mountPath: /app/App.config
              subPath: App.config
            - name: {{ .Values.name }}-config-volume
              mountPath: /app/{{ .Values.cron_dll }}
              subPath: App.config
          restartPolicy: OnFailure
EOF

  cat <<EOF >"$Chart_Dir/.helmignore"
$HELM_IGNORE
EOF

  cat <<EOF >"$Chart_Dir/Chart.yaml"
apiVersion: v2
name: $cronjob
description: A Helm chart for ${cronjob//-/ }
type: application
version: $DISTRICTNEX_VERSION

EOF

  indent_resource baseCronJobsValues cronJobsValues cronJobsValuesInternal "$INDENTATION" "$NO_INDENTATION"

  cronJobsValues=$(
    echo "${cronJobsValues}" |
      sed \
        -e "s|$CRON_DLL_PLACEHOLDER|$cron_dll|g" \
        -e "s|$SERVICE_NAME_PLACEHOLDER|$cronjob|g" \
        -e "s|$TAG_PLACEHOLDER|$GLOBAL_TAG|g" \
        -e "s|$IMAGE_NAME_PLACEHOLDER|$cronjob_image|g" \
        -e "s|$CRON_SCHEDULE_PLACEHOLDER|$cron_schedule|g"
  )
  cronJobsValuesInternal=$(
    echo "${cronJobsValuesInternal}" |
      sed \
        -e "s|$CRON_DLL_PLACEHOLDER|$cron_dll|g" \
        -e "s|$SERVICE_NAME_PLACEHOLDER|$cronjob|g" \
        -e "s|$TAG_PLACEHOLDER|$DISTRICTNEX_VERSION|g" \
        -e "s|$IMAGE_NAME_PLACEHOLDER|$cronjob_image|g" \
        -e "s|$CRON_SCHEDULE_PLACEHOLDER|$cron_schedule|g"
  )

  cronJobsValues=$(
    cat <<EOF

$cronjob:
  enabled: true
$cronJobsValues
$config
EOF
  )
  cronJobsValuesInternal=$(
    cat <<EOF
$cronJobsValuesInternal
$configInternal
EOF
  )
  cat <<EOF >"$Chart_Dir/values.yaml"
$cronJobsValuesInternal
EOF
  cat <<EOF >>"$BASE_DIR/values.yaml"
$cronJobsValues
EOF
  cat <<EOF >>"$TARGETS_DIR/$DEV_ENV_IDENTIIFIER.yaml"
$cronJobsValues
EOF
  cat <<EOF >>"$TARGETS_DIR/$DEMO_ENV_IDENTIIFIER.yaml"
$cronJobsValues
EOF

done
#endregion
#endregion
