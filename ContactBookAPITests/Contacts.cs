﻿using System.Text.Json.Serialization;

namespace ContactBookAPITests
{
    public class Contacts
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("firstName")]

        public string firstName { get; set; }

        [JsonPropertyName("lastName")]

        public string lastName { get; set; }

        [JsonPropertyName("email")]

        public string email { get; set; }

        [JsonPropertyName("phone")]

        public string phone { get; set; }
    }
}