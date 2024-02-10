using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control_BrightQ : MonoBehaviour
{
    // Start is called before the first frame update
    public main main;
    public GameObject textQ;
    public GameObject B_Q;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(main.B_Q1.interactable || main.B_Q2.interactable || main.B_Q3.interactable || main.B_Q4.interactable){

        textQ.GetComponent<ChangeBright_Text>().enabled=true;
        B_Q.GetComponent<ChangeBright>().enabled=true;
        }
        else{
            textQ.GetComponent<Text>().color= new Color(0,0,0,0);
           textQ.GetComponent<ChangeBright_Text>().enabled=false;
        B_Q.GetComponent<ChangeBright>().enabled=false; 
        B_Q.GetComponent<Image>().color = new Color(0,0,0,0); 
        }
    }
}
