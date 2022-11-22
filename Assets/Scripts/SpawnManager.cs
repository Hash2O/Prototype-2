using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        //Ici animalPrefabs.Length = 3, c'est le nombre exclusif, 
        //i.e. Random choisira entre 0, 1 et 2 sans aller jusqu'à 3
        int animalIndex = Random.Range(0, animalPrefabs.Length); 

        Vector3 spawnPos =  new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, 
            animalPrefabs[animalIndex].transform.rotation);
    }
}
