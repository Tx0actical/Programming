# possible values of status : Minor, adult, senior citizen

param
(
    # Parameter help description
    [Parameter(Mandatory, HelpMessage = "Please enter your status : Minor, Adult or Senior Citizen")]
    [string]$Status
)
if ($Status -eq 'Minor' -or 'minor')
{
    Write-Host "Not Applicable"
} elseif ($Status -eq 'Adult' -or $Status -eq 'adult') 
{
    Write-Host "Applicable"
} elseif ($Status -eq 'Senior Citizen' -or $Status -eq 'senior citizen')
{
    
    Write-Host "Applicable"
} else 
{
    Write-Host "Wrong Choice"
}