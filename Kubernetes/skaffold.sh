#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=$1

aws eks --region me-central-1 update-kubeconfig --name districtnex-cluster


helm repo add eks https://aws.github.io/eks-charts
helm repo add bitnami https://charts.bitnami.com/bitnami
helm repo add fairwinds https://charts.fairwinds.com/stable
helm repo add metrics-server https://kubernetes-sigs.github.io/metrics-server
helm repo add aws-efs-csi-driver https://kubernetes-sigs.github.io/aws-efs-csi-driver
helm repo add aws-ebs-csi-driver https://kubernetes-sigs.github.io/aws-ebs-csi-driver

helm repo update

helm install aws-load-balancer-controller eks/aws-load-balancer-controller --set clusterName=districtnex-cluster -n kube-system

helm dependency build ./helm
helm dependency update ./helm

# Run Skaffold with the specified environment
skaffold run -p "$ENVIRONMENT"

if [ "$ENVIRONMENT" == "demo" ]; then
    NAMESPACE=districtnex-demo
else
    NAMESPACE=districtnex-dev
fi

kubectl config set-context --current --namespace=$NAMESPACE
