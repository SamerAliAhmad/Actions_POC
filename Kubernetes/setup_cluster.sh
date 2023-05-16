#!/bin/bash

# Check if the user provided an environment name as the first argument
if [ -z "$1" ]; then
    echo "Please provide an environment name as the first argument."
    exit 1
fi

# Set the environment variable based on the first argument
ENVIRONMENT=$1

aws eks --region me-central-1 update-kubeconfig --name districtnex-cluster

if [ "$ENVIRONMENT" == "demo" ]; then
    kubectl config set-context --current --namespace=districtnex-demo
else
    kubectl config set-context --current --namespace=districtnex-dev-picacity
fi

kubectl get pods
