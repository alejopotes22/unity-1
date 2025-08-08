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

    // Listas estáticas para que otras clases puedan agregar datos
    public static List<Estudiante> estudiantes = new List<Estudiante>();
    public static List<Puntos2D> puntos2D = new List<Puntos2D>();

    // Puedes llamar estos métodos desde cualquier clase
    public static void ExportarAlumnos(string archivoSalida = "datos_alumnos.json")
    {
        Debug.Log("ExportarAlumnos ejecutado");
        RegistroDeAlumnos paquete = new RegistroDeAlumnos();
        paquete.contenido = estudiantes;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.streamingAssetsPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log("Archivo guardado en: " + destino);
    }

    public static void ExportarCoordenadas(string archivoSalida = "datos_puntos.json")
    {
        RegistroDePuntos paquete = new RegistroDePuntos();
        paquete.datos = puntos2D;

        string jsonFinal = JsonUtility.ToJson(paquete, true);
        string destino = Application.streamingAssetsPath + "/" + archivoSalida;

        File.WriteAllText(destino, jsonFinal);
        Debug.Log("Archivo guardado en: " + destino);
    }
}