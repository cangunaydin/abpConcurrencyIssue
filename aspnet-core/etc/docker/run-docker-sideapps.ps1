$currentFolder = $PSScriptRoot
$parentFolder = (get-item $currentFolder).parent

$slnFolder=$parentFolder.parent.fullname
$certsFolder = Join-Path $parentFolder.fullname "certs"



If(!(Test-Path -Path $certsFolder))
{
    New-Item -ItemType Directory -Force -Path $certsFolder
    if(!(Test-Path -Path (Join-Path $certsFolder "localhost.pfx") -PathType Leaf)){
        Set-Location $certsFolder
        dotnet dev-certs https -v -ep localhost.pfx -p 91f91912-5ab0-49df-8166-23377efaf3cc -t        
    }
}

Set-Location $currentFolder
docker-compose -f docker-compose-sideapps.yml up -d