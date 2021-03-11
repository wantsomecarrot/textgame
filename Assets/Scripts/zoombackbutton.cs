using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoombackbutton : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gamemanager.maincamera == true &&gameObject.activeSelf)
            gameObject.SetActive(false);
        else if (gamemanager.maincamera == false && gameObject.activeSelf== false)
            gameObject.SetActive(true);
    }
}
