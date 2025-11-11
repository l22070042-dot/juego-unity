// 1. TODAS LAS LÍNEAS "using" VAN AQUÍ, AL PRINCIPIO
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Esta es la importante para las escenas

// 2. DESPUÉS, EMPIEZA LA CLASE
public class MainMenu : MonoBehaviour
{
    // 3. DENTRO DE LA CLASE VAN TUS FUNCIONES

    // Esta función la llamas desde el botón "Jugar"
    public void Jugar()
    {
        // Carga la escena que se llama "mapa2"
        SceneManager.LoadScene("mapa2");
    }

    // Esta función la llamas desde el botón "Salir"
    public void Salir()
    {
        // Cierra el juego
        Debug.Log("Saliendo del juego...");
        Application.Quit();

        // Esto detiene el editor (Application.Quit no funciona en el editor)
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    // (Puedes añadir más funciones public si tienes más botones)
}