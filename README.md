# Poe

[![Nuget package](https://img.shields.io/nuget/vpre/Poe)](https://www.nuget.org/packages/Poe/)
[![dotnet](https://github.com/tryAGI/Poe/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Poe/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Poe)](https://github.com/tryAGI/Poe/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

A reverse engineered C# API wrapper for Quora's Poe, which provides access to ChatGPT, GPT-4, and Claude.

### Usage
```csharp
using Poe;

using var httpClient = new HttpClient();
var api = new PoeApi(apiKey, httpClient);
```

## Support

Priority place for bugs: https://github.com/tryAGI/Poe/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Poe/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  