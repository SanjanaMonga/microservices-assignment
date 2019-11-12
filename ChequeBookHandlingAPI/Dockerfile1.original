FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["ChequeBookHandlingAPI/ChequeBookHandlingAPI.csproj", "ChequeBookHandlingAPI/"]
RUN dotnet restore "ChequeBookHandlingAPI/ChequeBookHandlingAPI.csproj"
COPY . .
WORKDIR "/src/ChequeBookHandlingAPI"
RUN dotnet build "ChequeBookHandlingAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ChequeBookHandlingAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ChequeBookHandlingAPI.dll"]