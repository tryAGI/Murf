# Microsoft.Extensions.AI Integration

The Murf SDK provides `AIFunction` tools that integrate with [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI) (MEAI), enabling Murf AI capabilities as tools with any `IChatClient`.

## Available Tools

| Tool | Method | Description |
|------|--------|-------------|
| Text-to-Speech | `AsTextToSpeechTool()` | Generates speech audio from text |
| List Voices | `AsListVoicesTool()` | Lists available voices with optional filters |
| Translate | `AsTranslateTool()` | Translates text between languages |

## Usage

```csharp
using Murf;
using Microsoft.Extensions.AI;

using var murfClient = new MurfClient(apiKey);

// Create tools
var ttsTool = murfClient.AsTextToSpeechTool(
    voiceId: "en-US-natalie",  // default voice
    format: "MP3");            // default format

var voicesTool = murfClient.AsListVoicesTool(model: "GEN2");
var translateTool = murfClient.AsTranslateTool();

// Use with any IChatClient
IChatClient chatClient = /* your preferred chat client */;
var response = await chatClient.GetResponseAsync(
    "Generate speech saying 'Hello World' in a female voice",
    new ChatOptions
    {
        Tools = [ttsTool, voicesTool, translateTool],
    });
```

## Tool Details

### AsTextToSpeechTool

Generates speech from text using Murf AI's TTS engine.

**Parameters (set by LLM):**
- `text` (required) -- The text to synthesize
- `voice` (optional) -- Override the default voice ID
- `locale` (optional) -- Language locale (e.g. "en-US", "es-ES")

**Returns:** Audio URL, duration, and character usage info.

### AsListVoicesTool

Lists available voices with optional filtering.

**Parameters (set by LLM):**
- `gender` (optional) -- Filter by gender ("MALE" or "FEMALE")
- `locale` (optional) -- Filter by locale (e.g. "en-US")

**Returns:** List of voices with IDs, names, genders, and styles.

### AsTranslateTool

Translates text between languages.

**Parameters (set by LLM):**
- `text` (required) -- Text to translate
- `targetLanguage` (required) -- Target language code (e.g. "es-ES")

**Returns:** Translated text with character count metadata.
