#!/usr/bin/env bash

dnu restore src/Spudmash.Api
dnu build src/Spudmash.Api  --framework dnxCore50
dnu pack src/Spudmash.Api --out src/Spudmash.Api/artifacts --framework dnxCore50
dnx --project src/Spudmash.Api/project.json web
