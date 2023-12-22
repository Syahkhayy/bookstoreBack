#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/PlaygroundDemo.Migrator/PlaygroundDemo.Migrator.csproj", "src/PlaygroundDemo.Migrator/"]
COPY ["src/PlaygroundDemo.EntityFrameworkCore/PlaygroundDemo.EntityFrameworkCore.csproj", "src/PlaygroundDemo.EntityFrameworkCore/"]
COPY ["src/PlaygroundDemo.Core/PlaygroundDemo.Core.csproj", "src/PlaygroundDemo.Core/"]
COPY ["src/PlaygroundDemo.Core.Shared/PlaygroundDemo.Core.Shared.csproj", "src/PlaygroundDemo.Core.Shared/"]
RUN dotnet restore "src/PlaygroundDemo.Migrator/PlaygroundDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/PlaygroundDemo.Migrator"
RUN dotnet build "PlaygroundDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlaygroundDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlaygroundDemo.Migrator.dll"]
