using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    
    public AudioSource beee;
  public saltalupo saltalupo;
  public  distruggipecora distruggipecora;
public Text T_saltalupo;
    public GameObject P_GameOver;
    int countPecore;
    [Header("Jump System")]
    Rigidbody2D rb;
    [SerializeField] int jumpPower;
[SerializeField] float fallMultiplier;
[SerializeField] float jumpTime;
[SerializeField] float jumpMultiplier;
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    bool isJumping;
    float jumpCounter;
    Vector2 vecGravity;
    // Start is called before the first frame update
    void Start()
    {
        vecGravity = new Vector2(0,-Physics2D.gravity.y);
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded=Physics2D.OverlapCapsule(groundCheck.position, new Vector2 (250,100),CapsuleDirection2D.Horizontal,0,groundLayer);
        if (Input.GetMouseButtonDown(0) && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            isJumping=true;
            jumpCounter=0;
        }
if(rb.velocity.y>0 && isJumping)
{
    jumpCounter+=Time.deltaTime;
    if(jumpCounter>jumpTime) isJumping=false;
    rb.velocity += vecGravity*jumpMultiplier*Time.deltaTime;
}
if (Input.GetMouseButtonUp(0)){
   isJumping=false; 
}

        if (rb.velocity.y <0){
            rb.velocity -= vecGravity*fallMultiplier*Time.deltaTime;
        }

    }


     void OnCollisionEnter2D (Collision2D col)
     {
       if(col.gameObject.name == "Pecora(Clone)"){
        P_GameOver.SetActive(true);
        beee.Play();
        Destroy(col.gameObject);
        saltalupo.P_SaltaLupo.SetActive(false);
      T_saltalupo.text="Hai perso, riprova!";
      distruggipecora.countPecore=0;
      var myNewSmoke = Instantiate (distruggipecora.Pecora, new Vector3(Screen.width,-1017, transform.position.z) , Quaternion.identity);
            myNewSmoke.transform.SetParent(distruggipecora.myCanvas);
            myNewSmoke.transform.localScale =new Vector3(1,1,1);
       }
     }
     
}
