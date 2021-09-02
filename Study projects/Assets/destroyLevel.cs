using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLevel : MonoBehaviour
{
    public GameObject Prefabs;
    public GameObject genPoint;
    public GameObject parent;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("floor"))
        {
            Destroy(collider.gameObject);
            Instantiate(Prefabs, genPoint.transform.position, genPoint.transform.rotation, parent.transform);
        }
    }
}
