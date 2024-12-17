using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() 
    {
        playerMove();
    }

    void playerMove () 
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput == 1)
        {
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        }
        else if (horizontalInput == -1)
        {
            body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        }
        else if (horizontalInput == 0)
        {
            body.velocity = new Vector2(horizontalInput, body.velocity.y);
        }
        
        

        if (verticalInput == 1)
        {
            body.velocity = new Vector2(body.velocity.x, verticalInput * speed);
        }
        else if (verticalInput == -1)
        {
            body.velocity = new Vector2(body.velocity.x, verticalInput * speed);
        }
        else if (verticalInput == 0)
        {
            body.velocity = new Vector2(body.velocity.x, verticalInput);
        }
        
    }
}
