using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Sprite Right;
    public Sprite Left;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;


    // Update is called once per frame
    void Update()
    {   
        Vector3 move;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // converting from pixels to world units
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = Left;
            move = new Vector2(moveSpeed * Time.deltaTime, 0);

            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = Right;
            move = new Vector2(moveSpeed * Time.deltaTime, 0);

            transform.position += move;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed *Time.fixedDeltaTime);

        //get the direction to our mouse from where we are currently standing

        //Vector2 lookDir = mousePos - rb.position;
        //the z rotation
        //float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;


    }
}
