using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public float vida = 5000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//	void OnTriggerEnter2D (Collider2D col) 
//	{
//		if (ovo_life.tomandodano = true ) {
//			vida -= 1;//se atingir um soldado deve descontar um ponto de vida
//			if(vida==0) Destroy(gameObject);
//			Destroy (col.gameObject);//e se destruir
//		}
//		
//	}
	void OnGUI(){
		GUI.Label (new Rect (Screen.width / 2, Screen.height / 5, 100, 100), "Vida " + vida);
		}
}
