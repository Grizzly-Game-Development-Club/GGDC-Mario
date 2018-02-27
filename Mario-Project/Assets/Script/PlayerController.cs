using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float height = 5;

    public bool grounded = false;

    private Rigidbody2D rb2d;

    void Start()
    {
        // Sets Rigidbody2D component to rb2d
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Translate(Vector3.right * speed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            if (grounded == true)
                rb2d.velocity = new Vector2(0f, height);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        grounded = false;
    }
}