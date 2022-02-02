using UnityEngine;
using System.Collections;

public class player_tiro : MonoBehaviour {
	public Rigidbody2D balaPreFab;
	public GameObject mira;
	public float cooldown;
	float tempo_tiro;

	//animaçao
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Time.time >= tempo_tiro) {

						if (Input.GetKeyDown (KeyCode.Z)) {
								tempo_tiro = Time.time + cooldown;
								anim.SetBool ("fire", true);//começa animaçao de tiro
								tiro ();
			
						}
						if (Time.time > tempo_tiro) {
								anim.SetBool ("fire", false);//começa animaçao de tiro
						}

				}
	}
	void tiro(){
		Rigidbody2D bala = Instantiate(balaPreFab, mira.transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
		balaPreFab.velocity = new Vector2(100, 0);

		Destroy (bala.gameObject, 5);
	}
}
