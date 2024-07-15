using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : StateMachine
{
    public static PlayController instance;

    void Awake()
    {
        instance = this;
    }
}
