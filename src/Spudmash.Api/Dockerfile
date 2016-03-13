FROM microsoft/aspnet:1.0.0-rc1-final

RUN mkdir -p /app/Spudmash.Api
COPY . /app/Spudmash.Api
WORKDIR /app/Spudmash.Api
RUN ["dnu", "restore"]
RUN ["dnu", "pack", "--out", "artifacts"]

EXPOSE 5000
ENTRYPOINT ["dnx", "-p", "project.json", "web", "--server.urls", "http://0.0.0.0:5000"]
