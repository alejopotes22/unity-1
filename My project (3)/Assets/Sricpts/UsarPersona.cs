using PackagePersona;
using UnityEngine;
using TMPro;

public class UsarPersona : MonoBehaviour
{
    public void Start()
    {
        Utilidades.estudiantes.Add(new Estudiante("001", "Ingenier�a", "Sara Enriquez", "sara@mail.com", "Calle 1"));
        Utilidades.estudiantes.Add(new Estudiante("002", "Matem�ticas", "David Alejandro", "david@mail.com", "Calle 2"));

        // Exporta cuando lo necesites
        Utilidades.ExportarAlumnos();
    }
}
