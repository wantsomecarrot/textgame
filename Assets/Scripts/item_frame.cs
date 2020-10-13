﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Image>itemimage;
    public Animator anime;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        anime = GetComponent<Animator>();
    }
    public void enter()
    {
        anime.SetBool("open",true);
    }
    public void exit()
    {
        anime.SetBool("open",false);
    }
    void Update()
    {

    }
    public void loaditems()
    {
        loaditemimage(itemimage[0], gamemanager.spriteDATA[gamemanager.resentitem]);
        StartCoroutine(loaditemlist(gamemanager.playeritem));
    }
    public void loaditemimage(Image image,Sprite sprite)
    {
        image.sprite = sprite;
    }

    IEnumerator loaditemlist(List<string> itemlist)
    {
        for (int i = 0; i < itemlist.Count; i++) {
            loaditemimage(itemimage[i + 1], gamemanager.spriteDATA[itemlist[i]]);
        }
        yield return null;
    }
}
