# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/MRDX.Game.DownPatcher/*" -Force -Recurse
dotnet publish "./MRDX.Game.DownPatcher.csproj" -c Release -o "$env:RELOADEDIIMODS/MRDX.Game.DownPatcher" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location