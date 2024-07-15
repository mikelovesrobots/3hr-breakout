using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public delegate void ScoreChangeDelegate(float newScore);
    public static GameState instance;


    public float initialSpeed = 4f;
    public float speedIncreasePerLevel = 0.5f;
    public float currentLevel = 0;
    public float ballSpeed
    {
        get
        {
            return initialSpeed + (currentLevel * speedIncreasePerLevel);
        }
    }

    // Score system
    private float _score = 0;
    public float score
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            OnChangeScore?.Invoke(_score);
        }
    }
    public event ScoreChangeDelegate OnChangeScore;

    private void Awake()
    {
        instance = this;
    }
}
