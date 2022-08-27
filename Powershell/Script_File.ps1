# Create a script file
param 
(   
    [parameter(Mandatory, HelpMessage = "Please provide a valid path")]
    $path       <#Can also be written as [string]$path, so that only strings would be accepted as input#>
)
New-Item $path
Write-Host "File created at path $path"

$value = 3
if ( $value -le 0)   # -le flag means less than or equal to 
{
    Write-Host "$value is negative"
} else {
    Write-Host "$value is positive"
}