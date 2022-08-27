function Get-Advanced {

    [CmdletBinding()]
    param (
        [Parameter(Mandatory=$true, ValueFromPipelineByPropertyName=$true, HelpMessage="Enter the first two letters of your last name")]
        [ValidatePattern("[a-z][a-z][0-9][0-9][0-9][0-9]")] # specify paramter format
        $EmployeeID
    )
    Write-Host $EmployeeID
}
