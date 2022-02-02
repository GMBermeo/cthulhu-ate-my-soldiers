using UnityEngine;
using System.Collections;

public class Scoreimport : MonoBehaviour {

	public GUIText mostrapont;
	public GUIText mostrapontsombra;

 
	void Update () {
		mostrapont.text = "Score:" + score.scorefinal;
		mostrapontsombra.text = "Score:" + score.scorefinal;
	
	}
}
