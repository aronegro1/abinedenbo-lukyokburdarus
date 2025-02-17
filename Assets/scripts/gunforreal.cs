using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunforreal : MonoBehaviour
{
     public GameObject gun;   
        
        
        
        
        void Start()
    {
        
    }

    
    void Update()
    {
         if (Input.GetMouseButtonDown(1)){
            gun.transform.Rotate(-7.093f,-177.015f,-0.111f,Space.Self);
         gun.transform.localPosition= new Vector3(0.073f,0.1303885f,0.671f);
         }
    }
}
