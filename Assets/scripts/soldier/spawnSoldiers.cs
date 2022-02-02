using UnityEngine;
using System.Collections;

public class spawnSoldiers : MonoBehaviour {

	//lugares para nascer soldier
	public Transform lugar1;
	public Transform lugar2;
	public Transform lugar3;
	public Transform lugar4;
	public Transform lugar5item;
	public AudioClip avisodeitem;
	

	public GameObject soldier;
	public GameObject item;
	
	int numeroSorteado;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		numeroSorteado = Mathf.Abs(Random.Range(1,3000));
		
		if (numeroSorteado >= 1 && numeroSorteado < 10 + score.dificuldade && !FimDeJogo.gameover) {
			spawnNOW(lugar1);
		}
		if (numeroSorteado >= 100 && numeroSorteado < 110 + score.dificuldade && !FimDeJogo.gameover) {
			spawnNOW(lugar2);
		}
		if (numeroSorteado >= 1000 && numeroSorteado < 1001 + score.dificuldade/10 && !FimDeJogo.gameover) {
			spawnNOW(lugar3);
		}
		if (numeroSorteado >= 1200 && numeroSorteado < 1201 + score.dificuldade/10 && !FimDeJogo.gameover) {
			spawnNOW (lugar4);
		}
		if (numeroSorteado == 666 && !FimDeJogo.gameover) {
			spawnITEM(lugar5item);
			audio.clip = avisodeitem;
			audio.Play(); 
		}
	}
	void spawnNOW(Transform lugar){
		GameObject soldiere = Instantiate(soldier, lugar.position, Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
	}
	void spawnITEM(Transform lugar){
		GameObject iteme = Instantiate(item, lugar.position, Quaternion.Euler(new Vector3(0,0,0))) as GameObject;
	}

}
