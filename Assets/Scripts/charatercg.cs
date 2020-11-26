using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charatercg : MonoBehaviour
{
    private GameManager_s gamemanager;
    private Animator anime;
    public Image character;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        anime =  character.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void characterenter(string type)
    {
        switch (type)
        {
            case "popout":
                anime.SetTrigger("enter");
                break;
        }
    }
    public void characterexit( string type)
    {
        switch (type)
        {
            case "slide":
                anime.SetTrigger("exit");
                break;
        }
    }
    void changeCG(Sprite CG)
    {
    }
}
