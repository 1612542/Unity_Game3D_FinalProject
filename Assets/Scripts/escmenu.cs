using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escmenu : MonoBehaviour
{
    private int k;
    private Text[] text;
    public AudioSource sound;
    GameObject escMenu;
    // Start is called before the first frame update
    void Start()
    {
        k = 1002;
        text = new Text[3];
        text[0] = GameObject.Find("continue").GetComponent<Text>();
        text[1]= GameObject.Find("retry").GetComponent<Text>();
        text[2] = GameObject.Find("quit").GetComponent<Text>();
        escMenu = GameObject.Find("esc");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            k++;
            sound.Play();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            k--;
            sound.Play();
        }

        for (int i = 0; i < 3; i++)
            text[i].color = Color.gray;
        text[k % 3].color = Color.white;
        if (k % 3 == 0 && Input.GetKeyDown(KeyCode.Return))
            escMenu.SetActive(false);
        if (k % 3 == 1 && Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (k % 3 == 2 && Input.GetKeyDown(KeyCode.Return))
            SceneManager.LoadScene("MainMenu");
    }
}
