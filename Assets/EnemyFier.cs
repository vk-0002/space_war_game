using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFier : MonoBehaviour {

    GameObject player;
    float area = 400;
    float speed = 9000000;

    int rand;

	// Use this for initialization
	void Start () {

       
       
	}
	
	// Update is called once per frame
	void Update () {

        rand = Random.Range(1, 5);

        if (rand == 1)
        {
            player = GameObject.Find("Center");
        }
        else if (rand == 2)
        {
            player = GameObject.Find("Left");
        }
        else if (rand == 3)
        {
            player = GameObject.Find("Right");
        }
        else if (rand == 4)
        {
            player = GameObject.Find("Up");
        }
        else if (rand == 5)
        {
            player = GameObject.Find("Down");
        }


        transform.LookAt(player.transform);

        if (transform.position.z < player.transform.position.z + area && transform.position.z > player.transform.position.z - area && transform.position.x < player.transform.position.x + area && transform.position.x > player.transform.position.x - area)
        {
            if (Random.Range(1, 20) == 10)
            {
                Invoke("fier", 4f);
            }
        }


	}

    void fier()
    {
        GameObject tempBullet = Instantiate(Resources.Load("RedBullet"), transform.position, transform.rotation)  as GameObject;
        Rigidbody RBtempBullet = tempBullet.GetComponent<Rigidbody>();

        RBtempBullet.AddForce(RBtempBullet.transform.forward * Time.deltaTime * speed);

        Destroy(tempBullet, 2f);
    }
}
