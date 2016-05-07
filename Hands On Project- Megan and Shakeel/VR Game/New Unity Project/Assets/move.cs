using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

    float angle = 0;
    float speed = (2 * Mathf.PI)  ; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    float radius = 10f; 
    float z;
    float x ;

    void Start()
    {
    
    }

    void Update()
    {
        transform.Translate(x/15, 0, z/15);
        angle += speed*Time.deltaTime;

        x = Mathf.Cos(angle)*radius;
        z = Mathf.Sin(angle)*radius;
     


    }
}

