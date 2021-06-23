using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    private GameManager_s gamemanager;
    public GameObject thecello;
    private cellocode cello;
    private SpriteRenderer sprite;
    public int num;
    public int value;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        cello = thecello.GetComponent<cellocode>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (cello.abled) { 
        sprite.sprite = cello.numimage[value];
            cello.value[num] = value;
    }
}
    private void OnMouseDown()
    {
        if (cello.abled && gamemanager.gamemode == "searching") {
            if (value == 9)
                value = 1;
            else
                value ++;
            }
    }
}
