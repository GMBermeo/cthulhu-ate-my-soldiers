using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	
	static int scorefinal = 0;
	static int scorecombo = 0;
	public static int dificuldade = 1;
	public static int kill = 0;
	public static int bodycount = 0;
	public static double timer = 0.0;
	public GUIText mostrapont;
	public GUIText mostrapontsombra;
	

	void Update () {
		mostrapont.text = scorefinal + ":scorE";
		mostrapontsombra.text = scorefinal + ":scorE";

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
		dificuldade = (int)timer/10;
			}


//	void OnGUI(){
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 300, 100), "tempo " + timer);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 6, 300, 100), "dificuldade " + dificuldade);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 5, 300, 100), "scorefinal " + scorefinal);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 4, 300, 100), "scorecombo " + scorecombo);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 3, 300, 100), "vida_ovo " + ovo_life.vida_ovo);
//		GUI.Label (new Rect (Screen.width / 2, Screen.height / 7, 300, 100), "tomandodano " + ovo_life.tomandodano);
//	}
}