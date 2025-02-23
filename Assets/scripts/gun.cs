using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
   float bulletNumber2;
   public gunforreal script;
   public GameManager gameManager;
    void Start(){
    
     float bulletNumber2 = Random.Range(1,7);
    }

    void Update(){


          if(Input.GetMouseButtonDown(0) && script.RightClicked == true){
           if(bulletNumber2 == 6){ 
            gameManager.EndGame();
           
           }
          else {
              bulletNumber2++;
          }
          }
         
          
          
           if(Input.GetKey("k")){ 
            gameManager.EndGame();
           }
         Debug.Log(bulletNumber2);
        }




    
   
}
