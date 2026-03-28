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
