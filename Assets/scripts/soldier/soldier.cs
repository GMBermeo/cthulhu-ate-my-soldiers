
using UnityEngine;
using System.Collections;


public class soldier : MonoBehaviour {
//	public AudioClip Tomouhit;
	public float vida=2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.tag == "bala") {
			{vida -= 1;//se atingir um soldado deve descontar um ponto de vida
//				audio.clip=Tomouhit;
//				audio.Play();
				if(vida==0){
					score.kill += 2;
					score.bodycount +=1;
					Destroy(gameObject);
				}
			}
			Destroy (col.gameObject);//e se destruir
//			audio.clip=Tomouhit;
//			audio.Play();
		}
		
	}
}
