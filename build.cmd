SET version=%1
set artifactsdir=artifacts
IF NOT EXIST "%artifactsDir%" (
    mkdir "%artifactsDir%"
)
set builddir=build
IF NOT EXIST "%builddir%" (
    mkdir "%builddir%"
)
nuget pack SecurityHeaders.nuspec -Version %version% -OutputDirectory "%artifactsDir%"