using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TwoStepActor : MonoBehaviour
{
    [SerializeField]
    [Header("Togglable")]
    bool ShouldDoOnce = false;

    [Header("Steps")]
    public bool Step_1;
    public bool Step_2;

    
    [SerializeField]
    UnityEvent ActivationEvent;
    [SerializeField]
    UnityEvent DeactivationEvent;
    
    bool activative = true;
    bool deactivative = false;


    // Update is called once per frame
    void Update()
    {

        if (Step_1 && Step_2)
        {
            if (activative)
            {
            activative = false;
            ActivationEvent.Invoke();
            deactivative = true; 
            }
        }
        else
        {
            if (deactivative && !ShouldDoOnce)
            {
                deactivative = false;
                DeactivationEvent.Invoke();
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
