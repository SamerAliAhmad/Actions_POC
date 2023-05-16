#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=$1

aws eks --region me-central-1 update-kubeconfig --name districtnex-cluster

helm uninstall goldilocks --namespace goldilocks
helm uninstall metrics-server --namespace metrics-server
helm uninstall aws-efs-csi-driver --namespace kube-system
helm uninstall aws-ebs-csi-driver --namespace kube-system


if [ "$ENVIRONMENT" == "demo" ]; then
    kubectl delete pods mgob-0 districtnex-demo-mongodb-0 districtnex-demo-mongodb-1 districtnex-demo-mongodb-2 districtnex-demo-redis-node-0 districtnex-demo-redis-node-1 districtnex-demo-redis-node-2 --force
    helm uninstall redis --namespace districtnex-demo
    helm uninstall mongodb --namespace districtnex-demo
    helm uninstall districtnex-demo
    kubectl delete all --all -n districtnex-demo
    kubectl delete namespace districtnex-demo
else
    kubectl delete pods mgob-0 districtnex-dev-mongodb-0 districtnex-dev-mongodb-1 districtnex-dev-mongodb-2 districtnex-dev-redis-node-0 districtnex-dev-redis-node-1 districtnex-dev-redis-node-2 --force
    helm uninstall redis --namespace districtnex-dev
    helm uninstall mongodb --namespace districtnex-dev
    helm uninstall districtnex-dev
    kubectl delete all --all -n districtnex-dev
    kubectl delete namespace districtnex-dev
fi

helm repo remove bitnami
helm repo remove fairwinds
helm repo remove metrics-server
helm repo remove aws-efs-csi-driver
helm repo remove aws-ebs-csi-driver

helm repo update
