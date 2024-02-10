using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloudMovement : MonoBehaviour
{
    public float speed = 10f; // velocità del movimento verso l'alto
    private Rigidbody2D rb;
    

    void Start()
    {  
        speed=300f;
        rb = GetComponent<Rigidbody2D>();
        
        gameObject.transform.localPosition= new Vector2(Random.Range(-Screen.width/2,Screen.width/2),-Screen.height/2);
    }

    void Update()
    {
        // muovi la nuvola verso l'alto
        
            rb.velocity = new Vector2(0, speed);
        }
        
}

