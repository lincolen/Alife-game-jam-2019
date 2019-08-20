using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    public float growthSpeed;
    public float initialScale;
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        Destroy(gameObject, lifeTime);
    }

    void awake()
    {

    }
    

    // Update is called once per frame
    void Update()
    {
        // Widen the object by 0.1
        transform.localScale += new Vector3(growthSpeed, growthSpeed, growthSpeed);
    }
}
