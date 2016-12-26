using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectCounter : SingletonMonoBehaviour<GameObjectCounter> {
	private int count = 0;
	private Dictionary<int, bool> threshold = new Dictionary<int, bool>() {
		{ 1000, true },
		{ 8000, true },
		{ 27000, true },
	};

	public void Add () {
		count++;
		if (threshold.ContainsKey(count)) {
			TimeKeeper.Instance.Log(count.ToString());
		}
	}

	public void Reset() {
		count = 0;
	}
}
