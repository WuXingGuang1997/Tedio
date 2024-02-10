using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Changedposition : MonoBehaviour
{public GameObject P_Bowling;
    Vector3 lastPos;
    public Text strike;
    public GameObject Indietro;
    public DistruggiPalla DistruggiPalla;
  // drag the object to monitor here
 float threshold = 0.5f; // minimum displacement to recognize a 
 
 void Start(){
   lastPos = transform.position;
   PlayerPrefs.SetInt("CountBirillo",0);

 }
 
 void Update(){
    if (DistruggiPalla.GameOver==true){
   Vector3 offset = transform.position - lastPos;
   if (offset.x > threshold){
     lastPos = transform.position;
    PlayerPrefs.SetInt("CountBirillo",PlayerPrefs.GetInt("CountBirillo")+1);
    Debug.Log(PlayerPrefs.GetInt("CountBirillo"));
    
    
    gameObject.GetComponent<Changedposition>().enabled=false;

   }
   else
   if (offset.x < -threshold){
     lastPos = transform.position; 
PlayerPrefs.SetInt("CountBirillo",PlayerPrefs.GetInt("CountBirillo")+1);
Debug.Log(PlayerPrefs.GetInt("CountBirillo"));
gameObject.GetComponent<Changedposition>().enabled=false;
   }
 }
 }
}
