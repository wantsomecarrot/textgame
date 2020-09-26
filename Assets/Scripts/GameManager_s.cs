using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_s : MonoBehaviour
{
    // Start is called before the first frame update
    private Text_s Text ;//文字腳本
    private  test_level_BETA levelmanager;//關卡腳本
    private converstation_frame talkframe;//對話界面腳本
    private item_frame itemframe;
    public string nowweareat = "story";//當下使用劇本的暫存
    public float level=0;//當下使用劇本的對話階段暫存
    public string gamemode = "converstation";//遊戲狀態暫存
    private RaycastHit hit ;//滑鼠偵測暫存
    private Ray mouseray;//鐳射暫存
    private option optionframe;//
    public string anime =null;//
    public bool optionbool = false;//
    public List<string> flag;
    public List<string> playeritem ;
    public string resentitem;
    void Start()
    {
        Text = GameObject.Find("Words").GetComponent<Text_s>();
        levelmanager = GameObject.Find("LevelManager").GetComponent<test_level_BETA>();
        talkframe = GameObject.Find("Text_frame").GetComponent<converstation_frame>();
        optionframe = GameObject.Find("Option").GetComponent<option>();
        itemframe = GameObject.Find("Item_frame").GetComponent<item_frame>();
        levelmanager.story(nowweareat,level);
        playeritem.Insert(0,"empty");
     
    }

    // Update is called once per frame
    void Update()
    {
                switch (gamemode)
                {
                    case "converstation":
                        if (Input.GetKey(KeyCode.Space)) {
                            converstationclickframe();
                        }
                        break;
                    case "searching":
                        if (Input.GetMouseButtonDown(0)) {
                            mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
                            if (Physics.Raycast(mouseray, out hit, 1000f))
                            {
                                nowweareat = hit.transform.name;
                                levelmanager.story(nowweareat, level);
                            }
                        }
                            if (Input.mousePosition.x <= Screen.width * 0.25f)
                        {
                            Camera.main.transform.Rotate(0,-0.5f,0);
                        }
                        else if (Input.mousePosition.x >= Screen.width * 0.75f)
                        {
                            Camera.main.transform.Rotate(0, 0.5f, 0);
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
                    }
                    break;
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
    public void talk(string commend)//對話框動畫指令
    {
        switch (commend)//開始或結束
        {
            case"begin":
                gamemode = "anime";
             talkframe.enter();
                anime = "textframein";
                break;
            case "end":
                gamemode = "anime";
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
    public void next_level()//關卡數值+1，並傳給關卡腳本
    {
        level++;
        levelmanager.story(nowweareat ,level);
    }
    public void skip()//跳過劇情事件
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
    
}

