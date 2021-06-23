using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour
{
    private Image sprite;
    private GameManager_s gamemanager;
    public List<Sprite> images; 
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<Image>();
        if (GameObject.Find("GameManager"))
            gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //var rect = GetComponent<RectTransform>();
        if (GameObject.Find("GameManager"))
        {
            if (gamemanager.gamemode == "converstation")
                changeimage(3);
            else if (gamemanager.gamemode == "searching")
            {
                if (gamemanager.maincamera == false)
                    changeimage(0);
                else
                {
                    if (gamemanager.custersetzoom)
                        changeimage(2);
                    else
                        changeimage(4);
                }
            }
            else if (gamemanager.gamemode == "anime")
            { }
            else
                changeimage(4);
        }
        else
            changeimage(4);
        transform.position = Input.mousePosition;
    }
    void changeimage(int num)
    {
        sprite.sprite = images[num];
    }
}
