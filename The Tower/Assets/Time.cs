using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time : MonoBehaviour
{
    float x = 0;
    float rotate = 0.000001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.Rotate(x += rotate, 0, 0);
        Debug.Log(x);
    }
}
