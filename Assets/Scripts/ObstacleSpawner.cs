using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public List<GameObject> obstaclesToSpawn = new List<GameObject>();

    int index;
    float speed;

    public static float FasterGameTime = 1;

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
        if (FasterGameTime > 0.5f)
        {
            FasterGameTime = FasterGameTime - 0.0001f;
        }
        if (PlayerHealth.PlayerAlive == false)
        {
            FasterGameTime = 1;
        }

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
        yield return new WaitForSeconds(Random.Range(1.5f * FasterGameTime, 3.5f * FasterGameTime));
        int index = Random.Range(0, obstaclesToSpawn.Count);

        while (true)
        {
            if (!obstaclesToSpawn[index].activeInHierarchy) {
                obstaclesToSpawn[index].SetActive(true);
                obstaclesToSpawn[index].transform.position = transform.position;
                break;
            }
            else {
                index = Random.Range(0, obstaclesToSpawn.Count);
            }
        }

        StartCoroutine(SpawnRandomObstacle());
    

        


    }
}
