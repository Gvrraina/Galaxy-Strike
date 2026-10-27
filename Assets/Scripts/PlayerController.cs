using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f;
    public float rotationSpeed = 60f;

    [Header("Playable Area")]
    public float minX = 10f;
    public float maxX = 490f;
    public float minZ = 10f;
    public float maxZ = 490f;
    public float minY = 2f;
    public float maxY = 80f;


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        float vertical = Input.GetAxis("Vertical");     // W/S

        float ascend = 0f;

        if (Input.GetKey(KeyCode.Space))
            ascend = 1f;

        if (Input.GetKey(KeyCode.LeftShift))
            ascend = -1f;

        transform.Rotate(
            Vector3.up,
            horizontal * rotationSpeed * Time.deltaTime
        );

        Vector3 move =
            transform.forward * vertical +
            Vector3.up * ascend;

        transform.position +=
            move * moveSpeed * Time.deltaTime;
    }
}
