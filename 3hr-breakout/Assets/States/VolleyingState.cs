using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyingState : State
{
    public BallLauncher ballLauncher;

    public override void OnEnterState()
    {
        ballLauncher.LaunchBall();
        GameState.instance.ballsLeft -= 1;
    }
}
