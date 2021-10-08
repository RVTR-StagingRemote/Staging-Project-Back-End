FROM mcr.microsoft.com/dotnet/sdk
RUN mkdir app
COPY . /app
EXPOSE 80
ENTRYPOINT ["dotnet", "run"]