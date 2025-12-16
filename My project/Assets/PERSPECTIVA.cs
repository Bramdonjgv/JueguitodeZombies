using UnityEngine;

// Obliga a que el objeto tenga un SpriteRenderer
[RequireComponent(typeof(SpriteRenderer))]
public class YSort : MonoBehaviour
{
    // Referencia al SpriteRenderer del objeto
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        // Obtenemos el SpriteRenderer del objeto
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void LateUpdate()
    {
        /*
         Mientras más abajo esté el objeto (Y menor),
         mayor será su prioridad de dibujo (se verá delante).

         Se multiplica por 100 para evitar errores decimales.
        */
        spriteRenderer.sortingOrder =
            Mathf.RoundToInt(-transform.position.y * 100);
    }
}
