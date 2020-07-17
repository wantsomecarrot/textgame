using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        loaditems(gamemanager.playeritem);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void loaditems(List<string> itemlist)
    {

        StartCoroutine( loaditem(itemlist));
    }

    IEnumerator loaditem(List<string> itemlist)
    {
        

        for (int i = transform.childCount; i<=0; i-- ) {
            if (GameObject.Find("Frame" + i)) {
            }
            item_show child= GameObject.Find("Frame"+i).GetComponent<item_show>();
            child.loadimage(itemlist[child.number]);
        }
        yield return null;
    }
}
