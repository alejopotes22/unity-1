using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PackagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {

        private string carrera;
        private string codigo;

        public Estudiante()
        {
        }

        public Estudiante(string carrera, string codigo,string nombreP, string mail, string dirP) : base (nombreP, mail, dirP) 
        {
            this.carrera = carrera;
            this.codigo = codigo;
        }

        public string Carrera { get => carrera; set => carrera = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
