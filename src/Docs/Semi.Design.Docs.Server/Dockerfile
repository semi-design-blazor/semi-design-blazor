#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Docs/Semi.Design.Docs.Server/Semi.Design.Docs.Server.csproj", "Docs/Semi.Design.Docs.Server/"]
COPY ["Docs/Semi.Design.Shared/Semi.Design.Shared.csproj", "Docs/Semi.Design.Shared/"]
COPY ["Semi.Design.Blazor/Semi.Design.Blazor.csproj", "Semi.Design.Blazor/"]
COPY ["Component/BlazorComponent/BlazorComponent.csproj", "Component/BlazorComponent/"]
RUN dotnet restore "Docs/Semi.Design.Docs.Server/Semi.Design.Docs.Server.csproj"
COPY . .
WORKDIR "/src/Docs/Semi.Design.Docs.Server"
RUN dotnet build "Semi.Design.Docs.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Semi.Design.Docs.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Semi.Design.Docs.Server.dll"]