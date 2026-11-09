#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: https://murf.ai/api/docs/api-reference/openapi.json (locally maintained)
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection

rm -rf Generated

# Murf API spec is from the Fern-hosted docs (https://murf.ai/api/docs/api-reference/openapi.json)
# with fixes: duplicate operationIds, api-key header params removed, single server URL.
# Auth: --security-scheme sends the API key directly as api-key header.
autosdk generate openapi.json \
  --namespace Murf \
  --clientClassName MurfClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
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
