using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChengeCenturyScript : MonoBehaviour {
	public Camera mainCam;
	public Camera century19Cam;
	public Image century19Image;
	public Image century19Lvl1Image;
//	private TakeTapScript takeTap;
//	private bool isCentury19ActiveChenge = false;
	public Text century19Txt;
	public Text century19Lvl1Txt;
	public Image backMMImage;
	public Image backToCenturyImage;
	
	public bool isCentury19Active = false;

	void Update () {


		//TakeTapScript takeTap = GetComponent<TakeTapScript> ();
	//	isCentury19ActiveChenge = GetComponent<TakeTapScript> ().isCentury19Active;

		if (isCentury19Active == true) {
			backMMImage.enabled = false;
			backToCenturyImage.enabled = true;
			century19Txt.enabled = false;
			century19Lvl1Txt.enabled = true;
			century19Lvl1Image.enabled = true;
			century19Image.enabled = false;
			century19Cam.enabled = true;
			mainCam.enabled = false;
		} else {
			backMMImage.enabled = true;
			backToCenturyImage.enabled = false;
			century19Txt.enabled = true;
			century19Lvl1Txt.enabled = false;
			century19Lvl1Image.enabled = false;
			century19Image.enabled = true;
			century19Cam.enabled = false;
			mainCam.enabled = true;
		}
	}

	public void Century19Active () {
		isCentury19Active = true;
	}

	public void Century19Lvl1 () {
		Application.LoadLevel (2);
	}

	public void BackToChooseCentury () {
		isCentury19Active = false;
	}
}
