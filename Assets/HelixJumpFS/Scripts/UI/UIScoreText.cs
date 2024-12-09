using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text maxScoreText;
    [SerializeField] private string retainMaxScoreText;

    private void Start()
    {
        maxScoreText.text = retainMaxScoreText + " " + scoresCollector.MaxScores;
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoresCollector.Scores.ToString();
        }

        if (type == SegmentType.Finish)
        {
            maxScoreText.text = retainMaxScoreText + " " + scoresCollector.MaxScores;
        }
    }
}
