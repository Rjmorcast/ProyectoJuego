using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour {

    public float forwardSpeed = 2f;
 

    // Use this for initialization
    void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        //Funcion para darle movimiento a el camion 
        transform.Translate(new Vector3(-1, 0, 0) * forwardSpeed * Time.deltaTime);
        if (transform.position.x < -14)
        {
            Destroy(gameObject);
            GameController.instance.score++;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {//Funcion para que se de la condicion de perder
        GameController.instance.gameOver = true;
        GameController.instance.GameOver();
    }
}
