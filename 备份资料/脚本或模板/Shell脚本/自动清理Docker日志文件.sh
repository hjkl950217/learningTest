#!/bin/sh
echo "======== docker containers logs file size ========"
#logs=$(find /home/docker-data/docker/containers/ -name *-json.log)
logs=$(find /var/lib/docker/containers/ -name *-json.log)
for log in $logs
do
ls -lh $log
done