using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMemory : MonoBehaviour
{


public int scoperte;
public static bool DO_NOT=false;
[SerializeField]
public int _state;
[SerializeField]
public int _cardValue;
[SerializeField]
public bool _initialized =false;

private Sprite _cardBack;
private Sprite _cardFace;
private GameObject _manager;
public AudioSource flippato;
public AudioSource ft;


    void Start()
    {
        _state =1;
        _manager = GameObject.FindGameObjectWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        if(scoperte==2){
            scoperte=0;
        }
    }
public void setupGraphics(){
    _cardBack = _manager.GetComponent<GameManager>().getCardBack();
     _cardFace = _manager.GetComponent<GameManager>().getCardFace(_cardValue);

     flipCard();
}

    public void flipCard(){
        if(_state == 0)
        _state=1;
        else if(_state ==1)
        _state=0;
       if(_state==0 && !DO_NOT){
       GetComponent<Image>().sprite=_cardBack;
       
       }
       else if (_state ==1 && !DO_NOT){
       GetComponent<Image>().sprite =_cardFace;
       flippato.Play();
       }
        
    }
    public int cardValue {
        get{return _cardValue;}
        set {_cardValue = value;}
    }

    public int state {
        get{return _state;}
        set {_state = value;}
    }

    public bool initialized{
        get {return _initialized;}
        set {_initialized=value;}
    }

    public void falseCheck(){
        StartCoroutine(pause());
    }

    IEnumerator pause(){
        yield return new WaitForSeconds(1);
        if(_state ==0){
        GetComponent<Image>().sprite = _cardBack;
        ft.Play();
        }
        else if (_state == 1)
        GetComponent<Image>().sprite =_cardFace;
        DO_NOT=false;
    }
}
