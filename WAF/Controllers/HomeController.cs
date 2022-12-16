using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Diagnostics;
using System.Net.Http.Headers;
using WAF.Models;
using WAF.Models.files;

namespace WAF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IHttpContextAccessor _context;
        public HomeController(ILogger<HomeController> logger,
            IWebHostEnvironment webHostEnvironment,
            IHttpContextAccessor context)
        {
            _logger = logger;
            this.webHostEnvironment = webHostEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        private byte[] GetBinaryFile(string filename)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }
      
        [HttpPost]
        public async Task<IActionResult> TestUrl(ModelDTO model)
        {
            
            if(model.file != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "files");
                string FilePath = Guid.NewGuid().ToString() + "_" + model.file.FileName;
                string filePath = Path.Combine(uploadsFolder, FilePath);
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    await model.file.CopyToAsync(fs);
                }
                var baseUri = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}"; ;
                string path = filePath.Replace(@"D:\Project\WAF\WAF\wwwroot", baseUri).Replace('\\', '/');
                byte[] bytes = GetBinaryFile(filePath);
                 MultipartFormDataContent multipartContent = new MultipartFormDataContent(); // your boundary value if need anything can be passed in the contructore
                 ByteArrayContent fileContent = new ByteArrayContent(bytes);
                multipartContent.Add(fileContent, "file", model.file.FileName);
               
              
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://www.virustotal.com/api/v3/files"),
                    Headers =
                        {
                            { "accept", "application/json" },
                            { "x-apikey", "ec67be112d53ccd1ea96bd15d71174517740641a1c40843d776c36d9a179618f" },
                        },
                    Content = multipartContent,
                    
                };
                using (var response = await client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                         System.IO.File.Delete(filePath);
                        var body = await response.Content.ReadFromJsonAsync<RootData>();
                        var request2 = new HttpRequestMessage
                        {
                            Method = HttpMethod.Get,
                            RequestUri = new Uri($"https://www.virustotal.com/api/v3/analyses/{body?.data.id}"),
                            Headers =
                                    {
                                        { "accept", "application/json" },
                                        { "x-apikey", "ec67be112d53ccd1ea96bd15d71174517740641a1c40843d776c36d9a179618f" },
                                    },
                        };
                        using (var response2 = await client.SendAsync(request2))
                        {
                            if (response2.IsSuccessStatusCode)
                            {
                                var body2 = await response2.Content.ReadFromJsonAsync<ResultDTO>();
                                return Ok(body2);
                            }
                            else
                            {

                            }
                            
                           
                        }
                       
                    }
                    else
                    {
                        var body = await response.Content.ReadFromJsonAsync<RootError>();
                        return Ok(body);
                    }
                    
                   
                }

            }
            else if(string.IsNullOrEmpty(model.url) )
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://www.virustotal.com/");

                    HttpResponseMessage response = await client.GetAsync($"vtapi/v2/url/report?apikey=ec67be112d53ccd1ea96bd15d71174517740641a1c40843d776c36d9a179618f&resource={model.url}");
                    if (response.IsSuccessStatusCode)
                    {
                        var obj = await response.Content.ReadFromJsonAsync<WAF.Models.Root>();
                        return Ok(obj);
                    }
                }
            }
           
            return BadRequest();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}