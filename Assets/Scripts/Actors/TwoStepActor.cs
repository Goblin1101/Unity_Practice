using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TwoStepActor : Actor
{
    [SerializeField]
    [Header("Togglable")]
    bool ShouldDoOnce = false;

    [Header("Steps")]
    public bool Step_1;
    public bool Step_2;

    bool activative = true;
    bool deactivative = false;
    void Update()
    {
        if (Step_1 && Step_2)
        {
            if (activative)
            {
                activative = false;
                StartActivate();
                deactivative = true; 
            }
        }
        else
        {
            if (deactivative && !ShouldDoOnce)
            {
                deactivative = false;
                StartDeactivate();
                activative = true;
            }
        }
    }
    public void SetYesStep_1()
    {
        Step_1 = true;
    }
    public void SetYesStep_2()
    {
        Step_2 = true;
    }
    public void SetNoStep_1()
    {
        Step_1 = false;
    }
    public void SetNoStep_2()
    {
        Step_2 = false;
    }
}
