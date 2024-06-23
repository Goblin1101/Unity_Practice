using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideActivation : MonoBehaviour
{


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Actor"))
        {

            collider.GetComponent<Actor>().StartActivate();
        }

    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Actor"))
        {
            collider.GetComponent<Actor>().StartDeactivate();
        }
    }
}
