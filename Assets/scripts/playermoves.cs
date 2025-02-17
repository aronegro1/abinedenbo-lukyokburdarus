using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoves : MonoBehaviour
{
    public GameObject niga;
    public Rigidbody rb;
    public float forwardForce = 10f;
    
   public float backwardsForce = 500f;

   
    void FixedUpdate()
    {
        if( Input.GetKey("d")){
        rb.AddForce(1500 * Time.deltaTime,0,0);
        
    }
    if( Input.GetKey("a")){
        rb.AddForce(-1500 * Time.deltaTime,0,0);
    }
    
    
    
     if( Input.GetKey("w")){
    rb.AddForce(0,0,1500 * Time.deltaTime);
     }
    
     if (Input.GetKey("space"))
    {
        rb.AddForce(0, 3000 * Time.deltaTime, 0);
    }
   
   if (Input.GetKey("s")){
    rb.AddForce(0,0,-1500 * Time.deltaTime);
   }
   
   
   
    
   
   
    }





    



}


