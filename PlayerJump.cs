using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 10.0f; // bounceforce
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // When the space bar is pressed, jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        // Transfer the jumping power to the rigid body to make the player jump
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }
}

