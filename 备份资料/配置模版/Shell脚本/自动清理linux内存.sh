#!/bin/bash
#================参数设定================
maxFreeNum=8000
dateStr=`date`
usedNum=0
freeNum=0
logAddr='/var/log/autoClearMem.log'
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

#定义内存查询函数
showMemData(){
	usedNum=`free -m | awk 'NR==2' | awk '{print $3}'`
	freeNum=`free -m | awk 'NR==2' | awk '{print $4}'`
	
	memLogStr="Use：${usedNum}MB | Free：${freeNum}MB"
	log $1 "$memLogStr"
	return $?
}



#定义清理内存函数
clearFreeMem(){

	#执行
	sync && echo 1 > /proc/sys/vm/drop_caches &> /dev/null
	sync && echo 2 > /proc/sys/vm/drop_caches &> /dev/null
    sync && echo 3 > /proc/sys/vm/drop_caches &> /dev/null
	
	#日志
	showMemData '清理后的内存数据'
	
}




#开始执行清理
echo '开始执行清理脚本'
echo '日志地址:  '$logAddr

showMemData '当前内存数据'
if [ $freeNum -le $maxFreeNum ]
then
	clearFreeMem
else
    log "当前FreeMem有"$freeNum"MB,大于阈值"$maxFreeNum"MB,不需要清理" 
fi

#退出脚本
exit


