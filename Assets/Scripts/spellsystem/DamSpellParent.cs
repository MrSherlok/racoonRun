using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class DamSpellParent : MonoBehaviour {

	protected int[] damCount = new int[3];
	protected float[] damRestoreTime = new float[3];
	protected int[] damDamage = new int[3];
	//UI indication
	protected Image restoreImage;
	//Weapon Sprite
	public Sprite weaponSprite;
	protected Sprite gunPoint;

	protected GameObject shotPrefab;
	protected GameObject shoot;
	protected float cooldown;
	protected float activeTime;
	protected float timer;
	protected int count;
	protected int maxCount;
	protected bool nonCooldown = true;
	protected Animator animator;

	abstract public void OnClick ();

 	void Awake(){
	animator = GameObject.Find("Player1").GetComponent<Animator> ();

	
			}
	void OnEnable(){
		//gunPoint = GameObject.Find("GunPoint").GetComponent<SpriteRenderer>().sprite;
		//gunPoint = weaponSprite;
		restoreImage = GameObject.Find("Power").GetComponent<Image>();
		restoreImage.fillAmount = 1;
		GameObject.Find ("GunPoint").GetComponent<SpriteRenderer>().sprite = weaponSprite;
	}
	protected void CountIndication(){
		restoreImage.fillAmount = ((float)count / (float)maxCount);
	}
}