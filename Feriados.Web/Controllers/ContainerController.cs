using Feriados.Model.DTO;
using Feriados.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;


namespace Feriados.Web.Controllers
{
    public class BaseController : Controller
    {
        public List<FeriadoRequest> Get(string url, string parametros = "")
        {

            List<FeriadoRequest> feriadoList = new List<FeriadoRequest>();

            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };

            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(parametros).Result;

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                feriadoList = JsonConvert.DeserializeObject<List<FeriadoRequest>>(json);

                var service = new FeriadosService();

                foreach (var item in feriadoList)
                {
                    FeriadoRequest request = new FeriadoRequest();

                    request.date = item.date;
                    request.title = item.title;
                    request.description = item.description;
                    request.legislation = item.legislation;
                    request.type = item.type;
                    request.startTime = item.startTime;
                    request.endTime = item.endTime;
                    request.variables = item.variables;

                    service.Save(request);
                }
            }
            else
                feriadoList = new List<FeriadoRequest>();

            client.Dispose();

            return feriadoList;
        }
              
      
    }
}