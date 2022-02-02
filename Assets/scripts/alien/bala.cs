using UnityEngine;
using System.Collections;


public class bala : MonoBehaviour {
	public Vector2 velocidade;
	player_movement pm;

	// Use this for initialization
	void Start () {
		audio.Play();
		//acha e usa o codigo do player como parametro
		pm = GameObject.Find("player").GetComponent("player_movement") as player_movement;

		//muda a direçao da bola de acido para o lado que esta olhando
		if (!pm.olhando_direita) {
			flip ();
			velocidade = -velocidade;
		}
	}
	
	// Update is called once per frame
	void Update () {
			//Lança 
			rigidbody2D.AddForce (velocidade);

	}

	//vira a bala de acordo com sua direçao
	void flip(){
		Vector2 escala = transform.localScale;
		escala.x = escala.x * -1;
		transform.localScale = escala;
		

	}

	/*void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.tag == "soldier") {
			col.gameObject.GetComponent<soldier>().vida = 0;//se atingir um soldado deve mata-lo
						Destroy (gameObject);//e se destruir
				}

	}*/
	/*void OnCollisionEnter2D(Collision2D collision){
		//Destroy(objectYouCollidedWith);
		Debug.Log("Hit");
	}*/
}
