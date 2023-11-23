#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV EmpDb="Data Source=192.168.1.38,1433;Initial Catalog=EmployeeDb;User ID=SA;Password=Admin@1234;TrustServerCertificate=true"
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EmployeAPI/EmployeAPI.csproj", "EmployeAPI/"]
RUN dotnet restore "EmployeAPI/EmployeAPI.csproj"
COPY . .
WORKDIR "/src/EmployeAPI"
RUN dotnet build "EmployeAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EmployeAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeAPI.dll"]