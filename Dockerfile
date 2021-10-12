FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build


WORKDIR /REST

# # copy csproj and restore as distinct layers
COPY *.csproj .
# RUN dotnet restore .

# # copy and publish app and libraries
COPY . .
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app
COPY --from=build /app .
EXPOSE 5000
RUN dotnet dev-certs https --trust
# RUN dotnet run --project REST
ENTRYPOINT ["dotnet", "REST.dll"]


# FROM mcr.microsoft.com/dotnet/sdk
# # RUN mkdir app
# # COPY . /app

# RUN dotnet run --project REST
# ENTRYPOINT ["dotnet", "run"]