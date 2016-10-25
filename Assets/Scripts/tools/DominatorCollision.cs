using UnityEngine;

public class DominatorCollision : MonoBehaviour {

	void OnTriggerStay2D(Collider2D collider) {
		if (collider.tag == "enemys" && Dominator3000.IsDominatorActive) {
			collider.gameObject.SetActive(false);
		}
	}
}
