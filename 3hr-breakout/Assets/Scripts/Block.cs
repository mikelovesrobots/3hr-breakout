using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int blockLevel = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameState.instance.currentLevel = Math.Max(GameState.instance.currentLevel, blockLevel);
            GameState.instance.score += blockLevel * 100;

            // Destroy the block
            Destroy(gameObject);
        }
    }
}
