﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();

    int index;

    void Awake() {
        InitObstacles ();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitObstacles()
    {
        index = 0;
        //Initialisere Hindernisse 
        for (int i = 0; i < obstacles.Length; i++)
        {
            GameObject obj = Instantiate (obstacles [index], transform.position, Quaternion.identity);
            obstaclesToSpawn.Add(obj);
            index++;
            obstaclesToSpawn[i].SetActive(false);
            if(index == obstacles.Length) {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomObstacle()
    {
        // Warte eine gewisse Zeit
        yield return new WaitForSeconds (Random.Range (1.5f, 4.5f));
        int index = Random.Range(0, obstaclesToSpawn.Count);

        while(true)
        {
            if(!obstaclesToSpawn[index].activeInHierarchy) {
                obstaclesToSpawn [index].SetActive(true);
                obstaclesToSpawn [index].transform.position = transform.position;
                break;
            }
            else {
                index = Random.Range(0, obstaclesToSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomObstacle());
    }
}
