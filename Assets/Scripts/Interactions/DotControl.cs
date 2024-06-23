using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotControl : MonoBehaviour
{


    [SerializeField]
    private Texture2D texture2D;
    Vector2 cursorPos;

    void Awake()
    {
        cursorPos = new Vector2(texture2D.width / 2,texture2D.height/2);
        Cursor.SetCursor(texture2D,cursorPos,CursorMode.Auto);

        
    }


}
