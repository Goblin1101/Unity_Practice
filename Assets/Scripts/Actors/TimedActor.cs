using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedActor : Actor
{
    [SerializeField]
    float max_time = 1;

    float time = 0;
    
    bool timer = false;

    private void Update()
    {
        if (timer)
        {
            time += Time.deltaTime;
            if(time >= max_time)
            {
                base.StartDeactivate();
                timer = false;
                time = 0;
            }
        }
    }


    public override void StartActivate()
    {
        if (!timer) 
        {
            timer = true;
            base.StartActivate();
        }
        

    }

    public override void StartDeactivate()
    {
        base.StartDeactivate();
    }
}
