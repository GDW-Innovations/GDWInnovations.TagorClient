# Builds the NuGet package with the Dockerfile and pushes it to GitHub Packages.
# Usage: .\build.ps1 [-Version 1.2.0]
param([string]$Version)

$ErrorActionPreference = 'Stop'

$secureToken = Read-Host 'GitHub PAT (write:packages)' -AsSecureString
$env:GITHUB_TOKEN = [Net.NetworkCredential]::new('', $secureToken).Password
try {
    # --no-cache-filter push: always run the push step, a cached layer would silently skip it
    $dockerArgs = @('build', '--target', 'push', '--no-cache-filter', 'push', '--progress', 'plain', '--secret', 'id=github_token,env=GITHUB_TOKEN')
    if ($Version) { $dockerArgs += @('--build-arg', "VERSION=$Version") }

    docker @dockerArgs $PSScriptRoot
    if ($LASTEXITCODE -ne 0) { throw "docker build failed with exit code $LASTEXITCODE" }
}
finally {
    Remove-Item Env:GITHUB_TOKEN -ErrorAction SilentlyContinue
}
