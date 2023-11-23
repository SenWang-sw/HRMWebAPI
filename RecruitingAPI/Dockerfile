#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV RecruitingDb="Data Source=192.168.1.38,1433;Initial Catalog=RecruitingDb;User ID=SA;Password=Admin@1234;TrustServerCertificate=true"
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RecruitingAPI/RecruitingAPI.csproj", "RecruitingAPI/"]
COPY ["Recruiting.Infras/Recruiting.Infras.csproj", "Recruiting.Infras/"]
COPY ["Recruiting.AppCore/Recruiting.AppCore.csproj", "Recruiting.AppCore/"]
RUN dotnet restore "RecruitingAPI/RecruitingAPI.csproj"
COPY . .
WORKDIR "/src/RecruitingAPI"
RUN dotnet build "RecruitingAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecruitingAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecruitingAPI.dll"]