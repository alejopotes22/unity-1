using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PackagePersona
{
    [Serializable]
    public class Persona
    {

        private string nameP;
        private string mail;
        private string dirP;

        public Persona()

        {
        }

        public Persona(string nombreP, string mail, string dirP)
        {
            this.mail = mail;
            this.dirP = dirP;
        }

        public Persona(string nameP, string mail, string dirP, string Carrera, string codigo)
        {
            this.nameP = nameP;
            this.mail = mail;
            this.dirP = dirP;
        }

        public string NameP { get => nameP; set => nameP = value; }
        public string Mail { get => mail; set => mail = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
}
