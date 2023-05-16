#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=$1

aws eks --region me-central-1 update-kubeconfig --name districtnex-cluster

helm dependency update ./Helm
helm dependency build ./Helm

MONGODB_ROOT_PASSWORD=$(kubectl get secret mongodb-secrets -o jsonpath="{.data.mongodb-root-password}" | base64 -d)

if [ "$ENVIRONMENT" == "demo" ]; then
    helm upgrade -f helm/targets/demo.yaml districtnex-demo ./Helm --set auth.rootPassword=$MONGODB_ROOT_PASSWORD
else
    helm upgrade -f helm/targets/dev.yaml districtnex-dev ./Helm --set auth.rootPassword=$MONGODB_ROOT_PASSWORD
fi
