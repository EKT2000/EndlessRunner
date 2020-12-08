using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverScreen;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Collector") {
            PlayerHealth.PlayerAlive = false;
            Show_GameOver();
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.tag == "Enemy") {
            PlayerHealth.PlayerAlive = false;
            Show_GameOver();
        }

    }

    void Show_GameOver()
    {
        GameOverScreen.SetActive(true);
        
    }

    
}
