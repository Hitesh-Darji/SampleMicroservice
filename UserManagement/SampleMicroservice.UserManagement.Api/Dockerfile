#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["UserManagement/SampleMicroservice.UserManagement.Api/SampleMicroservice.UserManagement.Api.csproj", "UserManagement/SampleMicroservice.UserManagement.Api/"]
COPY ["UserManagement/SampleMicroservice.UserManagement.Infrastructure/SampleMicroservice.UserManagement.Infrastructure.csproj", "UserManagement/SampleMicroservice.UserManagement.Infrastructure/"]
COPY ["UserManagement/SampleMicroservice.UserManagement.Domain/SampleMicroservice.UserManagement.Domain.csproj", "UserManagement/SampleMicroservice.UserManagement.Domain/"]
RUN dotnet restore "./UserManagement/SampleMicroservice.UserManagement.Api/SampleMicroservice.UserManagement.Api.csproj"
COPY . .
WORKDIR "/src/UserManagement/SampleMicroservice.UserManagement.Api"
RUN dotnet build "./SampleMicroservice.UserManagement.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SampleMicroservice.UserManagement.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleMicroservice.UserManagement.Api.dll"]