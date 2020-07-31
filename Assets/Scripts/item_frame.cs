using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public Image[] itemframe= new Image[15];
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        loaditems(gamemanager.playeritem);
    }

    void Update()
    {

    }
    public void loaditems(List<string> itemlist)
    {

        StartCoroutine( loaditem(itemlist));
    }

    IEnumerator loaditem(List<string> itemlist)
    {
        for (int i = transform.childCount; i>=0; i-=1 ) {


            
        }
        yield return null;
    }
}
