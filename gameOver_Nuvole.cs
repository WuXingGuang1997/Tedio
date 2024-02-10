using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver_Nuvole : MonoBehaviour
{
    public GameObject Panel_Principale;
    public GameObject P_Game_Nuvola_2;
    public GameObject P_Game_Nuvola;
    public GameObject P_FineGame;
    public Text T_FineNuvola;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }


     void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "Goku")
       {
        P_Game_Nuvola.SetActive(false);
        P_FineGame.SetActive(true);
        P_Game_Nuvola_2.SetActive(false);
        T_FineNuvola.text="Hai perso, riprova!";
       }
       if(col.gameObject.name == "Nuvola(Clone)")
       {
            Destroy(col.gameObject);
       }
    }

    public void Indietro_P_FineNuvola(){
         P_FineGame.SetActive(false);
         Panel_Principale.SetActive(true);
    }
}
