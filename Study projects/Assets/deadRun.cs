using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadRun : MonoBehaviour
{
    public Collider wall;
    public restartLevel rm;
    private void onTriggerEnter(Collider wall)
    {
        rm.EndGame();

        Debug.Log("Hit Something");
    }
}
