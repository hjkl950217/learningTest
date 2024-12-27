@echo off

echo 拉取最新代码...
git pull

echo 添加所有修改...
git add .

echo 检查当前状态...
git status > status.log

findstr "Changes to be committed" status.log > nul
if %errorlevel% equ 0 (
    echo 发现有文件改动。

    :confirm
    set /p "continue=是否继续提交并推送？ (Y/N) "
    if /i "%continue%"=="y" goto commit
    if /i "%continue%"=="n" goto end
    echo 请输入 Y 或 N。
    goto confirm

    :commit
    echo 正在提交代码...
    git commit -m "更新文件"

    echo 正在推送代码...
    git push

    echo 操作完成。
    goto end
) else (
    echo 没有发现需要提交的改动。
)

:end
del status.log 2>nul
pause
exit /b 0