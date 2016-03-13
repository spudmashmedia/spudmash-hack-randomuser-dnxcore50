# Spudmash Quick Hacks: Random User API - DNX Core 50

*Quick Hack Tasks:*

Integrate the <http://randomuser.me> REST service by building a DNXCore50 Web API (complete with Dockerfile/docker-compose yaml) running on Linux.


Each tech will consist of:

- Responsive UI
- Service Layer
- Automated Test (UI, unit, integration)


## Prerequisites

- For DNXCore50, console, DNU, DNX needs to be installed
(<http://docs.asp.net/en/latest/getting-started/installing-on-mac.html>)

- Docker Toolbox (Kitematic, docker-compose)
<https://www.docker.com/products/docker-toolbox>


## Installation

Clone this repo

### DNX Kestrel:

#### Build & Run
```
cmd> sh dnx-build.sh
```

#### Integration Test

SoupUI Integration Tests

```
src/Spudmash.Api.IntegrationTests/spudmash.api.randomuser.integrationtest.xml
```

Use endpoint `http://localhost:5000`  


### Docker

#### Build Docker Container & Run
```
cmd> sh docker-build.sh
```

#### Integration Test

SoupUI Integration Tests

```
src/Spudmash.Api.IntegrationTests/spudmash.api.randomuser.integrationtest.xml
```

Use endpoint `http://192.168.99.100:8080`



## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## History

| Date | Version | Description|
|-------|----------|-------------|
|2016-03-12 | 0.1 | Initial commit

## Credits

<http://www.swagger.io>  
<https://www.docker.com>  
<https://www.asp.net>  

Copyright (c) 2015 Spudmash Media
