using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    public bool moveRight;
    public bool moveLeft;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }
        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.Impulse);
        }
        moveLeft = false;
        moveRight = false;
    }
    private void Update()
    {
        if (Input.GetKey("a"))
        {
            moveLeft = true;
        }
        if (Input.GetKey("d"))
        {
            moveRight = true;
        }
    }
}
