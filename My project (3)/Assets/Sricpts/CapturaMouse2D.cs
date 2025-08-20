//using PackagePersona;
//using Packages;
//using System.Collections.Generic;
//using System.IO;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;

//public class MouseOverPanel : MonoBehaviour
//{
//    public RectTransform panelRojo; // Asigna aqu� tu panel rojo (RectTransform)
//    List<Punto2D> puntos = new List<Punto2D>();

//    public void Start()
//    {

//    }

//    void Update()
//    {
//        Vector2 localMousePos;

//        // Verifica si el mouse est� sobre el panel
//        if (RectTransformUtility.RectangleContainsScreenPoint(panelRojo, Input.mousePosition))
//        {
//            // Convierte a coordenadas locales del panel
//            RectTransformUtility.ScreenPointToLocalPointInRectangle(
//                panelRojo,
//                Input.mousePosition,
//                null, // o Camera.main si el Canvas est� en Screen Space - Camera
//                out localMousePos
//            );

//            Punto2D punto2D = new Punto2D(localMousePos.x, localMousePos.y);
//            puntos.Add(punto2D);



//            //Debug.Log(" Mouse sobre panel rojo. Pos local: " + localMousePos.x);
//            //Debug.Log(" Mouse sobre panel rojo. Pos local: " + localMousePos);
//        }


//    }
//    public void saveDataPuntos()
//    {
//        Utilidades.SaveDataPuntos(puntos);
//    }



//}
