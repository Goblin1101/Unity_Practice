using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;

public class Shmooving : CamUpdate
{
    [SerializeField]
    float sped;
    Vector3 direction;
    // Update is called once per frame
    void Update()
    {
        transform.rotation = cam_parent.rotation;
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        gameObject.transform.Translate(sped * Time.deltaTime * direction);
    }
}
