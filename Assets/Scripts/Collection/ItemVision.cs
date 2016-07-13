using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemVision : MonoBehaviour {

	public Image First;
	public Image Second;
	public Image Third;
	public Image Fourth;
	public Image Fifth;
	public Image Sixth;
	public Image Seventh;
	public Image Eighth;
	public Image Nineth;
	public Image Tenth;
	

	void Update () {
		if (PlayerPrefs.GetInt("FirstItem") != 1)
			First.color = new Color32(0,0,0,150);
		else
			First.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("SecondItem") != 1)
			Second.color = new Color32(0,0,0,150);
		else
			Second.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("ThirdItem") != 1)
			Third.color = new Color32(0,0,0,150);
		else
			Third.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("FourthItem") != 1)
			Fourth.color = new Color32(0,0,0,150);
		else
			Fourth.color = new Color32(255,255,255,255);


		if (PlayerPrefs.GetInt("FifthItem") != 1)
			Fifth.color = new Color32(0,0,0,150);
		else
			Fifth.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("SixthItem") != 1)
			Sixth.color = new Color32(0,0,0,150);
		else
			Sixth.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("SeventhItem") != 1)
			Seventh.color = new Color32(0,0,0,150);
		else
			Seventh.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("EighthItem") != 1)
			Eighth.color = new Color32(0,0,0,150);
		else
			Eighth.color = new Color32(255,255,255,255);


		if (PlayerPrefs.GetInt("NinethItem") != 1)
			Nineth.color = new Color32(0,0,0,150);
		else
			Nineth.color = new Color32(255,255,255,255);



		if (PlayerPrefs.GetInt("TenthItem") != 1)
			Tenth.color = new Color32(0,0,0,150);
		else
			Tenth.color = new Color32(255,255,255,255);
	}
}
