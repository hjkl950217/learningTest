# !/bin/sh
# 使用方法： 在定时任务中配置执行此脚本
# 原理： 扫描登录日志来判断攻击ip

# 日志路径
LOG_PATH=$(tail -n 2000 /var/log/auth.log)
# hosts.deny路径
DENY_HOST_PATH=/etc/hosts.deny

# 正则匹配模版
SSH_DENY_FORMAT='Failed[[:space:]]password.+ssh[[:digit:]]*$'
IP_FORMAT='([[:digit:]]{1,3}\.){3}[[:digit:]]{1,3}'

# 失败次数
DENY_COUNT=5

NEED_DENY_IP_LIST=`echo "$LOG_PATH" | grep -oE $SSH_DENY_FORMAT | grep -oE $IP_FORMAT | sort | uniq -c | sort -t " " -k 1r | awk -v denyCount="${DENY_COUNT}" '{if($1>denyCount) print $2}'`
ALREADY_DENY_IP_LIST=`cat $DENY_HOST_PATH | grep -oE $IP_FORMAT`

for ip in ${NEED_DENY_IP_LIST}
do
    echo "监视"$ip"正在攻击此计算机"
    EXIST_IP=`cat $DENY_HOST_PATH | grep $ip | uniq`
    if [ -z "$EXIST_IP" ];
    then
        echo "sshd:"$ip":deny" >> ${DENY_HOST_PATH}
        echo "已添加到 "$DENY_HOST_PATH"： "$ip
    else
        echo "已在 "$DENY_HOST_PATH"中： "$ip
    fi
done