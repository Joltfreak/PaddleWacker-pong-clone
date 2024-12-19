using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    TMP_Text playerScoredText;
    TMP_Text aiScoredText;
    ScoreHandling scoreHandling;

    void Start()
    {
        scoreHandling = FindObjectOfType<ScoreHandling>();
        playerScoredText = GameObject.Find("PlayerScoredText").GetComponent<TMP_Text>();
        aiScoredText = GameObject.Find("AiScoredText").GetComponent<TMP_Text>();
    }

    public void DisplayEndGameText()
    {
        if(scoreHandling.player_score > scoreHandling.ai_score)
        {
            playerScoredText.text = "Player Wins!";
        }
        else
        {
            aiScoredText.text = "  AI Wins!";
        }
    }

    public IEnumerator DisplayPlayerScoredText()
    {
        playerScoredText.text = "Player Scored!";
        yield return new WaitForSeconds(2);
        playerScoredText.text = "";
    }

    public IEnumerator DisplayAiScoredText()
    {
        aiScoredText.text = "AI Scored!";
        yield return new WaitForSeconds(2);
        aiScoredText.text = "";
    }
}
