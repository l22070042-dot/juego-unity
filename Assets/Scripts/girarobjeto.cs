using UnityEngine;

public class GirarMoneda : MonoBehaviour
{
    // === Variables para ajustar desde el Inspector ===

    // Qué tan rápido quieres que gire (un número más alto es más rápido)
    public float velocidadGiro = 8.0f;

    // ===============================================

    private Vector3 escalaInicial;

    // Start se llama una vez, al inicio
    void Start()
    {
        // Guarda la escala original que tiene tu objeto
        escalaInicial = transform.localScale;
    }

    // Update se llama en cada frame
    void Update()
    {
        // 1. Usamos Coseno para crear una onda suave que va de 1 a -1 y regresa.
        //    'Time.time * velocidadGiro' hace que avance en el tiempo.
        float nuevaEscalaX = Mathf.Cos(Time.time * velocidadGiro);

        // 2. Multiplicamos por la escala X inicial para mantener el tamaño.
        //    Esto hará que la escala X pase de (ej.) 1... a 0... a -1... a 0... a 1
        nuevaEscalaX = escalaInicial.x * nuevaEscalaX;

        // 3. Aplicamos la nueva escala SOLO en el eje X.
        //    Los ejes Y y Z se quedan como estaban (escalaInicial.y, escalaInicial.z)
        transform.localScale = new Vector3(nuevaEscalaX, escalaInicial.y, escalaInicial.z);
    }
}