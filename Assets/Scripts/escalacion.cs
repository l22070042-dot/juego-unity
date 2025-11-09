using UnityEngine;

public class EscalarObjeto : MonoBehaviour
{
    // Qué tan grande o pequeño se hará
    public float magnitudEscala = 0.25f;

    // Qué tan rápido hará el pulso
    public float velocidad = 2.0f;

    private Vector3 escalaInicial;

    void Start()
    {
        // Guarda la escala original del objeto
        escalaInicial = transform.localScale;
    }

    void Update()
    {
        // Mathf.Sin() crea una onda suave que va de -1 a 1
        float pulso = Mathf.Sin(Time.time * velocidad) * magnitudEscala;

        // Sumamos la escala inicial + el pulso
        transform.localScale = escalaInicial + new Vector3(pulso, pulso, pulso);
    }
}