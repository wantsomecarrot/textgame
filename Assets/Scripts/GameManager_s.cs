﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager_s : MonoBehaviour
{
    // Start is called before the first frame update
    private Text_s Text ;//文字腳本
    private test_level_BETA levelmanager;//關卡腳本
    private converstation_frame talkframe;//對話界面腳本
    private item_frame itemframe;//物品欄腳本
    private charatercg CG;//角色立繪顯示系統
    private Animator CGanime;
    private bool spacekeyactive=true;
    private float spacekeycooldown;
    public blackcontrol black;//黑幕控制
    public string nowweareat = "story";//當下使用劇本的暫存
    public float level=0;//當下使用劇本的對話階段暫存
    public string gamemode = "converstation";//遊戲狀態暫存
    public bool maincamera = true;//探索模式鏡頭狀態
    public int changetargetcamera = 0;//切換鏡頭暫存
    private RaycastHit hit ;//滑鼠偵測暫存
    private RaycastHit2D hit2d;//滑鼠平面偵測暫存
    private Ray mouseray;//鐳射暫存
    private option optionframe;//設定界面腳本
    private item_info iteminfo;//物品資訊顯示腳本
    private itemget itemget;
    private audiosource audio;
    public string stage; 
    public string anime =null;//動畫名稱暫存
    public bool optionstate = false;//設定界面是否開啟
    public List<string> flag;//劇情要素蒐集區
    public List<string> playeritem ;//玩家物品蒐集區
    public string resentitem = "empty";//手上物品暫存
    public int resentcamera = 0 ;//現在的攝影機
    private string blackstate ;//黑幕開關暫存
    public Dictionary<string, Sprite> spriteDATA;//存圖區
    public GameObject tutorial;
    public GameObject lv1sence;
    public GameObject lv2sence;
    public GameObject zaball;
    public GameObject zoombackbutton;
    public bool custersetzoom;

    private bool IsTouchedUI()//判斷是否摸著UI圖標
    {
        bool touchedUI = false;
        if (EventSystem.current.IsPointerOverGameObject())
        {
            touchedUI = true;
        }
        return touchedUI;
    }
    void Start()
    {
        stage= SceneManager.GetActiveScene().name;
        Text = GameObject.Find("Words").GetComponent<Text_s>();
        levelmanager = GameObject.Find("LevelManager").GetComponent<test_level_BETA>();
        talkframe = GameObject.Find("Text_frame").GetComponent<converstation_frame>();
        optionframe = GameObject.Find("Option").GetComponent<option>();
        itemframe = GameObject.Find("Item_frame").GetComponent<item_frame>();
        black = GameObject.Find("blackback").GetComponent<blackcontrol>();
        CG = GameObject.Find("CharaterCG").GetComponent<charatercg>();
        CGanime = GameObject.Find("CG").GetComponent<Animator>();
        iteminfo = GameObject.Find("iteminfo").GetComponent<item_info>();
        itemget = GameObject.Find("Itemget").GetComponent<itemget>();
        audio = GameObject.Find("Audio Source").GetComponent<audiosource>();
        levelmanager.story(nowweareat,level);


    }

    // Update is called once per frame
    void Update()
    {
        if (optionstate)
        {

        }
        else
            switch (gamemode)
            {
                case "converstation":
                    if (Input.GetKey(KeyCode.Space) && spacekeyactive) {
                        spacekeyactive = false;
                        converstationclickframe();
                    }
                    if (Input.GetKeyDown(KeyCode.S))
                    {

                        skip();
                    }
                    break;
                case "searching":
                    if (IsTouchedUI() == false)
                    {
                        if (maincamera)
                        {
                            if (Input.GetMouseButtonDown(0))
                            {
                                mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                if (Physics.Raycast(mouseray, out hit, 1000f))
                                {
                                    searchtrigger(hit.transform.name);
                                }
                            }
                            if (Input.mousePosition.x <= Screen.width * 0.05f)
                            {
                                Camera.main.transform.Rotate(0, -0.5f, 0);
                            }
                            else if (Input.mousePosition.x >= Screen.width * 0.95f)
                            {
                                Camera.main.transform.Rotate(0, 0.5f, 0);
                            }
                            else if (Input.mousePosition.x <= Screen.width * 0.25f && Input.mousePosition.x > Screen.width * 0.05f)
                            {
                                Camera.main.transform.Rotate(0, -0.15f, 0);
                            }
                            else if (Input.mousePosition.x >= Screen.width * 0.75f && Input.mousePosition.x < Screen.width * 0.95f)
                            {
                                Camera.main.transform.Rotate(0, 0.15f, 0);
                            }
                        }
                        else
                        {                           
                                mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
                                hit2d = Physics2D.Raycast(mouseray.origin, mouseray.direction, 1000f);
                            if (hit2d.collider)
                            {
                                if (Input.GetMouseButtonDown(0))
                                searchtrigger(hit2d.transform.name); 
                                if (hit2d.transform.CompareTag("Zoom"))
                                {
                                    custersetzoom = true;
                                }
                                else
                                    custersetzoom = false;
                            }
                                                      
                        }
                    }
                    break;
                case "anime":
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
                        case "effectblackfadeout":
                            if (black.anime.GetCurrentAnimatorStateInfo(0).IsName("black_off"))
                            {
                                gamemode = "converstation";
                                anime = null;
                            }
                            break;
                        case "effectblackfadein":
                            if (black.anime.GetCurrentAnimatorStateInfo(0).IsName("black_on"))
                            {
                                gamemode = "converstation";
                                anime = null;
                            }
                            break;
                        case "camerachangeblackfadein":
                            break;
                        case "camerachangeblackfadeout":
                            break;
                        
                    }
                    break;
                case "tutorial":
                    break;
            }
        if (spacekeycooldown<=0) {
            spacekeyactive = true;
            spacekeycooldown = 0.1f;
        }
        if (!spacekeyactive)
            spacekeycooldown -= Time.deltaTime;
        if (Input.GetKey(KeyCode.K))
            nextstage();
    }
    public void entertutorial() {
        tutorial.SetActive(true);
        gamemode = "tutorial";
    }
    public void exittutorial() {
        tutorial.SetActive(false);
        gamemode = "searching";
    }
    public void searchtrigger(string target) {
        nowweareat = target;
        levelmanager.story(nowweareat, level);
    }
    public void CGcontrol(string commend)
    {
        if (gamemode== "converstation")
        switch (commend)//開始或結束
        {
            case "show":
                CGanime.SetTrigger("on");
                break;
            case "hide":
                    CGanime.SetTrigger("off");
                break;
            case "change":
                break;
        }
    }
    public void optionswitch()
    {
        if (optionstate)
        {
            optionframe.exit();
            optionstate = false;
        }
        else {
            optionframe.enter();
            optionstate = true;
        }
    }
    public void talk(string commend)//對話框動畫指令
    {
        switch (commend)//開始或結束
        {
            case"begin":
                gamemode = "anime";
             talkframe.enter();
                itemframe.exit();
                anime = "textframein";
                break;
            case "end":
                gamemode = "anime";
                talkframe.exit();
                itemframe.enter();
                level = 0;
                anime = "textframeout";
                nowweareat = "search";
                break;
        }
    }
    public void charactercontrol(float num, string commend,string type)
    {
        switch (commend)
        {
            case "enter":
                CG.characterenter(num,type);
                break;
            case "exit":
                CG.characterexit(num,type);
                break;
        }
    }

    public void Speak(talkform talk)//將文字傳給文字腳本
    {
        Text.type_start(talk.words);
        Text.speaker_name_set(talk.speaker);
        Text.recordtolog(talk.speaker, talk.words);
    }
    public void next_level()//關卡數值+1，並                                                                                                                                          關卡腳本
    {
        level++;
        levelmanager.story(nowweareat ,level);
    }
    public void skip()//跳過劇情事件,秘技
    {
        if (gamemode == "converstation"&& levelmanager.skipvalue(nowweareat,stage) != 0&&Text.typing==false)
        {
            level = levelmanager.skipvalue(nowweareat,stage);
            levelmanager.story(nowweareat, level);
        }
    }
    public void converstationclickframe()//對話事件
    {
        if (gamemode== "converstation"&& optionstate==false)
        {
            if (Text.typing)
                Text.type_delay = 0.005F;
            else
            {
                itemget.exit();
                next_level();

            }

                
        }
    }
    public void selectitem(int num)//選取物品事件
    {
        if (num <= playeritem.Count) { 
        if (playeritem[num - 1] != resentitem) {
            resentitem = playeritem[num - 1];
            itemframe.loaditems();
        }
        else if (playeritem[num - 1] == resentitem) {
            resentitem = "empty";
            itemframe.loaditems();
        }
        }
        
    }
    public void itemadd(string item,string name)
    {
        playeritem.Add(item);
        itemget.enter(name, getiteminfo(item),levelmanager.spriteDATA[item]);
    }
    public void camerachange(int cameranumber)//切換攝影機事件
    {
        levelmanager.cameralist[resentcamera].SetActive(false);
        levelmanager.cameralist[cameranumber].SetActive(true);
        if (cameranumber == 0)
            maincamera = true;
        else {
            maincamera = false;
            zoombackbutton.SetActive(true);
        }
        resentcamera = cameranumber;
    }
    public void effect(string effecttype)
    {
        switch (effecttype)
        {
            case "blackfadeout":
                if (black.anime.GetCurrentAnimatorStateInfo(0).IsName("black_on")) { 
                    blackstate = "off";
                gamemode = "anime";
                anime = "effectblackfadeout";
                black.anime.SetTrigger("fadeout");
                black.state = blackstate;
                }
                break;
            case "blackfadein":
                if (black.anime.GetCurrentAnimatorStateInfo(0).IsName("black_off"))
                {
                    blackstate = "black";
                    gamemode = "anime";
                    anime = "effectblackfadein";
                    black.anime.SetTrigger("fadein");
                    black.state = blackstate;
                }
                break;
        }
    }
    public string getiteminfo(string item)
    {
        return levelmanager.iteminfo[item];
    }
    public bool combinable()
    {
        return playeritem[iteminfo.sensorstage - 1] != resentitem && resentitem != "empty" && levelmanager.combine(resentitem, playeritem[iteminfo.sensorstage - 1]) != "fail";
    }
    public void combine() {
        if (combinable())
        {
            searchtrigger(levelmanager.combine(resentitem, playeritem[iteminfo.sensorstage - 1]));
            playeritem.Remove(playeritem[iteminfo.sensorstage - 1]);
            iteminfo.sensorstage = -1;
            useitem();
        }
    }
    public void useitem() {
        playeritem.Remove(resentitem);
        resentitem = "empty";
    }
    public void loadgame()
    {

    }
    public void nextstage()
    {
        switch (stage)
        {
            case "stage_one":
        load("stage_two");
                break;
            case "stage_two":
                load("stage_three");
                break;
        }

    }
    public void changemusic(int num)
    {
        audio.change(num);
    }
    public void stopmusic()
    {
        audio.stop();
    }
    public void load(string nextsence)
    {
        SceneManager.LoadScene(nextsence);
    }
}

