﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSpaceship : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward);
    }
}
