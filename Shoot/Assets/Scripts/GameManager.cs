using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject []spawnGate;
    public GameObject enemyPrefab;

    public void Start()
    {
        InvokeRepeating("SpawnEnemy", 2, 0.5f);
    }



    void SpawnEnemy()
    {
        int spawnGateIndex = Random.Range(0,2);
       
        Instantiate(enemyPrefab, , enemyPrefab.transform.rotation);
    }

   

}
