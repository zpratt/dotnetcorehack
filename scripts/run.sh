#!/bin/bash

set -e

docker container prune -f
docker run --name dotnetcorehack -p 8080:80 dotnetcorehack
