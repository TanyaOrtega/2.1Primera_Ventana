using UnityEngine;

public class BotonesUI : MonoBehaviour
{
    public void Viajar()
    {
        Debug.Log("Botón Viajar presionado");
    }

    public void Galeria()
    {
        Debug.Log("Botón Galería Presionado"); 
    }

    public void Salir()
    {
        Debug.Log("Botón Salir Presionado");
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
