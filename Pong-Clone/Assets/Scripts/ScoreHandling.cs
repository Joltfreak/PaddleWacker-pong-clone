using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandling : MonoBehaviour
{
    public int player_score = 0;
    public int ai_score = 0;

    DisplayText displayText;
    SpawnBall spawnBall;
    BallMovement ballMovement;

    private void Start() 
    {
        displayText = FindObjectOfType<DisplayText>();
        spawnBall = FindObjectOfType<SpawnBall>();
        ballMovement = FindObjectOfType<BallMovement>();
    }

    private void Update() 
    {
        print($"player score: {player_score}");
        print($"Ai score: {ai_score}");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "PlayerPointZone")
        {
            ai_score++;
            ballMovement.ballMoveSpeed = 5f;
            if(ai_score == 5 || player_score == 5)
            {
                displayText.DisplayEndGameText();
            }
            else
            {
                displayText.StartCoroutine(displayText.DisplayAiScoredText());
                spawnBall.StartCoroutine(spawnBall.spawnBall());
            }   
        }
        else if(other.gameObject.tag == "AiPointZone")
        {
            player_score++;
            ballMovement.ballMoveSpeed = 5f;
            if(ai_score == 5 || player_score == 5)
            {
                displayText.DisplayEndGameText();
            }
            else
            {
                displayText.StartCoroutine(displayText.DisplayPlayerScoredText());
                spawnBall.StartCoroutine(spawnBall.spawnBall());
            }   
        }
    }
}
