using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Zugriff auf UI's möglich

public class Score : MonoBehaviour
{
    
    public Text aktueller_Score;
    public Text Highscore;
    public Text final_Score;
    public Text final_HighScore;

    public float ScoreCount;
    public float HighScoreCount;

    public float PointsPerSecond;

    

    // Start is called before the first frame update
    void Start()
    {
        //PlayerHealth.PlayerAlive = true;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            HighScoreCount = PlayerPrefs.GetFloat("HighScore"); //HighScore-Anzeige steht bei HighScoreWert und nicht bei 0.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.PlayerAlive == true)
        {
            ScoreCount += PointsPerSecond * Time.deltaTime; //Score wird hochgezählt, wenn Spieler noch lebt
        }

        if (ScoreCount >= HighScoreCount) 
        {
            HighScoreCount = ScoreCount;  //Highscore nimmt Wert von Score an, wenn Score den Highscore überschreitet
            PlayerPrefs.SetFloat("HighScore", HighScoreCount); //HighScore wird gespeichert
        }

        aktueller_Score.text = "Score: " + Mathf.Round(ScoreCount);   //Score wird geprintet
        Highscore.text = "HighScore: " + Mathf.Round(HighScoreCount); //HighScore wird geprintet

        if (PlayerHealth.PlayerAlive == false)
        {
            final_Score.text = aktueller_Score.text;
            final_HighScore.text = Highscore.text;
            
        }
    }
    public void ResetHighScore()
    {
        PlayerPrefs.SetFloat("Highscore", 0);
        ScoreCount = 0;
        aktueller_Score.text = "Score: " + 0;
        HighScoreCount = 0;
        Highscore.text = "HighScore: " + 0;
        final_Score.text = aktueller_Score.text;
        final_HighScore.text = Highscore.text;
    }
   
}
