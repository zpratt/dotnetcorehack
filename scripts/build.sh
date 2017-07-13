#!/bin/bash

set -e

dotnet restore
dotnet build 
dotnet publish -o obj/docker
docker build -t dotnetcorehack .

