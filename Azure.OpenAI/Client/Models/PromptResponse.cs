﻿// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace Azure.OpenAI.Client.Models;

public record PromptResponse(string Prompt, string Response, bool IsComplete = false);