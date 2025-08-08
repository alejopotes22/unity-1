using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PackagePersona;
using Packages2D;
using System.IO;
using TMPro;

public class UsarPersona : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();

    public TMP_InputField codeStudent;
    public TMP_InputField carreraStudent;
    public TMP_InputField nameStudent;
    public TMP_InputField mailStudent;
    public TMP_InputField dirStudent;

    public void AddStudentList()
    {
        string codeStudent1 = codeStudent.text;
        string carreraStudent1 = carreraStudent.text;
        string nameStudent1 = nameStudent.text;
        string mailStudent1 = mailStudent.text;
        string dirStudent1 = dirStudent.text;

        Estudiante e1 = new Estudiante(codeStudent1, carreraStudent1,
            nameStudent1, mailStudent1, dirStudent1);

        listaE.Add(e1);
    }

    public void ShowStudentList()
    {
        foreach (Estudiante e in listaE)
        {
            Debug.Log(e.NameP + " " + e.Codigo + " " + e.Carrera);
        }

        // Actualiza la lista estática y exporta
        Utilidades.estudiantes = listaE;
        Utilidades.ExportarAlumnos();
    }
}