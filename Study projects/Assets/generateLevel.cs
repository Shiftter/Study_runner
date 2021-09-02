using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLevel : MonoBehaviour
{
    public GameObject Prefabs;
    public GameObject genPoint;

    protected bool next = false;

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {

        if(col.gameObject.tag != "floor")
        {
            Debug.Log("Generate");
            Instantiate(Prefabs, genPoint.transform.position, Quaternion.identity);

            next = true;
        }
    }

    void Update()
    {
        if (next)
        {
            genPoint.transform.Translate(0, 0, 75);
            next = false;
        }
    }

}
