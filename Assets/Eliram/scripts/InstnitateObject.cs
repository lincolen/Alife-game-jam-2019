using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstnitateObject : MonoBehaviour
{
    public GameObject[] prefabs;
    public float popInterval;
    private float lastPop;
    public float growthSpeed;
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        lastPop = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - lastPop >= popInterval)
        {
            lastPop = Time.time;
            GameObject plant = Instantiate(prefabs[Random.Range(0, 7) % 8], new Vector3(Random.Range(0.0f,1000.0f), 0.0f, Random.Range(0.0f, 1000.0f)), Quaternion.identity) as GameObject;
            // plant.GetComponent<PlantGrowth>.lifeTime = 20;
            // plant.GetComponent<PlantGrowth>.growthSpeed = 2;
            plant.GetComponent<PlantGrowth>().lifeTime = lifeTime;
            plant.GetComponent<PlantGrowth>().growthSpeed = growthSpeed;
        }
    }
}
