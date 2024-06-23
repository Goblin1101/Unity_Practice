using UnityEngine;
public class PlayerInteraction : CamUpdate
{
    [SerializeField]
    private Texture2D[] texture2D;
    Vector2 cursorPos;
    RaycastHit prev_hit;
    public void ChangeCursor(int i)
    {
        cursorPos = new Vector2(texture2D[i].width / 2, texture2D[i].height / 2);
        Cursor.SetCursor(texture2D[i], cursorPos, CursorMode.Auto);
    }
    private void Update()
    {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
        {
            if (hit.collider.CompareTag("PointerActor"))
            {
                prev_hit = hit;
                ChangeCursor(1);
                if (Input.GetMouseButtonDown(0))
                {
                    hit.collider.GetComponent<Actor>().StartActivate();
                }
                if(!Input.GetMouseButton(0))
                {
                    hit.collider.GetComponent<Actor>().StartDeactivate();
                }
            }
            else
            {
                ChangeCursor(0);
                if (prev_hit.collider != null)
                {
                    prev_hit.collider.GetComponent<Actor>().StartDeactivate();
                }
            }
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
