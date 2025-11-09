using UnityEngine;

public class MovimientoTopDown : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;

    private Rigidbody2D rb2D;
    private Animator animator; // Variable para el Animator

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>(); // Obtenemos el Animator
    }

    private void Update()
    {
        direccion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        // --- INICIO DE CÓDIGO DE ANIMACIÓN ---
        
        // Usamos sqrMagnitude por eficiencia (es más rápido que .magnitude)
        if (direccion.sqrMagnitude > 0.01f)
        {
            // Si nos movemos
            animator.SetBool("isMoving", true);
            animator.SetFloat("moveX", direccion.x);
            animator.SetFloat("moveY", direccion.y);
        }
        else
        {
            // Si estamos quietos
            animator.SetBool("isMoving", false);
        }
        
        // --- FIN DE CÓDIGO DE ANIMACIÓN ---
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
        
        if (direccion != Vector2.zero)
        {
            Debug.Log($"Moviendo a posición: {rb2D.position}, Dirección: {direccion}");
        }
    }
}