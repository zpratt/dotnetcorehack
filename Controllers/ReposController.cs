using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using dotnetcorehack.Repositories;

namespace dotnetcorehack.Controllers
{
    [Route("api/[controller]")]
    public class ReposController : Controller
    {
        private IGithubOrgRepository _githubOrgRepository;
        public ReposController(IGithubOrgRepository repository) {
            _githubOrgRepository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _githubOrgRepository.GetRepos());
        }
    }
}
