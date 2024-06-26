using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public AudioSource audioPlayer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public float backwardForce = 1f;
    public float sidewaysForce = 1f;

    // FixedUpdate because we are messing with physics4e3
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(new Vector2(0, backwardForce) * Time.deltaTime);

        // Player movement Left and Right
        // right
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(sidewaysForce, 0) * Time.deltaTime, ForceMode2D.Impulse);
        }
        // left
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector2(-sidewaysForce, 0) * Time.deltaTime, ForceMode2D.Impulse);
        }
 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            audioPlayer.Play();
        }
    }

}
