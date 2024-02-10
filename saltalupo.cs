using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltalupo : MonoBehaviour
{
   public main main;
    public GameObject P_SaltaLupo;
 public GameObject P_GameOver;
 public GameObject scatola;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Open_P_SaltaLupo()
    {
        P_SaltaLupo.SetActive(true);
    }
      public  void Indietro_P_SaltaLupo()
    {
        main.P_Random.SetActive(true);
        P_SaltaLupo.SetActive(false);
        P_GameOver.SetActive(false);
        scatola.SetActive(false);
        if(main.countAD>=main.conteggioAds){
main.countAD=0;
main.MostraTracking();
main.ShowAd();
       
}
    }
}
