using UnityEngine;

public class BotonesUI : MonoBehaviour
{
    public void Viajar()
    {
        Debug.Log("Bot�n Viajar presionado");
    }

    public void Galeria()
    {
        Debug.Log("Bot�n Galer�a Presionado"); 
    }

    public void Salir()
    {
        Debug.Log("Bot�n Salir Presionado");
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
