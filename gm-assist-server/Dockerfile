#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["gm-assist-server/gm-assist-server.csproj", "gm-assist-server/"]
RUN dotnet restore "gm-assist-server/gm-assist-server.csproj"
COPY . .
WORKDIR "/src/gm-assist-server"
RUN dotnet build "gm-assist-server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "gm-assist-server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "gm-assist-server.dll"]