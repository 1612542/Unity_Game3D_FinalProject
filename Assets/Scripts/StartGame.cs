using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
	public GameObject panel;
	public GameObject bot;
    public GameObject escmenu;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5);
	panel.SetActive(true);
	bot.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Escape) ))
        {
            escmenu.SetActive(true);     
        }
       
    }
}
