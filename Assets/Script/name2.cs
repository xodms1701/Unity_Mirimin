using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name2 : MonoBehaviour {
	public GameObject _nametag;
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
		if (other.CompareTag("nametag"))
		{
			Count2.count ();
			_nametag.transform.position = new Vector3(-2.14f,-2.48f,-4f);
			Destroy(other.gameObject);
		}
	}
}
