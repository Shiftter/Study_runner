using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float smooth = 1.0f;
    public float jumpForse = 50f;

    protected float lineLeftPos = -9f;
    protected float lineRightPos = 9f;
    protected float lineCenterPos = 0f;

    protected int linePos;

    protected bool doJump = false;

    // Start is called before the first frame update
    void Start()
    {
        linePos = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d")&&linePos<3)
        {
            linePos++;
        }
        if (Input.GetKeyDown("a")&&linePos>1)
        {
            linePos--;
        }


            if (Input.GetKeyDown("space"))
        {
            doJump = true;
        }
    }

    void FixedUpdate()
    {

        if (linePos==1)
        {
            Vector3 point = transform.position;
            point.x = lineLeftPos;
            rb.position = Vector3.Lerp(transform.position, point, smooth * Time.deltaTime);
        }

        if (linePos==2)
        {
            Vector3 point = transform.position;
            point.x = lineCenterPos;
            rb.position = Vector3.Lerp(transform.position, point, smooth * Time.deltaTime);
        }
        
        if (linePos==3)
        {
            Vector3 point = transform.position;
            point.x = lineRightPos;
            rb.position = Vector3.Lerp(transform.position, point, smooth * Time.deltaTime);
        }

        if (doJump&&rb.transform.position.y<=0)
        {
            rb.AddForce(Vector3.up * jumpForse, ForceMode.Impulse);

            doJump = false;
        }
    }
}
