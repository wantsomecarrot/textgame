using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private GameManager_s gamanager;
    // Start is called before the first frame update
    void Start()
    {
        gamanager=GameObject.Find("GameManager").GetComponent<GameManager_s>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onclickone()
    {
        gamanager.optionstart();
    }
    public void onclicktwo()
    {
        gamanager.optionend();
    }
}
