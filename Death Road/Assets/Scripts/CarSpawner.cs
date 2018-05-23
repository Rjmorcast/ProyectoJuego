using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarSpawner : MonoBehaviour {

    public GameObject Car;
    public GameObject Truck;
    public float spawnTime = 5f;
    public float elapsedTime = 0f;
    private bool car = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Funcion para que al azar se generen carros o camiones
        if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            float random = Random.Range(-1f, 1f);
            if (random < 0)
            {
                Instantiate(Truck, new Vector3(6.5F, -1f, 0), Quaternion.identity);
                elapsedTime = 0;
            }
            else
            {
                Instantiate(Car, new Vector3(6.5F, -2.5f, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
        }
    //Funcion para cambiar de escena
    public void juan()
    {
        SceneManager.LoadScene("Level1");
    }
}
