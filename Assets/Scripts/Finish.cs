using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Finish : MonoBehaviour
{
	public GameObject text;
	public GameObject total;
	public GameObject min;
	public GameObject sec;
	public GameObject ms;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag =="Car"){
			Debug.Log(min.GetComponent<Text>().text.ToString());
			total.GetComponent<Text>().text= "Total time: "+min.GetComponent<Text>().text+sec.GetComponent<Text>().text+"."+ms.GetComponent<Text>().text;
			text.SetActive(true);
		}
	}
}
