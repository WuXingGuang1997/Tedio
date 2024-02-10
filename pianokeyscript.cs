using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pianokeyscript : MonoBehaviour
{
    public AudioSource A_nota;// Start is called before the first frame update
    public float semitone_offset =0;
    public main main;
    public pianokeyscript tasto1;
    public pianokeyscript tasto2;
    public pianokeyscript tasto3;
    public pianokeyscript tasto4;
    public pianokeyscript tasto5;
    public pianokeyscript tasto6;
    public pianokeyscript tasto7;
    public pianokeyscript tasto8;
    public pianokeyscript tasto9;
    public pianokeyscript tasto10;
    public pianokeyscript tasto11;
    public pianokeyscript tasto12;
    public pianokeyscript tasto13;
    public pianokeyscript tasto14;
    public pianokeyscript tasto15;
    public Image  La;
    public Image Do2;
    public Image Re2;
    public Image Mi2;
    public Image Sol2;
    public Image La2;
    public bool repeat=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void suona(){
        
      if(gameObject.GetComponent<Image>().color.r==0 && gameObject.GetComponent<Image>().color.g==1 && gameObject.GetComponent<Image>().color.b==0){
        //repeat=false;
        main.CountNote+=1;
        A_nota.pitch = Mathf.Pow(2f,semitone_offset/12f);
        A_nota.Play();
       
      }
      else{
       A_nota.pitch = Mathf.Pow(2f,semitone_offset/12f);
        A_nota.Play();
        main.CountNote=1;
    La.color = new Color (0,1,0,1);
    Do2.color = new Color (1,1,1,1);
    Re2.color = new Color (1,1,1,1);
    Mi2.color = new Color (1,1,1,1);
    Sol2.color = new Color (1,1,1,1);
    La2.color = new Color (1,1,1,1);
       }   //  main.CountNote=0;
        
    }
}
