﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socks2 : MonoBehaviour {
	public GameObject _sock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	//rigidBody가 무언가와 충돌할때 호출되는 함수 입니다.
	//Collider2D other로 부딪힌 객체를 받아옵니다.
	{
		if (other.CompareTag ("socks")) {
			Count2.count ();
			_sock.transform.position = new Vector3(-2.67f,-6.06f,-2f);
			Destroy (this.gameObject);
			Destroy (other.gameObject);
		}
	}
}
