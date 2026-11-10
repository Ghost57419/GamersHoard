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
        string url = "https://www.gamestop.com/video-games";

        HttpClient client = new HttpClient();

        public async Task<HtmlNodeCollection> GetResponseAsync()
        {
            HttpResponseMessage response = await client.GetAsync(url);

            string html = await response.Content.ReadAsStringAsync();

            System.Diagnostics.Debug.WriteLine(html);

            HtmlDocument doc = new HtmlDocument();

            doc.LoadHtml(html);

            HtmlNodeCollection products = doc.DocumentNode.SelectNodes("//*[contains(@class,'product-grid-tile-wrapper')]");

            if(products == null)
            {
                Console.WriteLine("No products found.");       
            }

            return products;
        }
    }
}
