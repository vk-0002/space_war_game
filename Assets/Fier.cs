using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fier : MonoBehaviour {

  
    float speed=9000000;
    

    public void FierBullet()
    {
        GameObject tempBullet = Instantiate(Resources.Load("BlueBullet"), transform.position,transform.rotation ) as GameObject;            //Quaternion.Euler(180f, 90f, 90f)
        Rigidbody BulletRigidbody = tempBullet.GetComponent<Rigidbody>();
        BulletRigidbody.AddForce(BulletRigidbody.transform.forward * speed * Time.deltaTime);

        //BulletRigidbody.AddForce(0f, 0f, speed);

        Destroy(tempBullet, 2f);
    }

}
