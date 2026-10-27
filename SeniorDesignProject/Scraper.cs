using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Web-scraper packages
using System.Globalization;
using CsvHelper;
using HtmlAgilityPack;
using System.Net.Http;

namespace SeniorDesignProject
{
    internal class Scraper
    {
        string url = "https://sandbox.oxylabs.io/products";

        HttpClient client = new HttpClient();

        public async Task<HttpResponseMessage> GetResponseAsync()
        {
            HttpResponseMessage response = await client.GetAsync(url);

            return response;
        }
    }
}
