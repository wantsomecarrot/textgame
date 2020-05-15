﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_s : MonoBehaviour
{
    // Start is called before the first frame update
    private Text_s Text ;//文字腳本
    private  test_level levelmanager;//關卡腳本
    private converstation_frame talkframe;//對話界面腳本
    public string nowweareat = "story";//當下使用劇本的暫存
    public float level=0;//當下使用劇本的對話階段暫存
    public string gamemode = "converstation";//遊戲狀態暫存
    private RaycastHit hit ;//滑鼠偵測暫存
    private Ray mouseray;//鐳射暫存
    private option optionframe;//
    public string anime =null;//
    public bool optionbool = false;//
    void Start()
    {
        Text = GameObject.Find("Words").GetComponent<Text_s>();
        levelmanager = GameObject.Find("LevelManager").GetComponent<test_level>();
        talkframe = GameObject.Find("Text_frame").GetComponent<converstation_frame>();
        optionframe = GameObject.Find("Option").GetComponent<option>();
        levelmanager.story(nowweareat,level);
    }

    // Update is called once per frame
    void Update()
    {
        if (anime == null)
        {
            if (optionbool) { }
                
            else
            {
                switch (gamemode)
                {
                    case "converstation":
                        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))//偵測空白鍵，若文字未顯示完畢則加速，否則進入下一段
                            if (Text.typing)
                                Text.type_delay = 0.01F;
                            else
                                next_level();
                        break;
                    case "searching":
                        if (Input.GetMouseButtonDown(0))
                        {
                            mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
                            if (Physics.Raycast(mouseray, out hit, 1000f))
                            {
                                nowweareat = hit.transform.name;
                                levelmanager.story(nowweareat, level);
                            }
                        }
                        break;
                }
            }
        }
        else { 
        switch (anime)
        {
            case "textframein":
                if (talkframe.anime.GetCurrentAnimatorStateInfo(0).IsName("frame_on"))
                {
                    gamemode = "converstation";
                    level++;
                    levelmanager.story(nowweareat, level);
                        anime = null;
                    }

                break;
            case "textframeout":
                if (talkframe.anime.GetCurrentAnimatorStateInfo(0).IsName("off"))
                {
                    gamemode = "searching";
                    Text.type_clear();
                        anime = null;
                    }
                break;
        }
        }
    }
    public void optionstart()
    {
        optionbool = true;
        optionframe.enter();
    }
    public void optionend()
    {
        optionbool = false;
        optionframe.exit();
    }
    public void talk(string commend) {
        switch (commend)
        {
            case"begin":
             talkframe.enter();
                anime = "textframein";
                break;
            case "end":
                talkframe.exit();
                level = 0;
                anime = "textframeout";
                nowweareat = "search";
                break;
        }
    }
    public void Speak(string word)//將文字傳給文字腳本
    {
        Text.type_start(word);
    }
    public void next_level()//關卡數值+1傳給關卡腳本
    {
        level++;
        levelmanager.story(nowweareat ,level);
    }
    
}

