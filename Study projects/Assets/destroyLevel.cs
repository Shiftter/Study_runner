using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("delete"))
        {
            Debug.Log("SomeThing");
            Destroy(collider.gameObject);
        }
    }
}
