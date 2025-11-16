    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Anders_Åbjörn_slutuppgift
    {
        public class Lager
        {
      
            public int Id { get; set; }
            public string Namn { get; set; }
            public string Typ { get; set; }
            public int Pris { get; set; }

            public Lager(int id, string namn, string typ, int pris)
            {
                Id = id;
                Namn = namn;
                Typ = typ;
                Pris = pris;
            }
        }
    }
