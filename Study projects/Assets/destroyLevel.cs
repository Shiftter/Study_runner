using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLevel : MonoBehaviour
{
    public GameObject Prefabs;
    public GameObject genPoint;
    public GameObject parent;

    public int sum = 0;
    public bool moveEnabled;

    public float speed = 10f;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals("floor"))
        {
            sum++;
            speed += (sum / 20);
            Destroy(collider.gameObject);
            Instantiate(Prefabs, new Vector3(0,0, genPoint.transform.position.z), genPoint.transform.rotation, parent.transform);
            genPoint.transform.Translate(new Vector3(0, 0, -sum / 10) * Time.deltaTime);
        }
    }

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
    public void FixedUpdate()
    {
        if (moveEnabled)
        {
            parent.transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
    }
}
