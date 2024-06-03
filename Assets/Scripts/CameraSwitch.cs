using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraSwitch : MonoBehaviour
{

    public List<Camera> Cameras_List;

    [SerializeField]
    UnityEvent onCameraChange;

    Camera active_camera;
    int cam_index = 0;
    // Start is called before the first frame update
    void Start()
    {

            active_camera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            prev_cam();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            next_cam();
        }
    }
    void next_cam()
    {
        if(Cameras_List.Count > 0)
        {
            cam_index++;
            if (cam_index > Cameras_List.Count - 1) cam_index = 0;
            active_camera.gameObject.SetActive(false);
            active_camera = Cameras_List[cam_index];
            active_camera.gameObject.SetActive(true);
            onCameraChange?.Invoke();
        }
    }
    void prev_cam()
    {
        if (Cameras_List.Count >0)
        {
            cam_index--;
            if(cam_index < 0) cam_index = Cameras_List.Count - 1;
            active_camera.gameObject.SetActive(false);
            active_camera = Cameras_List[cam_index];
            active_camera.gameObject.SetActive(true);
            onCameraChange?.Invoke();
        }
    }
}
