using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	public void OnMouseEnter () {
		Debug.Log("３秒間見続けてください。");
		Invoke ( "SceneLoad2", 3.0f );
	}

	public void SceneLoad2 () {
		Debug.Log("3秒経ちました。ログイン画面に移ります。");
		SceneManager.LoadScene ("LoginView");
	}

	public void OnMouseExit () {
		Debug.Log("選択をキャンセルしました。");
		CancelInvoke ();
	}
}
