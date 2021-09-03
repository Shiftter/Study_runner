using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadPlayer : MonoBehaviour
{
    public restartLevel rm;
    void OnCollisionEnter (Collision collision)
    {
        if(collision.collider.tag == "Wall")
        {
            rm.EndGame();
        }
    }
}
