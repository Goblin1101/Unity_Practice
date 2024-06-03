using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Actor : MonoBehaviour
{
    [SerializeField]
    UnityEvent OnActivateAction;
    [SerializeField]
    UnityEvent OnDeactivateAction;
    [SerializeField]
    bool Togglable = false;


    bool togled = false;



    private void Update()
    {

    }

    public virtual void StartActivate()
    {
        if(!Togglable)
        {            
            OnActivateAction.Invoke();
        }
        else
        {
            if (!togled)
            {
                OnActivateAction.Invoke();
                togled = true;
            }
            else
            {
                OnDeactivateAction.Invoke();
                togled= false;
            }
        }

    }
    public virtual void StartDeactivate()
    {
        if (!Togglable)
        {
            OnDeactivateAction.Invoke();
        }
        
    }



}
