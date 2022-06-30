using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trace : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletPosL;
    [SerializeField] private GameObject bulletPosR;

    private float nextFire = 0.0f;
    [SerializeField] private float fireRate = 0.5f;

    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private float minDist = 80f;
    [SerializeField] private float shootRange = 120f;

    private void shoot(Transform t)
    {
        Instantiate(bullet, t.position, Quaternion.LookRotation(transform.forward));
    }

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
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, Random.Range(80, 100), 0), Time.deltaTime * rotateSpeed);
        }

        transform.position += transform.forward * Time.deltaTime * speed;

        //GOtta ignore other plaeness
        if (Physics.Raycast(bulletPosL.transform.position, transform.forward * shootRange, out RaycastHit hit))
        {
            
        
            if (hit.transform.CompareTag("HitMark") && Time.time > nextFire)
            {
                
                nextFire = Time.time + fireRate;
                shoot(bulletPosL.transform);
                shoot(bulletPosR.transform);
            }
        }
    }
}
