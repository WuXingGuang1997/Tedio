using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class draganddrop3d : MonoBehaviour
{
   public GameObject Camera2;
    public Rigidbody rb;
    public GameObject Blocco;
    public DestraSinistra DestraSinistra;
    public bool Cambiascena=false;
    public float timer;
    public main main;
    public GameObject P_Bowling;
    public Text T_Strike;
    public GameObject Birillo1;
     public GameObject Birillo2;
      public GameObject Birillo3;
       public GameObject Birillo4;
        public GameObject Birillo5;
         public GameObject Birillo6;
          public GameObject Birillo7;
           public GameObject Birillo8;
            public GameObject Birillo9;
             public GameObject Birillo10;
            public AudioSource BowlingSoundStrike;
    public GameObject palla;
    public void B_Sgancia() {
        main.Sgancia.SetActive(false);
Blocco.SetActive(false);
rb.useGravity = true;
DestraSinistra.enabled =false;
Cambiascena=true;
timer=Time.time+12;
BowlingSoundStrike.Play();
    }
    void Update(){
        if (Time.time>timer && Cambiascena==true)
    {
       // SceneManager.LoadScene("SampleScene");
    }
    }
public void IndietroScene(){
    main.P_Random.SetActive(true);
    rb.useGravity = false;
    Camera2.SetActive(false);
    P_Bowling.SetActive(false);
    T_Strike.text="";
    main.P_Principale.SetActive(false);
    Birillo1.GetComponent<Rigidbody>().isKinematic=true;
    Birillo2.GetComponent<Rigidbody>().isKinematic=true;
    Birillo3.GetComponent<Rigidbody>().isKinematic=true;
    Birillo4.GetComponent<Rigidbody>().isKinematic=true;
    Birillo5.GetComponent<Rigidbody>().isKinematic=true;
    Birillo6.GetComponent<Rigidbody>().isKinematic=true;
    Birillo7.GetComponent<Rigidbody>().isKinematic=true;
    Birillo8.GetComponent<Rigidbody>().isKinematic=true;
    Birillo9.GetComponent<Rigidbody>().isKinematic=true;
    Birillo10.GetComponent<Rigidbody>().isKinematic=true;


    Birillo1.transform.position= new Vector3(3.43f,1,141.8f);
    Birillo1.transform.rotation  = Quaternion.Euler(0, 0, 0);
    
    Birillo2.transform.position= new Vector3(0.38f,1,141.8f);
    Birillo2.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo3.transform.position= new Vector3(6.31f,1,141.8f);
    Birillo3.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo4.transform.position= new Vector3(-3.04f,1,141.8f);
    Birillo4.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo5.transform.position= new Vector3(1.87f,1,138.8f);
    Birillo5.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo6.transform.position= new Vector3(-1.38f,1,138.8f);
    Birillo6.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo7.transform.position= new Vector3(5.17f,1,138.8f);
    Birillo7.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo8.transform.position= new Vector3(-0.309f,1,136.32f);
    Birillo8.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo9.transform.position= new Vector3(3.36f,1,136.32f);
    Birillo9.transform.rotation  = Quaternion.Euler(0, 0, 0);
    Birillo10.transform.position= new Vector3(1.53f,1,134.19f);
    Birillo10.transform.rotation  = Quaternion.Euler(0, 0, 0);
    palla.transform.position= new Vector3(1.5f,10,33.2f);
    Birillo1.GetComponent<Rigidbody>().isKinematic=false;
    Birillo2.GetComponent<Rigidbody>().isKinematic=false;
    Birillo3.GetComponent<Rigidbody>().isKinematic=false;
    Birillo4.GetComponent<Rigidbody>().isKinematic=false;
    Birillo5.GetComponent<Rigidbody>().isKinematic=false;
    Birillo6.GetComponent<Rigidbody>().isKinematic=false;
    Birillo7.GetComponent<Rigidbody>().isKinematic=false;
    Birillo8.GetComponent<Rigidbody>().isKinematic=false;
    Birillo9.GetComponent<Rigidbody>().isKinematic=false;
    Birillo10.GetComponent<Rigidbody>().isKinematic=false;
    Birillo1.GetComponent<Changedposition>().enabled=true;
    Birillo2.GetComponent<Changedposition>().enabled=true;
    Birillo3.GetComponent<Changedposition>().enabled=true;
    Birillo4.GetComponent<Changedposition>().enabled=true;
    Birillo5.GetComponent<Changedposition>().enabled=true;
    Birillo6.GetComponent<Changedposition>().enabled=true;
    Birillo7.GetComponent<Changedposition>().enabled=true;
    Birillo8.GetComponent<Changedposition>().enabled=true;
    Birillo9.GetComponent<Changedposition>().enabled=true;
    Birillo10.GetComponent<Changedposition>().enabled=true;

    main.BowlingSound.Stop();
    DestraSinistra.enabled =true;
    main.scatola.SetActive(false);
    main.S_Background.Play();
    if(main.countAD>=main.conteggioAds){
main.countAD=0;
main.MostraTracking();
main.ShowAd();
       
}
}
}
