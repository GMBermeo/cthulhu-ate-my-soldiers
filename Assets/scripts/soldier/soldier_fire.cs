using UnityEngine;
using System.Collections;

public class soldier_fire : MonoBehaviour {
	segue_player sp;
	public GameObject balaPreFab;
	public GameObject mira;
	public float tempoDeTiro;

	float cooldown;
	// Use this for initialization
	void Start () {
		sp = GetComponent<segue_player> ();
		cooldown = Time.time + tempoDeTiro;
	}
	
	// Update is called once per frame
	void Update () {
		if (sp.pertoPlayer) {
						if (Time.time >= cooldown) {
								tiro ();
				cooldown = Time.time + tempoDeTiro;
						}
				}
	}

	//atira a bala


		

	void tiro(){
		audio.Play();
		GameObject bala = Instantiate(balaPreFab, mira.transform.position, Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
		bala.GetComponent<balaSoldier> ().olhandoDireita = !sp.olhando_direita;
		//balaPreFab.velocity = new Vector2(100, 0);

		Destroy (bala.gameObject, 5);
		
	}
}
