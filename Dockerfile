FROM mcr.microsoft.com/dotnet/sdk
# RUN mkdir app
# COPY . /app
EXPOSE 5001
RUN dotnet run --project REST
# ENTRYPOINT ["dotnet", "run"]