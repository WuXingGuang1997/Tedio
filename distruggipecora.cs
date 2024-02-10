using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class distruggipecora : MonoBehaviour
{
    public main main;
    public saltalupo saltalupo;
    public GameObject P_GameOver;
      public GameObject Pecora;
      public Transform myCanvas;
      public Text T_saltalupo;
     public int countPecore;
     public AudioSource Bee;
     public GameObject scatola;
     public timer10 timer10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D (Collision2D col)
     {
       if(col.gameObject.name == "Pecora(Clone)"){
            Destroy(col.gameObject);
            Bee.Play();
              countPecore+=1;
        if (countPecore>=10){
            P_GameOver.SetActive(true);
            saltalupo.P_SaltaLupo.SetActive(false);
            T_saltalupo.text="Bravo!\nHai ottenuto 15 punti!";
            main.soldi+=15;
                  main.aggiornaSoldi();
                  main.T_Soldi.text="Punti: "+main.soldi.ToString();
            //StartCoroutine(main.LateGetPuntiSaltaLupo(0.1f));
            countPecore=0;
            
        }
          
            GameObject myNewSmoke = Instantiate (Pecora, new Vector3(Screen.width,-1017,0) , Quaternion.identity);
            myNewSmoke.transform.SetParent(myCanvas);
            myNewSmoke.transform.localScale =new Vector3(1,1,1);
       }
    }
}
