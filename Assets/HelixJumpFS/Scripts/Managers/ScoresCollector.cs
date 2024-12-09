using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private int scores;
    [SerializeField] private int bonusScores;
    [SerializeField] private int maxScores;

    public int Scores => scores;
    public int MaxScores => maxScores;

    public int hit;
  
    protected override void Awake()
    {
        base.Awake();
        LoadMaxScores();
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel; 
            hit += 1; 

            if (hit > 1)
            {
                scores += levelProgress.CurrentLevel + bonusScores; 
            }

        }
        else hit = 0; 


        if (type == SegmentType.Finish)
        {
            if (scores > maxScores)
            {
                maxScores = scores;
                SeveMaxScores();
            }

        }
        
    }

    private void SeveMaxScores()
    {
        PlayerPrefs.SetInt("ScoresCollector:MaxScores", maxScores);
    }

    private void LoadMaxScores()
    {
        maxScores = PlayerPrefs.GetInt("ScoresCollector:MaxScores", 0);
    }

}
