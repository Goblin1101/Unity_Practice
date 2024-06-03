using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    Vector2 rotation = Vector2.zero;
    float angleXLimit = 50;

    [SerializeField]
    float lookSpeed = 3.0f;
    // Start is called before the first frame update

    [SerializeField]
    float init_x;
    [SerializeField]
    float init_y;


    private void Awake()
    {


    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButtonUp(1))
        {
            Cursor.lockState = CursorLockMode.None;
        }


        if(Input.GetMouseButton(1))
        {
            rotation.x -= Input.GetAxis("Mouse Y") * lookSpeed;
            rotation.y += Input.GetAxis("Mouse X") * lookSpeed;

            rotation.x = Mathf.Clamp(rotation.x, init_x - (angleXLimit +15), init_x + angleXLimit);
            rotation.y = Mathf.Clamp(rotation.y, init_y - angleXLimit, init_y + angleXLimit);

            transform.localEulerAngles = rotation;
        }
    }
}
