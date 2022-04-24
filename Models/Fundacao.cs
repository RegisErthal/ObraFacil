﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFAcil.Models
{
    public class Fundacao
    {
        public int TamanhoAlicerce { get; set; }
        public int AlturaPedra { get; set; }
        public int LarguraPedra { get; set; }
        public int ProfundidadePedra { get; set; }
        public int QuantidadeEstacas { get; set; }
        public int BarrasFerro { get; set; }
        public int LarguraViga { get; set; }
        public int ProfundidadeViga { get; set; }
        public int QuantidadeViga { get; set; }
        public DateTime PrevisaoEntrega { get; set; }
    }
}
