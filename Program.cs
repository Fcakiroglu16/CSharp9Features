using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Csharp9
{


    class Program
    {

        static async Task Main(string[] args)
        {

            // HttpClientJsonExtensions which provides extension methods to send/receive HTTP content as JSON
            // HttpContentJsonExtensions which provides extension methods to read and then parse the HttpContent from JSON
            // JsonContent which provides HTTP content based on JSON

            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");

            var getPost = await httpClient.GetFromJsonAsync<Post>("/posts/1");

            Console.WriteLine(getPost);
            using var postResponse = await httpClient.PostAsJsonAsync("/posts", new Post { Id = 2, Title = "Post 1", userId = 2, Body = "body" });

            Console.WriteLine(postResponse.EnsureSuccessStatusCode());


            #region  ReadFromJsonAsync
            // Get data from JSON HttpContent with ReadFromJsonAsync
            var request = new HttpRequestMessage(HttpMethod.Get, "/posts/1");
            using var response1 = await httpClient.SendAsync(request);

            if (response1.IsSuccessStatusCode)
            {
                var Post = await response1.Content.ReadFromJsonAsync<Post>();

                Console.WriteLine(Post);
            }

            #endregion ReadFromJsonAsync





            #region  JsonContent.Create
            // With .NET 5 using JsonContent and SendAsync method instead of PostAsJsonAsync
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/posts")
            {
                Content = JsonContent.Create(new Post { userId = 1, Id = 2, Body = "body", Title = "title" })
            };
            using var response2 = await httpClient.SendAsync(requestMessage);
            response2.EnsureSuccessStatusCode();
            #endregion JsonContent.Create


        }



    }
}
