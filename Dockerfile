# Use official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy everything
COPY . ./

# Publish app
RUN dotnet publish FutureFix/FutureFix.csproj -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./

EXPOSE 8080
ENTRYPOINT ["dotnet", "FutureFix.dll"]