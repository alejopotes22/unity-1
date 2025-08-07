using PackagePersona;
using UnityEngine;
using TMPro;

public class UsarPersona : MonoBehaviour
{
    public void Start()
    {
        Utilidades.estudiantes.Add(new Estudiante("001", "Ingeniería", "Sara Enriquez", "sara@mail.com", "Calle 1"));
        Utilidades.estudiantes.Add(new Estudiante("002", "Matemáticas", "David Alejandro", "david@mail.com", "Calle 2"));

        // Exporta cuando lo necesites
        Utilidades.ExportarAlumnos();
    }
}
