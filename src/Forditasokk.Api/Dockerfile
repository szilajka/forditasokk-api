FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 88
EXPOSE 44330

ENV ASPNETCORE_URLS=https://+:44330;http://88

# Creates a non-root user with an explicit UID and adds permission to access the /app folder
# For more info, please refer to https://aka.ms/vscode-docker-dotnet-configure-containers
RUN adduser -u 5678 --disabled-password --gecos "" appuser && chown -R appuser /app
USER appuser

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Forditasokk.Api/Forditasokk.Api.csproj", "src/Forditasokk.Api/"]
RUN dotnet restore "src/Forditasokk.Api/Forditasokk.Api.csproj"
COPY . .
WORKDIR "/src/src/Forditasokk.Api"
RUN dotnet build "Forditasokk.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Forditasokk.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Forditasokk.Api.dll"]
