FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /
EXPOSE 80
EXPOSE 443
ARG MyCustomPath.cutomepath
ENV MyCustomPath.cutomepath=$MyCustomPath.cutomepath
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["ImageUpload/ImageUpload.csproj", "ImageUpload/"]
RUN dotnet restore "ImageUpload/ImageUpload.csproj"
COPY . .
WORKDIR "/src/ImageUpload"
RUN dotnet build "ImageUpload.csproj" -c Release -o //build

FROM build AS publish
RUN dotnet publish "ImageUpload.csproj" -c Release -o //publish

FROM base AS final
WORKDIR /
COPY --from=publish //publish .
ENTRYPOINT ["dotnet", "ImageUpload.dll"]