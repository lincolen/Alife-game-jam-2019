using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstnitateObject : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time % 3 == 0)
        Instantiate(prefabs[Random.Range(0, 7) % 8], new Vector3(1000.0f, 0.0f, 0.0f), Quaternion.identity);
       // plant.GetComponent<PlantGrowth>.lifeTime = 20;
       // plant.GetComponent<PlantGrowth>.growthSpeed = 2;
    }
}
