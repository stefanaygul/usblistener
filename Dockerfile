FROM mcr.microsoft.com/windows/servercore:ltsc2022
COPY USBConsoleApp.exe c:\\USBConsoleApp.exe
ENTRYPOINT ["c:\\USBConsoleApp.exe"]