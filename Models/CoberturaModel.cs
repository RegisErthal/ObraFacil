using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFacil.Models
{
    public class CoberturaModel
    {
        public int AreaCobertaM2 { get; set; }
        public bool PossuiLaje { get; set; }
        public int EspessuraLaje { get; set; }
        public DateTime PrevisaoEntregaCobertura { get; set; }
    }
}
