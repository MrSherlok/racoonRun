using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class DefSpellParent : MonoBehaviour {

	protected float[] defCount = new float[3];
	protected float[] defRestoreTime = new float[3];
	protected float[] defRestoreSpeed = new float[3];
	protected float[] defSpecial = new float[3];
	//UI
	protected Image restoreImage;
	protected float maxCount;

	protected float cooldown;
	protected float activeTime;
	protected float timeTo;
	protected float cooldownTimer;
	protected float count;
	protected bool onCooldown = true;
	protected float restoreSpeed;
	protected Animator animator;

	abstract public void OnClickDef (bool isPressed);
	protected void OnEnable(){
		
		restoreImage = GameObject.Find("Energy").GetComponent<Image>();
		restoreImage.fillAmount = 1f;

	}
	void Awake(){
		animator = GameObject.Find("Player1").GetComponent<Animator> ();


	}
		
	protected void CountCorection(){
		maxCount = count;

	}

	protected void CountIndication(){
		
		restoreImage.fillAmount = Mathf.Lerp(restoreImage.fillAmount,count/maxCount,Time.deltaTime * 3f);

	}
}

