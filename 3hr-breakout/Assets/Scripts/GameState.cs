using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState instance;

    public float score = 0;
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

    private void Awake()
    {
        instance = this;
    }
}
