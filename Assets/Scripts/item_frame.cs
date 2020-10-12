using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public GameObject item_0, item_1, item_2, item_3, item_4, item_5, item_6;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        loaditems(gamemanager.playeritem);
    }
    public void enter
    {

    }
    public void exist
    {

    }
    void Update()
    {

    }
    public void loaditems(List<string> itemlist)
    {
        StartCoroutine( loaditemlist(itemlist));
    }
    public void loaditem()
    {

    }

    IEnumerator loaditemlist(List<string> itemlist)
    {
        for (int i = 0; i <itemlist.Count; i++) {


            
        }
        yield return null;
    }
}
