using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class DefSpellParent : MonoBehaviour {

	protected float[] defCount = new float[3];
	protected float[] defRestoreTime = new float[3];
	protected float[] defRestoreSpeed = new float[3];
	protected float[] defSpecial = new float[3];

	protected Image restoreImage;
	protected float maxCount;
	public float cooldown;
	public float activeTime;
	public float timeTo;
	public float cooldownTimer;
	public float count;
	public bool onCooldown = true;
	public float restoreSpeed;


	abstract public void OnClickDef (bool isPressed);
	void OnEnable(){
		restoreImage = GameObject.Find("Energy").GetComponent<Image>();
		Invoke("CountCorection",0.2f);
	}
	void Update(){
		restoreImage.fillAmount = Mathf.Lerp(restoreImage.fillAmount,count/maxCount,Time.deltaTime * 3f);
		//restoreImage.fillAmount = 0.2f;
	}

	void CountCorection(){
		maxCount = count;
	}
}

