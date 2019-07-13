﻿using System;
using JetBrains.Annotations;

namespace FilterLists.Agent.Core.Lists
{
    [UsedImplicitly]
    public class ListViewUrl
    {
        public int Id { get; [UsedImplicitly] private set; }
        public Uri ViewUrl { get; [UsedImplicitly] private set; }
    }
}