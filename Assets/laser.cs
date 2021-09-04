using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class laser : MonoBehaviour {

  

    LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
      

       

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider)
            {
                lr.SetPosition(1, new Vector3(0f, 0f, hit.distance));
            }

        }
        else
        {
            lr.SetPosition(1, new Vector3(0f, 0f, 5000));
        }

    }  
}
