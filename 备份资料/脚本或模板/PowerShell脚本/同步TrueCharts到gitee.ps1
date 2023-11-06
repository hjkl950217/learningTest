# 源仓库地址 源仓库分支
$source_repo = "https://github.com/truecharts/catalog.git"
$source_branch = "main"
# 目标仓库地址 目标仓库分支
$target_repo = "https://gitee.com/GTXCK/true-charts-catalog"
$target_branch = "main"
# 仓库名称
$repo_name = "TrueCharts"

# 检查仓库目录是否存在
if (Test-Path $repo_name) {
  # 如果存在，进入目录并拉取最新更改
  Set-Location $repo_name
  git pull
} else {
  # 如果不存在，克隆源仓库到本地
  git clone $source_repo $repo_name
  # 进入仓库目录
  Set-Location $repo_name
}

# 添加目标仓库为远程仓库
git remote add gitee $target_repo

# 获取目标仓库的数据
git fetch gitee

# 切换到源分支
git checkout $source_branch

# 将目标仓库的更改合并到当前分支
git merge gitee/$target_branch --allow-unrelated-histories

# 将更改强制推送到目标仓库
git push gitee $source_branch:$target_branch --force

# 退出仓库文件夹
cd ..