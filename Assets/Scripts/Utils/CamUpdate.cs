using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamUpdate : MonoBehaviour
{
    protected Camera cam;
    protected Transform cam_parent;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCamera();
    }
    public virtual void UpdateCamera()
    {
        cam = Camera.main;
        cam_parent = cam.transform.parent;
    }
}
