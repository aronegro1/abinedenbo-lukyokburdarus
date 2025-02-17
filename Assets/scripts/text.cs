using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text : MonoBehaviour
{
        public Text bulletText;
    void Start(){
       int a = 1;
    while(a != 2){
       int bulletNumber3 = Random.Range(0,6);
        bulletText.text = bulletNumber3.ToString("0");
       a++;
       }
    }

    
    void Update()
    {
       
      
    }

}
