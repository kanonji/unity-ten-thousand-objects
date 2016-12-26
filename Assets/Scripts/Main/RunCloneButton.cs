using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunCloneButton : MonoBehaviour {
	public void LoadScene30() {
		GameObjectCounter.Instance.Reset();
		TimeKeeper.Instance.Begin();
		SceneManager.LoadScene("Clone30", LoadSceneMode.Additive);
		TimeKeeper.Instance.End();
	}

	public void LoadScene30Count() {
		GameObjectCounter.Instance.Reset();
		TimeKeeper.Instance.Begin();
		SceneManager.LoadScene("Clone30Count", LoadSceneMode.Additive);
		TimeKeeper.Instance.End();
	}

	public void LoadScene20() {
		GameObjectCounter.Instance.Reset();
		TimeKeeper.Instance.Begin();
		SceneManager.LoadScene("Clone20", LoadSceneMode.Additive);
		TimeKeeper.Instance.End();
	}

	public void LoadScene20Count() {
		GameObjectCounter.Instance.Reset();
		TimeKeeper.Instance.Begin();
		SceneManager.LoadScene("Clone20Count", LoadSceneMode.Additive);
		TimeKeeper.Instance.End();
	}
}
