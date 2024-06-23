using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToglableActor : Actor
{
    [SerializeField]
    bool Togglable = false;
    bool togled = false;
    public override void StartActivate()
    {
        if (!Togglable)
        {
            base.StartActivate();
        }
        else
        {
            if (!togled)
            {
                base.StartActivate();
                togled = true;
            }
            else
            {
                base.StartDeactivate();
                togled = false;
            }
        }
    }
    public override void StartDeactivate()
    {
        if (!Togglable)
        {
            base.StartDeactivate();
        }
    }
}
