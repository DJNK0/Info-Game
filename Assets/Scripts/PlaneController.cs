using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float rotateSpeed = 5.0f;
    public float speed = 5.0f;
    [SerializeField] private Rigidbody bomb;

    // Update is called once per frame
    void Update()
    {
        //Horizontal Axis input, A=left=-1, D=Right=1
        float horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(0.0f, horizontal * rotateSpeed * Time.deltaTime, 0.0f);
    
        transform.position  += transform.forward * Time.deltaTime * speed;

        if (Input.GetKeyDown("f"))
        {
            Rigidbody projectileInstance;
            Quaternion playerRotation = transform.rotation;
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y - 20, transform.position.z);
            projectileInstance = Instantiate(bomb, spawnPos, playerRotation) as Rigidbody;
            projectileInstance.AddForce(transform.forward * 1000f);
        }
    }
}
