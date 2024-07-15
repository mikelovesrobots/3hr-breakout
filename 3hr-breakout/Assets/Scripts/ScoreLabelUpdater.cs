using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreLabelUpdater : MonoBehaviour
{
  public TMPro.TextMeshProUGUI scoreLabel;

  private void Start()
  {
    GameState.instance.OnChangeScore += UpdateScoreLabel;
    UpdateScoreLabel(GameState.instance.score);
  }

  private void UpdateScoreLabel(float newScore)
  {
    scoreLabel.text = $"{newScore} points";
  }
}