using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class ChangeBright_Text : MonoBehaviour
{
    // Start is called before the first frame update
   float timer=0;
   bool spegni=false;
   float color=0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // gameObject.GetComponent<Image>().color = new Color32(0,0,0,255);
        if (timer<Time.time){

            timer=Time.time+0.0025f;
            if (spegni==false){
            gameObject.GetComponent<Text>().color = new Color(0,0,0,color);
            color=color-0.01f;
            }
            if (spegni==true){
            gameObject.GetComponent<Text>().color = new Color(0,0,0,color);
            color=color+0.01f;
            }
            if (color<=0){
             spegni=true;
            }
            else if (color>=0.7f)
            {
                spegni=false;
            }
        }
    }
}
