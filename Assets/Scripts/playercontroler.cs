using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rb;
    private Animator anim; // Variable para el Animator

    void Start()
    {
        // Busca los componentes una sola vez al inicio
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {
        // 1. Obtenemos el input (cuánto se presiona)
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        // 2. ¡Esta es la parte clave!
        //    Enviamos esos valores a los parámetros del Animator
        //    (Asegúrate de que "MX" y "MY" se llamen igual
        //    que en tu ventana de Animator)
        anim.SetFloat("MX", inputHorizontal);
        anim.SetFloat("MY", inputVertical);

        // 3. Movemos el personaje
        rb.linearVelocity = new Vector2(inputHorizontal * velocidad, inputVertical * velocidad);
    }
}