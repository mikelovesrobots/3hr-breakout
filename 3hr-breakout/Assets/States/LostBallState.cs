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
        if (GameState.instance.ballsLeft > 0)
        {
            stateMachine.SwitchState(volleyingState);
        }
        else
        {
            stateMachine.SwitchState(exitState);
        }
    }

    public override void OnExitState()
    {
    }
}
