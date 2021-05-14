using Feriados.Model.DTO;
using Feriados.Service;
using System;

namespace FeriadoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
                var service = new FeriadosService();

            var request = new FeriadoRequest();

            //save
            /*  request.date = DateTime.Now;
              request.title = "test feriado";
              request.description = "descricao teste";
              request.legislation = "legislaco teste";
              request.type = "Estadual";
              request.startTime = new DateTime(2021, 05, 01);
              request.endTime = new DateTime(2021, 05, 01);
              request.variables = "";*/


            /*request.date = DateTime.Now;
            request.title = "test feriado dois";
            request.description = "descricao teste dois";
            request.legislation = "legislaco teste dois";
            request.type = "Municipal";
            request.startTime = new DateTime(2021, 04, 08);
            request.endTime = new DateTime(2021, 04, 08);
            request.variables = "X";
            service.Save(request);*/

            //edit
            /* request.id = 1;
             request.date = DateTime.Now;
             request.title = "test feriado trablho update";
             request.description = "descricao teste trabalho";
             request.legislation = "legislaco teste";
             request.type = "Estadual";
             request.startTime = new DateTime(2021, 05, 01);
             request.endTime = new DateTime(2021, 05, 01);
             request.variables = "feriado do trablaho update";
             service.Save(request);*/


            //delete
            request.id = 2;
            service.Delete(request.id);


            Console.WriteLine("Terminou!");
        }
    }
}
