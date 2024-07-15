using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsLeftLabelUpdater : MonoBehaviour
{
  public TMPro.TextMeshProUGUI label;

  private void Start()
  {
    GameState.instance.OnChangeBallsLeft += UpdateLabel;
    UpdateLabel(GameState.instance.ballsLeft);
  }

  private void UpdateLabel(int newBallsLeft)
  {
    label.text = $"balls left {newBallsLeft}";
  }
}