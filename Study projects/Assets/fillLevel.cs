using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class fillLevel : MonoBehaviour
{
    public List<GameObject> objects;
    public List<GameObject> points;

    public GameObject parent;

    protected int randomAmount;


    // Start is called before the first frame update
    void Start()
    {
        var ranfCH = Random.Range(0, 99);
        if (ranfCH <= 10)
        {
            randomAmount = 0;
        } else if (ranfCH <= 50 && ranfCH > 10){
            randomAmount = 1;
        } else if (ranfCH > 50)
        {
            randomAmount = 1;
        }
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObjects()
    {
        if (randomAmount==0)
        {
            //Destroy(points.Contains);
        }


        while (randomAmount > 0)
        {

            int objectIndex = Random.Range(0, objects.Count);
            int pointIndex = Random.Range(0, points.Count);

            Instantiate(objects[objectIndex], points[pointIndex].transform.position, points[pointIndex].transform.rotation, parent.transform);
            Destroy(points[pointIndex]);
            randomAmount--;
        }
    }
}
