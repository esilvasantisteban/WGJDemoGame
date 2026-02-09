using FMODUnity;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
   
    // Campos para el disparo de projectiles
    public float Cooldown;
    public float currentCooldown;
    public GameObject projectilePrefab;
    public EventReference fireSound;

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
                // Movemos al jugador hacia arriba en funci�n de su velocidad
                transform.position = transform.position + Vector3.up * speed * Time.deltaTime;
            }

            if (Input.GetKey("s"))
            {
                // Movemos al jugador hacia abajo en funci�n de su velocidad
                transform.position = transform.position - Vector3.up * speed * Time.deltaTime;
            }
        }
    }

    public void FireProjectile ()
    {
        // Se crea un projectil en la posici�n del jugador
        Instantiate(projectilePrefab, transform.position + Vector3.right * 0.6f + Vector3.up * Random.Range(-0.2f, 0.2f), Quaternion.identity);

        // Play fire sound
        RuntimeManager.PlayOneShot(fireSound);
    }
}
