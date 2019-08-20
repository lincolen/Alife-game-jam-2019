using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    public float growthSpeed;
    public float initialScale;
    public float lifeTime;
    public float colorChangeSpeed;
    public float witherSpan;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(initialScale, initialScale, initialScale);
        Destroy(gameObject, lifeTime);
        startTime = Time.time;
    }

    void awake()
    {

    }


    // Update is called once per frame
    void Update()
    {
        // Widen the object by 0.1
        transform.localScale += new Vector3(growthSpeed, growthSpeed, growthSpeed);
        if (Time.time - startTime >= lifeTime - witherSpan)
        {
            gameObject.GetComponent<Renderer>().material.color += new Color(colorChangeSpeed, 0.0f, 0.0f, -5.0f);
            gameObject.GetComponent<Transform>().Rotate(50/witherSpan/60, 0, 0);
        }
    }

  

}
