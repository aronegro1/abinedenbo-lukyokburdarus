using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunforreal : MonoBehaviour
{
     
     public bool RightClicked;
     public GameObject gun;   
       int guncount = 0;
        
        
        
        void Start()
    {
        
    }

    
    void Update()
    {
         if (Input.GetMouseButtonDown(1) && guncount == 0){
            
            gun.transform.Rotate(-7.093f,-177.015f,-0.111f,Space.Self);
         gun.transform.localPosition= new Vector3(0.073f,0.1303885f,0.671f);
         guncount++;
         RightClicked = true;
         }
    
         if(Input.GetKey("o") && guncount == 1){
            gun.transform.Rotate(-4.899f,0,0.003f,Space.Self);
         gun.transform.localPosition= new Vector3(0.5655996f,0.1387203f,0.3031884f);
        
         guncount--;
         
         }   
   
    
    
    
    
    
    }
}
