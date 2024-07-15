using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostBallState : State
{
    public StateMachine stateMachine;
    public State volleyingState;
    public State exitState;

    public override void OnEnterState()
    {
        AudioPlayer.instance.PlayLoseSound();
        if (GameState.instance.ballsLeft > 0)
        {
            StartCoroutine(WaitThenVolley());
        }
        else
        {
            stateMachine.SwitchState(exitState);
        }
    }

    public override void OnExitState()
    {
    }

    IEnumerator WaitThenVolley()
    {
        yield return new WaitForSeconds(1.0f);
        stateMachine.SwitchState(volleyingState);
    }
}
