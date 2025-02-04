﻿using dandd.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dandd.Services
{
    internal class SubRaceServices
    {
            private readonly HttpClient _client;
            private readonly JsonSerializerOptions _serializerOptions;
            private readonly string _baseUrl = "https://www.dnd5eapi.co/api/subraces";

            public SubRaceServices()
            {
                _client = new HttpClient();
                _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            }

            public async Task<ObservableCollection<SubRaces>> GetSubRacesAsync()
            {
                var url = $"{_baseUrl}/posts";
                try
                {
                    var response = await _client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        return JsonSerializer.Deserialize<ObservableCollection<SubRaces>>(content, _serializerOptions);
                    }
                    return null;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                    return null;
                }
            }
    }
}
