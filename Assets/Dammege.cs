using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dammege : MonoBehaviour {

   // public GameObject blast;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject tempBlast = Instantiate(Resources.Load("BigExplosionEffect"), transform.position, transform.rotation) as GameObject;

        Debug.Log("Kill");
        Destroy(this.gameObject);

        Destroy(tempBlast, 1f);
    }
}
