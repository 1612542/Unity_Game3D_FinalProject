using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
	public int totaltime;
    	public static int min;
	public static int sec;
	public static float ms;
	public static string msDisplay;
	
	public GameObject minbox;
	public GameObject secbox;
	public GameObject msbox;
    void Start(){
    	min = totaltime;
    }

    // Update is called once per frame
    void Update()
    {
        ms-=Time.deltaTime*10;
	msDisplay = ms.ToString("F0");
	msbox.GetComponent<Text>().text=""+msDisplay;

	if(ms<=0){
		ms=9;
		sec-=1;
	}
	
	if(sec<=9){
		secbox.GetComponent<Text>().text="0"+sec;
	} else {
		secbox.GetComponent<Text>().text=""+sec;
	}

	if(sec<=0){
		sec = 59;
		min -= 1;
	}

	if(min<=9){
		minbox.GetComponent<Text>().text="0"+min+":";
	} else {
		minbox.GetComponent<Text>().text=""+min+":";
	}


    }
}
