using UnityEngine;
using System.Collections;


public class score : MonoBehaviour {
	
	public static int scorefinal = 1;
	public static int scorecombo = 1;
	public static int dificuldade = 1;
	public static int kill = 0;
	public static int bodycount = 0;
	public static double timer = 0.0;
	public GUIText mostrapont;
	public GUIText mostrapontsombra;

	//API
	/// <summary>
	/// <para>Class representing the Score API callback information.</para>
	/// <para>See: http://gamejolt.com/api/doc/game/scores/fetch/ for further information.</para>
	/// <para>@author Christian "HyperGod" Bosence</para>
	/// <para>@version 0.1.0.0</para>
	/// </summary>
//	private int Sort;
//	private string value;
//	private string Extra_data;
//	private string User;
//	private int userid;
//	private string Guest;
//	private string Stored;




	void Update () {
				if (!FimDeJogo.gameover) {
			mostrapont.text = "Score:" + scorefinal;
			mostrapontsombra.text = "Score:" + scorefinal;

						timer += Time.deltaTime;
						scorecombo = (bodycount * kill) + dificuldade * 1000;
						if (scorefinal < scorecombo) {
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;
								scorefinal++;


			
						}
						dificuldade = (int)timer / 10;
				}
			if (FimDeJogo.gameover) {
				
				
				//							if (Input.GetKeyDown (KeyCode.X)) {
				Application.LoadLevel("Gameover");
				//								score.scorefinal = 1;
				//								score.scorecombo = 1;
				//								score.dificuldade = 1;
				//								score.kill = 0;
				//								score.bodycount = 0;
				//								score.timer = 0.0;
				//								ovo_life.vida_ovo = 250;
				//								FimDeJogo.gameover = false;
				//							}
			}
		}

//	if(gameover(true)){
//		}

	
		/// <summary>
		/// <para>Class representing the scoretable API callback information.</para>
		/// <para>See: http://gamejolt.com/api/doc/game/scores/fetch/ for further information.</para>
		/// <para>@author Christian "HyperGod" Bosence</para>
		/// <para>@version 0.1.0.0</para>
		/// </summary>

//	void OnGUI(){
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 100), Debug.Log);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 6, 300, 100), "dificuldade " + dificuldade);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 5, 300, 100), "scorefinal " + scorefinal);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 4, 300, 100), "scorecombo " + scorecombo);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 300, 100), "vida_ovo " + ovo_life.vida_ovo);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 7, 300, 100), "Gameover " + FimDeJogo.gameover);
//	}
}