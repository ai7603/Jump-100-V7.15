using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class StoreButtonControl : MonoBehaviour {

	public Transform UIButton;
	public Transform UITextOne;
	public Transform UITextTwo;
	public Transform UIImg;

    public Text CoinNum;

	private bool cont;
	// Use this for initialization
	void Start () {
		cont = false;
        CoinNum.text = "$" + UserInfo.COIN;
        if (UserInfo.PETS == true)
        {
            UIButton.gameObject.SetActive(false);
            UITextOne.gameObject.SetActive(false);
            UITextTwo.gameObject.SetActive(false);
            UIImg.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        CoinNum.text = "$" + UserInfo.COIN;
    }
	void OnGUI(){
		//if(cont)
			// GUI.Button (new Rect (300, 300, 350, 350), "BOUGHT");
	}

	public void Disable_Button(){

        string filepath = Application.dataPath + "/UserFiles" + "//" + UserInfo.USER+".txt";
        string[] str=File.ReadAllLines(filepath);
        if (UserInfo.COIN >= 50 && UserInfo.PETS==false)
        { 
            UserInfo.COIN -= 50;
            UserInfo.PETS = true;
            str[0] = UserInfo.COIN.ToString();
            str[1] = UserInfo.PETS.ToString();
            File.WriteAllLines(filepath, str);
            UIButton.gameObject.SetActive(false);
            UITextOne.gameObject.SetActive(false);
            UITextTwo.gameObject.SetActive(false);
            UIImg.gameObject.SetActive(false);
            cont = true;
        }

        
    }
}