using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socks : MonoBehaviour {
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
			Count.count ();
			_sock.transform.position = this.transform.position;
			Destroy (this.gameObject);
			Destroy (other.gameObject);
		}
	}
}
