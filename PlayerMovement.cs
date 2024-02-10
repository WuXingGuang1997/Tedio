using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{  
    public main main;
    public gameOver_Nuvole gameOver_Nuvole;
    public float speed = 5f; // velocità del movimento del personaggio
    public Button rightButton; // riferimento al bottone per il movimento a destra
    public Button leftButton; // riferimento al bottone per il movimento a sinistra
    public float x;
    float timer;
   public  bool finegioco;
public float timer2;
public Text T_CountDown;
    void Start()
    {  //speed = 100f;
       finegioco=false;
        timer2=60;
         
    }
    void Update(){
        if (timer<Time.time && finegioco==false){

            timer=Time.time+0.01f;
            timer2=timer2-0.03f;
    T_CountDown.text=timer2.ToString("F2");
            if(timer2<=0){
                finegioco=true;
                gameOver_Nuvole.P_Game_Nuvola_2.SetActive(false);
                gameOver_Nuvole.P_Game_Nuvola.SetActive(false);
                gameOver_Nuvole.T_FineNuvola.text="Hai vinto 100 punti!";
                gameOver_Nuvole.P_FineGame.SetActive(true);
                main.soldi+=100;
                main.aggiornaSoldi();
                main.T_Soldi.text="Punti: "+main.soldi.ToString();
            }
    }
    }

    public void MoveRight()
    {
        // sposta il personaggio verso destra
        x=gameObject.transform.localPosition.x+100;
        gameObject.transform.localPosition=new Vector2(x,gameObject.transform.localPosition.y);
    }

    public void MoveLeft()
    {
        // sposta il personaggio verso sinistra
       x=gameObject.transform.localPosition.x-100;
        gameObject.transform.localPosition=new Vector2(x,gameObject.transform.localPosition.y);
    }
}
