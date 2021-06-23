using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pianokey : MonoBehaviour
{
    private GameManager_s gamemanager;
    public GameObject thepiano;
    private piano piano;
    private SpriteRenderer sprite;
    public string code;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        piano = thepiano.GetComponent<piano>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        if (piano.abled&&gamemanager.gamemode=="searching")
            piano.entercode(code);
    }
    private void OnMouseDrag()
    {
        if (piano.abled && gamemanager.gamemode == "searching")
            sprite.color= new Color(0.5f, 0.5f, 0.5f, 1f);
        else
            sprite.color = new Color(1f, 1f, 1f, 1f);
    }
    private void OnMouseUp()
    {
        if (piano.abled && gamemanager.gamemode == "searching")
            sprite.color = new Color(1f, 1f, 1f, 1f);
    }
}
