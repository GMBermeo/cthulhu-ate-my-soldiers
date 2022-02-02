using UnityEngine;
using System.Collections;

public class item : MonoBehaviour {
	public AudioClip pegouitem;
//	public GameObject ovo_life;
//	public GameObject ovo_rec;
//	Animator anima;

	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "player") {
			//GameObject ovo_life = GameObject.Find("ovo");
		    ovo_life.vida_ovo += 100;
//			ovo = GameObject.FindGameObjectWithTag("ovo");
//			ovo_rec = gameObject.GetComponent<ovo_life>();
//			ovo_rec.
			//ovo.GetComponent<ovo_life>() =+100;
			//anima.SetBool("Pegou",true);
//			animation["activating"].wrapMode = WrapMode.Once;
//			animation.Play("activating");	
			audio.clip=pegouitem;
			audio.Play();
//			if (!animation.isPlaying) {
				gameObject.SetActive(false);
//			}
	}
}
}