using UnityEngine;
using System.Collections;

public class PetLife : MonoBehaviour {

	public int hp;
	public Animator anim;
	public GameObject pet;

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "enemys"){
			hp--;
			if(hp<=0){
				GetComponent<Collider2D>().enabled = false;
				anim.SetTrigger("Die");
				Invoke ("DisbleGO",3f);
			}
		}
	}
	void DisableGO(){
		pet.SetActive(false);
	}
}
