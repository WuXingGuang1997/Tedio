using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestraSinistra : MonoBehaviour
{
    float x;
    float timer;
    float somma=0.6f;
    public DistruggiPalla DistruggiPalla;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    { if (DistruggiPalla.GameOver==false){
        if(Time.time > timer)
        {
            timer=Time.time+0.01f;
            x+=somma;
        transform.position=new Vector3(x,transform.position.y,transform.position.z);
    if(x>=18)
{
    somma=-0.6f;
}
  else  if(x<=-15)
{
    somma=0.6f;
}
        }
    }
    }
}
