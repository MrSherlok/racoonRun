using UnityEngine;
using System.Collections;
using SmartLocalization;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour {
	public string langCode;
	Animator an;
	public Text changeLengHintText;
	void Start(){
		an = changeLengHintText.GetComponent<Animator>();
	}
	public void ChangeLang () {
		//PlayerPrefs.SetString("lang",langCode);
		//LanguageManager.Instance.ChangeLanguage(PlayerPrefs.GetString("lang")); 
		LanguageManager.Instance.ChangeLanguage(langCode); 
		LanguageManager.SetDontDestroyOnLoad();
		if(langCode == "ru")
		changeLengHintText.text = "Выбран русский язык";
		if(langCode == "en")
		changeLengHintText.text = "Chosed english language";
		an.SetTrigger ("ChangeLeng");
		Debug.Log(langCode);
	}
}
