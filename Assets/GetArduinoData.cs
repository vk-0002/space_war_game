using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetArduinoData : MonoBehaviour {
    
    public Transform MoveSpaceship;
    public GameObject gun;
    public float TurnSpeed=5f;
    public float speed = 30f;
    public Rigidbody rb;

    Vector3 EulerAngleRight;
    Vector3 EulerAngleLeft;

    // Use this for initialization
    void Start () {

        EulerAngleRight = new Vector3(0, 20, 0);
        EulerAngleLeft = new Vector3(0, -20, 0);

    }

    // Update is called once per frame
    void Update () {

        

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);

        }


        if (Input.GetMouseButton(0))
        {
            gun.GetComponent<Fier>().FierBullet();

            Debug.Log("Fier");
        }

        // Turn

        

        if (Input.GetKey(KeyCode.D))
        {
            // MoveSpaceship.Rotate(new Vector3(0f, TurnSpeed*Time.deltaTime, 0f));
            Quaternion deltaRotation = Quaternion.Euler(EulerAngleRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

            Debug.Log("Turn Right");
        }

        if (Input.GetKey(KeyCode.A))
        {
            // MoveSpaceship.Rotate(new Vector3(0f, -TurnSpeed*Time.deltaTime, 0f));
            Quaternion deltaRotation = Quaternion.Euler(EulerAngleLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

            Debug.Log("Turn Left");
        }
	}
}
