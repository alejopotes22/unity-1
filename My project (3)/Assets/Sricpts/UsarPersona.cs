using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PackagePersona;


public class UsarPersona : MonoBehaviour
{

    List<Estudiante> listaE = new List<Estudiante> ();
    // Start is called before the first frame update
   public void Start()
    {
       Estudiante e1 = new Estudiante ("ing multimedia", "2023_1", "david potes", "david.potes@uao.edu.co", "carrera 34");
       Estudiante e2 = new Estudiante("ing multimedia", "2023_1", "david potes", "david.potes@uao.edu.co", "carrera 34");

        listaE.Add (e1);
        listaE.Add (e2);

        for (int i = 0; i < listaE.Count; i++)
        {

            Debug.Log(listaE[i].NameP + " " + listaE[i].Carrera);
        }


    }

    // Update is called once per frame
   public void Update()
    {
        
    }
}
