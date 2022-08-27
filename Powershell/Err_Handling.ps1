try
{
    Get-Command
} catch [System.IO.IOException] 
{
    Write-Host "Something IO went wrong : $($_.error.message)"
} catch 
{
    Write-Host "Someething else went wrong : $($_.error.message)"
} finally 
{
    # Clear the space
}