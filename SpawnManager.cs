using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cloudPrefab; // prefab della nuvola
    public float spawnInterval = 2f; // intervallo di spawn delle nuvole
    public float spawnYPosition = 5f; // posizione di spawn delle nuvole
    public Transform canvas; // riferimento al canvas
    public float timer;
    void Start()
    {
      //  InvokeRepeating("SpawnCloud", 0f, spawnInterval);
    }
    void Update(){
        if(timer<Time.time){
            timer=Time.time+2;
            SpawnCloud();
        }
        
    }

    void SpawnCloud()
    {
        // istanzia una nuova nuvola
        GameObject cloud = Instantiate(cloudPrefab, canvas);
        

        // posiziona la nuvola in una posizione random
        cloud.transform.position = new Vector2(Random.Range(-Screen.width/2,Screen.width/2),-Screen.height/2);
    }
}


