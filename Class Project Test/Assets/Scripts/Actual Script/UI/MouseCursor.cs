using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    public Texture2D cursorArrow;
    public Texture2D enemyArrow;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }


   //Cursor.SetCursor(enemyArrow, Vector2.zero, CursorMode.ForceSoftware);
       
   
        
    


}
