using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    
    
    
    void Start()
    {
        Renderer[] rs = GetComponentsInChildren<Renderer>();
foreach(Renderer r in rs)
     r.enabled = false;
       
    }

    
    void Update()
    {
        
    }

void OnCollisionEnter(Collision collisionInfo){
    if(collisionInfo.collider.CompareTag("GUN")){
  Debug.Log("collision");
        
               Renderer[] rs = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            r.enabled = true;  // Disable rendering (make object invisible)
        }
    }
}




}
