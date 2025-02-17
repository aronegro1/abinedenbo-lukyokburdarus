using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousebehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }
public Vector2 turn;
    
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
       turn.y += Input.GetAxis("Mouse Y");
      
        transform.localRotation =  Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
