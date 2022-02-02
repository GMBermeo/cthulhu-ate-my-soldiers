using UnityEngine;
using System.Collections;

public class GameJoltAPIManager : MonoBehaviour {
	
	public int gameID;
	public string privateKey;
	public string userName;
	public string userToken;

	void Awake () {
		DontDestroyOnLoad ( gameObject );
		//gameID = 31755
		//privateKey = 12945c4a8f6d44bb29a70565312806da
		GJAPI.Init ( 31755, "12945c4a8f6d44bb29a70565312806da");
		GJAPI.Users.Verify ( "GM_Bermeo", "715d9f" );
		//GJAPI.Users.Verify ( userName, userToken );
		GJAPI.Users.VerifyCallback += OnVerifyUser;
		
	}
	
	void OnVerifyUser ( bool success ) {
		if ( success ) {
			Debug.Log ( "Yepee!" );
		}
		else {
			Debug.Log ( "Um... Something went wrong." );
		}
	}

}