using System;
using System.Collections.Generic;

namespace proyect_neet_core_3._1
{
    public class Equipo
    {
       public List<Integrante> Integrantes { get; set; }

    }
    public class Integrante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
    }


}
