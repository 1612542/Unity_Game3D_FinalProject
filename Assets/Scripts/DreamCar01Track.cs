using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCar01Track : MonoBehaviour
{
	int markcount;
    // Start is called before the first frame update
    void Start()
    {
        markcount=0;
    }

    // Update is called once per frame
    void Update()
    {
	string markName= "Mark ("+markcount+")";
	Debug.Log(markName);
        transform.position=GameObject.Find(markName).transform.position;
    }
	
	IEnumerator OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Dreamcar01"){
			this.GetComponent<BoxCollider>().enabled =false;
			markcount+=1;
			Debug.Log(markcount);
			if(markcount==15){ markcount =0;}
			yield return new WaitForSeconds(1);
			this.GetComponent<BoxCollider>().enabled=true;
		}	
	}
}
