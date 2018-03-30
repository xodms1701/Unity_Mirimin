using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragGameObject : MonoBehaviour {
    public GameObject _dragon;
    private Vector3 initMousePos;
    //처음마우스 클릭시
    void OnMouseDown()
    {
        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);   
 
        //Debug.Log("mouse Down : " + initMousePos);
    }
    //마우스 드래그시
    void OnMouseDrag()
    {
        Vector3 worldPoint = Input.mousePosition;
        worldPoint.z = 10;
        worldPoint = Camera.main.ScreenToWorldPoint(worldPoint);   
 
        Vector3 diffPos = worldPoint - initMousePos;
        diffPos.z = 0;
 
        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);
 
        _dragon.transform.position = new Vector3(Mathf.Clamp(_dragon.transform.position.x + diffPos.x, -4.5f, 4.5f),Mathf.Clamp(_dragon.transform.position.y + diffPos.y, -9f, 9f),_dragon.transform.position.z);
 
 
    //  Debug.Log("mouse drag" + diffPos);
    }
}