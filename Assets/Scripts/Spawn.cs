using UnityEngine;

public class Spawn : MonoBehaviour {
	private bool hasSpawn = false;

	// Update is called once per frame
	void Update() {
		if (!hasSpawn) {
			if (GetComponent<Renderer>().IsVisibleFrom (Camera.main)) {
				Spawne ();
			}
		} else {
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
				Destroy(gameObject,3f);
			}
		}
	}

	private void Spawne()
	{
		hasSpawn = true;
	}
}
