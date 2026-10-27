using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePoint;
    public float fireRate = 0.25f;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        if (laserPrefab == null || firePoint == null)
        {
            Debug.LogWarning(
                "Assign the Laser Prefab and FirePoint in the Inspector."
            );
            return;
        }

        Instantiate(
            laserPrefab,
            firePoint.position,
            firePoint.rotation
        );
    }
}
