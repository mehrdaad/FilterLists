﻿using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Infrastructure.FilterListsApi.EntityUrls
{
    [UsedImplicitly]
    public class SyntaxUrls
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri DefinitionUrl { get; [UsedImplicitly] private set; }
    }
}