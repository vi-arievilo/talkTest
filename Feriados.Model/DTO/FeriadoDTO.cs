using System;
using System.Collections.Generic;
using System.Text;

namespace Feriados.Model.DTO
{
    //pode ser exposto 
    public class FeriadoRequest
    {
        
        public int id { get; set; }
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string legislation { get; set; }
        public string type { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public List<string> variables { get; set; }
    }
    
    public class FeriadoRequestList
    {
        public List<FeriadoRequest> FeriadoRequestLst { get; set; }
    }
}
