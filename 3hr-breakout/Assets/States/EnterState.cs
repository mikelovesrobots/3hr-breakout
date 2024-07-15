using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterState : State
{
    public StateMachine stateMachine;
    public State volleyingState;

    public override void OnEnterState()
    {
        StartCoroutine(WaitThenVolley());
    }

    IEnumerator WaitThenVolley()
    {
        yield return new WaitForSeconds(1.0f);
        stateMachine.SwitchState(volleyingState);
    }
}
