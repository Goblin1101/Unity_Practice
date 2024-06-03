using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerInteraction : CamUpdate
{
    
    // Start is called before the first frame update

    bool ativated = false;

    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit prev_hit))
            {
                if (prev_hit.collider.CompareTag("PointerActor"))
                {
                    if (!ativated)
                    {
                        prev_hit.collider.GetComponent<Actor>().StartActivate();
                        ativated = true;
                    }
                    else
                    {
                        prev_hit.collider.GetComponent<Actor>().StartDeactivate();
                        ativated = false;
                    }
                }

            }
        }
    }

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
    private void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("ActivatableActor") && Input.GetKeyDown(KeyCode.F))
        {

            collider.GetComponent<Actor>().StartActivate();
            
        }
    }
}
