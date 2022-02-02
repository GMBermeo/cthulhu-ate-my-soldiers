using UnityEngine;
using System.Collections;

public class ovo_life : MonoBehaviour {
	public AudioClip hitnoovo;
	public AudioClip quebrando;
	public AudioClip gameoversound;
//	public GameObject item;

	public static float vida_ovo = 250;

	public GameObject boxcollidor;


	//Sprites do ovo quebrando
	public Sprite ovo_0;
	public Sprite ovo_1;
	public Sprite ovo_2;
	public Sprite ovo_3;
	public Sprite ovo_4;
	public Sprite ovo_5;

	public static bool gameover = false;
	public static bool tomandodano = false;

	//Sprite do ovo tomando hit
	public Sprite ovo_hit_0;

	//Sprite atual
	Sprite ovo_atual;
	public static Sprite ovo_hitAtual;
	//controlador de tempo do hit
	float hitcooldown;


	// Use this for initialization
	void Start () {

				ovo_hitAtual = ovo_hit_0;
				ovo_atual = ovo_0;
		}

	void Update () {
				tomandodano = false;
				if (Time.time >= hitcooldown)
						gameObject.GetComponent<SpriteRenderer> ().sprite = ovo_atual;

				if (vida_ovo <= 999999999999 && vida_ovo > 300) {
					ovo_atual = ovo_0;
				}
				if (vida_ovo <= 300 && vida_ovo > 250) {
						ovo_atual = ovo_1;
				}
				if (vida_ovo <= 250 && vida_ovo > 200) {
						ovo_atual = ovo_2;
				}
				if (vida_ovo <= 200 && vida_ovo > 150) {
						ovo_atual = ovo_3;
				}
				if (vida_ovo <= 150 && vida_ovo > 0) {
						ovo_atual = ovo_4;
				}
				if (vida_ovo <= 0) {
						ovo_atual = ovo_5;
						gameover = true;
						audio.clip = gameoversound;
						audio.Play (); 
						Destroy (boxcollidor);
				}
		}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "tiro" && !gameover ) {
			tomandodano = true;
			hitcooldown = Time.time + 0.2f;
			gameObject.GetComponent<SpriteRenderer> ().sprite = ovo_hitAtual;//sprite de hit
			audio.clip = hitnoovo;
			audio.Play();
			vida_ovo -= 1;//se atingir o ovo deve descontar um ponto de vida
			Destroy (col.gameObject);
					}

		}

}

//	public void RecuperaVida(){
//				vida_ovo += 100;
//		}



//		void OnTriggerEnter2D (Collider2D col) 
//		{
//			if (col.tag == "bala") {
//				{vida_ovo -= 1;//se atingir um soldado deve descontar um ponto de vida
//					if(vida_ovo==0){
//						Destroy(gameObject);
//					}
//				}
//				Destroy (col.gameObject);//e se destruir
//
//			}
//		
//		}
//		//Destroy (col.gameObject);//e se destruir