using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float rotateSpeed = 5.0f;
    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        //Horizontal Axis input, A=left=-1, D=Right=1
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(0.0f, horizontal * rotateSpeed * Time.deltaTime, 0.0f);
    
        transform.position  += transform.forward * Time.deltaTime * speed;
    }
}
