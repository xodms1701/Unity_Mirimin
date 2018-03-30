using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line2 : MonoBehaviour {
	public GameObject[] _line;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		for (int i = 0; i <= 12; i++) {
			Destroy(_line[i], i);
		}
	}

	// Update is called once per frame
	void Update () {
		if (_line[12].gameObject == false) {
			GameObject.Find("Canvas").transform.Find ("Panel").gameObject.SetActive (true);
			Count2.stop ();
		}
	}
	public static void stop(){
		Time.timeScale = 0;
		Count2.stop ();
	}
	public static void stop_p(){
		Time.timeScale = 0;
	}
	public static void start_l(){
		Time.timeScale = 1;
	}
}
