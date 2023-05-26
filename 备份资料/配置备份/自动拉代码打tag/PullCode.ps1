echo "正在拉取代码到发版专用仓库.."


#第二周--Git
#Git添加tag部分请在本地运行
#Git-gmp
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp
git checkout develop_latest
git pull
#Git-dms
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.dms
git checkout develop_latest
git pull
#Git-ams
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.ams2
git checkout develop_latest
git pull
#Git-tms
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.tms
git checkout develop_latest
git pull
#Git-rms
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.rms2
git checkout develop_latest
git pull
#Git-config
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.config
git checkout develop_latest
git pull
#Git-pcs
cd E:\公司\成都-鸿翼医药\V5\发版专用本地仓库\gmp.pcs
git checkout develop_latest
git pull
echo "拉取完毕"


#提示
$ws = New-Object -ComObject WScript.Shell
$wsr=$ws.Popup("定时拉取代码到发版仓库-成功！",0,"拉取提示",0+64)
