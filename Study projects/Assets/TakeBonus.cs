using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBonus : MonoBehaviour
{
    protected int coin = 0;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("coin"))
        {
            Destroy(collider.gameObject);
            coin++;
            Debug.Log("coin:"+coin);
        }
    }
}