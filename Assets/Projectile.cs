using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float timeToDestroy = 2;
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
    }
}
