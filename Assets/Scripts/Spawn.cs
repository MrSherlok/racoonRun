using UnityEngine;

public class Spawn : MonoBehaviour {
	private bool hasSpawn = false;

	// Update is called once per frame
	void FixedUpdate() {
		if (hasSpawn == false) {
			if (GetComponent<Renderer>().IsVisibleFrom (Camera.main)) {
				Spawne ();
			}
		} else {
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject);
			}
		}
	}

	private void Spawne()
	{
		hasSpawn = true;
	}
}
