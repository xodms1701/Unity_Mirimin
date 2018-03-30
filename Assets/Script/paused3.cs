using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paused3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void paused_btn(){
		GameObject.Find("Canvas").transform.Find ("P_Panel").gameObject.SetActive (true);
		line3.stop_p ();
	}
	public void s_btn(){
		GameObject.Find("Canvas").transform.Find ("P_Panel").gameObject.SetActive (false);
		line3.start_l ();
	}
}
