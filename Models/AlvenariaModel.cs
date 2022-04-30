using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFacil.Models
{
    public class AlvenarialModel
    {
        public int ParedeM2 { get; set; }
        public int AlturaBloco { get; set; }
        public int LarguraBloco { get; set; }
        public int ProfundidadeBloco { get; set; }
        public int QuantidadePilares { get; set; }
        public DateTime PrevisaoEntregaAlvenaria { get; set; }
    }
}
