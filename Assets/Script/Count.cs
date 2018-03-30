using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {
	public static int cnt=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void count(){
		cnt++;
		Debug.Log (cnt);
		if (cnt == 5) {
			GameObject.Find("Canvas").transform.Find ("C_Panel").gameObject.SetActive (true);
			cnt = 0;
			line.stop ();
		}
	}
	public static void stop(){
		cnt = 0;
	}
}
