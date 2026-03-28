# Murf

[![Nuget package](https://img.shields.io/nuget/vpre/Murf)](https://www.nuget.org/packages/Murf/)
[![dotnet](https://github.com/tryAGI/Murf/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Murf/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Murf)](https://github.com/tryAGI/Murf/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

C# SDK for the [Murf AI](https://murf.ai/) API -- enterprise-grade text-to-speech with 150+ voices across 35 languages, voice changer, translation, and dubbing.

## Features
- Fully generated C# SDK based on [Murf AI OpenAPI specification](https://murf.ai/api/docs/api-reference) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- MEAI AIFunction tools for use with any IChatClient

### Usage
```csharp
using Murf;

using var client = new MurfClient(apiKey);

// Generate speech from text
var response = await client.SubpackageTextToSpeech.GenerateAsync(
    text: "Hello, welcome to Murf AI!",
    voiceId: "en-US-natalie");

Console.WriteLine($"Audio URL: {response.AudioFile}");
Console.WriteLine($"Duration: {response.AudioLengthInSeconds}s");

// List available voices
var voices = await client.SubpackageTextToSpeech.GetVoicesAsync();
foreach (var voice in voices)
{
    Console.WriteLine($"{voice.DisplayName} ({voice.VoiceId}) - {voice.Gender}");
}

// Translate text
var translation = await client.SubpackageText.TranslateAsync(
    targetLanguage: "es-ES",
    texts: ["Hello, how are you?"]);
```

### MEAI Tools
```csharp
using Murf;
using Microsoft.Extensions.AI;

using var murfClient = new MurfClient(apiKey);

// Use Murf TTS as a tool with any IChatClient
IChatClient chatClient = /* your preferred chat client */;
var response = await chatClient.GetResponseAsync(
    "Generate speech saying 'Welcome to the future of AI'",
    new ChatOptions
    {
        Tools = [murfClient.AsTextToSpeechTool()],
    });
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Murf/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Murf/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
