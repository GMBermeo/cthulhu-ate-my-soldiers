using UnityEngine;
using System.Collections;

public class balaSoldier : MonoBehaviour {
	public Vector2 velocidade;
	public bool olhandoDireita;
	
	// Use this for initialization
	void Start () {
		if (olhandoDireita) {
			velocidade = -velocidade;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		//Lança 
		rigidbody2D.AddForce (velocidade);
	}
}