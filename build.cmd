SET version=%1
SET artifactsdir=artifacts
SET curpath=%~dp0

IF NOT EXIST "%artifactsDir%" (
    MKDIR "%artifactsDir%"
)
SET builddir=build
IF EXIST "%builddir%" (
    RMDIR "%builddir%" /s /q    
)
MKDIR "%builddir%"
dotnet.exe publish "src\SecurityHeaders" --framework net461 --output "%curpath%%builddir%" --configuration Release

nuget pack SecurityHeaders.nuspec -Version %version% -OutputDirectory "%artifactsDir%" -NoPackageAnalysis -Verbosity quiet
