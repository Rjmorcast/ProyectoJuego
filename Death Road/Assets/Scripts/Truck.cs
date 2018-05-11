﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour {

    public float forwardSpeed = 2f;
 

    // Use this for initialization
    void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-1, 0, 0) * forwardSpeed * Time.deltaTime);
        if (transform.position.x < -14)
        {
            Destroy(gameObject);
        }
    }
}