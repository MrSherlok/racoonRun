using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RotateCylinder : MonoBehaviour {
	Animator grabAnim;
	bool rotNow = false;
	bool isEnding = false;
	GameObject cyl;
	public ParticleSystem Iskru;
	void Start(){
		cyl = GameObject.Find ("Cylinder");
		grabAnim = GameObject.Find ("Grablya").GetComponent<Animator> ();
		grabAnim.SetBool ("Close",false);
		Iskru.enableEmission = false;
	}

	public void Roll () {
		gameObject.GetComponent<Button> ().enabled = false;
		//cyl.GetComponent<Rigidbody>().AddTorque(transform.forward * 1800f * 50f);
		rotNow = true;
		grabAnim.SetBool("Close",true);
		Invoke ("IskruEnbling",1f);
	}

	void IskruEnbling(){
		Iskru.enableEmission = true;
		Invoke ("Stop",2f);
	}
	void Stop(){
		rotNow = false;
		isEnding = true;
		Iskru.enableEmission = false;
	}

	void Update ()
	{
		if (isEnding ) {
			
			cyl.transform.Rotate (Vector3.down * 1 * Time.deltaTime);
		}
		if (rotNow) {
			cyl.transform.Rotate (Vector3.down * 1000 * Time.deltaTime);

		}
	}
}
