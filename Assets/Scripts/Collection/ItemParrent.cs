using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class ItemParrent : MonoBehaviour {

	public static int isActiveItem = 0;
	public string name;
	public string description;
	public int sellPrise;
	public int byePrise;
	public GameObject ItemPanel;
	public Text nameTXT;
	public Text descript;
	public Text price;


	abstract public void OnItemClick ();

}
