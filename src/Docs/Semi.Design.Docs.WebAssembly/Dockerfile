FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Docs/Semi.Design.Docs.WebAssembly/Semi.Design.Docs.WebAssembly.csproj", "Docs/Semi.Design.Docs.WebAssembly/"]
COPY ["Docs/Semi.Design.Shared/Semi.Design.Shared.csproj", "Docs/Semi.Design.Shared/"]
COPY ["Semi.Design.Blazor/Semi.Design.Blazor.csproj", "Semi.Design.Blazor/"]
RUN dotnet workload restore --project Docs/Semi.Design.Docs.WebAssembly/Semi.Design.Docs.WebAssembly.csproj
RUN dotnet restore "Docs/Semi.Design.Docs.WebAssembly/Semi.Design.Docs.WebAssembly.csproj"
COPY . .
WORKDIR "/src/Docs/Semi.Design.Docs.WebAssembly"
RUN dotnet build "Semi.Design.Docs.WebAssembly.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Semi.Design.Docs.WebAssembly.csproj" -c Release -o /app/publish /p:UseAppHost=false
