using UnityEngine;
using System.Collections;

public class CameraFollow3 : MonoBehaviour {

	public GameObject camTargetObject;
	[SerializeField]
	float ppc;
	void Start(){
		//camTargetObject = GameObject.Find("Player");

			
	}
	void Update () {
		ppc = camTargetObject.transform.localPosition.y - 19.69f;
		//if (camTargetObject.transform.position.y)

		gameObject.transform.position = new Vector3(camTargetObject.transform.position.x,ppc*-0.35f,-10f);


	}
}
