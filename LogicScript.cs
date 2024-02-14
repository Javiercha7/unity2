using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    void Awake()
    {
     string [] anything = {"wawa","wewe","wiwi","wowo","wuwu"};
     for(int i=0; i<anything.Length; i++;){
        Debug.Log(anything[i])
     }
    }
}
