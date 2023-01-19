﻿using Newtonsoft.Json;
using NuGet.Common;
using promoit_frontend_cs.Pages.Admin;
using Shared;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace promoit_frontend_cs.Services
{
    public class SocialActivistService
    {
		private readonly ILogger<SocialActivistService> _logger;
		private readonly AuthService _authservice;
		private readonly HttpClient _http;

		public SocialActivistService(HttpClient Http, ILogger<SocialActivistService> logger, AuthService authservice)
		{
			_http = Http;
			_logger = logger;
			_authservice = authservice;
		}

		public async Task<IEnumerable<SpResults>> GetCampaignsAndMoney(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<IEnumerable<SpResults>>($"https://localhost:7263/api/SaToCampaignWithCampaignInfo/{id}");
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, $"Error getting campaigns and money");
				throw new Exception($"Error getting campaigns and money", exception);
			}
		}

        //public async Task<IEnumerable<SocialActivistDTO>> GetSocialActivists()
        //{
        //    try
        //    {
        //        var response = await _http.GetAsync("http://localhost:7000/social-activists");
        //        var json = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<IEnumerable<SocialActivistDTO>>(json);
        //    }
        //    catch (Exception exception)
        //    {
        //        _logger.LogError(exception, $"Error getting social activists");
        //        throw new Exception($"Error getting social activists", exception);
        //    }
        //}

        public async Task<HttpResponseMessage> UpdateMoney(int id, SaToCampaignShared saToCampaignShared)
        {
            try
            {
                return await _http.PutAsJsonAsync($"http://localhost:7000/sa-to-campaign/{id}", saToCampaignShared);
			}
			catch (Exception exception)
			{
				_logger.LogError(exception, $"Error updating money");
				throw new Exception($"Error updating money", exception);
			}
		}

        public async Task<HttpResponseMessage> AddNewSocialActivist(SocialActivistDTO newSocialActivist, string user_id)
        {
            newSocialActivist.UserId = user_id;
            newSocialActivist.CreateUserId = user_id;
            newSocialActivist.UpdateUserId = user_id;

            try
            {
                return await _http.PostAsJsonAsync("http://localhost:7000/social-activists", newSocialActivist);

            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Error sending the data of social activist");
                throw new Exception($"Error sending the data of social activist", exception);
            }
        }

        public async Task<SocialActivistDTO[]> GetSocialActivists()
        {
            try
            {
                var response = await _http.GetAsync("http://localhost:7000/social-activists");
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<SocialActivistDTO[]>(json);
                return data;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Error getting the data of social activist");
                throw new Exception($"Error getting the data of social activist", exception);
            }
        }

        public async Task<IEnumerable<TwitterReportType>> GetTwitterReport()
        {
            try
            {
                var response = await _http.GetAsync("http://localhost:7000/twitter-report");
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<IEnumerable<TwitterReportType>>(json);
                return data;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Error getting the twitter report");
                throw new Exception($"Error getting the twitter report", exception);
            }
        }
    }
}
