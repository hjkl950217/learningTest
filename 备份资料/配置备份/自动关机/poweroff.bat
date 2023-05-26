@echo off
setlocal enabledelayedexpansion

rem 是否交流电 0=否 1=是
set /a ac=0
set /a timer=0

:begin
rem 计数器
set /a counter=0
rem 当前电源状态
set state=

for /f "delims=" %%i in ('wmic path win32_battery get BatteryStatus') Do (
    set /a counter+=1
    set /a val=%%i+0
      
    if !counter! == 2 (
      if !val! == 2 if %ac% == 0 ( 
        set /a ac=1 
        shutdown -a
      ) 
      
      set state=%%i
    )
)

rem 只有当从交流电源切换到电池后才执行关机
if %ac% == 0 goto loop
if %ac% == 2 goto loop
if %ac% == 1 if %state% == 1 (goto shutdown) else (goto loop)

:shutdown
shutdown -h
rem timeout -t 3 
rem start %windir%\system32\rundll32.exe user32.dll,LockWorkStation
goto showMsg

:showMsg
set msgbox=Msgbox("即将关闭计算机，是否取消？",1,"关机提醒")
for /f "Delims=" %%a in ('MsHta VBScript:Execute("CreateObject(""Scripting.Filesystemobject"").GetStandardStream(1).Write(%msgbox:"=""%)"^)(Close^)') do Set "returnValue=%%a"
if %returnValue% == 2 (
  shutdown -a
  set /a ac=0
)

:loop
timeout -t 3
set /a timer+=3
if %timer% GTR 60 exit
goto begin