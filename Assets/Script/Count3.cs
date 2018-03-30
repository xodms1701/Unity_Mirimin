using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count3 : MonoBehaviour {
	public static int cnt3=0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public static void count(){
		cnt3++;
		Debug.Log (cnt3);
		if (cnt3 == 9) {
			GameObject.Find("Canvas").transform.Find ("C_Panel").gameObject.SetActive (true);
			cnt3 = 0;
			line3.stop ();
		}
	}
	public static void stop(){
		cnt3 = 0;
	}
}
