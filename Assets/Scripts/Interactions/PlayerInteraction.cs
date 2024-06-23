using UnityEngine;
public class PlayerInteraction : CamUpdate
{
    [SerializeField]
    private Texture2D[] texture2D;
    Vector2 cursorPos;
    public void ChangeCursor(int i)
    {
        cursorPos = new Vector2(texture2D[i].width / 2, texture2D[i].height / 2);
        Cursor.SetCursor(texture2D[i], cursorPos, CursorMode.Auto);
    }

    private void Update()
    {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out RaycastHit prev_hit))
                {
                    if (prev_hit.collider.CompareTag("PointerActor"))
                    {
                        ChangeCursor(1);
                        if (Input.GetMouseButtonDown(0))
                            prev_hit.collider.GetComponent<Actor>().StartActivate();
                    }
                    else
                    {
                        ChangeCursor(0);
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
