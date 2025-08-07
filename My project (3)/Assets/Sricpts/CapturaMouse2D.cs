using Packages2D;
using UnityEngine;

public class CapturaMouse2D : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 = clic izquierdo
        {
            Vector3 mouseScreen = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);

            // Suponiendo que Puntos2D usa double, puedes castear a float o double según tu clase
            Puntos2D punto = new Puntos2D(mouseWorld.x, mouseWorld.y);

            Debug.Log($"Punto capturado: X={punto.X}, Y={punto.Y}");

            // Si quieres guardar el punto:
            Utilidades.puntos2D.Add(punto);
        }
    }
}
