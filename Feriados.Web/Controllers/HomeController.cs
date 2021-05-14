using Feriados.Model.DTO;
using Feriados.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Feriados.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var service = new FeriadosService();
            var url = service.urlAPI();
            var api = new List<FeriadoRequest>();
            api = service.GetDataApi();

            if (api.Count== 0)
            {
                //service.updateApi();
                api = Get(url);
            }
            else
            {
                api = service.GetDataApi();
            }
               

            return View(api);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var service = new FeriadosService();
            FeriadoRequest request = new FeriadoRequest();
            var dados = service.GetDataApiId(id);

            request.date = dados.date;
            request.title = dados.title;
            request.description = dados.description;
            request.legislation = dados.legislation;
            request.type = dados.type;
            request.startTime = dados.startTime;
            request.endTime = dados.endTime;
            request.variables = dados.variables;
            request.id = dados.id;


            return View(request);
        }
        [HttpPost]
        public IActionResult Edit(FeriadoRequest feriado)
        {
            var service = new FeriadosService();
            FeriadoRequest request = new FeriadoRequest();

            request.date = feriado.date;
            request.title = feriado.title;
            request.description = feriado.description;
            request.legislation = feriado.legislation;
            request.type = feriado.type;
            request.startTime = feriado.startTime;
            request.endTime = feriado.endTime;
            request.variables = feriado.variables;
            request.id = feriado.id > 0 ? feriado.id  : 0;


            service.Save(request);
            return RedirectToAction("Index");
           // return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var service = new FeriadosService();
            FeriadoRequest request = new FeriadoRequest();
            var dados = service.GetDataApiId(id);
            service.Delete(id);

            return RedirectToAction("Index");
        }


    }
}
