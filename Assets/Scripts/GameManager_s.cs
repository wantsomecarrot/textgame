using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManager_s : MonoBehaviour
{
    // Start is called before the first frame update
    private Text_s Text ;//文字腳本
    private  test_level_BETA levelmanager;//關卡腳本
    private converstation_frame talkframe;//對話界面腳本
    private item_frame itemframe;//物品欄腳本
    private charatercg CG;
    private bool spacekeyactive=true;
    private float spacekeycooldown;
    public blackcontrol black;
    public string nowweareat = "story";//當下使用劇本的暫存
    public float level=0;//當下使用劇本的對話階段暫存
    public string gamemode = "converstation";//遊戲狀態暫存
    public string UImode = "game";//?
    private RaycastHit hit ;//滑鼠偵測暫存
    private Ray mouseray;//鐳射暫存
    private option optionframe;//?
    private item_info iteminfo;
    public string anime =null;//動畫名稱暫存
    public bool optionbool = false;//？
    public List<string> flag;//劇情要素蒐集區
    public List<string> playeritem ;//玩家物品蒐集區
    public string resentitem = "empty";//手上物品暫存
    public int resentcamera = 0 ;//現在的攝影機
    private string blackstate ;//黑幕開關暫存
    public Dictionary<string, Sprite> spriteDATA;//存圖區
    
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
        Text = GameObject.Find("Words").GetComponent<Text_s>();
        levelmanager = GameObject.Find("LevelManager").GetComponent<test_level_BETA>();
        talkframe = GameObject.Find("Text_frame").GetComponent<converstation_frame>();
        optionframe = GameObject.Find("Option").GetComponent<option>();
        itemframe = GameObject.Find("Item_frame").GetComponent<item_frame>();
        black = GameObject.Find("blackback").GetComponent<blackcontrol>();
        CG = GameObject.Find("CharaterCG").GetComponent<charatercg>();
        iteminfo = GameObject.Find("iteminfo").GetComponent<item_info>();
        levelmanager.story(nowweareat,level);

    }

    // Update is called once per frame
    void Update()
    {
                switch (gamemode)
                {
                    case "converstation":
                        if (Input.GetKey(KeyCode.Space)&&spacekeyactive) {
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
                    }
                    break;
            }
        if (spacekeycooldown<=0) {
            spacekeyactive = true;
            spacekeycooldown = 0.1f;
        }
        if (!spacekeyactive)
            spacekeycooldown -= Time.deltaTime;

    }
    public void searchtrigger(string target) {
        nowweareat = target;
        levelmanager.story(nowweareat, level);
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
    public void CGcontrol(string commend,string type)
    {
        switch (commend)
        {
            case "enter":
                CG.characterenter(type);
                break;
            case "exit":
                CG.characterexit(type);
                break;
        }
    }
    /*public void Speak(string word)//將文字傳給文字腳本
    {
        Text.type_start(word);
    }*/
    public void Speak(talkform talk)//將文字傳給文字腳本
    {
        Text.type_start(talk.words);
        Text.speaker_name_set(talk.speaker);
    }
    public void next_level()//關卡數值+1，並傳給關卡腳本
    {
        level++;
        levelmanager.story(nowweareat ,level);
    }
    public void skip()//跳過劇情事件,秘技
    {
        if (gamemode == "converstation"&& levelmanager.skipvalue(nowweareat) != 0)
        {
            level = levelmanager.skipvalue(nowweareat);
            levelmanager.story(nowweareat, level);
        }
    }
    public void converstationclickframe()//對話事件
    {
        if (gamemode== "converstation")
        {
            if (Text.typing)
                Text.type_delay = 0.01F;
            else
                next_level();
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
    public void camerachange(int cameranumber)//切換攝影機事件
    {
        levelmanager.cameralist[resentcamera].SetActive(false);
        levelmanager.cameralist[cameranumber].SetActive(true);
        resentcamera = cameranumber;
    }
    public void effect(string effecttype)
    {
        switch (effecttype)
        {
            case "blackfadeout":
                blackstate = "off";
                gamemode = "anime";
                anime = "effectblackfadeout";
                black.anime.SetTrigger("fadeout");
                black.state = blackstate;
                break;
        }
    }
    public string getiteminfo(string item)
    {
        return levelmanager.iteminfo[item];
    }
    public void combine() {
        if (playeritem[iteminfo.sensorstage - 1] != resentitem && resentitem != "empty"&&levelmanager.combine(resentitem, playeritem[iteminfo.sensorstage - 1])!="fail")
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
}

