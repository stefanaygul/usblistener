FROM mcr.microsoft.com/dotnet/sdk:6.0-windowsservercore-ltsc2022 

RUN mkdir c:\\dev
COPY USBDeviceInfo-net6/bin/Debug/net6.0 c:/dev
ENTRYPOINT ["c:\\dev\\USBConsoleApp.exe"]
