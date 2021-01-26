FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
EXPOSE 9000:80
EXPOSE 9001:443

COPY TaxaJuros.csproj .
RUN dotnet restore

COPY . .
RUN dotnet build -c release --no-restore

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TaxaJuros.dll"]