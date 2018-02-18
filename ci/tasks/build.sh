#!/bin/bash
set -e -u -x

cd sources

echo I am in `pwd`
ls -l ../

echo "Starting build ..."

#dotnet restore
#dotnet publish -c Release -o out

#echo "copying files to ../build-output"
#cp manifest.yml ../build-output
mkdir -p ../out
#cp -R ./out/* ../out
