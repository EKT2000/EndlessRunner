using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Collector") {
            RestartGame();
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
        
        if (other.gameObject.tag == "Enemy") {
            RestartGame();
        }

    }

    void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
