using UnityEngine;
using System.Collections;
using UnityEngine.UI;

abstract public class ItemParrent : MonoBehaviour {

	protected static int isActiveItem = 0;
	protected string name;
	protected string description;
	public int sellPrise;
	public int byePrise;
	protected int wasFirstBye = 0;
	public GameObject ItemPanel;
	public Text nameTXT;
	public Text descript;
	public Text price;


	abstract public void DataUpdate ();

	abstract public void OnItemClick ();

}
