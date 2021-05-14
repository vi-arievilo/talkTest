using Feriados.Model;
using Feriados.Model.Entities;
using System;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using Feriados.Model.DTO;
using System.Collections.Generic;
using System.Linq;

namespace Feriados.Repository
{
    //1
    //rsponsavel por salvar no banco -- nao pode ter dependecia de outros projetos
    //criar os metodos para salvar dados
    public class FeriadoRepo
    {
        public void Save(FeriadoModel feriado)
        {
            //criar o banco
            //criar a conexao
            try
            {
                string Comando = "INSERT INTO Feriado (date, title, description, legislation, type, startTime, endTime, variables) " +
                                                "VALUES (@date, @title, @description, @legislation, @type, @startTime, @endTime, @variables)";
                using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
                {
                    // var parameters = new { UserName = username, Password = password };
                    string date = feriado.date.ToString();
                    cn.Execute(Comando, new { date, feriado.title,  feriado.description,  feriado.legislation, feriado.type, feriado.startTime, feriado.endTime, feriado.variables });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(FeriadoModel feriado)
        {

            try
            {
                string Comando = "UPDATE Feriado  SET date = @date, title =  @title, description =  @description, legislation = @legislation, type = @type, " +
                    "startTime = @startTime, endTime =  @endTime, variables = @variables WHERE id = @id";
                using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
                {
                    cn.Execute(Comando, new { feriado.date, feriado.title, feriado.description, feriado.legislation, feriado.type, feriado.startTime, feriado.endTime, feriado.variables, feriado.id });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                string Comando = "DELETE FROM feriado WHERE id = @id";
                using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
                {
                    cn.Execute(Comando, new { id });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ConsultaApi()
        {
            try
            {
                string Comando = "select url from consultaApi where id = 1 and isActive = 1";
                using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
                {
                    var ret = cn.QueryFirstOrDefault<string>(Comando);
                    return ret;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdaeAPI()
        {
            try
            {
                string Comando = "UPDATE consultaApi  SET isActive = 0 WHERE id = 1";
                using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
                {
                    cn.Execute(Comando);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public List<FeriadoRequestList> GetDataApi()
        //{
        //    try
        //    {
        //        string Comando = "select * from feriado";
        //        using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
        //        {
        //            List<FeriadoRequestList> ret = (List<FeriadoRequestList>)cn.Query(Comando);
        //            return ret;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<FeriadoRequest> GetAll()
        {
            using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
            {
                return cn.Query<FeriadoRequest>("SELECT * FROM feriado").ToList();
            }
        }

        public FeriadoRequest ById(int id)
        {
            using (IDbConnection cn = new SqlConnection("Server=NYC;Database=feriado;Trusted_Connection=True;"))
            {
                return cn.Query<FeriadoRequest>("SELECT * FROM feriado where id = @id", new { id  }).FirstOrDefault();
            }
        }

    }
}
