# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/MRDX.Game.RestoreSave/*" -Force -Recurse
dotnet publish "./MRDX.Game.RestoreSave.csproj" -c Release -o "$env:RELOADEDIIMODS/MRDX.Game.RestoreSave" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location