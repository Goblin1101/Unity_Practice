using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Color color;
    [SerializeField]
    float speed;

    Material material;
    private void Awake()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
    }
    public void ActiveState()
    {
        material.SetColor("_Color", color);
        material.SetFloat("_Speed", speed);
    }
    public void DeactiveState()
    {
        material.SetColor("_Color", Color.white);
        material.SetFloat("_Speed", 1);
    }
    private void OnDestroy()
    {
        DeactiveState();
    }
}
