#!/bin/bash
#================参数设定================
dateStr=`date`
logAddr='/var/log/clearDocker.log'
kvAddr='/var/lib/docker/network/files/local-kv.db'
bkKvAddr='/var/lib/docker/network/files/local-kv.db_bk'

#================参数设定================


echo "===========================" >> $logAddr

#定义日志函数
log(){
	if [ -n "$2" ]
	then
		echo "[$(date)] | ${1} | ${2}" >> $logAddr
	else
		echo "[$(date)] | ${1}" >> $logAddr
	fi
	
	return $?
}

#定义docker无用资源清理
stopDocker(){
	log "开始清理docker无用资源"
	docker system prune -a -f --volumes
}



#定义docker kvdb清理
clearFreeMem(){
	log "开始清理docker local-kv.db"
	log "上次文件备份地址: " $bkKvAddr
	
	#service docker stop 
	cp $kvAddr $bkKvAddr
	rm $kvAddr
	#service docker start
	#reboot
}




#开始执行
echo '开始执行清理Docker脚本'
echo '日志地址:  '$logAddr

stopDocker
clearFreeMem


#退出脚本
exit


