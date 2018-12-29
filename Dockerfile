FROM microsoft/dotnet:2.2-sdk
ENV ASPNETCORE_URLS="http://*:5123"
WORKDIR /opt/netcore/src
COPY . ./
RUN useradd -m net && chown net:net -R /usr/share/dotnet /opt/netcore
USER net
RUN dotnet restore && dotnet publish -c Release -o app && mv app /opt/netcore/ && rm -rf /opt/netcore/src
EXPOSE 5123
WORKDIR /opt/netcore/app
ENTRYPOINT ["dotnet", "Vilticket.dll"]
