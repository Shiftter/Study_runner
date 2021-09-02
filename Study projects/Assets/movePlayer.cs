using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public Rigidbody rb;

    public float runSpeed = 500f;
    public float strafeSpeed = 500f;
    public float strafeRange = 500f;
    public float smoothing = 10f;
    public float jumpForse = 50f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight = false;
        }

        if(Input.GetKey("a"))
        {
            strafeLeft = true;
        }
        else
        {
            strafeLeft = false;
        }

        if(Input.GetKeyDown("space"))
        {
            doJump = true;
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.forward * runSpeed * Time.deltaTime);

        if(strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //rb.position = Vector3.Lerp(transform.position, transform.position + (Vector3.left * strafeRange), smoothing * Time.deltaTime);
        }
        
        if(strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //rb.position = Vector3.Lerp(transform.position, transform.position + (Vector3.right * strafeRange), smoothing * Time.deltaTime);
        }
        
        if(doJump)
        {
            rb.AddForce(Vector3.up * jumpForse, ForceMode.Impulse);

            doJump = false;
        }
    }
}
