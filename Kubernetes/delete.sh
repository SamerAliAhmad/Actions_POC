#!/bin/bash

aws eks --region me-central-1 update-kubeconfig --name districtnex-cluster

rm -R Helm cleanup.sh skaffold.sh skaffold.yaml uninstall.sh upgrade.sh setup_cluster.sh delete.sh
