using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GoToLotteryScene : MonoBehaviour {

	public void LoadLottery () {
		SceneManager.LoadScene ("Lottery");
	}

}
