using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gira_Moneta : MonoBehaviour
{
    float timer=0;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Time.time){
            timer=Time.time+0.09f;
            if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_1").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_2").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_2").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_3").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_3").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_4").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_4").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_5").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_5").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_6").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_6").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_7").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_7").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_8").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_8").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_9").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_9").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_10").GetComponent<Image>().sprite;
            }
            else if (gameObject.GetComponent<Image>().sprite==GameObject.Find("S_10").GetComponent<Image>().sprite){
                gameObject.GetComponent<Image>().sprite=GameObject.Find("S_1").GetComponent<Image>().sprite;
            }
            
        }
    }
}
