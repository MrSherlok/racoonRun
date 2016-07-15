using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintTextChanger : MonoBehaviour {

	Text goText;
	void Start () {
		goText = gameObject.GetComponent<Text>();
	}
	public void ChangeMessage(string newText){
		goText.text = newText;
	}

}
