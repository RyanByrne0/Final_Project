using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    int timer = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer--;
        if (timer < 0)
        {
            int ran = Random.Range(-360, 360);

            transform.Rotate(0, ran, 0);

            timer = 500;
        }
    }
}
