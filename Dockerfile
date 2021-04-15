FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["ServicingAPI.csproj", "./"]
RUN dotnet restore "ServicingAPI.csproj"
COPY . .
RUN dotnet build "ServicingAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServicingAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ServicingAPI.dll"]
