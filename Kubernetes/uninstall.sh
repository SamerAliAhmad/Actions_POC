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
    helm uninstall districtnex-demo -n districtnex-demo
else
    helm uninstall districtnex-dev -n districtnex-dev
fi
