using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float forwardSpeed = 2f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(new Vector3(-1, 0, 0) * forwardSpeed * Time.deltaTime);
        if (transform.position.x < -14)
        {
            Destroy(gameObject);
        }

    }
}
