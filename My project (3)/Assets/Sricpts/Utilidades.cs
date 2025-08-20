using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;
using System.Runtime.Serialization;
using System.IO;
public class Utilidades
{
    public static bool Savedatosestudiantes(List<Estudiante> listaE)
    {
        try
        {
            string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaE }, true);
            string folderPath = Application.streamingAssetsPath;

            // Crear la carpeta si no existe
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            // Definir la ruta del archivo
            string filePath = Path.Combine(folderPath, "datosEstudiante.json");

            // Escribir el archivo
            File.WriteAllText(filePath, jsonString);

            Debug.Log(" Archivo JSON guardado correctamente en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar archivo JSON: " + ex.Message);
            return false;
        }
    }

    //public static bool SaveDataPuntos(List<Punto2D> listaP)
    //{
    //    try
    //    {
    //        string jsonString = JsonUtility.ToJson(new PuntosListWrapper { puntos = listaP }, true);
    //        string folderPath = Application.streamingAssetsPath;

    //        // Crear la carpeta si no existe
    //        if (!Directory.Exists(folderPath))
    //        {
    //            Directory.CreateDirectory(folderPath);
    //        }

    //        string filePath = Path.Combine(folderPath, "datosPuntos.json");

    //        // Escribir el archivo
    //        File.WriteAllText(filePath, jsonString);

    //        Debug.Log(" Archivo JSON guardado correctamente en: " + filePath);
    //        return true;
    //    }
    //    catch (System.Exception ex)
    //    {
    //        Debug.LogError("Error al guardar archivo JSON: " + ex.Message);
    //        return false;
    //    }
    //}

    public static bool SaveOtrasCarreras(List<Estudiante> listaE)
    {
        try
        {
            List<Estudiante> listaOtros = new List<Estudiante>();

            foreach (var e in listaE)
            {
                string carrera = (e.nameCarrera ?? "").ToLower().Trim().Replace("í", "i");
                if (!carrera.Contains("ingenieria"))
                    listaOtros.Add(e);
            }

            string folderPath = Application.streamingAssetsPath;
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "otras.json");
            string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaOtros }, true);
            File.WriteAllText(filePath, jsonString);

            Debug.Log("Archivo JSON de otras carreras guardado en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar otras.json: " + ex.Message);
            return false;
        }
    }


    public static bool SaveIngenieria(List<Estudiante> listaE)
    {
        try
        {
            List<Estudiante> listaIng = new List<Estudiante>();

            foreach (var e in listaE)
            {
                string carrera = (e.nameCarrera ?? "").ToLower().Trim().Replace("í", "i");
                if (carrera.Contains("ingenieria"))
                    listaIng.Add(e);
            }

            string folderPath = Application.streamingAssetsPath;
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, "ingenieria.json");
            string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaIng }, true);
            File.WriteAllText(filePath, jsonString);

            Debug.Log("Archivo JSON de ingeniería guardado en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar ingenieria.json: " + ex.Message);
            return false;
        }
    }





}

[Serializable]
public class EstudianteListWrapper
{

    public List<Estudiante> estudiantes;

}

//[Serializable]
//public class PuntosListWrapper
//{

//    public List<Punto2D> puntos;

//}