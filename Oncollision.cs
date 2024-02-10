using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Oncollision : MonoBehaviour {
public int MoneteCounting;
public AudioSource A_plin;

void OnCollisionEnter2D (Collision2D col)
     {
       if(col.gameObject.name == "Moneta(Clone)")
       {
        MoneteCounting+=1;
    A_plin.Play();
        Destroy(col.gameObject);

       }
     }
}
