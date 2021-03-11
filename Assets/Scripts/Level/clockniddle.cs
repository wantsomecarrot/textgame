using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockniddle : MonoBehaviour
{
    public float angle;
    private GameManager_s gamemanager;
    public bool draging = false;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
            transform.up = (new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) - transform.position).normalized;
    }
    public void Drag()
    {
        if (gamemanager.gamemode == "search" && gamemanager.flag.Contains("clockopened") == false)
            draging = true;
    }
}
