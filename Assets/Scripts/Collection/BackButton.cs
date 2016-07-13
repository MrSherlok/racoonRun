using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public GameObject Panel;


	public void BackCollection () {
		Panel.SetActive (false);
	}

}
