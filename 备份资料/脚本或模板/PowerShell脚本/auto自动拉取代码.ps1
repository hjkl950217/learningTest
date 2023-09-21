function log {
    param($a)
    $date="["+(Get-Date -Format "yyyy-MM-dd HH:mm:ss")+"]"
    $logMsg="$date $a"
    Write-Host $logMsg
}



log "正在拉取代码到开发仓库.."


#第二周--Git
#Git添加tag部分请在本地运行

#Git-gmp
log '===开始拉取 GMP==='
cd E:\公司\成都-鸿翼医药\V5\gmp
git checkout develop_latest
git pull
log '===结束拉取 GMP==='

#Git-DMS
log '===开始拉取 DMS==='
cd E:\公司\成都-鸿翼医药\V5\gmp.dms
git checkout develop_latest
git pull
log '===结束拉取 DMS==='

#Git-AMS
log '===开始拉取 AMS==='
cd E:\公司\成都-鸿翼医药\V5\gmp.ams2
git checkout develop_latest
git pull
log '===结束拉取 AMS==='

#Git-TMS
log '===开始拉取 TMS==='
cd E:\公司\成都-鸿翼医药\V5\gmp.tms
git checkout develop_latest
git pull
log '===结束拉取 TMS==='

#Git-RMS
log '===开始拉取 RMS==='
cd E:\公司\成都-鸿翼医药\V5\gmp.rms2
git checkout develop_latest
git pull
log '===结束拉取 RMS==='

#Git-Config
log '===开始拉取 Config==='
cd E:\公司\成都-鸿翼医药\V5\gmp.config
git checkout develop_latest
git pull
log '===结束拉取 Config==='

#Git-PCS
log '===开始拉取 PCS==='
cd E:\公司\成都-鸿翼医药\V5\gmp.pcs
git checkout develop_latest
git pull
echo "拉取完毕"
log '===结束拉取 PCS==='

cd ..

#提示
$ws = New-Object -ComObject WScript.Shell
$wsr=$ws.Popup("定时拉取代码-成功！",0,"拉取提示",0+64)
