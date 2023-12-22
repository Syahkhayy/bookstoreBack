#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/PlaygroundDemo.Web.Public/PlaygroundDemo.Web.Public.csproj", "src/PlaygroundDemo.Web.Public/"]
COPY ["src/PlaygroundDemo.Web.Core/PlaygroundDemo.Web.Core.csproj", "src/PlaygroundDemo.Web.Core/"]
COPY ["src/PlaygroundDemo.Application/PlaygroundDemo.Application.csproj", "src/PlaygroundDemo.Application/"]
COPY ["src/PlaygroundDemo.Application.Shared/PlaygroundDemo.Application.Shared.csproj", "src/PlaygroundDemo.Application.Shared/"]
COPY ["src/PlaygroundDemo.Core.Shared/PlaygroundDemo.Core.Shared.csproj", "src/PlaygroundDemo.Core.Shared/"]
COPY ["src/PlaygroundDemo.Core/PlaygroundDemo.Core.csproj", "src/PlaygroundDemo.Core/"]
COPY ["src/PlaygroundDemo.EntityFrameworkCore/PlaygroundDemo.EntityFrameworkCore.csproj", "src/PlaygroundDemo.EntityFrameworkCore/"]
COPY ["src/PlaygroundDemo.GraphQL/PlaygroundDemo.GraphQL.csproj", "src/PlaygroundDemo.GraphQL/"]
RUN dotnet restore "src/PlaygroundDemo.Web.Public/PlaygroundDemo.Web.Public.csproj"
COPY . .
WORKDIR "/src/src/PlaygroundDemo.Web.Public"
RUN dotnet build "PlaygroundDemo.Web.Public.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlaygroundDemo.Web.Public.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlaygroundDemo.Web.Public.dll"]
