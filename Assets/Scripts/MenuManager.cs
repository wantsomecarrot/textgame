using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject starttext;
    private GameObject black;
    private GameObject menu;
    private GameObject logo;
    void Start()
    {
        starttext = GameObject.Find("start");
        black = GameObject.Find("blackfront");
        menu = GameObject.Find("首頁02");
        logo = GameObject.Find("首頁LOGO");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (logo.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("logo_stay"))
        {
            openmenu();
            
        }
        if (black.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("black_on"))
        {
           load();
        }
    }
    public void openmenu()
    {
        menu.GetComponent<Animator>().SetTrigger("on");
    }
    public void startload()
    {
black.GetComponent<Animator>().SetTrigger("fadein");
    }
    public void load()
    {
        SceneManager.LoadScene("stage_one");
    }
}
