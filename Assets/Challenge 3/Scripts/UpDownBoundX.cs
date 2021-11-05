using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownBoundX : MonoBehaviour
{
    public float lowerBound = 1.0f;
    public float upperBound = 16.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > upperBound)
            transform.position = new Vector3(transform.position.x, upperBound , transform.position.z);
        
        if (transform.position.y < lowerBound)
            transform.position = new Vector3( transform.position.x, lowerBound, transform.position.z);

    }
}
