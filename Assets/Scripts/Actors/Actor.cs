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
    public virtual void StartActivate()
    {
         OnActivateAction.Invoke();
    }
    public virtual void StartDeactivate()
    {
         OnDeactivateAction.Invoke();
    }
}

