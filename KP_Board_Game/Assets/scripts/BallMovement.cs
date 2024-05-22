using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Start function called. Rigidbody component initialized.");
    }

    void FixedUpdate()
    {
        // Get input from arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply movement to the ball
        rb.AddForce(movement * moveSpeed);

        // Restrict the ball within boundaries
        RestrictMovement();
    }

    void RestrictMovement()
    {
        Vector3 position = transform.position;

        // Assuming walls are placed in a square/rectangular layout
        position.x = Mathf.Clamp(position.x, -100.0f, 100.5f); // Adjust these values based on your wall positions
        position.z = Mathf.Clamp(position.z, -100.5f, 100.5f); // Adjust these values based on your wall positions
        position.y = Mathf.Clamp(position.y, -10.5f, 10.0f); // To avoid infinite fall.
        transform.position = position;
        Debug.Log("Ball position clamped within boundaries.");
    }
}

