using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    private float nextFire = 0.0f;
    [SerializeField] private float fireRate = 0.5f;
    
    [SerializeField] private GameObject bullet;

    [SerializeField] private GameObject bulletPosL;
    [SerializeField] private GameObject bulletPosR;

    // Start is called before the first frame update
    private void shoot(Transform t)
    {
        
        Instantiate(bullet, t.position, Quaternion.LookRotation(transform.forward));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            shoot(bulletPosL.transform);
            shoot(bulletPosR.transform);
        }
    }
}
