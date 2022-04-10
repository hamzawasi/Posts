﻿using System.Text.Json.Serialization;

namespace Backend.API.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortBy
    {
        New,
        Popular,
        Trending
    }
}
