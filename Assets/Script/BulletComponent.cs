using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    public float bulletSpeed = 10f; // Speed of the bullet

    void Start()
    {
        // Add an impulse force in the forward direction
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, 5f);
    }
}

