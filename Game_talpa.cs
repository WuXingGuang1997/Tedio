using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_talpa : MonoBehaviour
{
    public GameObject P_Game_Talpa;

public GameObject P_HaiVinto;
    public main main;
public int talpa;
public bool bool_Talpa=false;
public float timer;
public float velocity=2f;
public bool talpagiu=true;
public int talpacount;
public Image talpastunn;
public Image talpanormale;
public AudioSource didu;
public AudioSource dish;
public AudioSource disheun;
public void P_Talpa(){
    
    P_Game_Talpa.SetActive(true);
    bool_Talpa=true;

}
public void Indietro_P_Talpa(){
    main.P_Random.SetActive(true);
    P_Game_Talpa.SetActive(false);
    bool_Talpa=false;
    P_HaiVinto.SetActive(false);
    main.scatola.SetActive(false);
    if(main.countAD>=main.conteggioAds){
main.countAD=0;
main.MostraTracking();
main.ShowAd();
       
}
}
public void Talpa(){


}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bool_Talpa){
            if(timer<Time.time){
                if(talpagiu){
    talpa=Random.Range(1,10);
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().enabled=true;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Button>().enabled=true;
    didu.Play();
    timer=Time.time+velocity;
    talpagiu=false;}
    else if(talpagiu==false){
   
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().sprite=talpanormale.sprite;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().enabled=false;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Button>().enabled=false;
    timer=Time.time+velocity;
    talpagiu=true;}
            }
        }
        
    }
    public void colpito(){
        if(talpacount<9){
     GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().sprite=talpastunn.sprite;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Button>().enabled=false;
    timer=Time.time+1;
    talpacount+=1;
    }
    else{
        GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().sprite=talpanormale.sprite;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Image>().enabled=false;
    GameObject.FindWithTag("Talpa"+talpa).GetComponent<Button>().enabled=false;
   // StartCoroutine(main.LateGetPuntiTalpa(0.1f));
       talpagiu=true;
        P_HaiVinto.SetActive(true);
        bool_Talpa=false;
        talpacount=0;
        main.soldi+=15;
                  main.aggiornaSoldi();
                  main.T_Soldi.text="Punti: "+main.soldi.ToString();
       //main.scatola.SetActive(true);
      // main.timer10.xButton();
    }
    disheun.Play();
    }
    public void dishPlay(){
        dish.Play();
    }

}
