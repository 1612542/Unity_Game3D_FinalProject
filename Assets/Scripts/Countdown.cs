using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
	float ms;
	int count;
    // Start is called before the first frame update 
    void Start()
    {
        ms =0;
	count =4;
    }

    // Update is called once per frame
    void Update()
    {
        ms+=Time.deltaTime*10;
	transform.Rotate(new Vector3(2.8f,0f,0f));
	if (ms>=10){
		count-=1;
		ms=0;
		transform.rotation = Quaternion.Euler(0, 0, 0);
		gameObject.GetComponent<Text>().text=""+count.ToString();
	}
	if (count <=-1 ){
		Destroy(gameObject);
	}
	if (count <=0 ){
		gameObject.GetComponent<Text>().text="GO!";
	}
		

    }
}
