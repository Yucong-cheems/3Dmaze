using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{

    public GameObject plane;
    public GameObject spawnPoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < plane.transform.position.y - 10)
        {

            transform.position = spawnPoint.transform.position;

        }
    }
}
