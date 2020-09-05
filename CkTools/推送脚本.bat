rm package

dotnet build CkTools --configuration Release --no-restore -o package

dotnet nuget push "**/*.nupkg" -k 'oy2ood3whx623akk2snqwa3oloxkwjmehp4lom5skyuodq' -s https://api.nuget.org/v3/index.json  --skip-duplicate 
dotnet nuget push "**/*.snupkg" -k 'oy2ood3whx623akk2snqwa3oloxkwjmehp4lom5skyuodq' -s https://api.nuget.org/v3/index.json  --skip-duplicate 
