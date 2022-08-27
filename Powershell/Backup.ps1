Param (
    [string]$path = './app',
    [string]$destinationpath = './'
)

$date = Get-Date -format "yyy-mm-dd"
Compress-Archive -Path './app' -CompressionLevel 'Fastest' -DestinationPath "./backup-$date"
Write-Host "Created backup at $('./backup' + $date).zip"
