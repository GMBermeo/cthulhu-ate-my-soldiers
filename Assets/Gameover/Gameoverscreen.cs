using UnityEngine;
using System.Collections;

public class Gameoverscreen : MonoBehaviour {
//	
//	public int gameID;
//	public string privateKey;
//	public string userName;
//	public string userToken;
//	//	public score score;
//	public bool onetime;



	void Awake () {


		//		DontDestroyOnLoad (gameObject);
		//		//gameID = 31755
//		//privateKey = 12945c4a8f6d44bb29a70565312806da
//		
//		GJAPI.Init (gameID, privateKey);
//		//				GJAPIHelper.Users.GetFromWeb (OnGetFromWeb);
//		GJAPI.Users.Verify ("GM_Bermeo", "715d9f");
//		//				GJAPI.Users.Verify ( userName, userToken );
//		GJAPI.Users.VerifyCallback += OnVerifyUser;
//		//				GJAPI.Scores.Add (score.scorefinal.ToString(), (uint)score.scorefinal, 32987, "Main");
	}
	void Update(){
//		if (FimDeJogo.gameover) {
//			if (!onetime) {
//				GJAPI.Scores.Add (score.scorefinal.ToString (), (uint)score.scorefinal, 33334, "Score");
//				if (score.scorefinal>0) { GJAPI.Trophies.Add(10346); }
//				if (score.scorefinal>9000) { GJAPI.Trophies.Add(10353); }
//				if (score.scorefinal>10000) { GJAPI.Trophies.Add(10347); }
//				if (score.scorefinal>50000) { GJAPI.Trophies.Add(10348); }
//				if (score.scorefinal>100000) { GJAPI.Trophies.Add(10349); }
//				if (score.scorefinal>1000000) { GJAPI.Trophies.Add(10352); }
//				onetime = true;
//			}
			
			if (Input.GetKeyDown (KeyCode.X)) {
				Application.LoadLevel("Main");
				score.scorefinal = 1;
				score.scorecombo = 1;
				score.dificuldade = 1;
				score.kill = 0;
				score.bodycount = 0;
				score.timer = 0.0;
				ovo_life.vida_ovo = 250;
			}
	}
}