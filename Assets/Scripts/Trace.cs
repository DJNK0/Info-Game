using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float minDist = 80f;
    [SerializeField] private float shootRange = 120f;


    void Update()
    {
        

        if (Vector3.Distance(transform.position, target.position) >= minDist)
        {
            Vector3 direction = target.position - transform.position;
            Quaternion targetRot = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * rotateSpeed);
        }
        transform.position += transform.forward * Time.deltaTime * speed;

        Debug.DrawRay(transform.position, transform.forward * 100, Color.green);

        if (Physics.Raycast(transform.position, transform.forward * shootRange, out RaycastHit hit))
        {
            if (hit.transform.CompareTag("HitMark"))
            {
                Debug.Log("shoot");
            }
        }   
    }
}
