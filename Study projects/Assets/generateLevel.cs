using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLevel : MonoBehaviour
{
    public GameObject Prefabs;
    public Collider Trigger;

    // Update is called once per frame
    void OnTriggerEnter (Collider collider)
    {

        if(collider.tag == "Player")
        {
            Instantiate(Prefabs, Trigger.transform.position + Vector3.forward * 30, Quaternion.identity);
        }
    }
}
