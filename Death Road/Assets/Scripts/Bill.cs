using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bill : MonoBehaviour {

    private Rigidbody2D rb;
    public float jumpForce = 600f;
   // public float move = 0;
    public GameObject feet;
    public LayerMask layer;
    private Boolean parado = true;
    //Animator anim;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        // anim = GetComponent<Animator>();
        scoreText.text = "Score: 0"; 
    }
	
	// Update is called once per frame
	void Update () {
        //Controla el salto
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
      //  move = 0;
      //Controla cuando el personaje se agacha
        if (Input.GetButtonDown("Vertical"))
        {
            Down();
        }
        //Imprime y lleva el conteo del puntaje
        scoreText.text = "Score: " + GameController.instance.score.ToString();
    }
    //Funcion para que el personaje pueda saltar
    public void Jump() {
        if (!parado)
        {
            rb.transform.Rotate(new Vector3(0, -20, -90));
            parado = true;
            // move = 0;
            //anim.SetFloat("Speed", Mathf.Abs(move));
        }
        // RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layer);
        // if (raycast.collider != null)
        rb.AddForce(Vector2.up * jumpForce);
        // move = 1;

        // anim.SetFloat("Speed", Mathf.Abs(move));
    }
    //Funcion para que el personaje pueda bajar
    public void Down() {
        if (parado)
        {
            rb.transform.Rotate(new Vector3(0, 0, 90));
            parado = false;
            // move = 0;
            //anim.SetFloat("Speed", Mathf.Abs(move));
        }
    }
}
