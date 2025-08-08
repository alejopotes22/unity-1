using Packages2D;
using UnityEngine;
using UnityEngine.UI; // O TMPro si usas TextMeshPro
using UnityEngine.EventSystems;
using TMPro;

public class CapturaMouse2D : MonoBehaviour
{
    public RectTransform panelComponente2; // Asigna el panel desde el inspector
    public TMPro.TextMeshProUGUI textoCoordenadas;
    private Vector2 ultimaCoordenada;

    void Update()
    {
        if (panelComponente2 != null &&
            RectTransformUtility.RectangleContainsScreenPoint(panelComponente2, Input.mousePosition, null))
        {
            Vector3 mouseScreen = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);

            ultimaCoordenada = new Vector2(mouseWorld.x, mouseWorld.y);

            if (textoCoordenadas != null)
                textoCoordenadas.text = $"X: {ultimaCoordenada.x:F2}, Y: {ultimaCoordenada.y:F2}";
        }
        else
        {
            if (textoCoordenadas != null)
                textoCoordenadas.text = "";
        }
    }

    // Este método lo llamas desde el botón
    public void GuardarUltimaCoordenada()
    {
        // Guardar solo si hay una coordenada válida
        Puntos2D punto = new Puntos2D(ultimaCoordenada.x, ultimaCoordenada.y);
        Utilidades.puntos2D.Add(punto);
        Utilidades.ExportarCoordenadas("ultima_coordenada.json");
        Debug.Log("Coordenada guardada: " + punto.X + ", " + punto.Y);
    }
}
