using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void S_ButtonClick()
    {
        Application.LoadLevel("2_game");
    }
    public void H_ButtonClick()
    {
        Application.LoadLevel("3_howtoplay");
    }
    public void first_ButtonClick()
    {
        Application.LoadLevel("4_game2");
    }
	public void second_ButtonClick()
	{
		Application.LoadLevel("5_game3");
	}
	public void gHButtonClick(){
		Application.LoadLevel("2_game");
		Count.cnt = 0;
		Count2.cnt2 = 0;
		Count3.cnt3 = 0;
	}
	public void third_ButtonClick(){
		Application.LoadLevel("6_game4");
	}

}
