using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trash2 : MonoBehaviour {

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
		if (other.CompareTag("ring"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("lip"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("kodeki"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("lighter"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("nanacorn"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("keyring"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("dosirock"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
		if (other.CompareTag("jagmikal"))
		{
			Count3.count ();
			Destroy(other.gameObject);
		}
	}
}
