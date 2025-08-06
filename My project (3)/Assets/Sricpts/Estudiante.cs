using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PackagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {

        private string codeE;
        private string nameCarrera;

        public Estudiante()
        {
        }

        public Estudiante(string codeE, string nameCarrera, string nameP, string mail, string dirP)
        : base(nameP, mail, dirP)
        {

            this.codeE = codeE;
            this.nameCarrera = nameCarrera;

        }

        public string Codigo { get => codeE; set => codeE = value; }
        public string Carrera { get => nameCarrera; set => nameCarrera = value; }
    }

}

