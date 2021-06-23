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
    private GameObject white;
    void Start()
    {
        starttext = GameObject.Find("start");
        black = GameObject.Find("blackfront");
        white = GameObject.Find("whitefront");
        menu = GameObject.Find("首頁02");
        logo = GameObject.Find("首頁LOGO");
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (white.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("black_off"))
        {
            logo.GetComponent<Animator>().SetTrigger("in");

        }
        if (black.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("black_on"))
        {
            load();
            
        }
        if (logo.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("logo_stay"))
        {
           openmenu();
        }
    }
    public void endbutton()
    {
        Application.Quit();
    }
    public void openmenu()
    {
        menu.GetComponent<Animator>().SetTrigger("on");
    }
    public void startloadbutton()
    {
        black.GetComponent<Animator>().SetTrigger("fadein");
    }
    public void load()
    {
        SceneManager.LoadScene("stage_one");
    }
}
