#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://murf.ai/api/docs/api-reference/openapi.json (locally maintained)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Murf API spec is from the Fern-hosted docs (https://murf.ai/api/docs/api-reference/openapi.json)
# with fixes: duplicate operationIds, api-key header params removed, single server URL.
# Auth: --security-scheme sends the API key directly as api-key header.
autosdk generate openapi.json \
  --namespace Murf \
  --clientClassName MurfClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:api-key

rm -rf ../../cli/Murf.CLI

autosdk cli-project openapi.json \
  --output ../../cli/Murf.CLI \
  --sdk-project ../../libs/Murf/Murf.csproj \
  --targetFramework net10.0 \
  --namespace Murf \
  --clientClassName MurfClient \
  --package-id Murf.CLI \
  --tool-command-name murf \
  --user-secrets-id Murf.CLI \
  --api-key-env-var MURF_API_KEY \
  --base-url-env-var MURF_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:api-key
