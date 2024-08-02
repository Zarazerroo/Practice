using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    ///  creat an animal array
    public GameObject[] animals;
    private float spawnRangeX = 20;
    private float startDealy = 2;
    private float spwanInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpwanAnimals", startDealy, spwanInterval);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void SpwanAnimals()
    {
        /// randomize the animals array
        int animalsIndex = Random.Range(0, animals.Length);
        /// randomize the X range for spwaning animals.
        Vector3 spwanPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 18);
        /// instaniate the animals 
        Instantiate(animals[animalsIndex], spwanPos, animals[animalsIndex].transform.rotation);
    }
}
