using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count2 : MonoBehaviour {
	public static int cnt2=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static void count(){
		cnt2++;
		Debug.Log (cnt2);
		if (cnt2 == 6) {
			GameObject.Find("Canvas").transform.Find ("C_Panel").gameObject.SetActive (true);
			cnt2 = 0;
			line2.stop ();
		}
	}
	public static void stop(){
		cnt2 = 0;
	}
}
