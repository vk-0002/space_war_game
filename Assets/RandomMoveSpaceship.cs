using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveSpaceship : MonoBehaviour
{


    private GameObject player;
    private Rigidbody rb;
    float speed = 100f;
   
    float area = 300;
    float RotateR;
    float RotateL;

    // Use this for initialization
    void Start()
    {

        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() {


        Invoke("ForwardForce", 2f);

       
        if (transform.position.z < player.transform.position.z + area && transform.position.z > player.transform.position.z -area && transform.position.x < player.transform.position.x + area && transform.position.x > player.transform.position.x - area)
        {
            if (Random.Range(3 , 8) == 7)            //random number get 7 then enter ;
            {
                float angle=Random.Range(-15.0f, 15.0f);
                
                transform.Rotate(transform.rotation.x, transform.rotation.y + angle *Time.deltaTime, transform.rotation.z);
            }

        }
        else
        {
           
            transform.LookAt(player.transform);
            rb.AddForce(-transform.forward * 10 * Time.deltaTime);
        }

    }

    void ForwardForce()
    {
        rb.AddForce(transform.forward * speed * Time.deltaTime);

    }
}
