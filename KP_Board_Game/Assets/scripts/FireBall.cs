using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Random.insideUnitSphere * speed; // Set initial random velocity
    }

    void OnCollisionEnter(Collision collision)
    {
        // Reflect the velocity vector on collision
        Vector3 reflectDirection = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
        rb.velocity = reflectDirection.normalized * speed;
    }
}
