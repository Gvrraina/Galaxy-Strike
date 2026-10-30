
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{
    public float speed = 60f;
    public float lifetime = 3f;

    private float timer;

    void Update()
    {
        float distance = speed * Time.deltaTime;

        // Check for objects in front of the laser
        if (Physics.Raycast(
            transform.position,
            transform.forward,
            out RaycastHit hit,
            distance
        ))
        {
            if (!hit.collider.CompareTag("Player"))
            {
                Debug.Log("Laser hit: " + hit.collider.name);
                Destroy(gameObject);
                return;
            }
        }

        transform.position += transform.forward * distance;

        timer += Time.deltaTime;

        if (timer >= lifetime)
            Destroy(gameObject);
    }
}
