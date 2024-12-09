using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;


    protected override void Awake()
    {
        base.Awake();
        Load();
    }

#if UNITY_EDITOR
    private void Update()
   {
        if (Input.GetKeyDown(KeyCode.F1) == true)
        {
            Reset();
        }

        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
#endif



    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;
            Seve();
        }
    }

    private void Seve()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
    }

    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
    }


#if UNITY_EDITOR
    private void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
#endif
}
