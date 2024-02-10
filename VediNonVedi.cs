using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
public class VediNonVedi : MonoBehaviour
{
    public Text T_PuntiUovo;
    public float invisible=0;
    float timer=0;
    float counter=0.05f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<Time.time){
        

        timer=Time.time+0.1f;
        invisible+=counter;
        T_PuntiUovo.color=new Color (1,1,1,invisible);
        if(invisible>=1){
            counter=-0.05f;
        }
        else if(invisible<=0)
        {
         counter=0.05f;
        }
        }
    
    }
}
