using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterState : State
{
    public StateMachine stateMachine;
    public State volleyingState;

    public override void OnEnterState()
    {
        stateMachine.SwitchState(volleyingState);
    }
}
