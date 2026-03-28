# CLAUDE.md -- Murf SDK

## Overview

Auto-generated C# SDK for [Murf AI](https://murf.ai/) -- enterprise-grade text-to-speech with 150+ voices across 35 languages, voice changer, translation, and dubbing.
OpenAPI spec sourced from Fern-hosted docs (`https://murf.ai/api/docs/api-reference/openapi.json`) with fixes for duplicate operationIds and auth scheme.

## Build & Test

```bash
dotnet build Murf.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (sent as `api-key` header via `--security-scheme`):

```csharp
var client = new MurfClient(apiKey); // MURF_API_KEY env var
```

## Key Files

- `src/libs/Murf/openapi.json` -- OpenAPI spec from Fern docs, with fixes (duplicate operationIds, auth, single server)
- `src/libs/Murf/generate.sh` -- Runs autosdk with `--security-scheme ApiKey:Header:api-key` (no download step needed, spec is local)
- `src/libs/Murf/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Murf/Extensions/MurfClient.Tools.cs` -- MEAI AIFunction tools (AsTextToSpeechTool, AsListVoicesTool, AsTranslateTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with api-key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- OpenAPI spec sourced from `https://murf.ai/api/docs/api-reference/openapi.json` (Fern-hosted)
- Fixes applied: duplicate `create` operationIds renamed to `createDubbingJob`/`createDubbingProject`, `api-key` header params removed in favor of `--security-scheme`
- Auth: `--security-scheme ApiKey:Header:api-key` sends the key directly as the native header (no spec conversion or PrepareRequest hook needed)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v1/speech/generate` | POST | Generate speech from text (non-streaming) |
| `/v1/speech/stream` | POST | Stream speech with ultra-low latency |
| `/v1/speech/voices` | GET | List available voices |
| `/v1/voice-changer/convert` | POST | Convert voice (multipart/form-data) |
| `/v1/text/translate` | POST | Translate text |
| `/v1/auth/token` | GET | Generate auth token |
| `/v1/murfdub/jobs/create` | POST | Create dubbing job |
| `/v1/murfdub/jobs/create-with-project-id` | POST | Create dubbing job with project ID |
| `/v1/murfdub/jobs/{job_id}/status` | GET | Get dubbing job status |
| `/v1/murfdub/list-destination-languages` | GET | List dubbing destination languages |
| `/v1/murfdub/list-source-languages` | GET | List dubbing source languages |
| `/v1/murfdub/projects/create` | POST | Create dubbing project |
| `/v1/murfdub/projects/list` | GET | List dubbing projects |
| `/v1/murfdub/projects/{project_id}/update` | PUT | Update dubbing project |

## Models

- **Falcon**: Ultra-fast streaming model for conversational AI (<130ms TTFA)
- **Gen2**: Studio-quality model with advanced customization for multimedia

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsTextToSpeechTool()` -- Generate speech from text
- `AsListVoicesTool()` -- List available voices with filtering
- `AsTranslateTool()` -- Translate text between languages
