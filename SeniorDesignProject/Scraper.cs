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

        public async Task<HtmlNodeCollection> GetResponseAsync()
        {
            HttpResponseMessage response = await client.GetAsync(url);

            string html = await response.Content.ReadAsStringAsync();

            HtmlDocument doc = new HtmlDocument();

            doc.LoadHtml(html);

            HtmlNodeCollection products = doc.DocumentNode.SelectNodes("//*[contains(@class,'product-card')]");

            if(products == null)
            {
                Console.WriteLine("No products found.");       
            }

            return products;
        }
    }
}
