param 
(
    [string]$path = './app',
    [string]$DestinationPath = './'
)
if(-not (Test-Path $path))
{
    throw "The source directory $path does not exist, please specify an existing directory"
}

$date = Get-Date -Format "dd-mm-yyyy"

$DestinationFile = "$($DestinationPath = 'backup-')$date.zip"
if (-not (Test-Path $DestinationFile))
{
    Compress-Archive -Path $Path -CompressionLevel 'Fastest' -DestinationPath "$($DestinationPath + 'backup-' + $date)"
    Write-Host "Created backup at $($DestinationPath + 'backup-' + $date).zip"
} else 
{
    Write-Error "Today's backup already exists"
}