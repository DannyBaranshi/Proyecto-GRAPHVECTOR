# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar el archivo .csproj
COPY VECTORGRAPH/VECTORGRAPH/*.csproj ./VECTORGRAPH/
RUN dotnet restore ./VECTORGRAPH/*.csproj

# Copiar todo el código fuente
COPY VECTORGRAPH/VECTORGRAPH/ ./VECTORGRAPH/

# Compilar
WORKDIR /src/VECTORGRAPH
RUN dotnet publish -c Release -o /app/publish

# Etapa runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copiar la publicación
COPY --from=build /app/publish .

# Exponer puerto
EXPOSE 5278

# Configurar variable de entorno para el puerto
ENV ASPNETCORE_URLS=http://+:5278

ENTRYPOINT ["dotnet", "VECTORGRAPH.dll"]