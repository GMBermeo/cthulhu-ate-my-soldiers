using UnityEngine;
using System.Collections;

public class segue_player : MonoBehaviour {
	public Vector3 velocidade;	//Velocidade que o soldado segue o player
	public bool olhando_direita = true; // orientaçao inicial do personagem

	public bool pertoPlayer = false; //saber se o soldado esta ou nao na distancia para atirar
	public Vector2 dis_tiro;
	private Transform player;		// O alvo, no caso o player

	//parar de andar se tem soldier na frente
//	bool fila = false;

	//animaçao
	Animator anim;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("ovo").transform;//acha o player pela sua tag
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		seguePlayer();

		Vector2 targetDir = transform.position - player.position ;
		//Debug.Log ("DIS"+targetDir);
		if (dis_tiro.x > targetDir.x && targetDir.x > -dis_tiro.x && transform.position.y >= 0.1158416 && transform.position.y <= 0.4467483 && !FimDeJogo.gameover) {
						//Debug.Log ("PERTO");
			anim.SetBool("fire",true);//aciona animaçao de tiro
			anim.SetFloat("speed",Mathf.Abs(0f));
			pertoPlayer = true;
				} 
		else {
			pertoPlayer = false;
			anim.SetBool("fire",false);//desaciona animaçao de tiro
			}
	}
	void seguePlayer(){
		//Segue o player
		if (!pertoPlayer && !FimDeJogo.gameover) {//so vai andar se nao tiver perto
			anim.SetFloat("speed",Mathf.Abs(3f));
						if (transform.position.x < player.position.x) {
								transform.position = transform.position + velocidade;
								if (!olhando_direita)
										flip ();
						}
						if (transform.position.x > player.position.x) {
								transform.position = transform.position - velocidade;
								if (olhando_direita)
										flip ();
						}
				}
	}
	//vira o soldier de acordo com sua orientaçao
	void flip(){
		olhando_direita = !olhando_direita;
		Vector3 escala = transform.localScale;
		escala.x = escala.x * -1;
		transform.localScale = escala;
	}

}
