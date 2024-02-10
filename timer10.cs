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
//using GoogleMobileAds.Api;
//using Firebase.Unity.Editor;
using UnityEngine.Advertisements;
public class timer10 : MonoBehaviour,IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{ public Text T_Punti;
public float punti;
    [Header("Firebase")]
   public DependencyStatus dependencyStatus;
    public FirebaseAuth auth;    
    public FirebaseUser User;
     public string uid;
     public Text T_Video;
    public Button B_Video;
    public Text  P_T_Scatola; 
    public GameObject P_Scatola;
    public GameObject scatola;
    public main main;
   public string secString;
public string minString;
 public int TimerMinuti;
public  int TimerSecondi;
public int TimerOre;
     public Text TimerButton;
  public bool AttivaTimer=true;
public int ora10min;
public int oraM10min;
public int oraH10min;
public int dopo10min;
public int dopo10minH;
public int dopo10minM;
public float timing;
 bool aggiornaora=true;
[SerializeField] Button _showAdButton;
[SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _iOSAdUnitId = "Rewarded_iOS";
    [SerializeField] string _androidGameId="5076459";
    [SerializeField] string _iOSGameId="5076458";
     private string _gameId;
     string _adUnitId;
     public GameObject Login;
    // Start is called before the first frame update
    void Start()
    {
       

    }
   public IEnumerator LateGetDopo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
StartCoroutine(Getdopo((int dopo2)=>{
    dopo10min=dopo2;
    }));
    yield return new WaitForSeconds(waitTime);
StartCoroutine(GetdopoM((int dopoM2)=>{
    dopo10minM=dopoM2;
    }));
    yield return new WaitForSeconds(waitTime);
    StartCoroutine(GetdopoH((int dopoH2)=>{
    dopo10minH=dopoH2;
    }));
    yield return new WaitForSeconds(waitTime);
    StartCoroutine (LateAggiornaora10min(0.1f));
    }
     public IEnumerator Getdopo(Action<int> onCallback) 
 { 
   main=main.GetComponent<main>();
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10min").Child("dopo10min").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }

     public IEnumerator GetdopoM(Action<int> onCallback) 
 { 
   main=main.GetComponent<main>();
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10minM").Child("dopo10minM").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
       public IEnumerator GetdopoH(Action<int> onCallback) 
 { 
   main=main.GetComponent<main>();
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10minH").Child("dopo10minH").GetValueAsync();
   yield return new WaitUntil(predicate: () => userNameData.IsCompleted);
   if(userNameData!=null){ 
   DataSnapshot snapshot = userNameData.Result;
        onCallback.Invoke(int.Parse((snapshot.Value).ToString())); 
   }
  }
    // Update is called once per frame
    public void xButton(){

    StartCoroutine( LateGetDopo(0.1f));
        StartCoroutine( LateAggiornaora10min(0.1f));
        Debug.Log("fghdgfnjgfdnjgfhgfhgf");}


    IEnumerator LateGetPunti(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetPunti((float punti2)=>{
                       main=main.GetComponent<main>(); 
                        main.punti=punti2;
                        float number = Mathf.Round(Random.Range(0.1f, 0.3f)*10f)/10f;
                     
                        T_Video.text=number.ToString("F1")+" ";
                        
                        main.punti+=float.Parse(number.ToString("F1"));
                        T_Punti.text="Punti: "+main.punti.ToString("F1");

                        main.PuntiQ+=float.Parse(number.ToString("F1"));
                         if(main.PuntiQ<5){
                            main.T_Q1.text="Ottenuti "+main.PuntiQ.ToString("F1")+"/5";
                            main.B_Q1.interactable=false;
                            
                        }
                        else if (main.PuntiQ==null){
                            main.T_Q1.text="Ottenuti "+"0"+"/5";
                            main.B_Q1.interactable=false;
                           
                        }
                        else
                        {
                             main.T_Q1.text="Ottenuti "+"5"+"/5";
                             main.B_Q1.interactable=main.Q1;
                            
                        }
                       if(main.PuntiQ<10){
                         main.T_Q2.text="Ottenuti "+main.PuntiQ.ToString("F1")+"/10";
                         main.B_Q2.interactable=false;
                         
                       }
                       else if (main.PuntiQ==null){
                            main.T_Q2.text="Ottenuti "+"0"+"/10";
                            main.B_Q2.interactable=false;
                            
                        }
                         else{
                            main.T_Q2.text="Ottenuti "+"10"+"/10";
                            main.B_Q2.interactable=main.Q2;
                           
                         }
                            main.QCompletati=Convert.ToInt32(main.B_Q1.interactable)+Convert.ToInt32(main.B_Q2.interactable)+Convert.ToInt32(main.B_Q3.interactable);
                            if(main.QCompletati<3){
                                main.T_Q4.text="Completati "+main.QCompletati+"/3";
                                main.B_Q4.interactable=false;
                               
                            }
                            else{
                                main.T_Q4.text="Completati 3/3";
                                main.B_Q4.interactable=main.Q4;
                                
                            }
                        }));
       yield return new WaitForSeconds(waitTime);
        aggiornaPunti();
        main.aggiornaPuntiQ();
    }
public void aggiornaPunti() 
{  
     main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("punti").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
    
      newScoreMap["punti"] = main.punti;
      mutableData.Value = newScoreMap;
      return TransactionResult.Success(mutableData);
    });
} 
     public IEnumerator GetPunti(Action<float> onCallback) 
 { 
    main=main.GetComponent<main>();
   var userNameData = FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("punti").Child("punti").GetValueAsync();
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
      public void PuntiScatola(){
        
    StartCoroutine(LateGetPunti(0.1f));
    LoadAd();
    StartCoroutine(LateAggiornadopo10min(0.1f));
            TimerMinuti=9;
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

             scatola.GetComponent<ChangeBright>().enabled=false;
        scatola.GetComponent<Image>().color = new Color(0,0,0,0.7f);
        scatola.GetComponent<Button>().interactable=false;
        
        P_Scatola.SetActive(true);
    }
    public void Indietro_scatolaBloccata(){
    P_Scatola.SetActive(false);
    scatola.SetActive(false);
    main.P_Random.SetActive(true);
    }
    public void GuardaVideo(){
         
         ShowAd();
         B_Video.interactable=false;
    }


       IEnumerator LateGetPuntiVideo(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(main.GetPunti((float punti2)=>{
                        main=main.GetComponent<main>();
                        main.punti=punti2;
                        float number = Random.Range(0.3f, 1.5f);
                        main.punti+=float.Parse(number.ToString("F1"));
                        T_Video.text=number.ToString("F1")+" ";
                        T_Punti.text="Punti: "+main.punti.ToString("F1");
                        main.PuntiQ+=float.Parse(number.ToString("F1"));
                         if(main.PuntiQ<5){
                            main.T_Q1.text="Ottenuti "+main.PuntiQ.ToString("F1")+"/5";
                            main.B_Q1.interactable=false;
                            
                        }
                        else if (main.PuntiQ==null){
                            main.T_Q1.text="Ottenuti "+"0"+"/5";
                            main.B_Q1.interactable=false;
                           
                        }
                        else
                        {
                             main.T_Q1.text="Ottenuti "+"5"+"/5";
                             main.B_Q1.interactable=main.Q1;
                            
                        }
                       if(main.PuntiQ<10){
                         main.T_Q2.text="Ottenuti "+main.PuntiQ.ToString("F1")+"/10";
                         main.B_Q2.interactable=false;
                         
                       }
                       else if (main.PuntiQ==null){
                            main.T_Q2.text="Ottenuti "+"0"+"/10";
                            main.B_Q2.interactable=false;
                            
                        }
                         else{
                            main.T_Q2.text="Ottenuti "+"10"+"/10";
                            main.B_Q2.interactable=main.Q2;
                           
                         }
                            main.QCompletati=Convert.ToInt32(main.B_Q1.interactable)+Convert.ToInt32(main.B_Q2.interactable)+Convert.ToInt32(main.B_Q3.interactable);
                            if(main.QCompletati<3){
                                main.T_Q4.text="Completati "+main.QCompletati+"/3";
                                main.B_Q4.interactable=false;
                               
                            }
                            else{
                                main.T_Q4.text="Completati 3/3";
                                main.B_Q4.interactable=main.Q4;
                                
                            }
                        }));
                        
       yield return new WaitForSeconds(waitTime);
        main.aggiornaPunti();
        yield return new WaitForSeconds(waitTime);
        main.aggiornaPuntiQ();
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
         //   _showAdButton.interactable = true;
        }
    }
 
    // Implement a method to execute when the user clicks the button:
    public void ShowAd()
    {
        // Disable the button:
        _showAdButton.interactable = false;
        // Then show the ad:
        Advertisement.Show(_adUnitId, this);
    }
 
    // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {   
            StartCoroutine(LateGetPuntiVideo(0.1f));

            TimerMinuti=9;
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

            Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
             main.adscount+=1;
            main.aggiornaAdsCount();
             main.adscount2-=1;
            main.aggiornaAdsCount2();

            if(main.adscount2<=0){
             main.resetMonete();
             main.Bool_monete=true;
             main.aggiornaAdsCount2();
             main.aggiornaMonete();
            }
            if(main.adscount>=10){
                
                
                main.resetUovo();
                main.Bool_uovo=true;
                main.aggiornaUovo();
                main.uovobright.GetComponent<ChangeBright>().enabled=true;
                
                main.aggiornaAdsCount();
            }
          // StartCoroutine(LateGetPunti(0.1f));
  
            // Load another ad:
            LoadAd();
          //  Advertisement.Load(_adUnitId, this);
            
        }
    }


    public IEnumerator LateAggiornaora10min(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequests("https://www.arduinoxing.it/Request/times.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestm("https://www.arduinoxing.it/Request/timem.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequesth("https://www.arduinoxing.it/Request/timeh.php"));
    yield return new WaitForSeconds(waitTime);
    aggiornaora10min();
    yield return new WaitForSeconds(waitTime);
    aggiornaoraM10min();
    yield return new WaitForSeconds(waitTime);
    aggiornaoraH10min();
 yield return new WaitForSeconds(waitTime);

if((oraH10min-dopo10minH)<0){
    TimerOre=oraH10min+(24-dopo10minH);
    if(TimerOre==1){
        
    if(oraM10min<dopo10minM){
        //40   50
      TimerMinuti=oraM10min+(60-dopo10minM);

      if(TimerMinuti>=10){
                            TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                        }
                        else if (TimerMinuti<10){
                             AttivaTimer=true;/////DISATTIVA BUTTON///
                            _showAdButton.interactable = false;
                            scatola.GetComponent<ChangeBright>().enabled=false;
                            scatola.GetComponent<Image>().color = new Color(0,0,0,0.7f);
                             scatola.GetComponent<Button>().interactable=false; 
                             if(ora10min<dopo10min){
                               TimerSecondi=60-( ora10min+(60-dopo10min));
                             }
                             else if(ora10min>dopo10min){
                                TimerSecondi=60-(ora10min-dopo10min);
                             }
                        }
                        if((oraM10min-dopo10minM)==0){
                            if((ora10min-dopo10min)==0){
                                TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                            }
                        }
    }
    }
    
    else if (TimerOre>1){
                          TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
    }
}
if((oraH10min-dopo10minH)>1){
                         TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
}
 else if((oraH10min-dopo10minH)==1){
    if(oraM10min<dopo10minM){
        //05   59
      TimerMinuti=oraM10min+(60-dopo10minM);
      if(TimerMinuti>=10){
                            TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                        }
                        else if (TimerMinuti<10){
                             AttivaTimer=true;/////DISATTIVA BUTTON///
                            _showAdButton.interactable = false;
                            scatola.GetComponent<ChangeBright>().enabled=false;
                            scatola.GetComponent<Image>().color = new Color(0,0,0,0.7f);
                             scatola.GetComponent<Button>().interactable=false; 
                             if(ora10min<dopo10min){
                               TimerSecondi=60-( ora10min+(60-dopo10min));
                             }
                             else if(ora10min>dopo10min){
                                TimerSecondi=60-(ora10min-dopo10min);
                             }
                        }
                        if((oraM10min-dopo10minM)==0){
                            if((ora10min-dopo10min)==0){
                                TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                            }
                        }
    }
    else if(oraM10min>dopo10minM){
        //50   40
      TimerMinuti=oraM10min-dopo10minM;
      if(TimerMinuti>=10){
                            TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                        }
                        else if (TimerMinuti<10){
                             AttivaTimer=true;/////DISATTIVA BUTTON///
                            _showAdButton.interactable = false;
                            scatola.GetComponent<ChangeBright>().enabled=false;
                            scatola.GetComponent<Image>().color = new Color(0,0,0,0.7f);
                             scatola.GetComponent<Button>().interactable=false; 
                             if(ora10min<dopo10min){
                               TimerSecondi=60-( ora10min+(60-dopo10min));
                             }
                             else if(ora10min>dopo10min){
                                TimerSecondi=60-(ora10min-dopo10min);
                             }
                        }
                        if((oraM10min-dopo10minM)==0){
                            if((ora10min-dopo10min)==0){
                                TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                            }
                        }
 }

    }
    else if((oraH10min-dopo10minH)==0){
                        //17 18
                        if(oraM10min<dopo10minM){
                         TimerMinuti= 10-(oraM10min+(60-dopo10minM));
                        }
                        else
                        if(oraM10min>dopo10minM){
                            TimerMinuti=10-(oraM10min-dopo10minM);
                        }
                        if(TimerMinuti>=10){
                            TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                         Debug.Log("1");
                        }
                        else if (TimerMinuti<10){
                             AttivaTimer=true;/////DISATTIVA BUTTON///
                            _showAdButton.interactable = false;
                            scatola.GetComponent<ChangeBright>().enabled=false;
                            scatola.GetComponent<Image>().color = new Color(0,0,0,0.7f);
                             scatola.GetComponent<Button>().interactable=false; 
                             if(ora10min<dopo10min){
                               TimerSecondi=60-( ora10min+(60-dopo10min));
                             }
                             else if(ora10min>dopo10min){
                                TimerSecondi=60-(ora10min-dopo10min);
                             }
                        }
                        else if((oraM10min-dopo10minM)==0){
                            if((ora10min-dopo10min)==0){
                                TimerButton.text="";
                            AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                         Debug.Log("2");
                            }
                        }
            }    
            else{
                            TimerButton.text="";
                           AttivaTimer=false;
                            LoadAd();//////ATTIVA BUTTON//////////
                         scatola.GetComponent<ChangeBright>().enabled=true;
                         B_Video.interactable=true;
                         scatola.GetComponent<Button>().interactable=true;
                         Debug.Log("3");
            }         
    }
        IEnumerator LateAggiornadopo10min(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopo10mins("https://www.arduinoxing.it/Request/times.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopo10minm("https://www.arduinoxing.it/Request/timem.php"));
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(GetRequestdopo10minh("https://www.arduinoxing.it/Request/timeh.php"));
    yield return new WaitForSeconds(waitTime);
    aggiornadopo10min();
    yield return new WaitForSeconds(waitTime);
    aggiornadopo10minM();
    yield return new WaitForSeconds(waitTime);
    aggiornadopo10minH();

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

void Awake()
    {
#if UNITY_IOS
        _adUnitId = _iOSAdUnitId;
        
#elif UNITY_ANDROID
        _adUnitId = _androidAdUnitId;
#endif
      

        //Disable the button until the ad is ready to show:
        _showAdButton.interactable = false;
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
    //_gameId = _iOSGameId;
     
    _gameId= _androidGameId;
     Advertisement.Initialize(_gameId,false,this);
}
    private void InitializeFirebase()
        {
            Debug.Log("Setting up Firebase Auth");
            //Set the authentication instance object
            auth = main.auth;
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
                ora10min= int.Parse(webRequest.downloadHandler.text);
                
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
                oraM10min= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log(oraM10min);
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
                oraH10min= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( oraH10min);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopo10mins(string uri)
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
                dopo10min= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log(dopo10min);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopo10minm(string uri)
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
                dopo10minM= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( dopo10minM);
                    break;
            }
        }
    }
    IEnumerator GetRequestdopo10minh(string uri)
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
                dopo10minH= int.Parse(webRequest.downloadHandler.text);
                    Debug.Log( dopo10minH);
                    break;
            }
        }
    }
     public void aggiornaoraH10min() 
{   main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("oraH10min").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["oraH10min"] = oraH10min;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornaoraM10min() 
{   main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("oraM10min").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["oraM10min"] = oraM10min;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornaora10min() 
{  
     main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("ora10min").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["ora10min"] = ora10min;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornadopo10minH() 
{  
     main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10minH").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopo10minH"] = dopo10minH;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
 public void aggiornadopo10minM() 
{  
     main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10minM").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopo10minM"] = dopo10minM;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 
public void aggiornadopo10min() 
{  
     main=main.GetComponent<main>();
    FirebaseDatabase.GetInstance("https://we-are-bored-87e2d-default-rtdb.europe-west1.firebasedatabase.app").GetReference("users").Child(main.uid).Child("dopo10min").RunTransaction(mutableData => {
      List<object> leaders = mutableData.Value as List<object>;
      leaders = new List<object>();
    Dictionary<string, object> newScoreMap =
                       new Dictionary<string, object>();
        
      newScoreMap["dopo10min"] = dopo10min;
      
      mutableData.Value = newScoreMap;
     
      return TransactionResult.Success(mutableData);
    });
} 


void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus==true)
            {
                if (Login.activeSelf==false)
                    {
                        StartCoroutine(LateGetDopo(0.1f));
                        StartCoroutine(LateAggiornaora10min(0.1f));
                      //  AggiungiNuovoUtenteOnline();
                    }
            }
        else
            {
                
            }
    }


    public void logout(){
        scatola.GetComponent<Button>().interactable=true;
        AttivaTimer=true;
     TimerMinuti=0;
   TimerSecondi=0;
   aggiornaora=true;
    Login.SetActive(true);
 punti=0;
}
}
