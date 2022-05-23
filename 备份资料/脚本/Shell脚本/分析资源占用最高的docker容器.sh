#!/bin/bash
#================参数设定================
nowDateStr=`date "+%Y-%m-%d %k:%M:%S"`
shName="findTopResources"
logAddr=/tmp/$shName.log
#================参数设定================


#================脚本内部参数设定================
mode=""	#脚本运行模式 cpu or mem
topNum=3	#统计前几项
#================脚本内部参数设定================


echo "===========================" >> $logAddr

#定义日志函数
log(){
	
	if [ -n "$2" ]
	then
		echo "[${nowDateStr}] | ${1} | ${2}" | tee -a $logAddr
	else
		echo "[${nowDateStr}] | ${1}" | tee -a $logAddr
	fi
	
	return $?
}

#执行分析
executeAnalysis(){

	log "分析模式" $mode
	
	#[1] 从top上获取信息
	#-s 以安全模式运行-适合非交互式模式
	#-b 以批量模式运行,重定向到文件使用，默认只显示一部分
	#-c 显示完整命令行,默认只显示命令名称
	#-n 采样几次
	#-i 不显示任何闲置或者僵死进程
	top -o $mode -sc -n 1 | tail -n +8 | head -n $topNum \
	| while read tlineStr
	do
		lineStr=`echo $tlineStr | sed 's@^\s*@@g'` #去除行首空格
		dataLine=($lineStr) 	#按空格分割后存入变量
		#1=PID 2=USER 3=PR 4=NI 5=VIRT 6=RES 7=SHR 8=S 9=%CPU 10=%MEM 11=TIME+ 12=COMMAND
		
		#[2] 用PID查找到容器名
		cgLine=`cat /proc/${dataLine[1]}/cgroup | head -n 1`
		cgLineArray=(${cgLine//// }) #以/分割字符串
		conId=${cgLineArray[2]} # 获取容器Id
		sourceConName=`docker inspect --format '{{.Name}}' "$conId" | sed 's@^\/@@g'` #获取原始容器名

		#[3] 显示容器名
		if [[ ${#sourceConName} -eq 0 ]];then
		log "[非容器应用]CPU%:"${dataLine[9]} ${dataLine[1]}-${dataLine[12]}
		else
		log "[容器应用]CPU%:"${dataLine[9]} $sourceConName
		fi
		
		
	done

	log "分析结束"
	return $?
}

#定义帮助文档
showHelp(){
	echo -e "用法: ./$shName.sh [command] [parameter]"
	echo "查找占用主机资源最多的docker容器"
	echo ""
	echo "command:"
	echo "help,显示帮助"
	echo "cpu,按CPU分析"
	echo "mem,按内存分析"
	echo ""
	echo "parameter:"
	echo -e "分析前几项进程,如果进程不是docker容器则不会记录	例: './$shName.sh cpu 5' 只分析前5项进程"
	echo ""
}



#开始执行清理
echo "==========================="
log '分析资源占用最高的docker容器'
log '日志地址:  '$logAddr

if [[ "$1"x == "x" ]] || [[ "$1" == "help" ]];then
	showHelp
elif [[ "$1" == "cpu" ]] || [[ "$1" == "mem" ]];then	
	mode="%"`echo $1 |tr a-z A-Z`	
	topNum="$2"$topNum
	
	executeAnalysis
else
    showHelp
fi

#退出脚本
exit


