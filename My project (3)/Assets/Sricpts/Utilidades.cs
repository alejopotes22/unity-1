using PackagePersona;
using Packages2D;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Utilidades : MonoBehaviour
{
    [Serializable]
    private class RegistroDeAlumnos
    {
        public List<Estudiante> contenido;
    }

    [Serializable]
    private class RegistroDePuntos
    {
        public List<Puntos2D> datos;
    }

    // Listas públicas para asignar desde el inspector o inicializar aquí
    public List<Estudiante> estudiantes = new List<Estudiante>();
    public List<Puntos2D> puntos2D = new List<Puntos2D>();

    // Este método se ejecuta automáticamente al iniciar el GameObject
    void Start()
    {
        // Ejemplo de inicialización de datos (puedes quitar esto si asignas desde el inspector)
        if (puntos2D.Count == 0)
        {
            puntos2D.Add(new Puntos2D(11.7, 22.4));
            puntos2D.Add(new Puntos2D(31.8, 19.3));
            puntos2D.Add(new Puntos2D(1.9, 0.0));
            puntos2D.Add(new Puntos2D(-32.4, 15.8));
        }

        if (estudiantes.Count == 0)
        {
            estudiantes.Add(new Estudiante("001", "Ingeniería", "Juan", "juan@mail.com", "Calle 1"));
            estudiantes.Add(new Estudiante("002", "Matemáticas", "Ana", "ana@mail.com", "Calle 2"));
        }

        ExportarAlumnos(estudiantes);
        ExportarCoordenadas(puntos2D);
    }

    public void ExportarAlumnos(List<Estudiante> entrada, string archivoSalida = "datos_alumnos.json")
    {
        Debug.Log("ExportarAlumnos ejecutado");
        RegistroDeAlumnos paquete = new RegistroDeAlumnos();
        paquete.contenido = entrada;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.persistentDataPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log("Archivo guardado en: " + destino);
    }

    public void ExportarCoordenadas(List<Puntos2D> entrada, string archivoSalida = "datos_puntos.json")
    {
        RegistroDePuntos paquete = new RegistroDePuntos();
        paquete.datos = entrada;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.persistentDataPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log("Archivo guardado en: " + destino);
    }
}