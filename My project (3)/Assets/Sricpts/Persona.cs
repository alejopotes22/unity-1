using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace PackagePersona
{
    [Serializable]
    public class Persona
    {

        [SerializeField] private string nameP;
        [SerializeField] private string mail;
        [SerializeField] private string dirP;

        public Persona()
        {

        }

        public Persona(string nameP, string mail, string dirP)
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
