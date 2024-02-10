using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOn : MonoBehaviour
{
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Time.time){
            timer=Time.time+0.025f;
transform.localPosition=new Vector2(transform.localPosition.x-20,-1017);
        }
    }
}