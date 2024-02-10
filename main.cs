using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using Firebase.Auth;
using Firebase;
using System.IO;
using Firebase.Database;
using Firebase.Extensions;
using System;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;
//using GoogleMobileAds.Api;
//using Firebase.Unity.Editor;
#if UNITY_IOS

// Include the IosSupport namespace if running on iOS:
using Unity.Advertisement.IosSupport;
using UnityEngine.iOS;
#endif

using UnityEngine.Advertisements;
public class main : MonoBehaviour,IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public GameObject Sgancia;
    public DistruggiPalla DistruggiPalla;
    public Text T_Bowling;
    public GameObject Birillo;
    public GameObject Birillo1;
    public GameObject Birillo2;
    public GameObject Birillo3;
    public GameObject Birillo4;
    public GameObject Birillo5;
    public GameObject Birillo6;
    public GameObject Birillo7;
    public GameObject Birillo8;
    public GameObject Birillo9;

    public AudioSource BowlingSound;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject P_Piano;
    public GameObject P_Principale;
    public GameObject P_BQ;
    public Text T_BQ;
    public GameObject P_Q;
    public Text T_Q1;
    public Text T_Q2;
    public Text T_Q3;
     public Text T_Q4;
    public Text T_Tedio;
    public bool Q1;
    public bool Q2;
    public bool Q3;
    public bool Q4;
    public float PuntiQ;
    public int AmiciQ;
    public int DataCurrent;
    public int QCompletati;
    public Button B_Q1;
    public Button B_Q2;
    public Button B_Q3;
    public Button B_Q4;
public int DataAdesso=0;

    public GameObject P_Tedio;
    public float Timer2;
    public timer10 timer10;
    public Text T_Video;
    public Button B_Video;
    public Text  P_T_Scatola; 
    public GameObject P_Scatola;
    public GameObject scatola;
    public string randomP;
    public Image BarraExpBianca;
    public GameObject P_ITuoiBuoni;
 public float NumeroBuoni050;
  public float NumeroBuoni1;
   public float NumeroBuoni5;
    public float NumeroBuoni10;
     public float NumeroBuoni20;
      public float NumeroBuoni50;
 public string CodiceAmazon050uid;
 public string CodiceAmazon1uid;
 public string CodiceAmazon5uid;
 public string CodiceAmazon10uid;
 public string CodiceAmazon20uid;
 public string CodiceAmazon50uid;
    public Text T_MyCoupon;
public Button B_T_X;
    public Text T_X;
     public bool caricamentoX=true;
   public int countConsigliati=6;
    public GameObject P_ConsigliatiAmazon;
    public Button Oggetto1;
    public Button Oggetto2;
    public Text T_CodiceEseguito;
    public GameObject P_ScambioEffettuato;
public float count050;
public string CodeAmazon050;
public float count1;
public string CodeAmazon1;
public float count5;
public string CodeAmazon5;
public float count10;
public string CodeAmazon10;
public float count20;
public string CodeAmazon20;
public float count50;
public string CodeAmazon50;
public InputField I_CodeAmazon;
public Button scambia_1;
public Button scambia_2;
public Button scambia_3;
public Button scambia_4;
public Button scambia_5;
public Button scambia_6;
public GameObject P_Premi;
string secString;
 string minString;
 public int TimerMinuti;
public  int TimerSecondi;
public int TimerH;
 public Text TimerButton;
  public bool AttivaTimer=true;
public int ora;
public int oraM;
public int oraH;
public int dopo;
public int dopoH;
public int dopoM;
 [SerializeField] Button _showAdButton;
[SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _iOSAdUnitId = "Rewarded_iOS";
    [SerializeField] string _androidGameId="5076459";
    [SerializeField] string _iOSGameId="5076458";
     private string _gameId;
     string _adUnitId;
   public GameObject P_TeC; 
   public GameObject P_Pp; 
    public Toggle TeC;
    public Toggle Pp;
    public string TestoDiConfronto;
    public bool aumentaExp=false;
    public float puntiAmico=0;
    public int AmiciCountDellAmico;
    public bool codiceEsistente=false;
    public int i=0;
public long AmiciCount;
    public bool BoolButtonAmiciCode=true;
    public Text T_Amici;
    public Text T_NameOfFriends;
    public string stringa;
    public GameObject P_FriendCode;
    public GameObject P_FriendsList;
    public Button buttonAmiciCode;
    public string uid;
    public int conteggioExp=0;
    public int conteggioExpDellAmico=0;

    string ErrorBlockString;
    int counter;
    int aggiungiSecondi=0;
        int TimeBlock;
        float oneSec;

    public delegate void MethodToCall (string[] input);
    Firebase.Auth.FirebaseUser user;
    DatabaseReference reference;
    public string NameOfStronger;
    public int numberTotalOfPeople;
    public int numberTotalOfPeopleOnline;
    public int TheMostNumberOfFriends;
   public int HighScore;
   public GameObject PannelloVerify;
   public Text T_Verify;
   public InputField I_codeFriends;
     [Header("Firebase")]
   public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;    
    public FirebaseUser User;
     string password="";
     string repeatPw="";
     public string[] nameOfFriends;
     public Button myFriendsButtonCode;
     public InputField I_R_Username;
     public InputField I_R_Email;
     public InputField I_R_Password;
     public InputField I_R_RepeatPw;
    public InputField I_L_Email;
    public InputField I_L_Password;
    public GameObject Login;
    public GameObject Register;
    public Image BarraExpBlu;
    public Text T_R_Error;
    public Text T_L_Error;
    public Text T_ErrorFriend;
    string Dati;
    string url;
    int count;
    public string Json;
    bool isPaused=false;
    public Text Title;
     public Text Title2;
     public Text T_livello;
     public Text T_Punti;
     public Text T_exp;
  public string username;
    public string email;
    public int level;
    public float ExpBar;
    public float ExpTot;
    public float punti;
public string ID;
public int MaxScores=1000;
public long numeroUtentiTotali;
public float timing;
public GameObject GameObject;
int ErrorCounting=0;
int TempoBloccato=1;
public string codiceAmico;
public string[] codiceNuovoAmico;
public class Utente {
    public string ID;
    public string username;
    public string email;
 public int level;
    public float ExpBar;
    public float ExpTot;
    public float punti;
    public long numeroUtentiTotali;
    public string codiceAmico;
    public bool muoviPunti=false;
public int conteggioAds;


    //public string gameId="5076458";
    bool testMode=false;
    

    public Utente() {
    }

    public Utente(string ID,string username, string email, int level, float ExpBar, float ExpTot, float punti , long numeroUtentiTotali, string codiceAmico) {
        this.ID=ID;
        this.username = username;
        this.email = email;
        this.level=level;
        this.ExpBar=ExpBar;
        this.ExpTot=ExpTot;
        this.punti=punti;
        this.numeroUtentiTotali=numeroUtentiTotali;
        this.codiceAmico=codiceAmico;
    }
    public Dictionary<string, object> ToDictionary() {
        Dictionary<string, object> result = new Dictionary<string, object>();
         result["ID"] = ID;
        result["username"] = username;
        result["email"] = email;
        result["level"] = level;
        result["ExpBar"] = ExpBar;
        result["ExpTot"] = ExpTot;
        result["punti"] = punti;
       result["numeroUtentiTotali"] = numeroUtentiTotali;
       result["codiceAmico"] = codiceAmico;
        return result;
    }
}

public class Globali {
   public string NameOfStronger;
    public int numberTotalOfPeople;
    public int numberTotalOfPeopleOnline;
    public int TheMostNumberOfFriends;
    public int HighScore;
    
    public Globali() {
    }

    public Globali(string NameOfStronger, int numberTotalOfPeople, 
    int numberTotalOfPeopleOnline, int TheMostNumberOfFriends, int HighScore) {
        this.NameOfStronger = NameOfStronger;
        this.numberTotalOfPeople = numberTotalOfPeople;
        this.numberTotalOfPeopleOnline=numberTotalOfPeopleOnline;
        this.TheMostNumberOfFriends=TheMostNumberOfFriends;
        this.HighScore=HighScore;
    }
    
}

public Globali Global;
public GameObject P_Game_Uovo;
public Image Egg;
public Sprite Egg_1;
public Sprite Egg_2;
public Sprite Egg_3;
public Sprite Egg_4;
public Sprite Egg_6;
public Sprite Egg_7;
public Sprite Egg_8;
public Sprite Egg_9;
public Image Half_Egg;
public float rotz;
public float timing2;
public bool rotazione=false;
public GameObject Indietro_B_Game_Uovo;
public GameObject Gold;
public float y;
public bool muoviGold=false;
public Text T_PuntiUovo;
public GameObject T_puntiUovoGO;
public bool muoviPunti=false;
public int adscount;
public GameObject uovobright;
public bool Bool_uovo;
public AudioSource A_kr;
public AudioSource A_moneta;

public GameObject Moneta;
public bool MonetaGame=false;
public float timing3;
public int numeromonete=100;
public GameObject bag;
public Oncollision Oncollisions;
public Text T_Monete;
public GameObject B_IndietroGameMonete;
public GameObject P_MoneteGame;
public GameObject saccobright;
public int adscount2=3;
public bool Bool_monete;
float timering=1;
float r;
float g;
float b;
public Image Do;
public Image Re;
public Image Mi;
public Image Fa;
public Image Sol;
public Image La;
public Image Si;
public Image Do2;
public Image Re2;
public Image Mi2;
public Image Fa2;
public Image Sol2;
public Image La2;
public Image Si2;
public int  CountNote;
public Text T_Piano;

public Text T_Memory;
public float puntioffriends;
public GameManager GameManager; 
public Game_talpa Game_talpa;
public saltalupo saltalupo;
public GameObject P_Random;
public int countAD=0;
public int conteggioAds=10;
public Text T_Soldi;
public Text T_ID;
public int soldi;
public bool item1;
public string vendorID;
public GameObject P_Buy;
public GameObject P_NonHaiSoldi;
public GameObject P_VuoiAcquistareItem1;
public GameObject P_AcquistoEffettuato;
public GameObject I_Bag;
public Button SaccoNero;
public Text T_PuntiSaccoNero;
public GameObject P_Gioca;
public GameObject B_Gioca;
public string cambioID;
public GameObject P_AttivaTracciamento;
public AudioSource S_Background;
public GameObject negozio;
public GameObject P_GameNuvola;
public GameObject Goku;
public GameObject P_Game_Nuvola_2;

public bool item2;
public GameObject B_GameNuvola;
public Text T_PuntiGameNuvola;
public GameObject P_VuoiAcquistareItem2;
public Button GameNuvola;
public Button GameKugo;
public GameObject distruggiPecora;

public void RandomButton(){
countAD+=1;
int rand = Random.Range(0, 8);


switch (rand)
{
   case 0:
   resetUovo();
     B_P_Game_Uovo();
     break;
   case 1:
   resetMonete();
   Bool_monete=true;
     B_P_MoneteGame2();
     break;
   case 2:
   S_Background.Stop();
     P_Bowling();
     break;
     case 3:
     GameManager.P_AttivaMemory();
     break;
     case 4:
     P_PianoOpen();
     break;
     case 5:
    Game_talpa.P_Talpa();
    break;
    case 6:
saltalupo.Open_P_SaltaLupo();
distruggiPecora.SetActive(true);
    break;
    case 7:
    if(item2==true){
    distruggiPecora.SetActive(false);
    Open_P_Game_Nuvola();
    }
    else{
        countAD-=1;
        RandomButton();
    }
    break;
   default: break;
}
P_Random.SetActive(false);

}

public void Open_P_Game_Nuvola(){
    P_GameNuvola.SetActive(true);
    P_Game_Nuvola_2.SetActive(true);
    Goku.transform.localPosition= new Vector2(0,Screen.height/2);
    Goku.GetComponent<PlayerMovement>().timer2=60;
    Goku.GetComponent<PlayerMovement>().finegioco=false;
    distruggiPecora.SetActive(false);
}

public void continua(){
    P_AttivaTracciamento.SetActive(false);
    B_Gioca.SetActive(true);
    #if UNITY_IOS
    if(ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED) {
            ATTrackingStatusBinding.RequestAuthorizationTracking();
        }
    #endif
        
}


public void Open_P_Gioca(){
#if UNITY_ANDROID
cambioID=SystemInfo.deviceUniqueIdentifier;
//T_ID.text=(cambioID);
StartCoroutine(LateDatiDaDataBase(1f));
P_Gioca.SetActive(true);
B_Gioca.SetActive(false);
S_Background.Play();

#elif UNITY_IOS
cambioID=Device.advertisingIdentifier;
//T_ID.text=cambioID;
if (Device.advertisingIdentifier=="00000000-0000-0000-0000-000000000000")
{
    //P_AttivaTracciamento.SetActive(true);
    B_Gioca.SetActive(false);
    T_Soldi.enabled=false;
    negozio.SetActive(false);
    P_Gioca.SetActive(true);
}
else {
StartCoroutine(LateDatiDaDataBase(1f));
P_Gioca.SetActive(true);
B_Gioca.SetActive(false);
S_Background.Play();
}
#endif



}
public void Open_P_Buy(){
    
    P_Buy.SetActive(true);
}
public void Indietro_P_Buy(){
    P_Buy.SetActive(false);
    P_NonHaiSoldi.SetActive(false);
    P_VuoiAcquistareItem1.SetActive(false);


    P_AcquistoEffettuato.SetActive(false);
}
public void acquista_Item1(){
    if(soldi<200){
        P_NonHaiSoldi.SetActive(true);
        
    }
    else {
        P_VuoiAcquistareItem1.SetActive(true);
        
    }
}
public void acquista_Item2(){
    if(soldi<300){
        P_NonHaiSoldi.SetActive(true);
        
    }
    else {
        P_VuoiAcquistareItem2.SetActive(true);
        
    }
}
public void BSI_acquista_Item1(){
   soldi-=200;
   aggiornaSoldi();
   item1=true;
   aggiornaitem1();
   A_moneta.Play();
   if(item1==true){
    I_Bag.GetComponent<Image>().color =new Color(0,0,0,1);
   }
   T_PuntiSaccoNero.text="Acquistato";
    SaccoNero.interactable=false;
   T_Soldi.text="Punti: "+soldi.ToString();
   P_VuoiAcquistareItem1.SetActive(false);
   P_AcquistoEffettuato.SetActive(true);
}
public void BNO_acquista_Item1(){
   P_VuoiAcquistareItem1.SetActive(false);
}


public void BSI_acquista_Item2(){
   soldi-=300;
   aggiornaSoldi();
   item2=true;
   aggiornaitem2();
   A_moneta.Play();
   if(item2==true){
    //B_GameNuvola.SetActive(true);
                    
   }
   T_PuntiGameNuvola.text="Acquistato";
    GameNuvola.interactable=false;
    GameKugo.interactable=false;
   T_Soldi.text="Punti: "+soldi.ToString();
   P_VuoiAcquistareItem2.SetActive(false);
   P_AcquistoEffettuato.SetActive(true);
}
public void BNO_acquista_Item2(){
   P_VuoiAcquistareItem2.SetActive(false);
}
    void Start()

        {  

         

Debug.Log(cambioID);

            
            LoadAd();
            //T_ID.text=cambioID;
         conteggioAds=5;
            I_L_Email.text=PlayerPrefs.GetString("Email");
            I_L_Password.text=PlayerPrefs.GetString("Password");
            //BarraExpBianca.rectTransform.sizeDelta = new Vector2(100, Screen.height);
            ErrorCounting = PlayerPrefs.GetInt("ErrorCounting");
            TimeBlock = PlayerPrefs.GetInt("TimeBlock");
            counter = PlayerPrefs.GetInt("counter");
            ErrorBlockString = PlayerPrefs.GetString("ErrorBlockString");
            T_L_Error.text=ErrorBlockString;
            Register.SetActive(false);
            StartCoroutine(LateStart(1));
            
            codiceNuovoAmico=new string[1000];
            nameOfFriends=new string[1000];
            
         }

        IEnumerator LateDatiDaDataBase(float waitTime){
            yield return new WaitForSeconds(waitTime);
            StartCoroutine(GetID((string vendorID2)=>{
               vendorID=vendorID2;
               
            }));
            yield return new WaitForSeconds(waitTime);
            //Device.vendorIdentifier
            //cambioID
             
if (vendorID==cambioID ){
                
                StartCoroutine(GetSoldi((int soldi2)=>{
                    soldi=soldi2;
                    T_Soldi.text="Punti: "+soldi2.ToString();
                }));
                 yield return new WaitForSeconds(waitTime);
                StartCoroutine(GetItem1((bool item12)=>{
                    item1=item12;
                    if(item1==true){
                    I_Bag.GetComponent<Image>().color =new Color(0,0,0,1);
                    T_PuntiSaccoNero.text="Acquistato";
                    SaccoNero.interactable=false;
                    }
                }));
                yield return new WaitForSeconds(waitTime);
                StartCoroutine(GetItem2((bool item22)=>{
                    item2=item22;
                    if(item2==true){
                    //B_GameNuvola.SetActive(true);
                    T_PuntiGameNuvola.text="Acquistato";
                    GameNuvola.interactable=false;
                     GameKugo.interactable=false;
                    }
                }));
                 }
               else{
                aggiornaID();
               }
           
         }
public void changeNote(){
    if(La.color.r == 1 && La.color.g == 1 && La.color.b==1 && CountNote==1){
        La.color = new Color (0,1,0,1);
    }
    else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==2)
    {
         La.color = new Color (0,1,0,1);
    }
     else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==3)
    {
         La.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
          Debug.Log(CountNote);
    }
    else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==4)
    {
         Do2.color = new Color (1,1,1,1);
          Re2.color = new Color (0,1,0,1);
          Debug.Log(CountNote);
    }
       else if (Re2.color.r == 0 && Re2.color.g == 1 && Re2.color.b==0 && CountNote==5)
    {
         Re2.color = new Color (1,1,1,1);
          Mi2.color = new Color (0,1,0,1);
    }
           else if (Mi2.color.r == 0 && Mi2.color.g == 1 && Mi2.color.b==0 && CountNote==6)
    {
         Mi2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
               else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==7)
    {
         La2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
                   else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==8)
    {
         La2.color = new Color (1,1,1,1);
          Sol2.color = new Color (0,1,0,1);
    }
        else if (Sol2.color.r == 0 && Sol2.color.g == 1 && Sol2.color.b==0 && CountNote==9)
    {
         Sol2.color = new Color (1,1,1,1);
          Mi2.color = new Color (0,1,0,1);
    }
         else if (Mi2.color.r == 0 && Mi2.color.g == 1 && Mi2.color.b==0 && CountNote==10)
    {
         Mi2.color = new Color (1,1,1,1);
          Re2.color = new Color (0,1,0,1);
    }
             else if (Re2.color.r == 0 && Re2.color.g == 1 && Re2.color.b==0 && CountNote==11)
    {
         Re2.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
    }
     else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==12)
    {
         Do2.color = new Color (1,1,1,1);
          La.color = new Color (0,1,0,1);
    }
         else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==13)
    {
         La.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
    }
     else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==14)
    {
         Do2.color = new Color (1,1,1,1);
          Re2.color = new Color (0,1,0,1);
    }
      else if (Re2.color.r == 0 && Re2.color.g == 1 && Re2.color.b==0 && CountNote==15)
    {
         Re2.color = new Color (1,1,1,1);
          Mi2.color = new Color (0,1,0,1);
    }
       else if (Mi2.color.r == 0 && Mi2.color.g == 1 && Mi2.color.b==0 && CountNote==16)
    {
         Mi2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
         else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==17)
    {
         La2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
          else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==18)
    {
         La2.color = new Color (1,1,1,1);
          Sol2.color = new Color (0,1,0,1);
    }

   else  if(La.color.r == 1 && La.color.g == 1 && La.color.b==1 && CountNote==19){
       Sol2.color = new Color (1,1,1,1);
        La.color = new Color (0,1,0,1);
    }
    else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==20)
    {
         La.color = new Color (0,1,0,1);
    }
     else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==21)
    {
         La.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
          Debug.Log(CountNote);
    }
    else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==22)
    {
         Do2.color = new Color (1,1,1,1);
          Re2.color = new Color (0,1,0,1);
          Debug.Log(CountNote);
    }
       else if (Re2.color.r == 0 && Re2.color.g == 1 && Re2.color.b==0 && CountNote==23)
    {
         Re2.color = new Color (1,1,1,1);
          Mi2.color = new Color (0,1,0,1);
    }
           else if (Mi2.color.r == 0 && Mi2.color.g == 1 && Mi2.color.b==0 && CountNote==24)
    {
         Mi2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
               else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==25)
    {
         La2.color = new Color (1,1,1,1);
          La2.color = new Color (0,1,0,1);
    }
                   else if (La2.color.r == 0 && La2.color.g == 1 && La2.color.b==0 && CountNote==26)
    {
         La2.color = new Color (1,1,1,1);
          Sol2.color = new Color (0,1,0,1);
    }
        else if (Sol2.color.r == 0 && Sol2.color.g == 1 && Sol2.color.b==0 && CountNote==27)
    {
         Sol2.color = new Color (1,1,1,1);
          Mi2.color = new Color (0,1,0,1);
    }
            else if (Mi2.color.r == 0 && Mi2.color.g == 1 && Mi2.color.b==0 && CountNote==28)
    {
         Mi2.color = new Color (1,1,1,1);
          Re2.color = new Color (0,1,0,1);
    }
    else if (Re2.color.r == 0 && Re2.color.g == 1 && Re2.color.b==0 && CountNote==29)
    {
         Re2.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
    }
        else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==30)
    {
         Do2.color = new Color (1,1,1,1);
          La.color = new Color (0,1,0,1);
    }
            else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==31)
    {
         La.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
    }
     else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==32)
    {
          Do2.color = new Color (0,1,0,1);
    }
    else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==33)
    {
         Do2.color = new Color (1,1,1,1);
          La.color = new Color (0,1,0,1);
    }
        else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==34)
    {
         La.color = new Color (1,1,1,1);
          Do2.color = new Color (0,1,0,1);
    }
            else if (Do2.color.r == 0 && Do2.color.g == 1 && Do2.color.b==0 && CountNote==35)
    {
         Do2.color = new Color (1,1,1,1);
          La.color = new Color (0,1,0,1);
    }

else if (La.color.r == 0 && La.color.g == 1 && La.color.b==0 && CountNote==36)
    {
         La.color = new Color (1,1,1,1);
                    soldi+=35;
                  aggiornaSoldi();
                  T_Soldi.text="Punti: "+soldi.ToString();
        // StartCoroutine(LateGetPuntiPiano(0.1f));
    T_Piano.text="Bravo! Hai ottenuto 35 punti!";
         // CountNote=0;
    }

}

public void P_Bowling(){
    Sgancia.SetActive(true);
     DistruggiPalla.GameOver=false;
    P_Principale.SetActive(false);
    Camera2.SetActive(true);
    BowlingSound.Play();
    PlayerPrefs.SetInt("CountBirillo",0);
    Birillo.GetComponent<Changedposition>().enabled=true;
    Birillo1.GetComponent<Changedposition>().enabled=true;
    Birillo2.GetComponent<Changedposition>().enabled=true;
    Birillo3.GetComponent<Changedposition>().enabled=true;
   Birillo4.GetComponent<Changedposition>().enabled=true;
    Birillo5.GetComponent<Changedposition>().enabled=true;
    Birillo6.GetComponent<Changedposition>().enabled=true;
    Birillo7.GetComponent<Changedposition>().enabled=true;
    Birillo8.GetComponent<Changedposition>().enabled=true;
    Birillo9.GetComponent<Changedposition>().enabled=true;
    
}
public void P_PianoOpen(){
  
    P_Piano.SetActive(true);
    CountNote=1;
    T_Piano.text="";
    La.color = new Color (0,1,0,1);
    Do2.color = new Color (1,1,1,1);
    Re2.color = new Color (1,1,1,1);
    Mi2.color = new Color (1,1,1,1);
    Sol2.color = new Color (1,1,1,1);
    La2.color = new Color (1,1,1,1);
}
public void Indietro_P_PianoOpen(){
    P_Piano.SetActive(false);
    P_Random.SetActive(true);
    if(countAD>=conteggioAds){
countAD=0;
MostraTracking();
}


}
public void MostraTracking(){
  //  #if UNITY_IOS
                 //Procedendo acconsenti la raccolta dell'informazione riguardo l'ID del dispositivo per salvare i punteggi sul database.
        // Check the user's consent status.
        // If the status is undetermined, display the request request:
  //      if(ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED) {
   //         ATTrackingStatusBinding.RequestAuthorizationTracking();
   //     }
      
//#endif
} 
public void fineMonete(){
numeromonete=0;
Oncollisions.MoneteCounting=0;
T_Monete.enabled=false;
MonetaGame=false;
B_IndietroGameMonete.SetActive(true);
saccobright.GetComponent<ChangeBright>().enabled =false;
}
public void resetMonete(){
    timering=1;
T_Monete.enabled=false;
numeromonete=100;
B_IndietroGameMonete.SetActive(true);
Oncollisions.MoneteCounting=0;
 saccobright.GetComponent<ChangeBright>().enabled =true;

}
public void B_P_MoneteGame2(){
 P_MoneteGame.SetActive(true);
 MonetaGame=true;
 saccobright.GetComponent<ChangeBright>().enabled =false;
 
}
public void Indietro_B_P_MoneteGame(){
 P_MoneteGame.SetActive(false);
 T_Monete.enabled=false;
 saccobright.GetComponent<Image>().color=new Color(0,0,0,0);
 P_Random.SetActive(true);
 Bool_monete=false;
 if(countAD>=conteggioAds){
 MostraTracking();
countAD=0;
ShowAd();
}
}
public void B_P_Game_Uovo(){
    P_Game_Uovo.SetActive(true);
}
public void Indietro_B_P_Game_Uovo(){
    P_Game_Uovo.SetActive(false);
     P_Random.SetActive(true);
     if(countAD>=conteggioAds){
countAD=0;
MostraTracking();
ShowAd();
}
}
public void resetUovo(){
    rotazione=false;
    muoviGold=false;
    muoviPunti=false;
    Egg.enabled=true;
    Egg.sprite = Egg_1;
    rotz=0;
    Half_Egg.transform.rotation  = Quaternion.Euler(0, 0, rotz);
    y=235;
     T_puntiUovoGO.transform.localPosition=new Vector2(0,y);
     y=-85;
    Gold.transform.localPosition=new Vector2(0,y);
    Indietro_B_Game_Uovo.SetActive(false);
}
public void fineUovo(){
     rotazione=false;
    muoviGold=false;
    muoviPunti=false;
    Egg.enabled=false;
    Egg.sprite = Egg_1;
    rotz=180;
    Half_Egg.transform.rotation  = Quaternion.Euler(0, 0, rotz);
    y=235;
     T_puntiUovoGO.transform.localPosition=new Vector2(0,y);
     T_puntiUovoGO.SetActive(false);
     y=-85;
    Gold.transform.localPosition=new Vector2(0,y);
    Gold.SetActive(false);
    Indietro_B_Game_Uovo.SetActive(true);
}

public void Game_Uovo(){
    if (Egg.sprite==Egg_1)
    {Egg.sprite = Egg_2;}
    else if (Egg.sprite==Egg_2)
    {Egg.sprite = Egg_3; }
    else if (Egg.sprite==Egg_3)
    {Egg.sprite = Egg_4; }
    else if (Egg.sprite==Egg_4)
    {Egg.sprite = Egg_6; }
    else if (Egg.sprite==Egg_6)
    {Egg.sprite = Egg_7; }
    else if (Egg.sprite==Egg_7)
    {Egg.sprite = Egg_8; }
    else if (Egg.sprite==Egg_8)
    {Egg.sprite = Egg_9; }
    else if (Egg.sprite==Egg_9)
    {
        Egg.enabled=false;
        rotazione=true;
        
    }
    A_kr.Play();

}

public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }
 
    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }
 public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
    }
 
    // If the ad successfully loads, add a listener to the button and enable it:
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Ad Loaded: " + adUnitId);
 
        if (adUnitId.Equals(_adUnitId))
        {
            // Configure the button to call the ShowAd() method when clicked:
           // _showAdButton.onClick.AddListener(ShowAd);
            // Enable the button for users to click:
           // _showAdButton.interactable = true;
        }
    }
 
    // Implement a method to execute when the user clicks the button:
    public void ShowAd()
    {
        //StartCoroutine(LateAggiornaDopo(0.1f));
        // Disable the button:
       // _showAdButton.interactable = false;
        // Then show the ad:
        Advertisement.Show(_adUnitId, this);

        
    }


 IEnumerator LateGetPuntiPiano(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = Mathf.Round(Random.Range(0.1f, 0.2f)*10f)/10f;
                        T_Piano.text="Bravo! Ora sei un pianista!";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }
 IEnumerator LateGetPuntiTedio(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = Mathf.Round(Random.Range(0.3f, 1.0f)*10f)/10f;
                        T_Tedio.text=number.ToString("F1")+" ";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }
   public IEnumerator LateGetPuntiSaltaLupo(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = 0.1f;
                       
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }
   public IEnumerator LateGetPuntiMemory(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = Mathf.Round(Random.Range(0.1f, 0.2f)*10f)/10f;
                        T_Memory.text="Hai vinto "+number.ToString("F1")+" punti!";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }
public IEnumerator LateGetPuntiTalpa(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number =0.1f;
                        T_Tedio.text=number.ToString("F1")+" ";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }
public IEnumerator LateGetPuntiBowling(float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = 0.1f;
                        T_Bowling.text="Hai buttato giù tutti i birilli!";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
                        
    }

    IEnumerator LateGetPuntiUovo(float waitTime)
    {
       
                        
       yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
            PuntiQ=PuntiQ2;
        }));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        float number = Mathf.Round(Random.Range(0.3f, 1f)*10f)/10f;
                        soldi+=10;
                        aggiornaSoldi();
                         T_Soldi.text="Punti: "+soldi.ToString();
                        T_PuntiUovo.text="10 punti";
                        punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+punti.ToString("F1");

                        PuntiQ+=float.Parse(number.ToString("F1"));
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                        }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
    }
    // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {   
            


            /* Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
            
            StartCoroutine(lategetDataCurrent(0.1f));
            P_Tedio.SetActive(true);
            StartCoroutine(LateGetPuntiTedio(0.1f));
            TimerMinuti=59;
            TimerSecondi=59;
            AttivaTimer=true;

            if(TimerSecondi<10){
                secString="0"+TimerSecondi.ToString();
            }else{
                secString=TimerSecondi.ToString();
            }
            if(TimerMinuti<10){
                minString="0"+TimerMinuti.ToString();
            }else{
                minString=TimerMinuti.ToString();
            }
            TimerButton.text=minString+":"+secString;
 */
          // StartCoroutine(LateGetPunti(0.1f));
            // Load another ad:
            LoadAd();

          /*  adscount+=1;
            aggiornaAdsCount();
            adscount2-=1;
            aggiornaAdsCount2();

            if(adscount2<=0){
             resetMonete();
             Bool_monete=true;

             aggiornaAdsCount2();
             aggiornaMonete();
            }
            aggiornaAdsCount();
            
            if(adscount>=3){
                resetUovo();
                Bool_uovo=true;
                aggiornaUovo();
                uovobright.GetComponent<ChangeBright>().enabled=true;
                aggiornaAdsCount();
            }*/
          //  Advertisement.Load(_adUnitId, this);
            
        }
    }

public void Indietro_P_Tedio(){
    P_Tedio.SetActive(false);
}
  public  IEnumerator LateAggiornaOra(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequests("https://www.arduinoxing.it/Request/times.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestm("https://www.arduinoxing.it/Request/timem.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequesth("https://www.arduinoxing.it/Request/timeh.php"));
    yield return new WaitForSeconds(waitTime);
    aggiornaOra();
    yield return new WaitForSeconds(waitTime);
    aggiornaOraM();
    yield return new WaitForSeconds(waitTime);
    aggiornaOraH();
 yield return new WaitForSeconds(waitTime);
if((oraH-dopoH)==1 && dopoM<=oraM){
                        //17 18
                       
                            //45 45
                            
                                //30 30
                                LoadAd();
                                Debug.Log("1");
                            AttivaTimer=false;
                            _showAdButton.interactable = true;
                            TimerButton.text="";
                        
                    }                  
                    else if((oraH-dopoH)>1){
                        //    12   23 
                        LoadAd();
                       AttivaTimer=false;
                       _showAdButton.interactable = true;
                            TimerButton.text="";
                        Debug.Log("2");
                    }
                    else if ((oraH-dopoH)<0){
                        //23 10
                        LoadAd();
                        AttivaTimer=false;
                        _showAdButton.interactable = true;
                            TimerButton.text="";
                        Debug.Log("3");
                        /////////////ATTIVA BUTTON/////////
                    }
                   
                    else{
                        if((oraM-dopoM)>=0){
                            //54   54
                            if((ora-dopo)>=0){
                            //23   24
                            TimerMinuti=59-(oraM-dopoM);
                            TimerSecondi=59-(ora-dopo);
                            AttivaTimer=true;
                          //  _showAdButton.interactable = false;
                            Debug.Log("9");
                            }
                            else if ((ora-dopo)<0){
                                TimerMinuti=60-(oraM-dopoM);
                            TimerSecondi=60-(59+(ora-dopo));
                            AttivaTimer=true;
                        //    _showAdButton.interactable = false;
                            }
                            
                        }
                        if ((oraM-dopoM)<0){
                            //54 53
                            TimerMinuti=60-(59+(oraM-dopoM));
                            if((ora-dopo)<0){
                               // 55 54
                            TimerSecondi=60-(59+(ora-dopo));
                            Debug.Log("8");
                            AttivaTimer=true;
                          //  _showAdButton.interactable = false;
                            }
                            else if ((ora-dopo)>=0)
                            {//55 58
                                TimerSecondi=59-(ora-dopo);
                                AttivaTimer=true;
                                Debug.Log("7");
                          //      _showAdButton.interactable = false;
                            }
                        }
                    }
                                    
                                    
    }



    
        IEnumerator LateAggiornaDopo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopos("https://www.arduinoxing.it/Request/times.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopom("https://www.arduinoxing.it/Request/timem.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopoh("https://www.arduinoxing.it/Request/timeh.php"));
    yield return new WaitForSeconds(waitTime);
    aggiornaDopo();
    yield return new WaitForSeconds(waitTime);
    aggiornaDopoM();
    yield return new WaitForSeconds(waitTime);
    aggiornaDopoH();

    }

   
      IEnumerator LateGetPuntiVideo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                       
                        punti=punti2;
                        float number = Random.Range(0.5f, 1.5f);
                        punti+=float.Parse(number.ToString("F1"));
                        T_Video.text=number.ToString("F1")+" ";
                         T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
    }
    IEnumerator LateGetPunti(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                        
                        punti=punti2;
                        T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
    }
 
    // Implement Load and Show Listener error callbacks:
    public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }
 
    public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
        // Use the error details to determine whether to try to load another ad.
    }
 
    public void OnUnityAdsShowStart(string adUnitId) { }
    public void OnUnityAdsShowClick(string adUnitId) { }
 
    void OnDestroy()
    {
        // Clean up the button listeners:
        _showAdButton.onClick.RemoveAllListeners();
    }


    public void OpenSettings()
    {
        #if UNITY_IPHONE
            string url = MyNativeBindings.GetSettingsURL();
            Debug.Log("the settings url is:" + url);
            Application.OpenURL(url);
        #endif
    }

void Awake()
    {

        MetaData gdprMetaData = new MetaData("gdpr");
gdprMetaData.Set("consent", "false");
Advertisement.SetMetaData(gdprMetaData); 
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
        
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif


 #if UNITY_IOS
  if(ATTrackingStatusBinding.GetAuthorizationTrackingStatus() == ATTrackingStatusBinding.AuthorizationTrackingStatus.NOT_DETERMINED) {
 P_AttivaTracciamento.SetActive(true);
 }

                 //Procedendo acconsenti la raccolta dell'informazione riguardo l'ID del dispositivo per salvare i punteggi sul database.
        // Check the user's consent status.
        // If the status is undetermined, display the request request:
        
      
#endif


        //Disable the button until the ad is ready to show:
       // _showAdButton.interactable = false;
        InitializeAds();
        
        //Check that all of the necessary dependencies for Firebase are present on the system
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            dependencyStatus = task.Result;
            if (dependencyStatus == DependencyStatus.Available)
            {
                //If they are avalible Initialize Firebase
                InitializeFirebase();
            }
            else
            {
                Debug.LogError("Could not resolve all Firebase dependencies: " + dependencyStatus);
            }
        });
    }

public void InitializeAds(){
    #if UNITY_IOS
    _gameId = _iOSGameId;
     #elif UNITY_ANDROID
    _gameId= _androidGameId;
    #endif
     Advertisement.Initialize(_gameId,false,this);
}
    private void InitializeFirebase()
        {
            Debug.Log("Setting up Firebase Auth");
            //Set the authentication instance object
            auth = FirebaseAuth.DefaultInstance;
        }
 IEnumerator GetRequests(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                ora= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log(ora);
                    break;
            }
        }
    }
    IEnumerator GetRequestm(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                oraM= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( oraM);
                    break;
            }
        }
    }

    IEnumerator GetRequesth(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                oraH= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( oraH);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopos(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                dopo= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log(dopo);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopom(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                dopoM= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( dopoM);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopoh(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                dopoH= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( dopoH);
                    break;
            }
        }
    }
     IEnumerator GetRequestd(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
             
                DataCurrent=int.Parse(webRequest.downloadHandler.text);
                    Debug.Log(dopo);
                    break;
            }
        }
    }
public void GetDataCurrent(){

   StartCoroutine(Getd((int d)=>{
                    DataAdesso=d;
                    if(DataCurrent==DataAdesso)
                {
                    //SE LA DATA DEL CELL è UGUALE ALLA DATA DEL SERVER////////

                }else{
                    DataAdesso=DataCurrent;
                    Q1=true;
                    Q2=true;
                    Q3=true;
                    Q4=true;
                    B_Q1.interactable=false;
                    B_Q2.interactable=false;
                    B_Q3.interactable=false;
                    B_Q4.interactable=false;
                    PuntiQ=0;
                    AmiciQ=0;
                    QCompletati=0;
                    aggiornaQ1();
                    aggiornaQ2();
                    aggiornaQ3();
                    aggiornaQ4();
                    aggiornaPuntiQ();
                    aggiornaAmiciQ();
                    aggiornaQCompletati();
                    T_Q1.text="Ottenuti "+"0"+"/5";
                    T_Q2.text="Ottenuti "+"0"+"/10";
                    T_Q4.text="Completati "+QCompletati+"/3";
                    T_Q3.text="Invitati "+"0"+"/1";
                    aggiornaDataCurrent();
                }
   }
                ));
}
public void Entra_Q(){
    P_Q.SetActive(true);

}
public void Indietro_PBQ(){
    P_BQ.SetActive(false);
}
public void BQ1(){
    StartCoroutine(GetPunti((float punti2)=>{
                        punti=punti2;
                        punti+=1;
                        T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
                        QCompletati+=1;
                        aggiornaQCompletati();
                        StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        aggiornaPunti();
                        Q1=false;
                        B_Q1.interactable=Q1;
                        aggiornaQ1();
                        P_BQ.SetActive(true);
                        T_BQ.text= "1 ";
}
public void BQ2(){
    StartCoroutine(GetPunti((float punti2)=>{
                        punti=punti2;
                        punti+=2;
                        T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
                        QCompletati+=1;
                        aggiornaQCompletati();
                        StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        aggiornaPunti();
                        Q2=false;
                        B_Q2.interactable=Q2;
                        aggiornaQ2();
                        P_BQ.SetActive(true);
                        T_BQ.text= "2 ";
}
public void BQ3(){
    StartCoroutine(GetPunti((float punti2)=>{
                        punti=punti2;
                        punti+=5;
                        T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
                        QCompletati+=1;
                        aggiornaQCompletati();
                        StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        aggiornaPunti();
                        Q3=false;
                        B_Q3.interactable=Q3;
                        aggiornaQ3();
                        P_BQ.SetActive(true);
                        T_BQ.text= "5 ";
}
public void BQ4(){
    StartCoroutine(GetPunti((float punti2)=>{
                        punti=punti2;
                        float number = Mathf.Round(Random.Range(0.1f, 5f)*10f)/10f;
                        punti+=number;
                        T_Punti.text="Punti: "+punti.ToString("F1");
                        P_BQ.SetActive(true);
                        T_BQ.text= number.ToString()+" "; 
                        }));
                        aggiornaPunti();
                        Q4=false;
                        B_Q4.interactable=Q4;
                        aggiornaQ4();                
}

public void Indietro_Q(){
    P_Q.SetActive(false);

}

IEnumerator LateGetPuntiMonete(float waitTime){
 
                   
                    MonetaGame=false;
                    T_Monete.enabled=true;
                     B_IndietroGameMonete.SetActive(true);
                   Bool_monete=false;
                   aggiornaMonete();
                   adscount2=3;
                   aggiornaAdsCount2();
                punti+=(Oncollisions.MoneteCounting*0.01f);
                 T_Punti.text= "Punti: "+punti.ToString("F1");
                    T_Monete.text="Hai raccolto "+(Oncollisions.MoneteCounting)+" monete" ;
                   
                    PuntiQ+=(Oncollisions.MoneteCounting*0.01f);
                         if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                           
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                            
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                         }
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                            }
                      }));
                        
       
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        aggiornaPuntiQ();
}
    void FixedUpdate()
    {
         if(Login.activeSelf == false){
            if(MonetaGame ){
                if(Time.time>timing3 && Bool_monete==true){
                    if(numeromonete>0 )
                    {
                        numeromonete-=1;
                        timering=timering/100*98;
                timing3=Time.time+timering;
                GameObject Moneta2 = Instantiate(Moneta, new Vector2(Random.Range(0,Screen.width),Screen.height), Quaternion.identity) as GameObject;
                Moneta2.transform.SetParent (GameObject.Find("Canvas").transform);
                }
                if(numeromonete<=0 && Bool_monete==true)
                {T_Monete.enabled=true;
                  T_Monete.text="Hai raccolto "+(Oncollisions.MoneteCounting)+" monete" ;
                  soldi+=Oncollisions.MoneteCounting;
                  aggiornaSoldi();
                  T_Soldi.text="Punti: "+soldi.ToString();
                //StartCoroutine(LateGetPuntiMonete(0.1f));
                Bool_monete=false;
                
                }

                }
                else {
                   // fineMonete();
                }

                }


          else if(timer10.AttivaTimer){
                if(Time.time>timer10.timing){
                    if (timer10.TimerSecondi>0)
                    {
                        timer10.timing=timer10.timing+1;
                    timer10.TimerSecondi-=1;
                    if(timer10.TimerSecondi<10){
                timer10.secString="0"+timer10.TimerSecondi.ToString();
            }else{
                timer10.secString=timer10.TimerSecondi.ToString();
            }
            if(timer10.TimerMinuti<10){
                timer10.minString="0"+timer10.TimerMinuti.ToString();
            }else{
                timer10.minString=timer10.TimerMinuti.ToString();
            }
            timer10.TimerButton.text=timer10.minString+":"+timer10.secString;
                    }
                    else if (timer10.TimerSecondi==0){
                        timer10.timing=timer10.timing+1;
                        timer10.TimerSecondi=59;
                        timer10.TimerMinuti-=1;
                          if(timer10.TimerSecondi<10){
                timer10.secString="0"+timer10.TimerSecondi.ToString();
            }else{
                timer10.secString=timer10.TimerSecondi.ToString();
            }
            if(timer10.TimerMinuti<10){
                timer10.minString="0"+timer10.TimerMinuti.ToString();
            }else{
                timer10.minString=timer10.TimerMinuti.ToString();
            }
            timer10.TimerButton.text=timer10.minString+":"+timer10.secString;

                       
          
                    
                    }
                     if (timer10.TimerMinuti<0){
                            timer10.AttivaTimer=false;
                            timer10.TimerButton.text="";
                            timer10.scatola.GetComponent<ChangeBright>().enabled=true;
        timer10.scatola.GetComponent<Button>().interactable=true;
        timer10.B_Video.interactable=true;
                            timer10.LoadAd();
                        }
                    
                
            
        }
    }
 }
    }






IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }


  public void OpenOggetto1Url ()
  {
    Application.OpenURL("https://amzn.to/3HUOJNX");
    
  }
  public void OpenOggetto2Url ()
  {
    Application.OpenURL("https://amzn.to/3hL0zj7");
    
  }
  public void B_Pp ()
  {
    Application.OpenURL("https://www.iubenda.com/privacy-policy/22993266");
    
  }
   public void B_Tec()
  {
    Application.OpenURL("https://www.iubenda.com/termini-e-condizioni/22993266");
    
  }
void Update()
    {               

if (ErrorCounting==6)
{
if (TimeBlock>0)
    {
    if(Time.time > oneSec)
            {
            TimeBlock-=1;
            oneSec=Time.time+1;
            T_L_Error.text="Bloccato per: "+TimeBlock.ToString()+" secondi";

            PlayerPrefs.SetInt("ErrorCounting",ErrorCounting);
            PlayerPrefs.SetInt("TimeBlock",TimeBlock);
            ErrorBlockString="Bloccato per: "+TimeBlock.ToString()+" secondi";
            PlayerPrefs.SetString("ErrorBlockString", ErrorBlockString);
            }
    }
    else 
    {
    ErrorCounting=0;
    T_L_Error.text="";
    }


}

        if(Login.activeSelf == false)
            {

                
                
             if (rotazione==true) 
              {
                if (Time.time>timing2)
                {
                    timing2=Time.time+0.005f;
                    rotz=rotz+4f;
                    Half_Egg.transform.rotation  = Quaternion.Euler(0, 0, rotz);
                    if(rotz>=180){
                        
                        rotazione = false;
                        A_moneta.Play();
                        muoviGold=true;
                        Gold.SetActive(true);
                        y=-85;
                        Gold.transform.localPosition=new Vector2(0,y);
                        

                    }
                }
              } 
              
              else if(muoviGold){
                if (Time.time>timing2)
                {
                    timing2=Time.time+0.005f;
                    y+=(1.725f*2f);
                Gold.transform.localPosition=new Vector2(0,y);
                }
                 if(y>=235){
                    //Gold.SetActive(false);
                    
                    muoviGold=false;
                    muoviPunti=true;
                    T_puntiUovoGO.SetActive(true);
                    T_PuntiUovo.text="10 punti";
                    soldi+=10;
                  aggiornaSoldi();
                  T_Soldi.text="Punti: "+soldi.ToString();
                    //StartCoroutine(LateGetPuntiUovo(0.1f));
              }
                }
              else if(muoviPunti==true){
                if (Time.time > timing2){
                timing2=Time.time+0.005f;
                    y+=2f;
                T_puntiUovoGO.transform.localPosition=new Vector2(0,y);
                }
                if(y>=435){
                    //Gold.SetActive(false);
                    Bool_uovo=false;
                   // aggiornaUovo();
                   // adscount=0;
                   // aggiornaAdsCount();
                    T_puntiUovoGO.SetActive(false);
                    muoviPunti=false;
                    Indietro_B_Game_Uovo.SetActive(true);
                    Gold.SetActive(false);
                    uovobright.GetComponent<ChangeBright>().enabled=false;
                    uovobright.GetComponent<Image>().color=new Color(0,0,0,0);
                    
                }
                }
    else if(P_ConsigliatiAmazon.activeSelf==true)
    {
        if(Time.time>timing && caricamentoX){
        countConsigliati-=1;
        timing=Time.time+1;
        T_X.text=countConsigliati.ToString();
        B_T_X.interactable=false;
        if(countConsigliati==0)
        {
            T_X.text="X";
            B_T_X.interactable=true;
            caricamentoX=false;
            
        }
        if(countConsigliati==1)
        {
           timer10.xButton();
         StartCoroutine(LateGetDopo(0.1f));
            StartCoroutine(LateAggiornaOra(0.1f));
        }
        }
    }
                else  if(aumentaExp){
                if(conteggioExp>0)
                {
                        if(Time.time>timing)
                        {
                                if(ExpBar<ExpTot)
                                {
                                    ExpBar+=1;
                                    T_exp.text=ExpBar.ToString()+"/"+ExpTot.ToString();
                                    BarraExpBlu.rectTransform.sizeDelta = new Vector2((ExpBar/ExpTot)*500,50);
                                    timing=Time.time+0.01f;
                                    conteggioExp-=1;
                                    
                                  StartCoroutine(LateConteggio(0.01f));
                                }
                                else
                                {
                                    level+=1;
                                    if (level>=2)
                                    {
                                        scambia_1.interactable=true;
                                    }
                                    else{
                                        scambia_1.interactable=false;
                                    }
                                    if(level>=3)
                                    {
                                        scambia_2.interactable=true;
                                    }
                                    else{
                                        scambia_2.interactable=false;
                                    }
                                     if (level>=4)
                                    {
                                        scambia_3.interactable=true;
                                    }
                                    else{
                                        scambia_3.interactable=false;
                                    }
                                    if(level>=5)
                                    {
                                        scambia_4.interactable=true;
                                    }
                                    else{
                                        scambia_4.interactable=false;
                                    }
                                     if (level>=6)
                                    {
                                        scambia_5.interactable=true;
                                    }
                                    else{
                                        scambia_5.interactable=false;
                                    }
                                    if (level>=7)
                                    {
                                        scambia_6.interactable=true;
                                    }
                                    else{
                                        scambia_6.interactable=false;
                                    }
                                    T_livello.text="Livello: "+level.ToString();
                                    ExpTot=level*10;
                                    ExpBar=0;
                                    T_exp.text=ExpBar.ToString()+"/"+ExpTot.ToString();
                                    BarraExpBlu.rectTransform.sizeDelta = new Vector2( (ExpBar/ExpTot)*500,50);
                                    StartCoroutine(LateConteggio(0.01f));
                                }

                                
                        }
                }
                else{
                    aumentaExp=false;
                }
                
            }
         

            else if(AttivaTimer){
                if(Time.time>timing){
                    if (TimerSecondi>0)
                    {
                        timing=timing+1;
                    TimerSecondi-=1;
                    if(TimerSecondi<10){
                secString="0"+TimerSecondi.ToString();
            }else{
                secString=TimerSecondi.ToString();
            }
            if(TimerMinuti<10){
                minString="0"+TimerMinuti.ToString();
            }else{
                minString=TimerMinuti.ToString();
            }
            TimerButton.text=minString+":"+secString;
                    }
                    else if (TimerSecondi==0){
                        timing=timing+1;
                        TimerSecondi=59;
                        TimerMinuti-=1;
                          if(TimerSecondi<10){
                secString="0"+TimerSecondi.ToString();
            }else{
                secString=TimerSecondi.ToString();
            }
            if(TimerMinuti<10){
                minString="0"+TimerMinuti.ToString();
            }else{
                minString=TimerMinuti.ToString();
            }
            TimerButton.text=minString+":"+secString;

                        if (TimerMinuti<0){
                            AttivaTimer=false;
                            TimerButton.text="";
                            LoadAd();
                        }
                    }
                    
                
            }
        }
     }
    }
   

    public void ConsigliatiAmazon(){
    P_ConsigliatiAmazon.SetActive(true);
    }
    public void Indietro_ConsigliatiAmazon(){
    P_ConsigliatiAmazon.SetActive(false);
    }

public void Indietro_Scambia050(){
    P_ScambioEffettuato.SetActive(false);
    I_CodeAmazon.text="";
}

public void Scambia050(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon050(0.1f));
}
IEnumerator LateCodeAmazon050(float waitTime)
    {
        if(punti>100){
       punti=punti-100;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount050((float count0502)=>{
                        count050=count0502;

                        StartCoroutine(GetCodiceAmazon050((string CodeAmazon0502)=>{
                        CodeAmazon050=CodeAmazon0502;
                        }));
                        }));
        yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon050();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni050((float NumeroBuoni0502)=>{
                        NumeroBuoni050=NumeroBuoni0502;
     }));
     yield return new WaitForSeconds(waitTime);
         aggiornaRemoveCodeAmazon050();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount050();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
public void Indietro_B_ITuoiBuoni(){
    P_ITuoiBuoni.SetActive(false);
}
 public void B_ITuoiBuoni(){
   
     T_MyCoupon.text="";
     StartCoroutine(GetNumeroBuoni050((float NumeroBuoni0502)=>{
                        NumeroBuoni050=NumeroBuoni0502;
     }));
    StartCoroutine(GetNumeroBuoni1((float NumeroBuoni12)=>{
                        NumeroBuoni1=NumeroBuoni12;
    }));

    StartCoroutine(GetNumeroBuoni5((float NumeroBuoni52)=>{
                        NumeroBuoni5=NumeroBuoni52;
    }));
    StartCoroutine(GetNumeroBuoni10((float NumeroBuoni102)=>{
                        NumeroBuoni10=NumeroBuoni102;
    }));
    StartCoroutine(GetNumeroBuoni20((float NumeroBuoni202)=>{
                        NumeroBuoni20=NumeroBuoni202;
    }));
        StartCoroutine(GetNumeroBuoni50((float NumeroBuoni502)=>{
                        NumeroBuoni50=NumeroBuoni502;
    }));

    StartCoroutine(LateCodeAmazon050uidTot(0.1f));
      
      P_ITuoiBuoni.SetActive(true);
 }
      IEnumerator LateCodeAmazon050uidTot(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(LateCodeAmazon050uid(0.1f));
yield return new WaitForSeconds(waitTime);
       StartCoroutine(LateCodeAmazon1uid(0.1f));  
yield return new WaitForSeconds(waitTime);
       StartCoroutine(LateCodeAmazon5uid(0.1f));  
yield return new WaitForSeconds(waitTime);
       StartCoroutine(LateCodeAmazon10uid(0.1f)); 
yield return new WaitForSeconds(waitTime);
       StartCoroutine(LateCodeAmazon20uid(0.1f)); 
       yield return new WaitForSeconds(waitTime);
       StartCoroutine(LateCodeAmazon50uid(0.1f)); 
        }
 
 IEnumerator LateCodeAmazon050uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon050uid((string CodiceAmazon050uid2)=>{
                        CodiceAmazon050uid=CodiceAmazon050uid2;
                        if (CodiceAmazon050uid!=""){
                        T_MyCoupon.text+=CodiceAmazon050uid+"\n";
                        }
                        }));
    }
 public void aggiornaCodiceAmazon050() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon050").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      if (NumeroBuoni050!=0 && CodeAmazon050!=""){
      newScoreMap[(mutableData.ChildrenCount).ToString()] = CodeAmazon050.ToString()+" 0.50€";
      newScoreMap["NumeroBuoni050"] = (mutableData.ChildrenCount).ToString();
      
      mutableData.Value = newScoreMap;
      }
      else if (NumeroBuoni050==0 && CodeAmazon050!=""){
        newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon050.ToString()+" 0.50€";
      newScoreMap["NumeroBuoni050"] = (mutableData.ChildrenCount+1f).ToString();
      mutableData.Value = newScoreMap;
      }
      return TransactionResult.Success(mutableData);
      
    });} 

public IEnumerator GetCodiceAmazon050uid(Action<string> onCallback) 
 { for(int k = 0; k < NumeroBuoni050; k++) {
       
       i++;              
     
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon050").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }

  }
  i=0;
 }
public IEnumerator GetNumeroBuoni050(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon050").Child("NumeroBuoni050").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }
  

    public void aggiornaRemoveCodeAmazon050() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").Child(count050.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count050.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount050() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").Child("count050").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count050<0){
      newScoreMap["count050"] = 0;
        }
        else{
            newScoreMap["count050"] = count050-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount050() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").Child("count050").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count050+=1;
      newScoreMap["count050"] = count050;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon050() 
{ 
     count050+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count050.ToString()] = CodeAmazon050;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon050(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").Child(count050.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=100;
         aggiornaPunti();
          
        }
   }

  }
  public IEnumerator GetCount050(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon050").Child("count050").Child("count050").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon050.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=100;
         aggiornaPunti();
        }
   }

  }
//////////////////////////////////1 EURO/////////////////////////////
 IEnumerator LateCodeAmazon1uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon1uid((string CodiceAmazon1uid2)=>{
                        CodiceAmazon1uid=CodiceAmazon1uid2;
                         if (CodiceAmazon1uid!=""){
                        T_MyCoupon.text+=CodiceAmazon1uid+"\n";
                        }
                        
                        }));
    }
 public void aggiornaCodiceAmazon1() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon1").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
       if (NumeroBuoni1!=0 && CodeAmazon1!=""){
      newScoreMap[mutableData.ChildrenCount.ToString()] = CodeAmazon1.ToString()+" 1€";
      newScoreMap["NumeroBuoni1"] = (mutableData.ChildrenCount).ToString();
      
      mutableData.Value = newScoreMap;
       }
       else if (NumeroBuoni1==0 && CodeAmazon1!=""){
        newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon1.ToString()+" 1€";
      newScoreMap["NumeroBuoni1"] = (mutableData.ChildrenCount+1f).ToString();
      
      mutableData.Value = newScoreMap;
       }
      return TransactionResult.Success(mutableData);
      });
      
}
public IEnumerator GetCodiceAmazon1uid(Action<string> onCallback) 
 { 
     for(int k = 0; k < NumeroBuoni1; k++) {
       
       i++;
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon1").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }
     }
     i=0;
  }

public IEnumerator GetNumeroBuoni1(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon1").Child("NumeroBuoni1").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }
public void Scambia1(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon1(0.1f));
}

IEnumerator LateCodeAmazon1(float waitTime)
    {
        if(punti>200){
       punti=punti-200;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount1((float count12)=>{
                        count1=count12;

                        StartCoroutine(GetCodiceAmazon1((string CodeAmazon12)=>{
                        CodeAmazon1=CodeAmazon12;
                        }));
                        }));
         yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon1();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni1((float NumeroBuoni12)=>{
                        NumeroBuoni1=NumeroBuoni12;
     }));
         yield return new WaitForSeconds(waitTime);
         
         aggiornaRemoveCodeAmazon1();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount1();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
    public void aggiornaRemoveCodeAmazon1() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").Child(count1.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count1.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount1() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").Child("count1").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count1<0){
      newScoreMap["count1"] = 0;
        }
        else{
            newScoreMap["count1"] = count1-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount1() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").Child("count1").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count1+=1;
      newScoreMap["count1"] = count1;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon1() 
{ 
     count1+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count1.ToString()] = CodeAmazon1;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon1(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").Child(count1.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=200;
         aggiornaPunti();
          
        }
   }

  }
  public IEnumerator GetCount1(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon1").Child("count1").Child("count1").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon1.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=200;
         aggiornaPunti();
        }
   }

  }
  /////////////////////////////////5 EURO//////////////////////////
IEnumerator LateCodeAmazon5uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon5uid((string CodiceAmazon5uid2)=>{
                        CodiceAmazon5uid=CodiceAmazon5uid2;
                        if (CodiceAmazon5uid!=""){
                        T_MyCoupon.text+=CodiceAmazon5uid+"\n";
                        }
                        }));
    }
 public void aggiornaCodiceAmazon5() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon5").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
       if (NumeroBuoni5!=0 && CodeAmazon5!=""){
      newScoreMap[mutableData.ChildrenCount.ToString()] = CodeAmazon5.ToString()+" 5€";
      newScoreMap["NumeroBuoni5"] = (mutableData.ChildrenCount).ToString();
      mutableData.Value = newScoreMap;
       } else if (NumeroBuoni5==0 && CodeAmazon5!=""){
      newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon5.ToString()+" 5€";
      newScoreMap["NumeroBuoni5"] = (mutableData.ChildrenCount+1f).ToString();
      mutableData.Value = newScoreMap;
       }
      return TransactionResult.Success(mutableData);
    });} 

public IEnumerator GetCodiceAmazon5uid(Action<string> onCallback) 
 {  for(int k = 0; k < NumeroBuoni5; k++) {
       
       i++;
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon5").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }
 }
 i=0;
  }

public IEnumerator GetNumeroBuoni5(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon5").Child("NumeroBuoni5").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }

public void Scambia5(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon5(0.1f));
}

IEnumerator LateCodeAmazon5(float waitTime)
    {
        if(punti>1000){
       punti=punti-1000;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount5((float count52)=>{
                        count5=count52;

                        StartCoroutine(GetCodiceAmazon5((string CodeAmazon52)=>{
                        CodeAmazon5=CodeAmazon52;
                        }));
                        }));
         yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon5();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni5((float NumeroBuoni52)=>{
                        NumeroBuoni5=NumeroBuoni52;
     }));
         yield return new WaitForSeconds(waitTime);
         
         aggiornaRemoveCodeAmazon5();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount5();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
    public void aggiornaRemoveCodeAmazon5() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").Child(count5.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count5.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount5() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").Child("count5").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count5<0){
      newScoreMap["count5"] = 0;
        }
        else{
            newScoreMap["count5"] = count5-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount5() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").Child("count5").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count5+=1;
      newScoreMap["count5"] = count5;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon5() 
{ 
     count5+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count5.ToString()] = CodeAmazon5;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon5(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").Child(count5.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=1000;
         aggiornaPunti();
          
        }
   }

  }

//////////////////////////10 EURO////////////////////////
 IEnumerator LateCodeAmazon10uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon10uid((string CodiceAmazon10uid2)=>{
                        CodiceAmazon10uid=CodiceAmazon10uid2;
                         if (CodiceAmazon10uid!=""){
                        T_MyCoupon.text+=CodiceAmazon10uid+"\n";
                        }
                        }));
    }
 public void aggiornaCodiceAmazon10() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon10").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      if (NumeroBuoni10!=0 && CodeAmazon10!=""){
      newScoreMap[mutableData.ChildrenCount.ToString()] = CodeAmazon10.ToString()+" 10€";
      newScoreMap["NumeroBuoni10"] = (mutableData.ChildrenCount).ToString();
      
      mutableData.Value = newScoreMap;
      }
      else if (NumeroBuoni10==0 && CodeAmazon10!=""){
      newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon10.ToString()+" 10€";
      newScoreMap["NumeroBuoni10"] = (mutableData.ChildrenCount+1f).ToString();
      
      mutableData.Value = newScoreMap;
      }
      return TransactionResult.Success(mutableData);
    });} 

public IEnumerator GetCodiceAmazon10uid(Action<string> onCallback) 
 { 
     for(int k = 0; k < NumeroBuoni10; k++) {
       
       i++;
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon10").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }
     }
     i=0;
  }

public IEnumerator GetNumeroBuoni10(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon10").Child("NumeroBuoni10").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }
public void Scambia10(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon10(0.1f));
}

IEnumerator LateCodeAmazon10(float waitTime)
    {
        if(punti>2000){
       punti=punti-2000;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount10((float count102)=>{
                        count10=count102;

                        StartCoroutine(GetCodiceAmazon10((string CodeAmazon102)=>{
                        CodeAmazon10=CodeAmazon102;
                        }));
                        }));
         yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon10();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni10((float NumeroBuoni102)=>{
                        NumeroBuoni10=NumeroBuoni102;
     }));
         yield return new WaitForSeconds(waitTime);
         aggiornaRemoveCodeAmazon10();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount10();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
    public void aggiornaRemoveCodeAmazon10() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").Child(count10.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count10.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount10() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").Child("count10").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count10<0){
      newScoreMap["count10"] = 0;
        }
        else{
            newScoreMap["count10"] = count10-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount10() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").Child("count10").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count10+=1;
      newScoreMap["count10"] = count10;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon10() 
{ 
     count10+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count10.ToString()] = CodeAmazon10;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon10(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").Child(count10.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=2000;
         aggiornaPunti();
          
        }
   }

  }
  public IEnumerator GetCount10(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon10").Child("count10").Child("count10").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon10.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=2000;
         aggiornaPunti();
        }
   }

  }
  ////////////////////////////20 EURO//////////////////////////
   IEnumerator LateCodeAmazon20uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon20uid((string CodiceAmazon20uid2)=>{
                        CodiceAmazon20uid=CodiceAmazon20uid2;
                         if (CodiceAmazon20uid!=""){
                        T_MyCoupon.text+=CodiceAmazon20uid+"\n";
                        }
                        }));
    }
 public void aggiornaCodiceAmazon20() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon20").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      if (NumeroBuoni20!=0 && CodeAmazon20!=""){
      newScoreMap[mutableData.ChildrenCount.ToString()] = CodeAmazon20.ToString()+" 20€";
      newScoreMap["NumeroBuoni20"] = (mutableData.ChildrenCount).ToString();
      
      mutableData.Value = newScoreMap;
      }
       if (NumeroBuoni20==0 && CodeAmazon20!=""){
      newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon20.ToString()+" 20€";
      newScoreMap["NumeroBuoni20"] = (mutableData.ChildrenCount+1f).ToString();
      
      mutableData.Value = newScoreMap;
      }
      return TransactionResult.Success(mutableData);
    });} 

public IEnumerator GetCodiceAmazon20uid(Action<string> onCallback) 
 {  for(int k = 0; k < NumeroBuoni20; k++) {
       
       i++;
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon20").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }
 }
 i=0;
  }

public IEnumerator GetNumeroBuoni20(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon20").Child("NumeroBuoni20").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }

public void Scambia20(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon20(0.1f));
}

IEnumerator LateCodeAmazon20(float waitTime)
    {
        if(punti>4000){
       punti=punti-4000;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount20((float count202)=>{
                        count20=count202;

                        StartCoroutine(GetCodiceAmazon20((string CodeAmazon202)=>{
                        CodeAmazon20=CodeAmazon202;
                        }));
                        }));
         yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon20();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni20((float NumeroBuoni202)=>{
                        NumeroBuoni20=NumeroBuoni202;
     }));
         yield return new WaitForSeconds(waitTime);
         aggiornaRemoveCodeAmazon20();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount20();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
    public void aggiornaRemoveCodeAmazon20() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").Child(count20.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count20.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount20() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").Child("count20").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count20<0){
      newScoreMap["count20"] = 0;
        }
        else{
            newScoreMap["count20"] = count20-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount20() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").Child("count20").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count20+=1;
      newScoreMap["count20"] = count20;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon20() 
{ 
     count20+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count20.ToString()] = CodeAmazon20;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon20(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").Child(count20.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=4000;
         aggiornaPunti();
          
        }
   }

  }
  public IEnumerator GetCount20(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon20").Child("count20").Child("count20").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon20.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=4000;
         aggiornaPunti();
        }
   }

  }


  ///////////////////////50 EURO//////////////////////

 IEnumerator LateCodeAmazon50uid(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetCodiceAmazon50uid((string CodiceAmazon50uid2)=>{
                        CodiceAmazon50uid=CodiceAmazon50uid2;
                         if (CodiceAmazon50uid!=""){
                        T_MyCoupon.text+=CodiceAmazon50uid+"\n";
                        }
                        }));
    }
 public void aggiornaCodiceAmazon50() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon50").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
       if (NumeroBuoni50!=0 && CodeAmazon50!=""){
      newScoreMap[mutableData.ChildrenCount.ToString()] = CodeAmazon50.ToString()+" 50€";
      newScoreMap["NumeroBuoni50"] = (mutableData.ChildrenCount).ToString();
      
      mutableData.Value = newScoreMap;
       }
      else  if (NumeroBuoni50==0 && CodeAmazon50!=""){
      newScoreMap[(mutableData.ChildrenCount+1f).ToString()] = CodeAmazon50.ToString()+" 50€";
      newScoreMap["NumeroBuoni50"] = (mutableData.ChildrenCount+1f).ToString();
      
      mutableData.Value = newScoreMap;
       }
     
      return TransactionResult.Success(mutableData);
    });} 

public IEnumerator GetCodiceAmazon50uid(Action<string> onCallback) 
 {  for(int k = 0; k < NumeroBuoni50; k++) {
       
       i++;
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon50").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        
         }
        else{
        }
   }
 }
 i=0;
  }

public IEnumerator GetNumeroBuoni50(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("CodiceAmazon50").Child("NumeroBuoni50").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
         }
        else{
        }
   }

  }

public void Scambia50(){
    P_ScambioEffettuato.SetActive(true);
    
      StartCoroutine(LateCodeAmazon50(0.1f));
}

IEnumerator LateCodeAmazon50(float waitTime)
    {
        if(punti>10000){
       punti=punti-10000;
        aggiornaPunti(); 
        
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCount50((float count502)=>{
                        count50=count502;

                        StartCoroutine(GetCodiceAmazon50((string CodeAmazon502)=>{
                        CodeAmazon50=CodeAmazon502;
                        }));
                        }));
         yield return new WaitForSeconds(waitTime);
        aggiornaCodiceAmazon50();
         yield return new WaitForSeconds(waitTime);
         StartCoroutine(GetNumeroBuoni50((float NumeroBuoni502)=>{
                        NumeroBuoni50=NumeroBuoni502;
     }));
         yield return new WaitForSeconds(waitTime);
         aggiornaRemoveCodeAmazon50();
         yield return new WaitForSeconds(waitTime);
        
         aggiornaPrelievoCount50();
         T_Punti.text= "Punti: "+punti.ToString("F1");
    }
    else{
        T_CodiceEseguito.text="Punti non disponibili";
    }
}
    public void aggiornaRemoveCodeAmazon50() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").Child(count50.ToString()).RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      
      newScoreMap[count50.ToString()] = null;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 

public void aggiornaPrelievoCount50() 
{  

    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").Child("count50").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
            
        if (count50<0){
      newScoreMap["count50"] = 0;
        }
        else{
            newScoreMap["count50"] = count50-1f;
        }
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });} 
public void aggiornaAggiungiCount50() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").Child("count50").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        count50+=1;
      newScoreMap["count50"] = count50;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAggiungiCodeAmazon50() 
{ 
     count50+=1;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").RunTransaction(mutableData => {
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[count50.ToString()] = CodeAmazon50;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public IEnumerator GetCodiceAmazon50(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").Child(count50.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        I_CodeAmazon.text=(snapshot.Value).ToString();
        T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
             T_CodiceEseguito.text="Codici esauriti";
            punti+=10000;
         aggiornaPunti();
          
        }
   }

  }
  public IEnumerator GetCount50(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon50").Child("count50").Child("count50").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon50.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=10000;
         aggiornaPunti();
        }
   }

  }
  //////////////////////////////////////////////////////////

  public IEnumerator GetCount5(Action<float> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("CodiciAmazon5").Child("count5").Child("count5").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
     //  I_CodeAmazon5.text=(snapshot.Value).ToString();
       T_CodiceEseguito.text="Buono Amazon generato con successo!";
         }
        else{
         T_CodiceEseguito.text="Codici esauriti";
         punti+=1000;
         aggiornaPunti();
        }
   }

  }




IEnumerator LateConteggio(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaConteggioExp();
        yield return new WaitForSeconds(waitTime);
         aggiornaExpSuDatabase();
         yield return new WaitForSeconds(waitTime);
         aggiornaExpTotSuDatabase();
         yield return new WaitForSeconds(waitTime);
         aggiornaLevel();
    }
IEnumerator LateConteggio1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaExpSuDatabase();
        yield return new WaitForSeconds(waitTime);
        aggiornaExpTotSuDatabase();
    }

    public void aggiornaitem1() 
{ 

 FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("item1").RunTransaction(mutableData => {
     List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["item1"] = item1;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
    public void aggiornaitem2() 
{ 

 FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("item2").RunTransaction(mutableData => {
     List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["item2"] = item2;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
    public void aggiornaID() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap[cambioID] = cambioID;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 

public void aggiornaSoldi() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("Soldi").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["Soldi"] = soldi;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
     public void aggiornaUovo() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("uovo").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["uovo"] = Bool_uovo;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaMonete() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Monete").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["Monete"] = Bool_monete;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
     public void aggiornaOraH() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("oraH").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["oraH"] = oraH;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornaOraM() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("oraM").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["oraM"] = oraM;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaOra() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ora").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["ora"] = ora;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornaDopoH() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopoH").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopoH"] = dopoH;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornaDopoM() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopoM").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopoM"] = dopoM;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaDopo() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopo").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopo"] = dopo;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
      public void aggiornaAmiciCount() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AmiciCount").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["AmiciCount"] = AmiciCount;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 

public void aggiornaAmiciCountDellAmico() 
{  
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("AmiciCount").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      newScoreMap["AmiciCount"] = AmiciCountDellAmico+1;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAmiciQ() 
{  
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AmiciQ").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      newScoreMap["AmiciQ"] = AmiciQ;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAmiciQDellAmico() 
{  
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("AmiciQ").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      newScoreMap["AmiciQ"] = AmiciQ+1;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
  public void aggiornaListaAmici() 
{  
     string key = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("codiceNuovoAmico").Push().Key;
    Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
    newScoreMap["/codiceNuovoAmico/"+i.ToString()] = codiceNuovoAmico[AmiciCount-1];
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).UpdateChildrenAsync(newScoreMap);

} 
public void aggiornaListaAmiciDellAmico() 
{  
     string key = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("codiceNuovoAmico").Push().Key;
    Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
    newScoreMap["/codiceNuovoAmico/"+AmiciCountDellAmico.ToString()] = uid;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).UpdateChildrenAsync(newScoreMap);
} 
public void AggiungiAmici() 
{  
    string key = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("NameOfFriends").Child("NameOfFriends"+i).Push().Key;
    Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
    newScoreMap["NameOfFriends"+(AmiciCount-1).ToString()] = nameOfFriends[AmiciCount-1];
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("NameOfFriends").UpdateChildrenAsync(newScoreMap);

} 

private void WriteNewScore() {
    // Create new entry at /user-scores/$userid/$scoreid and at
    // /leaderboard/$scoreid simultaneously
   }


public void AggiungiAmiciDellAmico() 
{  Debug.Log(codiceNuovoAmico[AmiciCount-1]);
 string key = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("NameOfFriends").Child("NameOfFriends"+(AmiciCountDellAmico).ToString()).Push().Key;
    Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
    newScoreMap["NameOfFriends"+(AmiciCountDellAmico).ToString()] = username;
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("NameOfFriends").UpdateChildrenAsync(newScoreMap);

} 
public void aggiornaAdsCount() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AdsCount").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["AdsCount"] = adscount;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaAdsCount2() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AdsCount2").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["AdsCount2"] = adscount2;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaLevel() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("level").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["level"] = level;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaQCompletati() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("QCompletati").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["QCompletati"] = QCompletati;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaDataCurrent() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("d").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["d"] = DataAdesso;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaQ1() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q1").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["Q1"] = Q1;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaQ2() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q2").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["Q2"] = Q2;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaQ3() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q3").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["Q3"] = Q3;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaQ4() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q4").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["Q4"] = Q4;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaPunti() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("punti").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["punti"] = punti;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaPuntiQ() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("puntiQ").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["puntiQ"] = PuntiQ;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 

public void aggiornaPuntiAmico() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("punti").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["punti"] = puntiAmico;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
    
public void aggiornaExpSuDatabase() 
{  
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ExpBar").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
   
      newScoreMap["ExpBar"] = ExpBar;
    
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaExpTotSuDatabase() 
{  
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ExpTot").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
   
      newScoreMap["ExpTot"] = ExpTot;
    
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void AggiungiCodiceAmicoSuDatabase() 
{  
    
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("codiceAmico").Child(codiceAmico).RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap[codiceAmico.ToString()] = uid;     
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void AggiornaBoolButtonAmiciCode() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["ID"] = uid;      
      newScoreMap["email"] = email;
      newScoreMap["username"] = username;
      newScoreMap["level"] = level;
      newScoreMap["punti"] = punti;
      newScoreMap["ExpBar"] = ExpBar;
      newScoreMap["ExpTot"] = ExpTot;
      newScoreMap["BoolButtonAmiciCode"] = BoolButtonAmiciCode;  
      
      numeroUtentiTotali=mutableData.ChildrenCount;
      newScoreMap["numeroUtentiTotali"] = mutableData.ChildrenCount;
      newScoreMap["codiceAmico"] = codiceAmico;      
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaConteggioExp() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("conteggioExp").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      newScoreMap["conteggioExp"] = conteggioExp;
          
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaConteggioExpDellAmico() 
{  
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("conteggioExp").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
      newScoreMap["conteggioExp"] = conteggioExpDellAmico;
      leaders.Add(newScoreMap);      
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
public void RegistraDatiUtente() 
{  
   
    
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid.ToString()).RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
    level=1;
    ExpBar=0;
    ExpTot=level*10;
    punti=0;//newScoreMap[name] = ID;
    

      newScoreMap["ID"] = uid;      
      newScoreMap["email"] = email;
      newScoreMap["username"] = username;
      newScoreMap["level"] = level;
      newScoreMap["ExpTot"] = ExpTot;
      newScoreMap["BoolButtonAmiciCode"] = true;  
      
      numeroUtentiTotali=mutableData.ChildrenCount;
      newScoreMap["AmiciCount"] = 0;
      randomCode();
      newScoreMap["codiceAmico"] = codiceAmico;
      //leaders.Add(newScoreMap);
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
    I_R_Email.text="";
    I_R_Username.text="";
    I_R_RepeatPw.text="";
    I_R_Password.text="";
    T_R_Error.text = "";
    TeC.isOn=false;
    Pp.isOn=false;
    //stringa="";
    Register.SetActive(false);
    
} 
 public void MyFriendCode(){
    if(P_FriendCode.activeSelf){
    P_FriendCode.SetActive(false);
    }
    else 
    P_FriendCode.SetActive(true);
 }
 public void MyFriendsList(){
    if(P_FriendsList.activeSelf){
    P_FriendsList.SetActive(false);
    }
    else 
    P_FriendsList.SetActive(true);
 }

 IEnumerator LateAmiciCount(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaAmiciCount();
    }
 public void InsertCode(){
            if (I_codeFriends.text==codiceAmico || I_codeFriends.text.Length<10)
            {T_ErrorFriend.text="Codice errato";}
            else{
                AmiciCount+=1;
                StartCoroutine(LateAmiciCount(0.1f));
                for(int k = 0; k < AmiciCount; k++) {
                if(name==codiceNuovoAmico[k] && codiceEsistente==false)
                {codiceEsistente=true;
                T_ErrorFriend.text="Codice già utilizzato";
                AmiciCount-=1;
                StartCoroutine(LateAmiciCount(0.1f));
                }
            }
            if (codiceEsistente==false){
        StartCoroutine(GetFriendsCode((string codiceNuovoAmico2)=>{

                                Debug.Log(i);
                                codiceNuovoAmico[AmiciCount-1]=codiceNuovoAmico2;
                              //
                                
                                
                                
                                 

                              // 
                                }));
                             StartCoroutine(LateStart1(0.1f));
                             BoolButtonAmiciCode=false;
                                AggiornaBoolButtonAmiciCode();
                                StartCoroutine(LateConteggio3(0.2f));
                                StartCoroutine(LateConteggio2(0.3f));
                               StartCoroutine(LateStart2(0.4f));
                               
                               if(AmiciCount>0) {
                                T_Amici.text="Hai "+AmiciCount+" amici annoiati";
                               }
                               else{
                                T_Amici.text="Non hai amici annoiati";
                               }
                            conteggioExpDellAmico=0;
            }
    }
 }

 IEnumerator LateConteggio2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaConteggioExpDellAmico();
    }
    IEnumerator LateConteggio3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaConteggioExp();
    }
IEnumerator LateStart1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetAmiciCountDellAmico((int AmiciCount3)=>{
                                AmiciCountDellAmico=AmiciCount3;
                                 }));
                                 yield return new WaitForSeconds(waitTime);
                                 StartCoroutine(GetAmiciQDellAmico((int AmiciQ2)=>{
                                AmiciQ=AmiciQ2;
                                 }));
                                 yield return new WaitForSeconds(waitTime);
                                 aggiornaAmiciCountDellAmico();
                                 yield return new WaitForSeconds(waitTime);
                                 aggiornaAmiciQDellAmico();
                                 yield return new WaitForSeconds(waitTime);
                                aggiornaListaAmiciDellAmico();
                                Debug.Log("Ciaoo");
                                T_NameOfFriends.text="";
         yield return new WaitForSeconds(waitTime);                       
        aggiornaListaAmici();
    }
    IEnumerator LateStart2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(AddNameOfFriends((string name)=>{
                                nameOfFriends[AmiciCount-1]=name;
                                StartCoroutine(LateStart3(0.5f));
                                })); 
                                
                                 
    }
IEnumerator LateStart3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
AggiungiAmici();
 yield return new WaitForSeconds(waitTime);
   AggiungiAmiciDellAmico();
    T_NameOfFriends.text+= nameOfFriends[AmiciCount-1]+"\n";
    for(int k = 0; k < AmiciCount; k++) {
                                    TestoDiConfronto+=nameOfFriends[k]+"\n";
                                
                                }
                                if(T_NameOfFriends.text==TestoDiConfronto){
                                 i+=1;
                                aumentaExp=true; }
                                TestoDiConfronto="";
    }
public void login()
    {if (ErrorCounting<5)
    {
       StartCoroutine(Login2(I_L_Email.text, I_L_Password.text)); 
       ErrorBlockString="";   
       PlayerPrefs.SetString("ErrorBlockString", ErrorBlockString);

    }  
    else if (ErrorCounting==5){
        counter+=1;
        aggiungiSecondi=30*counter;
TimeBlock=aggiungiSecondi;
ErrorCounting=6;
PlayerPrefs.SetInt("ErrorCounting",ErrorCounting);
PlayerPrefs.SetInt("counter",counter);
     PlayerPrefs.SetInt("TimeBlock",ErrorCounting);
PlayerPrefs.SetInt("aggiungiSecondi",aggiungiSecondi);
      
    }
    }
public IEnumerator Login2(string _email, string _password)
    {
        //Call the Firebase auth signin function passing the email and password
        var LoginTask = auth.SignInWithEmailAndPasswordAsync(_email, _password);
        //Wait until the task completes
        yield return new WaitUntil(predicate: () => LoginTask.IsCompleted);

        if (LoginTask.Exception != null)
        {
            //If there are errors handle them
            Debug.LogWarning(message: $"Failed to register task with {LoginTask.Exception}");
            FirebaseException firebaseEx = LoginTask.Exception.GetBaseException() as FirebaseException;
            AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

            string message = "Login Failed!";
            switch (errorCode)
            {
                case AuthError.MissingEmail:
                    message = "Inserire email";
                    break;
                case AuthError.MissingPassword:
                    message = "Inserire password";
                    break;
                case AuthError.WrongPassword:
                    message = "Password errata";
                    break;
                case AuthError.InvalidEmail:
                    message = "Email non valida";
                    break;
                case AuthError.UserNotFound:
                    message = "L'account non esiste";
                    break;
            }
            T_L_Error.text = message;
            ErrorCounting+=1;
            
        }
        else
        { 
            User = LoginTask.Result;
            if (User.IsEmailVerified){
            ErrorCounting=0;
            aggiungiSecondi=0;
           TimeBlock=0;
           counter=0;
           aumentaExp=true;
        PlayerPrefs.SetInt("counter",counter);    
        PlayerPrefs.SetInt("ErrorCounting",ErrorCounting);
        PlayerPrefs.SetInt("TimeBlock", TimeBlock);
        PlayerPrefs.SetString("ErrorBlockString", ErrorBlockString);
            //User is now logged in
            //Now get the result
            
            Debug.LogFormat("User signed in successfully: {0} ({1})", User.DisplayName, User.UserId);
            T_L_Error.text = "";
            PlayerPrefs.SetString("Email", I_L_Email.text);
            PlayerPrefs.SetString("Password", I_L_Password.text);
             i=0;
            email=I_L_Email.text;
            uid=User.UserId.ToString();
          StartCoroutine(SalutaUser((string name)=>{
                        Title2.text=("Ciao "+ name);
                        username=name;
                        Debug.Log(name);
                        }));
                        T_NameOfFriends.text="";
                        StartCoroutine(LateQ(0.1f));
                        StartCoroutine(LateMonete(0.1f));
                        StartCoroutine(LateUovo(0.1f));
                    StartCoroutine(LateGetDopo(0.1f));
                      StartCoroutine(LateAggiornaOra(0.1f));
                   // StartCoroutine(LateAggiornaOra(0.1f));
                    
                    

                    StartCoroutine(LateLogin1(0.1f)); 
                    StartCoroutine(LateLogin9(0.1f));
                   // StartCoroutine(LateLogin10(0.1f));
                   // StartCoroutine(LateLogin2(0.1f));
                    StartCoroutine(LateLogin3(0.1f));
                    StartCoroutine(LateLogin4(0.1f));
                    StartCoroutine(LateLogin5(0.1f));
                    StartCoroutine(LateLogin6(0.1f));
                    StartCoroutine(LateLogin7(0.1f));
                    StartCoroutine(LateLogin8(0.1f));
                    
            
                        
           
 StartCoroutine(GetNumeroUtentiTotali((long numeroUtentiTotali)=>{
        Debug.Log(numeroUtentiTotali);
        Title.text="Siamo annoiati In "+numeroUtentiTotali.ToString();
       })); 

                                    
                   // ConsigliatiAmazon();
                   
        }
        else {
            T_L_Error.text="Email non verificata, (controllare la posta indesiderata)";
        }
        }
    }
IEnumerator LateUovo(float waitTime){
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetAdsCount((int adscount2)=>{
                        adscount=adscount2;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetUovo((bool Bool_uovo2)=>{
                        Bool_uovo=Bool_uovo2;
                        if (Bool_uovo==false){
                            fineUovo();
                            uovobright.GetComponent<ChangeBright>().enabled=false;
                            uovobright.GetComponent<Image>().color=new Color(0,0,0,0);
                        }
                        else{
                            uovobright.GetComponent<ChangeBright>().enabled=true;
                            resetUovo();
                        }
                        }));
                        
}

IEnumerator LateMonete(float waitTime){
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetAdsCount2((int adscount22)=>{
                        adscount2=adscount22;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetMonete((bool Bool_monete2)=>{
                        Bool_monete=Bool_monete2;
                        if (Bool_monete==false){
                            fineMonete();
                            saccobright.GetComponent<ChangeBright>().enabled=false;
                            saccobright.GetComponent<Image>().color=new Color(0,0,0,0);
                        }
                        else{
                            saccobright.GetComponent<ChangeBright>().enabled=true;
                            resetMonete();
                        }
                        }));
                        
}

    IEnumerator LateQ(float waitTime){
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetQ1((bool Q12)=>{
                        Q1=Q12;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetQ2((bool Q22)=>{
                        Q2=Q22;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetQ3((bool Q32)=>{
                        Q3=Q32;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetQ4((bool Q42)=>{
                        Q4=Q42;
                        }));
    }
  IEnumerator LateGetOra(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(Getora((int ora2)=>{
    ora=ora2;
    }));
    yield return new WaitForSeconds(waitTime);
StartCoroutine(GetoraM((int oraM2)=>{
    oraM=oraM2;
    }));
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetoraH((int oraH2)=>{
    oraH=oraH2;
    }));
    }
    public  IEnumerator LateGetDopo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(Getdopo((int dopo2)=>{
    dopo=dopo2;
    }));
    yield return new WaitForSeconds(waitTime);
StartCoroutine(GetdopoM((int dopoM2)=>{
    dopoM=dopoM2;
    }));
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetdopoH((int dopoH2)=>{
    dopoH=dopoH2;
    }));
    }
    
IEnumerator LateLogin1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetCodiceAmico((string codiceAmico2)=>{
                        
                        codiceAmico=codiceAmico2;
                        }));
    }

  IEnumerator LateLogin9(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetAmiciCount((int AmiciCount2)=>{
                        AmiciCount=AmiciCount2;
                        
                        StartCoroutine(LateLogin10(0.1f));
                        }));
                        yield return new WaitForSeconds(waitTime);
                        

StartCoroutine(GetAmiciQ((int AmiciQ2)=>{
                        AmiciQ=AmiciQ2;
                        if (AmiciQ<1){
                        T_Q3.text="Invitati "+AmiciQ+"/1";
                        B_Q3.interactable=false;
                       
                        }
                        else if (AmiciQ==null){
                            T_Q3.text="Invitati "+"0"+"/1";
                            B_Q3.interactable=false;
                            
                        }

                        else{
                        T_Q3.text="Invitati "+"1"+"/1";
                        B_Q3.interactable=Q3;
                        
                        }
                        }));
    }
     IEnumerator LateLogin10(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
                        i=0;
                        for(int k = 0; k < AmiciCount; k++) {
                              yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetNameOfFriends((string nameOfFriends2)=>{
                      
                        nameOfFriends[i]=nameOfFriends2;
                        T_NameOfFriends.text+=nameOfFriends2+" Punti: ";
                        //baffo
                        
                        }));
                        yield return new WaitForSeconds(waitTime);
                         StartCoroutine(GetCodiceNuovoAmico((string codiceNuovoAmico2)=>{
                             codiceNuovoAmico[i]=codiceNuovoAmico2;
                        }));
                        yield return new WaitForSeconds(waitTime);
                        StartCoroutine(GetPuntiOfFriends((float puntioffriends)=>{
                            T_NameOfFriends.text+=puntioffriends.ToString("F1")+" ";
                        }));
                        StartCoroutine(GetLivelloOfFriends((float leveloffriends2)=>{
                            T_NameOfFriends.text+="Lv: "+ leveloffriends2+"\n";
                        }));
                        i+=1;
                        }
                        i=0;
                        }
    IEnumerator LateLogin2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
       StartCoroutine(GetCodiceNuovoAmico((string codiceNuovoAmico2)=>{
                        for(int k = 0; k < AmiciCount; k++) {
                            codiceNuovoAmico[i]=codiceNuovoAmico2;
                            i+=1;
                        }
                         i=0;
    }
    ));
 }
                       
                        
    
IEnumerator LateLogin3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
 StartCoroutine(GetLivello((int livello2)=>{
                        T_livello.text="Livello: "+livello2.ToString();
                        level=livello2;
                                                            if (level>=2)
                                    {
                                        scambia_1.interactable=true;
                                    }else{
                                         scambia_1.interactable=false;
                                    }
                                    if(level>=3)
                                    {
                                        scambia_2.interactable=true;
                                    }
                                    else{
                                        scambia_2.interactable=false;
                                    }
                                     if (level>=4)
                                    {
                                        scambia_3.interactable=true;
                                    }
                                    else{
                                        scambia_3.interactable=false;
                                    }
                                    if(level>=5)
                                    {
                                        scambia_4.interactable=true;
                                    }
                                    else{
                                        scambia_4.interactable=false;
                                    }
                                     if (level>=6)
                                    {
                                        scambia_5.interactable=true;
                                    }
                                    else{
                                        scambia_5.interactable=false;
                                    }
                                    if (level>=7)
                                    {
                                        scambia_6.interactable=true;
                                    }
                                    else{
                                        scambia_6.interactable=false;
                                    }
                        }));
    }
IEnumerator LateLogin4(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetPuntiExp((int conteggioExp2)=>{
                        conteggioExp=conteggioExp2;
                        }));
        
    }
    IEnumerator LateLogin5(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetBoolButtonAmiciCode((bool BoolButtonAmiciCode2)=>{
                        BoolButtonAmiciCode=BoolButtonAmiciCode2;
                        buttonAmiciCode.interactable=(BoolButtonAmiciCode);
                        }));
        
    }
    IEnumerator LateLogin6(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetPunti((float punti2)=>{
                       
                        punti=punti2;
                         T_Punti.text="Punti: "+punti.ToString("F1");
                        }));
                           yield return new WaitForSeconds(waitTime);
StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
                       
                        PuntiQ=PuntiQ2;
                        if(PuntiQ<5){
                            T_Q1.text="Ottenuti "+PuntiQ.ToString("F1")+"/5";
                            B_Q1.interactable=false;
                        }
                        else if (PuntiQ==null){
                            T_Q1.text="Ottenuti "+"0"+"/5";
                            B_Q1.interactable=false;
                        }
                        else
                        {
                             T_Q1.text="Ottenuti "+"5"+"/5";
                             B_Q1.interactable=Q1;
                        }

                        }));
                        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetPuntiQ((float PuntiQ2)=>{
                        PuntiQ=PuntiQ2;
                       if(PuntiQ<10){
                         T_Q2.text="Ottenuti "+PuntiQ.ToString("F1")+"/10";
                         B_Q2.interactable=false;
                         
                       }
                       else if (PuntiQ==null){
                            T_Q2.text="Ottenuti "+"0"+"/10";
                            B_Q2.interactable=false;
                            
                        }
                         else{
                            T_Q2.text="Ottenuti "+"10"+"/10";
                            B_Q2.interactable=Q2;
                           
                         }
      }));
                         yield return new WaitForSeconds(waitTime);
                      StartCoroutine(GetQCompletati((int QCompletati2)=>{
                        QCompletati=QCompletati2;
                        if(QCompletati<3){
                                T_Q4.text="Completati "+QCompletati+"/3";
                                B_Q4.interactable=false;
                               
                            }
                            else{
                                T_Q4.text="Completati 3/3";
                                B_Q4.interactable=Q4;
                                
                            }
                      }));
                            StartCoroutine(lategetDataCurrent(0.1f));
    }
    
    IEnumerator LateLogin7(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetExp((float ExpBar2)=>{
                        T_exp.text=ExpBar2.ToString()+"/";
                        ExpBar=ExpBar2;
                        }));
        
    }

    IEnumerator LateLogin8(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(GetExpTot((float ExpTot2)=>{
                        T_exp.text+=ExpTot2.ToString();
                        ExpTot=ExpTot2;
                        BarraExpBlu.rectTransform.sizeDelta = new Vector2((ExpBar/ExpTot)*500,50);
                      
                        
                    Login.SetActive(false);
                    P_Principale.SetActive(true);
                        }));
        
    }
    
  public void randomPunti(){ 
   float number = Random.Range(0.1f, 1f);
   randomP+=number.ToString();
   }
    //aggiungi a database
public void randomCode(){ 
   string st = "0123456789";
   for (int i=0; i<10; i++){
   char c = st[Random.Range(0,st.Length)];
   stringa+=c;
   }
   codiceAmico=stringa;
   stringa="";
    Debug.Log(stringa);
    //aggiungi a database
    
}
public void expa(){
    //conteggioExp=5;
}

public IEnumerator Registra(string _email, string _password, string _username)
    {email=I_R_Email.text;
    username=I_R_Username.text;
        if (I_R_Username.text == "")
        {
            //If the username field is blank show a warning
            T_R_Error.text = "Compilare il campo username";
        }
         else if (I_R_Email.text == "")
        {
            //If the username field is blank show a warning
            T_R_Error.text = "Compilare il campo email";
        }
         else if (I_R_Password.text == "")
        {
            //If the username field is blank show a warning
            T_R_Error.text = "Compilare il campo password";
        }
        else if (I_R_Password.text.Length < 9)
        {
            //If the username field is blank show a warning
            T_R_Error.text = "La password è troppo corta";
        }
        else if(I_R_Password.text != I_R_RepeatPw.text ||  I_R_RepeatPw.text =="")
        {
            //If the password does not match show a warning
            T_R_Error.text = "Le password non coincidono";
        }
        else if(TeC.isOn==false)
        {
            T_R_Error.text = "Accettare i termini e condizioni";
        }
        else if (Pp.isOn==false) 
        {
            T_R_Error.text = "Acconsentire il trattamento dei dati personali";
        }  
        else {//Call the Firebase auth signin function passing the email and password
            var RegisterTask = auth.CreateUserWithEmailAndPasswordAsync(_email, _password);
            //Wait until the task completes
           
            yield return new WaitUntil(predicate: () => RegisterTask.IsCompleted);
         
            if (RegisterTask.Exception != null)
            {
                //If there are errors handle them
                Debug.LogWarning(message: $"Failed to register task with {RegisterTask.Exception}");
                FirebaseException firebaseEx = RegisterTask.Exception.GetBaseException() as FirebaseException;
                AuthError errorCode = (AuthError)firebaseEx.ErrorCode;

                string message = "Email non valida!";
                switch (errorCode)
                {
                    case AuthError.MissingEmail:
                        message = "Compila il campo email";
                        break;
                    case AuthError.MissingPassword:
                        message = "Compila il campo password";
                        break;
                    case AuthError.WeakPassword:
                        message = "Password debole";
                        break;
                    case AuthError.EmailAlreadyInUse:
                        message = "Email esistente";
                        break;
                }
                T_R_Error.text = message;
            }
            else
            {
                //User has now been created
                //Now get the result
                User = RegisterTask.Result;
                
                if (User != null)
                {
                    //Create a user profile and set the username
                    UserProfile profile = new UserProfile{DisplayName = _username};
                   
                    //Call the Firebase auth update user profile function passing the profile with the username
                    var ProfileTask = User.UpdateUserProfileAsync(profile);
                    //Wait until the task completes
                  
                    yield return new WaitUntil(predicate: () => ProfileTask.IsCompleted);
                   
                    if (ProfileTask.Exception != null)
                    {
                        //If there are errors handle them
                        Debug.LogWarning(message: $"Failed to register task with {ProfileTask.Exception}");
                        FirebaseException firebaseEx = ProfileTask.Exception.GetBaseException() as FirebaseException;
                        AuthError errorCode = (AuthError)firebaseEx.ErrorCode;
                        T_R_Error.text = "Errore inserimento username";
                    }
                    else
                    {
                        
                        user = auth.CurrentUser;
                        //StartCoroutine(SendVerificationEmail());
                         
if (user != null) {
  user.SendEmailVerificationAsync().ContinueWith(task => {
    if (task.IsCanceled) {
      Debug.LogError("SendEmailVerificationAsync was canceled.");
      return;
    }
    if (task.IsFaulted) {
      Debug.LogError("SendEmailVerificationAsync encountered an error: " + task.Exception);
      return;
    }

    Debug.Log("Email sent successfully.");
  });
}
///////////////////////////////////////////////////////////////////////////////////////////
                        if (user != null) {
                        uid = user.UserId.ToString();
                        Debug.Log(uid);
                        
                        RegistraDatiUtente();
                        aggiornaLevel();
                        aggiornaPunti();
                        aggiornaExpSuDatabase();
                        aggiornaExpTotSuDatabase();
                        aggiornaAmiciCount();
                        aggiornaConteggioExp();
                        StartCoroutine(LateStart4(0.5f));
                        //Username is now set
                        //Now return to login screen
                        //CaricaGlobali();
                        
                        }
                       }
                }
            }
        
    }
}
IEnumerator LateStart4(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        AggiungiCodiceAmicoSuDatabase();
    }


private IEnumerator SendVerificationEmail(Firebase.Auth.FirebaseUser user){
    

    if (user != null)//////////////SENDEMAIL////////////////
    {
        var emailTask = user.SendEmailVerificationAsync();
        yield return new WaitUntil (predicate:() => emailTask.IsCompleted);
        if(emailTask.Exception != null)
        {
            FirebaseException firebaseException = (FirebaseException)emailTask.Exception.GetBaseException();
            AuthError error = (AuthError)firebaseException.ErrorCode;
            
            string output= "Unknow Error, try again";
            switch (error)
            {

                case AuthError.Cancelled:
                    output="Verification task is cancelled";
                    break;
               case AuthError.InvalidRecipientEmail:
                    output="Invalid Email";
                    break; 
                case AuthError.TooManyRequests:
                    output="Too Many Requests";
                    break;
                
            }
            AwaitVerification(false,user.Email,output);

        }
        else
        {
           AwaitVerification(true,user.Email, null);
           Debug.Log("Email sent successfully");
        }
    }
}


private void clearUI()
{
    PannelloVerify.SetActive(false);
}
public void AwaitVerification(bool _emailSent, string _email,string _output){
    clearUI();
    Register.SetActive(true);
    if(_emailSent)
    {
        T_Verify.text = $"Sent Email\nPlease Verify{_email}";
    }
    else
    {
        T_Verify.text=$"Email Not Sent: {_output}\nPlease Verify{_email}";
    }
}



 public void register(){
    if(Register.activeSelf == false)
    {
        Register.SetActive(true);
        Login.SetActive(false);
    }       
    else if (Register.activeSelf==true)
    {
        if(GameObject.activeSelf==true)
       {
       StartCoroutine(Registra(I_R_Email.text,I_R_Password.text,I_R_Username.text));
       }
       else {
        GameObject.SetActive(true);
       }
    }

}
  public IEnumerator GetMonete(Action<bool> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Monete").Child("Monete").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
    onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   else{
    onCallback.Invoke(true);
   }
         
   }
  }
   public IEnumerator GetUovo(Action<bool> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("uovo").Child("uovo").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
    onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   else{
    onCallback.Invoke(true);
   }
         
   }
  }
   public IEnumerator GetAdsCount2(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AdsCount2").Child("AdsCount2").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
    onCallback.Invoke(int.Parse((snapshot.Value).ToString()));
   }
   else{
    onCallback.Invoke(0);
   }
         
   }
  }
     public IEnumerator GetAdsCount(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AdsCount").Child("AdsCount").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
    onCallback.Invoke(int.Parse((snapshot.Value).ToString()));
   }
   else{
    onCallback.Invoke(0);
   }
         
   }
  }
   public IEnumerator Getora(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ora").Child("ora").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }

     public IEnumerator GetoraM(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("oraM").Child("oraM").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
       public IEnumerator GetoraH(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("oraH").Child("oraH").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }

 public IEnumerator Getdopo(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopo").Child("dopo").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }

     public IEnumerator GetdopoM(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopoM").Child("dopoM").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
       public IEnumerator GetdopoH(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("dopoH").Child("dopoH").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
 public IEnumerator GetNumeroUtentiTotali(Action<long> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(snapshot.ChildrenCount); 
   }

  }
   public IEnumerator GetCodiceNuovoAmico(Action<string> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("codiceNuovoAmico").Child(i.ToString()).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString());
        T_Amici.text="Hai "+AmiciCount+" amici annoiati";
        
         }
        else{
            T_Amici.text="Non hai amici annoiati";
        }
   }

  }
public IEnumerator GetBoolButtonAmiciCode(Action<bool> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("BoolButtonAmiciCode").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(System.Convert.ToBoolean(snapshot.Value)); 
   }

  }
   public IEnumerator GetPuntiExp(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("conteggioExp").Child("conteggioExp").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
  
   public IEnumerator GetAmiciCount(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AmiciCount").Child("AmiciCount").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
     public IEnumerator GetAmiciQ(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("AmiciQ").Child("AmiciQ").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        
        if(snapshot.Value!=null){
            onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
        }
        else{
                     onCallback.Invoke(0);    
        }
   }
  }

   public IEnumerator GetAmiciCountDellAmico(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("AmiciCount").Child("AmiciCount").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
    public IEnumerator GetAmiciQDellAmico(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("AmiciQ").Child("AmiciQ").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
   else{
    onCallback.Invoke(0); 
   }
   }
  }


public IEnumerator GetFriendsCode(Action<string> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("codiceAmico").Child(I_codeFriends.text).Child(I_codeFriends.text).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value!=null){
        onCallback.Invoke((snapshot.Value).ToString()); 
         MyFriendCode();
         myFriendsButtonCode.interactable=(false);
         // punti+=0;
                             //   puntiAmico+=0;
                                conteggioExp+=10;
                                conteggioExpDellAmico+=5;
                                aumentaExp=true;  
                                StartCoroutine(LatePunti(0.5f));
   }
   else{
        T_ErrorFriend.text="Codice non valido";
        AmiciCount-=1;
        aggiornaAmiciCount();
   }
   }

  }
  IEnumerator LatePunti(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
       // aggiornaPuntiAmico();
    }

   public IEnumerator GetNameOfFriends(Action<string> onCallback) //baffo
 { 
    Debug.Log("Ciao"+i);
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("NameOfFriends").Child("NameOfFriends"+i).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke((snapshot.Value).ToString()); 
   }
  }
     public IEnumerator GetPuntiOfFriends(Action<float> onCallback) //baffo
 { 
    Debug.Log("Ciao"+i);
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[i]).Child("punti").Child("punti").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(float.Parse((snapshot.Value).ToString())); 
   }
  }
  public IEnumerator GetLivelloOfFriends(Action<float> onCallback) //baffo
 { 
    Debug.Log("Ciao"+i);
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[i]).Child("level").Child("level").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(float.Parse((snapshot.Value).ToString())); 
   }
  }
     public IEnumerator AddNameOfFriends(Action<string> onCallback) 
 { 
    Debug.Log(i);
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(codiceNuovoAmico[AmiciCount-1]).Child("username").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
    Debug.Log(snapshot.Value);
        onCallback.Invoke((snapshot.Value).ToString()); 
       
   }
  }
  public IEnumerator SalutaUser(Action<string> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("username").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   Debug.Log(snapshot.Value);
        onCallback.Invoke((snapshot.Value).ToString()); 
   }
  }

   public IEnumerator GetLivello(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("level").Child("level").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }

  }
   public IEnumerator GetExp(Action<float> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ExpBar").Child("ExpBar").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
 }
    public IEnumerator GetExpTot(Action<float> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("ExpTot").Child("ExpTot").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
 }
   public IEnumerator GetPunti(Action<float> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("punti").Child("punti").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
 
    T_Punti.text="Punti: 0";
 
   }else{
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
   }
   }
   
 }
 
 public IEnumerator GetQCompletati(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("QCompletati").Child("QCompletati").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(0);
   }else{
        onCallback.Invoke(int.Parse((snapshot.Value).ToString()));
   }
   }
   
 }
 public IEnumerator GetID(Action<string> onCallback) 
 { 

   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child(cambioID).GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke("");
   }else{
        onCallback.Invoke((snapshot.Value).ToString());
   }
   }
   
 }
 public IEnumerator GetSoldi(Action<int> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("Soldi").Child("Soldi").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(0);
   }else{
        onCallback.Invoke(int.Parse((snapshot.Value).ToString()));
   }
   }
   
 }
 public IEnumerator GetItem1(Action<bool> onCallback) 
 { 
   
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("item1").Child("item1").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
   
 }
  public IEnumerator GetItem2(Action<bool> onCallback) 
 { 
   
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(cambioID).Child("item2").Child("item2").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
   
 }
 public IEnumerator GetPuntiQ(Action<float> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("puntiQ").Child("puntiQ").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(0);
   }else{
        onCallback.Invoke(float.Parse((snapshot.Value).ToString()));
   }
   }
   
 }
  public IEnumerator Getd(Action<int> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("d").Child("d").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(0);
   }else{
        onCallback.Invoke(int.Parse((snapshot.Value).ToString()));
   }
   }
 }
 public IEnumerator GetQ1(Action<bool> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q1").Child("Q1").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
 }
 public IEnumerator GetQ2(Action<bool> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q2").Child("Q2").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
 }
 public IEnumerator GetQ3(Action<bool> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q3").Child("Q3").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
 }
 public IEnumerator GetQ4(Action<bool> onCallback) 
 { 
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("Q4").Child("Q4").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   if(snapshot.Value==null){
    onCallback.Invoke(false);
   }else{
        onCallback.Invoke(Convert.ToBoolean(snapshot.Value));
   }
   }
 }
public IEnumerator GetCodiceAmico(Action<string> onCallback) 
 { 
   
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(uid).Child("codiceAmico").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
   
        onCallback.Invoke((snapshot.Value).ToString()); 
   }
  }
 
public IEnumerator lategetDataCurrent(float waitTime){
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetRequestd("https://www.arduinoxing.it/Request/timed.php"));
    yield return new WaitForSeconds(waitTime);
                     GetDataCurrent();

}
void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus==true)
            {
                isPaused = false;
                if (Login.activeSelf==false)
                    {
                     
                   //  StartCoroutine(lategetDataCurrent(0.1f));
                     // StartCoroutine (LateAggiornaOra(0.1f));//  AggiungiNuovoUtenteOnline();
                    }
            }
        else
            {
                isPaused = true;
            }
    }
void OnApplicationPause(bool inPausa)
    {
        if (inPausa==true)
            {
                isPaused = true;
            }
        else
            {
                if (Login.activeSelf==false)
                    {
                        
                    }
                isPaused = false;
            }
    }


public void back()
    {I_R_Email.text="";
    I_R_Username.text="";
    I_R_RepeatPw.text="";
    I_R_Password.text="";
    T_R_Error.text = "";
    TeC.isOn=false;
    Pp.isOn=false;
        Register.SetActive(false);
        Login.SetActive(true);
    }
     public void ScambiaPunti()
    {
        P_Premi.SetActive(true);
    }
     public void Indietro_ScambiaPunti()
    {
        P_Premi.SetActive(false);
    }
    public void FuncTeC()
    {
        P_TeC.SetActive(true);
    }
    public void Indietro_FuncTeC()
    {
        P_TeC.SetActive(false);
    }
    public void Avanti_FuncTeC()
    {
        P_TeC.SetActive(false);
        TeC.isOn=true;
    }

      public void FuncPp()
    {
        P_Pp.SetActive(true);
    }
    public void Indietro_FuncPp()
    {
        P_Pp.SetActive(false);
    }
    public void Avanti_FuncPp()
    {
        P_Pp.SetActive(false);
            Pp.isOn=true;
    }
public void logout(){
    auth = Firebase.Auth.FirebaseAuth.DefaultInstance;          
        auth.SignOut();
       caricamentoX=true;
        countConsigliati=6;
     TimerMinuti=0;
   TimerSecondi=0;
     AmiciCount=0;
    Login.SetActive(true);
    P_Principale.SetActive(false);
 
}

public void shareButton()
    {
 StartCoroutine(GetCodiceAmico((string codiceAmico2)=>{
        Debug.Log(codiceAmico2);
        new NativeShare().SetSubject("Scarica").SetText("Scarica anche tu: Tedio! Con il codice amico otterrai 5 punti esperienza. Scaricalo subito! https://play.google.com/store/apps/details?id=com.xing.WeAreBored&gl=IT"+"\nCodice amico: "+codiceAmico2).Share() ;
        //Title.text="Siamo annoiati In "+codiceAmico;
       })); 

    
    }
  
}
