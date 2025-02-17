using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUNFORGUN : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    
    
    
    }

public void OnCollisionEnter(Collision collisionInfo){
    if(collisionInfo.collider.CompareTag("Player")){
  Debug.Log("collision");
        
               Renderer[] rs = GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            r.enabled = false;  // Disable rendering (make object invisible)
        }
    }
}



}
