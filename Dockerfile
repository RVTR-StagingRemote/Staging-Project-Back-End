FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build


# WORKDIR /REST

# # copy csproj and restore as distinct layers
# COPY *.csproj .
# RUN dotnet restore -project REST

# # copy and publish app and libraries
# COPY . .
# RUN dotnet publish -c release -o /REST --no-restore

# final stage/image
# FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /REST
# COPY --from=build /REST .
EXPOSE 5000
RUN dotnet run --project REST
ENTRYPOINT ["dotnet", "dotnetapp.dll"]


# FROM mcr.microsoft.com/dotnet/sdk
# # RUN mkdir app
# # COPY . /app

# RUN dotnet run --project REST
# ENTRYPOINT ["dotnet", "run"]