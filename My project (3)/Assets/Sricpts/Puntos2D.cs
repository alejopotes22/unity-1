using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Packages2D{

    [Serializable]
    public class Puntos2D
    {
        [SerializeField] private double x;
        [SerializeField] private double y;

        public Puntos2D(double x, double y)
        {
            X = x;
            Y = y;

        }

        public Puntos2D()
        {



        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
}
