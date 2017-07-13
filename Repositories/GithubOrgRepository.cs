using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace dotnetcorehack.Repositories {

    public class GithubOrgRepository : IGithubOrgRepository {
        public async Task<string> GetRepos() {
            HttpClient client = BuildHttpClient();

            var request = client.GetStringAsync("https://api.github.com/orgs/facebook/repos");
            var result = await request;

            return result;
        }
        private HttpClient BuildHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Client");

            return client;
        }
    }

    public interface IGithubOrgRepository {
        Task<string> GetRepos();
    }    
}
