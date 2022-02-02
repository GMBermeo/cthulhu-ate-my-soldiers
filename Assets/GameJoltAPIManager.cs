using UnityEngine;
using System.Collections; 
using System;


public class GameJoltAPIManager : MonoBehaviour {

public int gameID = 31755;// The Game ID
public string privateKey = "12945c4a8f6d44bb29a70565312806da";//The Game Private Key
public string userName;//Leave Blank
public string userToken;//Leave Blank



void Awake()
	
{
			FimDeJogo.gameover = false;
			score.timer = 0.0;
			//DontDestroyOnLoad (gameObject);

//			GJAPI.Init(gameID, privateKey);
//			GJAPIHelper.Users.GetFromWeb(OnGetFromWeb);
//			GJAPI.Users.Verify (userName, userToken);
		//				GJAPI.Users.VerifyCallback += OnVerifyUser;
		//				GJAPI.Scores.Add (score.scorefinal.ToString(), (uint)score.scorefinal, 32987, "Main");

		//		if (!onetime) {

		//			onetime = true;
		//		}


	
	GJAPI.Init ( gameID, privateKey );//Initialize The Game
	GJAPIHelper.Users.GetFromWeb(OnGetFromWeb);//Get Information
//
//    GJAPI.Users.Verify ("GM_Bermeo", "666777666");
	GJAPI.Users.Verify (userName, userToken);
	GJAPI.Users.VerifyCallback += OnVerifyUser;

	
}



void Start ()
	
{
	
	Application.ExternalCall ( "GJAPI_AuthUser", gameObject.name, "MyMethodToCall" );
	
}

	
public void MyMethodToCall ( string response )
	
{
	
	string[] splittedResponse = response.Split ( ':' );
	
	string username = splittedResponse [0];
	
	string usertoken = splittedResponse [1];
	
	GJAPI.Users.Verify ( userName, userToken );
	
}



void OnGetFromWeb (string name, string token)
	
{
	
	Debug.Log (name + "@" + token);
	
	userName = name;
	
	userToken = token;

	GJAPI.Users.Verify (name, token);
	
}



void OnEnable()
	
{
	
	GJAPI.Users.VerifyCallback += OnVerifyUser;
	
}



void OnDisable()
	
{
	
	GJAPI.Users.VerifyCallback -= OnVerifyUser;
	
}



void OnVerifyUser ( bool success )
	
{
	
	if ( success )
		
	{
		
		Debug.Log ( "Login Confirmed!" );//Verified
			GJAPI.Scores.Add (score.scorefinal.ToString (), (uint)score.scorefinal, 33334, "Score");
			if (score.scorefinal>0) { GJAPI.Trophies.Add(10346); }
			if (score.scorefinal>9000) { GJAPI.Trophies.Add(10353); }
			if (score.scorefinal>10000) { GJAPI.Trophies.Add(10347); }
			if (score.scorefinal>50000) { GJAPI.Trophies.Add(10348); }
			if (score.scorefinal>100000) { GJAPI.Trophies.Add(10349); }
			if (score.scorefinal>1000000) { GJAPI.Trophies.Add(10352); }
	}
	
	else
		
	{
		
		Debug.Log ( "Nope Something Is Wrong!" );//Not Verified
		
	}
	
}

}
//using UnityEngine;
//using System.Collections;
//
//public class GameJoltAPIManager : MonoBehaviour {
//	
//	public int gameID = 31755;
//	public string privateKey = "12945c4a8f6d44bb29a70565312806da";
//	public string userName;
//	public string userToken;
////	public score score;
////	private string teste;
////	public bool onetime;
//	
//	void Awake () {
//				FimDeJogo.gameover = false;
//				score.timer = 0.0;
//				//DontDestroyOnLoad (gameObject);
//				gameID = 31755;
//				privateKey = "12945c4a8f6d44bb29a70565312806da";
//
//				GJAPI.Init(gameID, privateKey);
//				GJAPIHelper.Users.GetFromWeb(OnGetFromWeb);
////				GJAPI.Users.Verify ("GM_Bermeo", "666777666");
//				GJAPI.Users.Verify (userName, userToken);
////				GJAPI.Users.VerifyCallback += OnVerifyUser;
////				GJAPI.Scores.Add (score.scorefinal.ToString(), (uint)score.scorefinal, 32987, "Main");
//
//	//		if (!onetime) {
//				GJAPI.Scores.Add (score.scorefinal.ToString (), (uint)score.scorefinal, 33334, "Score");
//				if (score.scorefinal>0) { GJAPI.Trophies.Add(10346); }
//				if (score.scorefinal>9000) { GJAPI.Trophies.Add(10353); }
//				if (score.scorefinal>10000) { GJAPI.Trophies.Add(10347); }
//				if (score.scorefinal>50000) { GJAPI.Trophies.Add(10348); }
//				if (score.scorefinal>100000) { GJAPI.Trophies.Add(10349); }
//				if (score.scorefinal>1000000) { GJAPI.Trophies.Add(10352); }
//	//			onetime = true;
//	//		}
//		}
//		void OnGetFromWeb (string userName, string userToken)
//				
//			{
//				
//				Debug.Log (userName + "@" + userToken);			
//				GJAPI.Users.Verify ( userName, userToken );
//				
//			}
//
//
//				
////
////	void Start ()
////		
////	{
////		
////		Application.ExternalCall ( "GJAPI_AuthUser", gameObject.name, "MyMethodToCall" );
////		
////	}
////	void OnGetFromWeb (string name, string token)
////		
////	{
////		
////		Debug.Log (name + "@" + token);
////		
////		userName = name;
////		
////		userToken = token;
////		
////		GJAPI.Users.Verify ( userName, userToken );
////		
////	}
////
////	void OnVerifyUser ( bool success ) {
////		if ( success ) {
////			Debug.Log ( "Yepee!" );
////			teste = "VERIFICADO";
////
////		}
////		else {
////			Debug.Log ( "Um... Something went wrong." );
////			teste = "FODEU";		}
////	}
////	void OnEnable()
////		
////	{
////		
////		GJAPI.Users.VerifyCallback += OnVerifyUser;
////		
////	}
////	
////	
////	
////	void OnDisable()
////		
////	{
////		
////		GJAPI.Users.VerifyCallback -= OnVerifyUser;
////		
////	}
////		void OnGUI(){
////			GUI.Label (new Rect (Screen.width / 2, Screen.height / 6, 300, 100), "Verificaçao " + teste);
////			GUI.Label (new Rect (Screen.width / 2, Screen.height / 5, 300, 100), "name " + name);
////			GUI.Label (new Rect (Screen.width / 2, Screen.height / 4, 300, 100), "username " + userName);
//////			GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 300, 100), "token " + token);
////			GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 300, 100), "userToken " + userToken);
////		}
//
//}