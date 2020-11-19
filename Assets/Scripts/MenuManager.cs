using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject starttext;
    void Start()
    {
        starttext = GameObject.Find("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            starttext.GetComponent<Animator>().SetTrigger("Start");
        }
        if (starttext.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("starttext_void"))
        {
            load();
        }
    }
    public void load()
    {
        SceneManager.LoadScene("stage_one");
    }
}
