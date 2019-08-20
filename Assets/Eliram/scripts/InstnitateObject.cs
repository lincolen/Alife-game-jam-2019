using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstnitateObject : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, new Vector3(0.0f, 1.0f, 5.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
