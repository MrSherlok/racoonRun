using UnityEngine;

public class Spawn : MonoBehaviour {
	private bool hasSpawn = false;

	// Update is called once per frame
	void Update() {
		if (!hasSpawn) {
			if (GetComponent<Renderer>().IsVisibleFrom (Camera.main)) {
                gameObject.GetComponent<Animator>().enabled = true;
				Spawne ();
			}
		} else {
			if (GetComponent<Renderer>().IsVisibleFrom(Camera.main) == false)
			{
                gameObject.GetComponent<Animator>().enabled = false;
            }
		}
	}

	private void Spawne()
	{
		hasSpawn = true;
	}
}
