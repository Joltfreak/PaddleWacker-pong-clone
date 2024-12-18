using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    ScoreHandling scoreHandling;
    [SerializeField] TMP_Text playerScoreText;
    [SerializeField] TMP_Text aiScoreText;

    private void Start() 
    {
        scoreHandling = FindObjectOfType<ScoreHandling>();
    }

    void Update()
    {
        updateScores();
    }

    void updateScores()
    {
        playerScoreText.text = scoreHandling.player_score.ToString();
        aiScoreText.text = scoreHandling.ai_score.ToString();
    }
}