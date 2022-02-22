﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathSolutions.Data.Models
{
    public class Estudiante
    {
        public Estudiante()
        {
            //Inscripcions = new HashSet<Inscripcion>();
        }

        public int IdEstudiante { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        //public virtual ICollection<Inscripcion> Inscripcions { get; set; }
        public virtual ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
