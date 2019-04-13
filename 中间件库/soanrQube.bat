dotnet clean
dotnet restore -f

::-- 1.UT
dotnet test /p:CollectCoverage=true /p:CopyLocalLockFileAssemblies=true /p:CoverletOutputFormat=opencover /p:Exclude=\"[xunit.*]*,[*.Test]*\" /p:Threshold=0 /p:ThresholdType=line /p:ThresholdStat=average


::-- 2.analysis
echo 'start analysis'
echo ''
dotnet-sonarscanner begin /k:"Nova.LogicChain" /d:sonar.host.url="https://sonar.newegg.org" /d:sonar.login=7c15672da84d42aa0d1f3d07b903a8ac4c67260c /d:sonar.cs.opencover.reportsPaths="**\coverage.opencover.xml" /d:sonar.coverage.exclusions="1.cs,**\2.cs,**3.cs" 
dotnet msbuild -restore -target:Build -clp:ErrorsOnly -p:Configuration=Release
dotnet-sonarscanner end /d:sonar.login=7c15672da84d42aa0d1f3d07b903a8ac4c67260c