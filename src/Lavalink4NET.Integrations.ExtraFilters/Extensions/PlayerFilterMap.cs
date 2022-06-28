﻿namespace Lavalink4NET.Player;

using Lavalink4NET.Integrations.ExtraFilters;

public static class PlayerFilterMapExtensions
{
    public static void Echo(this PlayerFilterMap filterMap, EchoFilterOptions filterOptions)
    {
        filterMap[EchoFilterOptions.Name] = filterOptions;
    }
}
