using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameOverScreen;

    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Collector") {
            PlayerHealth.PlayerAlive = false;
            //RestartGame();
            Show_GameOver();
            Debug.Log(PlayerHealth.PlayerAlive);
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.tag == "Enemy") {
            PlayerHealth.PlayerAlive = false;
            //RestartGame();  
            Show_GameOver();
            Debug.Log(PlayerHealth.PlayerAlive);
        }

    }

    void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    void Show_GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
