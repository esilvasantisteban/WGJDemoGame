using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
   
    // Campos para el disparo de projectiles
    public float Cooldown;
    public float currentCooldown;
    public GameObject projectilePrefab;
    public AudioSource audioSource;

    void Update()
    {
        // Se dispara mientras el jugador mantenga presionado espacio
        {
            if (Input.GetKey("space"))
            {
                currentCooldown -= Time.deltaTime;
                if (currentCooldown < 0)
                {
                    currentCooldown = Cooldown;
                    FireProjectile();
                }
            }
        }

        // Movimiento del jugador
        {
            if (Input.GetKey("w"))
            {
                // Movemos al jugador hacia arriba en función de su velocidad
                transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
            }

            if (Input.GetKey("s"))
            {
                // Movemos al jugador hacia abajo en función de su velocidad
                transform.position = transform.position - Vector3.up * speed * Time.deltaTime;
            }
        }
    }

    public void FireProjectile ()
    {
        // Se crea un projectil en la posición del jugador
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Play fire sound
        audioSource.Play();
        audioSource.pitch = Random.Range(0.9f, 1.1f); // Random pitch
        audioSource.volume = Random.Range(0.7f, 1.3f) * 0.35f; // Random volume
    }
}
