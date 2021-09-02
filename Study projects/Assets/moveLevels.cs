using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLevels : MonoBehaviour
{
    protected bool moveEnabled;

    private void Start()
    {
        moveEnabled = true;
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (moveEnabled)
            {
                moveEnabled = false;
            }
            else
            {
                moveEnabled = true;
            }
        }
    }
    void FixedUpdate()
    {
        if (moveEnabled)
        {
            transform.Translate(new Vector3(0, 0, -10) * Time.deltaTime);
        }
    }
}