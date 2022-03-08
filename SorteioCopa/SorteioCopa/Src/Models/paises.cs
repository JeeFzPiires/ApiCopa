using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SorteioCopa.Models
{
    public class paises
    {
        public int ID { get; set; }

        public int RankingFifa { get; set; }

        public string Participantes { get; set; }

        public bool Sede { get; set; }

        public int IdConfederacao { get; set; }

        public confederacao Confederacao { get; set; } 


    }
}
