FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Service.Api/Service.Api.csproj Service.Api/
COPY DAO/DAO.csproj DAO/
RUN dotnet restore Service.Api/Service.Api.csproj
COPY . .
WORKDIR /src/Service.Api
RUN dotnet build Service.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Service.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Service.Api.dll"]
