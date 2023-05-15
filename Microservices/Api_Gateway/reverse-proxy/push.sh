#!/bin/bash

SPECIFIC_VERSION_TAG=""
IMAGE="picacityai/districtnex-picacity-api-gateway-reverse-proxy"

if [ -n "$DISTRICTNEX_VERSION" ]; then
    SPECIFIC_VERSION_TAG="-t $IMAGE:$DISTRICTNEX_VERSION"
fi

docker build . $SPECIFIC_VERSION_TAG -t $IMAGE:latest
docker push $IMAGE --all-tags
