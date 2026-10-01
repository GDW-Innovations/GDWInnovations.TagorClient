# syntax=docker/dockerfile:1
# Build context is the repository root (the csproj packs ../../../LICENSE), see build.ps1.

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS pack
WORKDIR /repo

# Optional: overrides the <Version> from the csproj, e.g. --build-arg VERSION=1.2.0
ARG VERSION

ARG PROJECT=GDWInnovations.TagorClient/src/GDWInnovations.TagorClient/GDWInnovations.TagorClient.csproj

COPY ${PROJECT} ${PROJECT}
RUN dotnet restore ${PROJECT}

COPY . .
RUN dotnet pack ${PROJECT} -c Release --no-restore -o /out ${VERSION:+-p:Version=$VERSION}

FROM pack AS push
# GitHub token with write:packages, passed as a BuildKit secret so it never ends up in an image layer
RUN --mount=type=secret,id=github_token,required=true \
    dotnet nuget push "/out/*.nupkg" \
        --source https://nuget.pkg.github.com/GDW-Innovations/index.json \
        --api-key "$(cat /run/secrets/github_token)"
