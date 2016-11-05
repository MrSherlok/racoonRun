using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {
	public static bool isPause;
	private Image chooseLvl;
	public void Start () {
		isPause = true;
		chooseLvl = GameObject.Find("Back").GetComponent<Image>();
	}

	public static void Pause () {
		isPause = !isPause;
        if (isPause)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }
    void Update()
    {
        if (isPause)
        {
            chooseLvl.enabled = false;
        }
        else
        {
            chooseLvl.enabled = true;
        }
    }
}
