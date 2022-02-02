using UnityEngine;
using System.Collections;

public class tocasom : MonoBehaviour {

	public AudioClip somzinho;

	// Update is called once per frame
	void Update () {

				}
	IEnumerator playSoundThenLoad() {
		audio.clip = somzinho;
		audio.Play();
		yield return new WaitForSeconds(somzinho.length*2);
		
		Application.LoadLevel("Menu");
	}
	void OnTriggerEnter2D (Collider2D col){
		if (col.tag == "logo") {
			StartCoroutine(playSoundThenLoad());
//				if (!somzinho.isPlaying){
//				Application.LoadLevel("Main"); 
			}
//	}
	}
}

