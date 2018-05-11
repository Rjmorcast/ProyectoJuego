using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bill : MonoBehaviour {

    private Rigidbody2D rb;
    public float jumpForce = 600f;
    public GameObject feet;
    public LayerMask layer;
    private Boolean parado = true;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            if (!parado) { 
                rb.transform.Rotate(new Vector3(0, 0, -90));
                parado = true;
            }
            RaycastHit2D raycast =
           Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layer);
            if (raycast.collider != null)
                rb.AddForce(Vector2.up * jumpForce);

        }

        if (Input.GetButtonDown("Vertical"))
        {
            if (parado)
            {
                rb.transform.Rotate(new Vector3(0, 0, 90));
                parado = false;
            }
        }
    }
}
