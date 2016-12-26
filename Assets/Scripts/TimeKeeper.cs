using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeper : SingletonMonoBehaviour<TimeKeeper> {
	private float record;
	private Text textComponent;

	private void Start() {
		textComponent = GameObject.Find("Canvas/Panel/Text").GetComponent<Text>();
	}

	public void Begin() {
		record = Time.realtimeSinceStartup;
	}

	public void End() {
		Log("Scene Loaded");
	}

	public void Log(string str = "") {
		var time = Time.realtimeSinceStartup - record;
		textComponent.text += ("\n" + str + " : " + time.ToString() + " sec");
	}
}
