﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BackgroundWorker/BackgroundWorker.csproj", "BackgroundWorker/"]
RUN dotnet restore "BackgroundWorker/BackgroundWorker.csproj"
COPY . .
WORKDIR "/src/BackgroundWorker"
RUN dotnet build "BackgroundWorker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BackgroundWorker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackgroundWorker.dll"]
