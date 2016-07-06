using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChoseYourColor : MonoBehaviour {

	public int color = 0;
	public void ChangeColor () {
		color++;
		if (color == 9)
			color = 1;
		switch (color) {
		case 1:
			gameObject.GetComponent<Image> ().color = new Color32 (255, 1, 1, 255);
			break;
		case 2:
			gameObject.GetComponent<Image> ().color = new Color32 (255, 180, 1, 255);
			break;
		case 3:
			gameObject.GetComponent<Image> ().color = new Color32 (255, 255, 1, 255);
			break;
		case 4:
			gameObject.GetComponent<Image> ().color = new Color32 (70, 255, 1, 255);
			break;
		case 5:
			gameObject.GetComponent<Image> ().color = new Color32 (0, 255, 170, 255);
			break;
		case 6:
			gameObject.GetComponent<Image> ().color = new Color32 (0, 45, 255, 255);
			break;
		case 7:
			gameObject.GetComponent<Image> ().color = new Color32 (255, 0, 255, 255);
			break;
		case 8:
			gameObject.GetComponent<Image> ().color = new Color32 (135, 135, 111, 255);
			break;
		}

	
	}

}
