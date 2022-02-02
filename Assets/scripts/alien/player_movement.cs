using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {
	public float vel_movimento; // velocidade do movimento do personagem
	public float forca_pulo;
	public bool olhando_direita = true;

	//animaçao
	Animator anim;

	//Variavel para saber se o player toca em algo
	public bool grounded;

	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		movimento_personagem();
		pulo ();
	}

	void movimento_personagem(){
		//Movimento do personagem por seta ou por WASD
		if (Input.GetKey(KeyCode.LeftArrow) ||Input.GetKey(KeyCode.A)){//Vai para a Esquerda
			transform.Translate(-Vector2.right * vel_movimento * Time.deltaTime);

			if(olhando_direita)flip();

			anim.SetFloat("speed",Mathf.Abs(3f));
		}
		else if (Input.GetKey(KeyCode.RightArrow) ||Input.GetKey(KeyCode.D)){//Vai para a Direita
			transform.Translate(Vector2.right * vel_movimento * Time.deltaTime);
			if(!olhando_direita)flip();

			anim.SetFloat("speed",Mathf.Abs(3f));
		}
		//soltar teclas de movimento
		if (Input.GetKeyUp(KeyCode.LeftArrow) ||Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.RightArrow) ||Input.GetKeyUp(KeyCode.D)){ 
			anim.SetFloat("speed",Mathf.Abs(0f));
		}


	}
	//pula
	void pulo(){
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) {
			rigidbody2D.AddForce(new Vector2(0f, forca_pulo));
			anim.SetBool("jump",true);
			grounded = false;
		}
	}
	//Vira o personagem de acordo com a sua direçao
	void flip(){
			olhando_direita = !olhando_direita;
			Vector3 escala = transform.localScale;
			escala.x = escala.x * -1;
			transform.localScale = escala;
		}
	//Se colidir ele pode pular
	void OnCollisionEnter2D(Collision2D coll) {
		anim.SetBool("jump",false);
		grounded = true;
	}

}
