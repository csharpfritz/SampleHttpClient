using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SampleHttpClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
           
            GitHubOrganization fritzAndFriends;

           using (var client = new HttpClient()) {

                client.BaseAddress = new Uri("https://api.github.com");
                client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
                client.DefaultRequestHeaders.UserAgent.Add( ProductInfoHeaderValue.Parse("HttpClient"));

                var responseString = await client.GetStringAsync("orgs/fritzandfriends/repos");
                fritzAndFriends = GitHubOrganization.FromJson(responseString)[0];

           }

            // Cheer 600 lannonbr 12/27/2018
            // Cheer 100 nodebotanist 12/27/2018

           Console.Out.WriteLine($"Found the organization {fritzAndFriends.FullName}");

        }
    }

}