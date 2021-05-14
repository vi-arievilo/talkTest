using System;
using System.Collections.Generic;

namespace Feriados.Model.Entities

{
    //representa entidade do banco de dados
    //somente ate a service
    public class FeriadoModel
    {
        public int id { get; set; }
        public string date { get; set; }
        public string title{ get; set; }
        public string description  {get; set; }
        public string legislation { get; set; }
        public string type { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public List<string> variables { get; set; }
    }
    public class FeriadoModelList
    {
        public List<FeriadoModelList> FeriadoModelLst { get; set; }
    }

}
