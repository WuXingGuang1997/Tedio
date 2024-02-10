using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistruggiPalla : MonoBehaviour
{
    public GameObject Camera2;
    float timer;
    bool B_timer=false;
    public GameObject palla;
    public GameObject blocco;
    public main main;
    public draganddrop3d draganddrop3d;
public bool GameOver=true;
public GameObject P_Bowling;
public Text strike; 

    void Start()
    {
      GameOver=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(B_timer){
            if(timer<Time.time){
   draganddrop3d.Birillo1.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo2.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo3.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo4.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo5.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo6.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo7.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo8.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo9.GetComponent<Rigidbody>().isKinematic=true;
    draganddrop3d.Birillo10.GetComponent<Rigidbody>().isKinematic=true;

     draganddrop3d.Birillo1.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo2.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo3.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo4.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo5.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo6.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo7.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo8.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo9.GetComponent<Rigidbody>().isKinematic=false;
    draganddrop3d.Birillo10.GetComponent<Rigidbody>().isKinematic=false;

    if(PlayerPrefs.GetInt("CountBirillo")>=10)
{
    P_Bowling.SetActive(true);
    strike.fontSize=200;
    strike.text="Strike!";
    main.T_Bowling.text="Hai buttato giù tutti i birilli!";
    main.soldi+=15;
                  main.aggiornaSoldi();
                  main.T_Soldi.text="Punti: "+main.soldi.ToString();
      //StartCoroutine(main.LateGetPuntiBowling(0.1f));
      /*main.scatola.SetActive(true);
       main.timer10.xButton();
         StartCoroutine(main.LateGetDopo(0.1f));
            StartCoroutine(main.LateAggiornaOra(0.1f));*/
      
   
}else{
    P_Bowling.SetActive(true);
    strike.fontSize=60;
    strike.text="Hai buttato giù "+PlayerPrefs.GetInt("CountBirillo")+"/10 birilli";
     main.T_Bowling.text="Ritenta!";
     //main.scatola.SetActive(true);
     
}
PlayerPrefs.SetInt("CountBirillo",0);

                // Camera2.SetActive(false);
                 B_timer=false;
                // main.P_Principale.SetActive(true);
              // main.BowlingSound.Stop();
              //  draganddrop3d.IndietroScene();
            }
        }
    }
         void OnCollisionEnter (Collision col)
     {
       if(col.gameObject.name == "palla")
       {
        //Destroy(col.gameObject);
        //col.gameObject.SetActive(false);
        timer=Time.time+2;
        B_timer=true;
         blocco.SetActive(true);
       GameOver=true;
       }
     }
}
