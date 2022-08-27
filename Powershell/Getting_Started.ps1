<# Program to display a message and collect user input
to reuse in a second message #>

$name = Read-Host -Prompt "Enter your name"
$date = Read-Host -Prompt "Enter today's date"
Write-Host "Today's date is $date"
Write-Host "Today is the day $name started their Powershell programming journey"