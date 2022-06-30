using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] private Camera main;
    [SerializeField] private Camera bomb;

    public GameObject player;
    public Vector3 offset;

    

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (main.enabled == false)
            {
                main.enabled = true;
                bomb.enabled = false;
            }
            else
            {
                main.enabled = false;
                bomb.enabled = true;
            }
            
        }
        main.transform.position = player.transform.position + offset;   
    }
}
