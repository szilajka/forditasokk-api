FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 88
EXPOSE 44330

ENV ASPNETCORE_URLS=https://+:44330;http://88

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
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
