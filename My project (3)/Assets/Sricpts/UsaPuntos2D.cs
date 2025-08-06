using Packages2D;
using System.Collections.Generic;
using UnityEngine;

public class UsaPunto2D : MonoBehaviour
{
    List<Puntos2D> coordenadas2D = new List<Puntos2D>();

    public void Start()
    {
        Puntos2D a = new Puntos2D(11.7, 22.4);
        coordenadas2D.Add(a);

        Puntos2D b = new Puntos2D(31.8, 19.3);
        coordenadas2D.Add(b);

        Puntos2D c = new Puntos2D(1.9, 0.0);
        coordenadas2D.Add(c);

        Puntos2D d = new Puntos2D(-32.4, 15.8);
        coordenadas2D.Add(d);

        foreach (var punto in coordenadas2D)
        {
            Debug.Log("Coordenada → X: " + punto.X + " | Y: " + punto.Y);
        }

        
    }

    public void Update()
    {

    }
}
