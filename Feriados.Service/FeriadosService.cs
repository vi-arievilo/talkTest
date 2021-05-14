using Feriados.Model.DTO;
using Feriados.Model.Entities;
using Feriados.Repository;
using System;
using System.Collections.Generic;

namespace Feriados.Service
{
    public class FeriadosService
    {
        //2
        //API chama a service

        public void Save(FeriadoRequest request)
        {
            var feriado = new FeriadoModel();

            feriado.id = request.id;
            feriado.date = request.date;
            feriado.title = request.title;
            feriado.description = request.description;
            feriado.legislation = request.legislation;
            feriado.type = request.type;
            feriado.startTime = request.startTime;
            feriado.endTime = request.endTime;
            feriado.variables = request.variables;

            if (string.IsNullOrEmpty(feriado.title))
                throw new Exception("Informa o tiitulo do feriado");

            if (string.IsNullOrEmpty(feriado.description))
                throw new Exception("Informa a descricção do feriado");

            if (string.IsNullOrEmpty(feriado.legislation))
                throw new Exception("Informa a legislação do feriado");

            if (string.IsNullOrEmpty(feriado.type))
                throw new Exception("Informa o tipo do feriado");

            if (feriado.startTime == null)
                throw new Exception("Informa a data de inicio do feriado");

            if (feriado.endTime == null)
                throw new Exception("Informa a data dfim do feriado");


            var repository = new FeriadoRepo();

            if (feriado.id == 0)
                repository.Save(feriado);
            else
                repository.Update(feriado);

        }
        public void Delete(int id)
        {
            var repository = new FeriadoRepo();
            repository.Delete(id);
        }

        public string urlAPI()
        {
            var repository = new FeriadoRepo();

            return repository.ConsultaApi();
        }
        public void updateApi()
        {
            var repository = new FeriadoRepo();
            repository.UpdaeAPI();
        }

        public List<FeriadoRequest> GetDataApi()
        {
            var repository = new FeriadoRepo();
           return  repository.GetAll();
        }

        public FeriadoRequest GetDataApiId(int id)
        {
            var repository = new FeriadoRepo();
            return repository.ById(id);
        }
    }
}
