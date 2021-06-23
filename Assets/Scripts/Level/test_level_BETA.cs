using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test_level_BETA : MonoBehaviour
{
    
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Sprite> DATAimage;
    public List<string> imagename;
    public Dictionary<string, Sprite> spriteDATA = new Dictionary<string, Sprite>();
    public Dictionary<string, string> iteminfo = new Dictionary<string, string>();
    public characterform Akun;
    public List<Sprite> Akunimage;
    public List<string> Akunimagename;
    public List<GameObject> cameralist;
    public List<GameObject> zoombackgroundlist;
    public List<GameObject> zoomobjectlist;
    public List<GameObject> zoomlist;
    public List<GameObject> puzzlelist;
    public void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        Akun = new characterform("akun");
        StartCoroutine(Getimage(imagename, DATAimage,spriteDATA));
        gamemanager.spriteDATA = spriteDATA;
        iteminfo.Add("match","賣女孩的小火柴");
        iteminfo.Add("matchbox", "沒有火柴的火柴盒？");
        iteminfo.Add("burnmatch", "燒毀！");
        iteminfo.Add("key", "開啟命運之門的石之鑰匙");
        StartCoroutine(Getimage(Akunimagename, Akunimage, Akun.CG));
    }
    IEnumerator Getimage(List<string>name,List<Sprite>image,Dictionary<string, Sprite>dictionary)
    {
        for (int i = 0; i < name.Count; i++)
        {
            dictionary.Add(name[i], image[i]);
        }
        name.Clear();
        image.Clear();
        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
        switch(gamemanager.stage)
        {
            case "stage_one":
                if (puzzlelist[0].GetComponent<clockniddle>().good&& puzzlelist[1].GetComponent<clockniddle>().good&&gamemanager.flag.Contains("clockopened")==false&&gamemanager.gamemode=="searching")
                {
                    gamemanager.searchtrigger("clocktrigger");
                    puzzlelist[0].GetComponent<clockniddle>().abled = false;
                    puzzlelist[1].GetComponent<clockniddle>().abled = false;
                }
                break;
            case "stage_two":
                if (puzzlelist[0].GetComponent<piano>().good && gamemanager.flag.Contains("pianolv2unlock") == false && gamemanager.gamemode == "searching")
                {
                    gamemanager.searchtrigger("pianotrigger");
                    puzzlelist[0].GetComponent<piano>().abled = false;
                }
                if (puzzlelist[1].GetComponent<cellocode>().good && gamemanager.flag.Contains("celloopen") == false && gamemanager.gamemode == "searching")
                {
                    gamemanager.searchtrigger("cellotrigger");
                    puzzlelist[1].GetComponent<cellocode>().abled = false;
                }
                break;
            default:
                break;
        }
    }
    public int skipvalue(string name,string stage)
    {
        int value = 0;
        switch (name)
        {
            case "story":
                switch (stage)
                {
                    case "stage_one":
                        value = 69;
                        break;
                    case "stage_two":
                        value = 50;
                        break;
                    case "stage_three":
                        value = 50;
                        break;
                }
                
                break;
            default:
                value = 0;
                break;
        }
        return value;
    }
    public void story(string name, float level)
    {
        switch (gamemanager.stage)
        {
            case"stage_one" :
                switch (name)
                {
                    case "story":
                        switch (level)
                        {
                            case 0:
                                gamemanager.black.state = "on";
                                gamemanager.talk("begin");
                                gamemanager.changemusic(1);
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("血液在大雨滂沱中漫開。", " ", " ", " "));

                                break;
                            case 2:
                                gamemanager.Speak(new talkform("我緊緊的握住了那雙逐漸冰冷的手。", " ", " ", " "));

                                break;
                            case 3:
                                gamemanager.Speak(new talkform("視線是模糊的，分不清是雨水還是淚。", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.Speak(new talkform("我做了一個夢，很長，很久。", " ", " ", " "));
                                break;
                            case 5:
                                gamemanager.Speak(new talkform("我感覺到有人在呼喊我的名字，很遙遠、很遙遠。", " ", " ", " "));
                                break;
                            case 6:
                                gamemanager.Speak(new talkform("在辨認出那是誰的聲音之前，我感受到了一陣疼痛。", " ", " ", " "));
                                gamemanager.stopmusic();
                                break;
                            case 7:
                                gamemanager.effect("blackfadeout");
                                break;
                            case 8:
                                gamemanager.Speak(new talkform("好痛……", "我", " ", " "));
                                break;
                            case 9:
                                gamemanager.Speak(new talkform("額頭好像被什麼結實的東西敲了一下。", " ", " ", " "));
                                break;
                            case 10:
                                gamemanager.Speak(new talkform("我摸索了一下周遭，是一本書。", " ", " ", " "));
                                break;
                            case 11:
                                gamemanager.Speak(new talkform("書？", " ", " ", " "));
                                break;
                            case 12:
                                gamemanager.Speak(new talkform("除了書以外，我發現自己躺在床上。", " ", " ", " "));
                                break;
                            case 13:
                                gamemanager.Speak(new talkform("陌生的觸感，這不是我的床。", " ", " ", " "));
                                break;
                            case 14:
                                gamemanager.Speak(new talkform("非常……", "？？？", " ", " "));

                                break;
                            case 15:
                                gamemanager.Speak(new talkform("……？", "我", " ", " "));
                                break;
                            case 16:
                                gamemanager.Speak(new talkform("非常對不起！！！", "？？？", " ", " "));
                                gamemanager.changemusic(2);
                                gamemanager.CGcontrol("show");
                                break;
                            case 17:
                                gamemanager.Speak(new talkform("欸？為什麼要突然道歉。", " ", " ", " "));
                                break;
                            case 18:
                                gamemanager.Speak(new talkform("床的一側站著一個少女。", " ", " ", " "));
                                break;
                            case 19:
                                gamemanager.Speak(new talkform("是不認識的面孔，她是誰？", " ", " ", " "));
                                break;
                            case 20:
                                gamemanager.Speak(new talkform("你還好嗎！？有沒有哪裡受傷！？", "？？？", " ", " "));
                                break;
                            case 21:
                                gamemanager.Speak(new talkform("腦袋裡一團混亂，但面前的少女看起來比我更慌亂。", " ", " ", " "));
                                break;
                            case 22:
                                gamemanager.Speak(new talkform("現在顯然不是慌亂的時候。一件事一件事慢慢來，要有條理的整理情況。", " ", " ", " "));
                                break;
                            case 23:
                                gamemanager.Speak(new talkform("嗯，先冷靜下來，深呼吸。", " ", " ", " "));
                                break;
                            case 24:
                                gamemanager.Speak(new talkform("砸在臉上的書已經被我拿到手上。", " ", " ", " "));
                                break;
                            case 25:
                                gamemanager.Speak(new talkform("看來是她不小心將書砸到我的臉上了。", " ", " ", " "));
                                break;
                            case 26:
                                gamemanager.Speak(new talkform("莫名其妙就這樣被打醒，我其實有點煩躁。", " ", " ", " "));
                                break;
                            case 27:
                                gamemanager.Speak(new talkform("起床氣指的應該就是這種感覺。", " ", " ", " "));
                                break;
                            case 28:
                                gamemanager.Speak(new talkform("不過看她慌張的樣子……脾氣還是先緩一緩。", " ", " ", " "));
                                break;
                            case 29:
                                gamemanager.Speak(new talkform("沒事，沒有大礙。", "我", " ", " "));
                                break;
                            case 30:
                                gamemanager.Speak(new talkform("比起那個，讓我在意的事情還有很多。", " ", " ", " "));
                                gamemanager.CGcontrol("hide");
                                gamemanager.charactercontrol(1, "enter", "popout");
                                break;
                            case 31:
                                gamemanager.Speak(new talkform("那就好了……要是害你受傷，大概又要被酒保先生說笑了。", "？？？", " ", " "));
                                
                                break;
                            case 32:
                                gamemanager.Speak(new talkform("酒保先生？", "我", " ", " "));
                                break;
                            case 33:
                                gamemanager.Speak(new talkform("那是誰？這裡的其他人嗎？", " ", " ", " "));
                                break;
                            case 34:
                                gamemanager.Speak(new talkform("我稍微環視了一下整個空間。", " ", " ", " "));
                                break;
                            case 35:
                                gamemanager.Speak(new talkform("這裡的擺設我完全沒有印象，我是怎麼睡的，會在這裡醒來？", " ", " ", " "));
                                break;
                            case 36:
                                gamemanager.Speak(new talkform("這裡...是哪裡呢？", "我", " ", " "));
                                break;
                            case 37:
                                gamemanager.Speak(new talkform("這個……我也不知道怎麼解釋……酒保先生在的話就好了……", "？？？", " ", " "));
                                break;
                            case 38:
                                gamemanager.Speak(new talkform("………", "我", " ", " "));
                                break;
                            case 39:
                                gamemanager.Speak(new talkform("………", "？？？", " ", " "));
                                gamemanager.stopmusic();
                                break;
                            case 40:
                                gamemanager.Speak(new talkform("總覺得。", " ", " ", " "));
                                break;
                            case 41:
                                gamemanager.Speak(new talkform("有點可疑啊……", " ", " ", " "));
                                break;
                            case 42:
                                gamemanager.Speak(new talkform("不過就這麼呆坐在這邊也不是辦法。", " ", " ", " "));
                                break;
                            case 43:
                                gamemanager.Speak(new talkform("聽你剛才的意思，去找那個酒保先生，他就有辦法跟我解釋現在的情況嗎？", "我", " ", " "));
                                break;
                            case 44:
                                gamemanager.Speak(new talkform("是、是的……不過……", "？？？", " ", " "));
                                break;
                            case 45:
                                gamemanager.Speak(new talkform("在那之前，我們有個有點棘手的問題……", "？？？", " ", " "));
                                break;
                            case 46:
                                gamemanager.Speak(new talkform("有點棘手的問題？", " ", " ", " "));
                                break;
                            case 47:
                                gamemanager.Speak(new talkform("啊，失禮了，我還沒有自我介紹吧。我叫喵可，可以告訴我你的名字嗎？", "？？？", " ", " "));
                                break;
                            case 48:
                                gamemanager.Speak(new talkform("艾德里安，叫我艾德就好。", "我", " ", " "));
                                break;
                            case 49:
                                gamemanager.Speak(new talkform("關於剛才你提到的，棘手的問題？", "我", " ", " "));
                                break;
                            case 50:
                                gamemanager.Speak(new talkform("嗚嗯……其實，在我進來之後，這間房間被反鎖住了。", "喵可", " ", " "));
                                break;
                            case 51:
                                gamemanager.Speak(new talkform("怎麼一回事？", "我", " ", " "));
                                break;
                            case 52:
                                gamemanager.Speak(new talkform("我也不知道....門就『喀喇！』一聲自己鎖起來了。", "喵可", " ", " "));
                                break;
                            case 53:
                                gamemanager.Speak(new talkform("……這還真是玄妙的狀況。", "我", " ", " "));
                                break;
                            case 54:
                                gamemanager.Speak(new talkform("的確是有點棘手的問題。", " ", " ", " "));
                                break;
                            case 55:
                                gamemanager.Speak(new talkform("跟一個不認識的女孩鎖在一個陌生的房間裡，尷尬到不行。", " ", " ", " "));
                                break;
                            case 56:
                                gamemanager.Speak(new talkform("如果困在這裡的時間一長，我們的食物、精神也有可能出問題...", " ", " ", " "));
                                break;
                            case 57:
                                gamemanager.Speak(new talkform("不過就剛才喵可說的話，聽起來外面應該還有什麼人。", " ", " ", " "));
                                break;
                            case 58:
                                gamemanager.Speak(new talkform("應該不至於在這裡關一輩子吧....", " ", " ", " "));
                                break;
                            case 59:
                                gamemanager.Speak(new talkform("我剛才原本是想在房間裡找找看鑰匙的，結果一不小心就把書本弄到艾德先生的臉上了。", "喵可", " ", " "));
                                break;
                            case 60:
                                gamemanager.Speak(new talkform("那個……真的非常抱歉！", "喵可", " ", " "));
                                break;
                            case 61:
                                gamemanager.Speak(new talkform("沒想到她還這麼在意書的事情。", " ", " ", " "));
                                break;
                            case 62:
                                gamemanager.Speak(new talkform("雖說要我這麼輕易地相信一個陌生人有些難度。", " ", " ", " "));
                                break;
                            case 63:
                                gamemanager.Speak(new talkform("但是喵可給我的感覺...應該是不會刻意傷害我。", " ", " ", " "));
                                break;
                            case 64:
                                gamemanager.Speak(new talkform("……頂多再砸一本書到我臉上的程度。", " ", " ", " "));
                                break;
                            case 65:
                                gamemanager.Speak(new talkform("別在意了，我也沒受傷。", "我", " ", " "));
                                break;
                            case 66:
                                gamemanager.Speak(new talkform("不過即然我醒了，就讓我也來找找看鑰匙吧。", "我", " ", " "));
                                break;
                            case 67:
                                gamemanager.Speak(new talkform("嗯、嗯，沒問題！", "喵可", " ", " "));
                                break;
                            case 68:
                                gamemanager.Speak(new talkform("那麼就開始吧，先把能看能摸的地方都先看過一次。", " ", " ", " "));
                                break;
                            case 69:
                                gamemanager.changemusic(3);
                                gamemanager.effect("blackfadeout");
                                gamemanager.charactercontrol(1, "exit", "slideout");
                                gamemanager.talk("end");
                                gamemanager.entertutorial();
                                break;
                            default:
                                break;
                        }
                        break;

                    case "bed":
                        if (gamemanager.flag.Contains("bed"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("一張雙人大床，我們剛檢查過它。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("哈啾！", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("可惡的灰塵。", "", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("一張雙人大床，我剛從上面爬下來。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("話說回來，床底下會有什麼嗎？", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("我鑽進去看看吧！", "喵可", " ", " "));
                                    gamemanager.charactercontrol(1, "enter", "popout");
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("等等，我來吧。", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("知道該說是她神經大條還是什麼呢……", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("她可是穿裙子的啊。", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("我掀開床單，趴下身來看了進去。", " ", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("可惜裡面只有灰塵。", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("有找到什麼嗎？", "喵可", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("嗯……空空如也呢。", "我", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.charactercontrol(1, "exit", "slideout");
                                    gamemanager.flag.Add("bed");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "light":
                        if (gamemanager.flag.Contains("light"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("房間裡的光源，燈火在裏頭搖曳著。", " ", " ", " "));
                                    openzoom(7);
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("裡面有一片銅片，上頭寫著數字。", " ", " ", " "));

                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    openzoom(7);
                                    gamemanager.Speak(new talkform("一盞壁燈，房間的光源似乎全都來自於他。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("唔、好亮。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("壁燈裡面有什麼東西在一閃一閃的。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("裡面有一片銅片，上頭寫著數字。", " ", " ", " "));
                                    zoomobjectlist[9].SetActive(true);
                                    break;
                                case 5:
                                    gamemanager.flag.Add("light");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "bookshelf":
                        if (gamemanager.flag.Contains("bookshelf"))
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("書櫃上頭塞滿了書本，但書頁都是空白的，什麼都沒有。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        else
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("書櫃裡滿滿都是書，滿到要拿一本書出來都很困難。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("好不容易抽了一本出來，翻開來一看，居然都是白紙。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("其他的書也是....這裡的書居然都是白紙。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("居然沒有內容的話，這些書有什麼意義？擺著這些書的這麼多書櫃有什麼意義？放著這些書櫃的這個房間又有什麼意義？", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("真要這麼追究下去的話，站在這間房間裡面的我們也要開始意義不明了。", "喵可", " ", " "));
                                    gamemanager.charactercontrol(1, "enter", "popout");
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("事物的存在有什麼意義不重要，重要的是事物當下對你我來說有什麼意義。我是這麼認為的。", "喵可", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.charactercontrol(1, "exit", "stretchdown");
                                    gamemanager.flag.Add("bookshelf");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        break;
                    case "vase":
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("盛著某種花卉，但花已經枯萎了。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.charactercontrol(1, "enter", "popout");
                                gamemanager.Speak(new talkform("啊…枯掉了，之後再換上新的一束吧。", "喵可", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("我是覺得沒什麼必要啦....", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.charactercontrol(1, "exit", "slideout");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;
                    case "fireplace":
                        if (gamemanager.flag.Contains("fireplace"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("房間裡的壁爐，中間掛著一個齒輪形狀的裝飾品。", " ", " ", " "));

                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("裡面沒有放柴火，不過房間仍然溫暖，真神奇。", " ", " ", " "));

                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        { 
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("怪了……壁爐裡面還真是乾淨。", "我", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("簡直跟新的一樣", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.charactercontrol(1, "enter", "popout");
                                    gamemanager.Speak(new talkform("一開始的時候都是這樣的呢....", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("一開始？什麼意思？", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("怎麼跟你解釋才好呢......啊啊啊啊...頭好痛...酒保先生在就好了....", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("喵可看起來真的很困擾的樣子，摸著自己的頭....", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("……那先不用跟我說沒關係，出去之後我再問問那個酒保先生吧。", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("總之先想辦法出去嗎...", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.flag.Add("fireplace");
                                    gamemanager.charactercontrol(1, "exit", "slideout");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                }
                break;
            case "window":
                if (gamemanager.flag.Contains("window"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("窗戶外面只有一片漆黑，天空、地面、景物之類的東西完全看不到。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("奇怪？", "我", " ", " "));
                            break;
                        case 2:
                            gamemanager.charactercontrol(1,"enter", "popout");
                            gamemanager.Speak(new talkform("怎麼了？", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("窗戶外面一片漆黑，什麼都看不到，有點恐怖。", " ", " ", " "));
                            break;
                                case 4:
                                    gamemanager.Speak(new talkform("這裡房間的窗戶是看不到外面的嗎？", "我", " ", " "));
                                    break;
                                case 5:
                            gamemanager.Speak(new talkform("可能是這間房間才看不到喔，其他的房間看出去都有景象呢。", "喵可", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("這樣的話，窗戶外一片漆黑，房間裡面又只靠幾個壁燈維持光源，不僅採光一塌糊塗，看書還傷眼睛。", "我", " ", " "));
                            break;
                                case 7:
                                    gamemanager.Speak(new talkform("看到這樣的房間，室內設計師想必會吐血吧。", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("啊哈哈哈...反正這裡的書好像都是空白的，暗一點沒有關係啦....", "喵可", " ", " "));
                                    break;
                                case 9:
                            gamemanager.charactercontrol(1,"exit", "slideout");
                            gamemanager.flag.Add("window");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "candle":
                        if (gamemanager.flag.Contains("key"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:

                                    gamemanager.Speak(new talkform("即使點燃了燭台，對房間的糟糕採光仍然沒有任何幫助。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("真的是只有裝飾功能欸...", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    openzoom(5);
                                    gamemanager.Speak(new talkform("一個燭台放在梳妝台上面。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("雖然好像跟整個房間的氣氛很合，但是對房間的昏暗光線沒有做出任何貢獻。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                break;
                    case "candletrigger":
                        if (gamemanager.resentitem == "burnmatch")
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    changzoomimage(zoomobjectlist[11], "candlelighton");
                                    gamemanager.Speak(new talkform("我用火柴點燃了燭台上的蠟燭。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("『碦咚』一聲，一個東西從燭台的中間掉了出來。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("是一把鑰匙。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.charactercontrol(1,"enter", "popout");
                                    gamemanager.Speak(new talkform("這該不會就是？", "喵可", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("這該不會就是？", "我", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("拿去試試看吧。", " ", " ", " "));
                                    gamemanager.charactercontrol(1,"exit", "slideout");
                                    break;
                                case 7:
                                    gamemanager.itemadd("key","鑰匙");
                                    gamemanager.Speak(new talkform("獲得了鑰匙！", " ", " ", " "));
                                    break;
                                case 8:
                                    
                                    gamemanager.flag.Add("key");
                                    gamemanager.useitem();
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if(gamemanager.flag.Contains("key"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    
                                    gamemanager.Speak(new talkform("點燃了蠟燭之後，鑰匙從燭台裡掉了出來。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("是機關燭台！不曉得它是怎麼偵測蠟燭有沒有點燃的？溫度感測嗎？", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("被點燃就會打開的話，作為保險箱感覺不怎麼安全呢...", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("應該就只是個擺飾品吧。", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.resentitem == "match")
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("把燭台點燃試試看吧。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("拿著火柴心裡這麼想，但是火柴沒辦法自己點燃。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("火柴盒...有這樣的東西就好了呢。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if(gamemanager.flag.Contains("candle"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:

                                    gamemanager.Speak(new talkform("這個燭台中間好像有東西，但是現在好像鎖住了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    
                                    gamemanager.Speak(new talkform("裝飾用的燭台。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("燭台中間的這個地方是一個收納區。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("我稍微摸了一下，打不太開。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("有意思。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "toyplane":
                if (gamemanager.flag.Contains("toyplane"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(6);
                            gamemanager.Speak(new talkform("古銅色的飛機模型，非常精緻。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(6);
                            gamemanager.Speak(new talkform("古銅色的飛機模型，非常精緻。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("裡面有根火柴。", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.charactercontrol(1,"enter", "popout");
                            gamemanager.Speak(new talkform("是用來點燃壁爐的嗎？", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("但壁爐沒有炭呢……", "我", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("連木柴都沒有一根。", " ", " ", " "));
                            break;
                        case 6:
                            gamemanager.flag.Add("toyplane");
                            gamemanager.charactercontrol(1,"exit", "slideout");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "toyplanetrigger":
                {
                    if (gamemanager.flag.Contains("match") == false) {
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                zoomobjectlist[8].SetActive(false);
                                gamemanager.itemadd("match","一根火柴");
                                gamemanager.Speak(new talkform("得到了火柴！", " ", " ", " "));
                                break;
                            case 2:
                                
                                gamemanager.flag.Add("match");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }

                }
                break;
            case "book":
                if (gamemanager.flag.Contains("book"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(1);
                            gamemanager.Speak(new talkform("我又嘗試翻了一些其他書頁，但是都是空白的，真奇怪。", " ", " ", " "));
                            break;
                        case 2:

                            gamemanager.Speak(new talkform("這裡的書本都是白的嗎？", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(1);
                            gamemanager.Speak(new talkform("這些書就這樣散落在地上。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("想把它們都撿起來收回書櫃上，但是書櫃上沒有塞得下的位置。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("書頁裡夾著一片透明的碎片。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
                    case"booktrigger":
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                openzoom(1);
                                gamemanager.Speak(new talkform("這本書就這樣開著，放在地板上。", " ", " ", " "));
                                break;
                            case 2:

                                gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                                break;
                            case 3:
                                zoomobjectlist[1].SetActive(true);
                                gamemanager.Speak(new talkform("書頁裡夾著一片透明的碎片。", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.flag.Add("book");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;
            case "carpet":
                if (gamemanager.flag.Contains("carpet"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("毛茸茸的地毯，邊角有狼的花紋裝飾。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(2);
                            gamemanager.Speak(new talkform("毛茸茸的地毯，邊角有狼的花紋裝飾。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "carpettrigger":
                switch (level)
                {
                    case 0:

                        gamemanager.talk("begin");
                        break;
                    case 1:
                        changzoomimage(zoomobjectlist[2], "carpet2");
                        gamemanager.Speak(new talkform("藏在地毯底下的地板刻著字。", " ", " ", " "));
                        break;
                    case 2:
                        if (gamemanager.flag.Contains("carpet") == false)
                            gamemanager.flag.Add("carpet");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bussinesscase":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("規矩的黑色公事包，在房裡顯得有些突兀。", " ", " ", " "));
                        openzoom(3);
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;

                }
                break;
            case "bussinesscasetrigger":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        changzoomimage(zoomobjectlist[3], "bussinesscase2");
                        zoomobjectlist[4].SetActive(true);
                        //gamemanager.charactercontrol(1,"enter","popout");
                        gamemanager.Speak(new talkform("…紙球？", "喵可", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("我將紙球攤開。", " ", " ", " "));
                        break;
                    case 3:
                        changzoomimage(zoomobjectlist[4], "bussinesscase3");
                        gamemanager.Speak(new talkform("獲得了打開的便條，上面似乎寫著一段文字。", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("注意時間……？", "喵可", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("我抬頭看了一眼時鐘，不知道是半夜三點還是下午三點。", " ", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("總之不是現在。", " ", " ", " "));
                        break;
                    case 7:
                        gamemanager.flag.Add("bussinesscase");
                        //gamemanager.charactercontrol(1,"exit", "slideout");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "dressingtable":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("一組造型典雅的梳妝台，上面的鏡子倒映著房間。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("邊邊刻上了貓咪的雕花，真是細緻。", "我", " ", " "));
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "bedsidetable":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak(new talkform("造型簡單的床頭櫃，上面的桌燈散發著溫暖的光芒，櫃子抽屜似乎還打不開。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "clock":
                if (gamemanager.flag.Contains("clockopened"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(4);
                            gamemanager.Speak(new talkform("一個貓咪時鐘，我真的沒想到他居然是貓咪時鐘……", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("clock"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(4);
                            gamemanager.Speak(new talkform("木製樹屋外觀的時鐘，這麼說來應該是個布穀鳥鐘了。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }

                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            openzoom(4);
                            gamemanager.Speak(new talkform("這種房子的造型應該是布穀鳥鐘吧？", "我", " ", " "));
                            break;
                        case 2:
                            //gamemanager.charactercontrol(1,"enter","popout");
                            gamemanager.Speak(new talkform("我還是第一次看到實體的布穀鳥鐘呢。", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("這個地方沒有其他的布穀鳥鐘？", "我", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("沒有的樣子，大廳到是有一座很大的座鐘。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("高到天花板那麼大喔！", "喵可", " ", " "));
                            break;
                        case 6:
                            gamemanager.Speak(new talkform("那還真不是普通的大。", " ", " ", " "));
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("我很感興趣呢。", "我", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("不過得先出去就是了。", " ", " ", " "));
                            break;
                        case 9:
                            //gamemanager.charactercontrol(1,"exit", "slideout");
                            gamemanager.flag.Add("clock");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
                    case "clocktrigger":
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                openzoom(4);
                                gamemanager.Speak(new talkform("說到時間的話，就是時鐘了吧。", "我", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("有沒有辦法調整呢？", "我", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("我將椅子搬了過來，踩上去看了看。", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.Speak(new talkform("太好了，似乎可以轉看看。", "我", " ", " "));
                                break;
                            case 5:
                                changzoomimage(zoombackgroundlist[3], "clock2");
                                gamemanager.Speak(new talkform("我把時鐘的時間調整到與找到的數字一致，時鐘喵了一聲後，一隻貓咪從裡面彈了出來。", " ", " ", " "));
                                break;
                            case 6:
                                gamemanager.Speak(new talkform("居然是貓咪？", "我", " ", " "));
                                break;
                            case 7:
                                gamemanager.Speak(new talkform("有貓咪的布榖鐘啊……", "喵可", " ", " "));
                                gamemanager.charactercontrol(1,"enter", "popout");
                                break;
                            case 8:
                                gamemanager.Speak(new talkform("她看起來很想要的樣子。", " ", " ", " "));
                                break;
                            case 9:
                                gamemanager.Speak(new talkform("以我的品味來說這鐘確實是過於可愛了，她想要的話或許可以讓她帶走。", " ", " ", " "));
                                break;
                            case 10:
                                gamemanager.Speak(new talkform("我觀察了一下沒有回到時鐘裡的貓咪。", " ", " ", " "));
                                gamemanager.charactercontrol(1,"exit", "slideout");
                                break;
                            case 11:
                                gamemanager.Speak(new talkform("牠的嘴上咬著空的火柴盒。", " ", " ", " "));
                                break;
                            case 12:
                                changzoomimage(zoombackgroundlist[3], "clock4");
                                gamemanager.itemadd("matchbox","火柴盒");
                                gamemanager.Speak(new talkform("得到了火柴盒！", " ", " ", " "));
                                break;
                            case 13:
                                
                                gamemanager.flag.Add("clockopened");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;
            case "door":
                if (gamemanager.resentitem == ("key"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("鑰匙剛剛好的放入了鎖裡。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("門喀嗤一聲，被打開了。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.charactercontrol(1,"enter", "popout");
                            gamemanager.Speak(new talkform("打開了！", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.charactercontrol(1,"exit", "slideout");
                            gamemanager.Speak(new talkform("真是太好了！我們可以出去了！", " ", " ", " "));
                            break;
                        case 5:
                                    gamemanager.stopmusic();
                                    gamemanager.effect("blackfadein");
                                    gamemanager.nextstage();
                            gamemanager.useitem();
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if (gamemanager.flag.Contains("door"))
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("上了鎖的門，想要出去只能快點找到鑰匙了。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("轉了轉手把，絲紋不動。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("真的被鎖上了呢……", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.flag.Add("door");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "setthefire":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("我把火柴點了起來。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("小小的火焰在火柴前端燃起。", " ", " ", " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform("它的柄完全沒有要燒短的跡象，感覺可以永遠燒下去，真神奇。", " ", " ", " "));
                        break;
                            case 4:
                                gamemanager.itemadd("burnmatch","點燃的火柴");
                                gamemanager.Speak(new talkform("獲得了點燃的火柴！", " ", " ", " "));
                                break;
                            case 5:
                        
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;
            case "chair":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:

                        gamemanager.Speak(new talkform("異常柔軟的沙發椅。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("坐在上面感覺自己的骨頭也變軟了。", " ", " ", " "));
                        break;
                    case 3:
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                break;

            case "niddleminute":

                break;
            default:
                break;
                /*
                case "curtain":
                    if (gamemanager.flag.Contains("curtain"))
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("造型典雅的窗簾。");
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("造型典雅的窗簾，拉繩上好像綁著一張紙。");
                                break;
                            case 2:
                                gamemanager.Speak("我把紙片抽出來，上面寫著些什麼。");
                                break;
                            case 3:
                                gamemanager.Speak("_ _ ：5 _");
                                break;
                            case 4:
                                gamemanager.flag.Add("curtain");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                

                case "planecarrot":
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:

                            gamemanager.Speak("這是貼了透明貼圖的平面物件。");
                            break;
                        case 2:
                            gamemanager.Speak("比紙還要薄，只有一面看得到，另一面甚至看過來是透明的。");
                            break;
                        case 3:
                            gamemanager.Speak("連影子都沒有，跟鬼一樣，可憐那。");
                            break;
                        case 4:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                    break;
               */
        }
                break;
            case "stage_two":
                switch (name)
                {
                    case "story":
                        switch (level)
                        {
                            case 0:
                                gamemanager.black.state = "on";
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("我和喵可成功出去之後，如願見到了傳說中的酒保先生。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("除此之外，也看見了大廳裡的那座大鐘……", " ", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("應該說，這裡的東西大多大的誇張。", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.Speak(new talkform("簡直像是世界上數一數二高級的圖書館。"," ", " ", " "));
                                break;
                            case 5:
                                gamemanager.Speak(new talkform("對，這裡的書也多的誇張。", " ", " ", " "));
                                break;
                            case 6:
                                gamemanager.Speak(new talkform("酒保——叫做柯斯莫的人，向我解釋了一切。", " ", " ", " "));
                                break;
                            case 7:
                                gamemanager.Speak(new talkform("還有另一位名叫羅瑟的青年，年紀看起來和我差不多大。", " ", " ", " "));
                                break;
                            case 8:
                                gamemanager.Speak(new talkform("我終於理解為什麼喵可會堅持讓他來講。", " ", " ", " "));
                                break;
                            case 9:
                                gamemanager.Speak(new talkform("這件事情真是複雜到難以置信。", " ", " ", " "));
                                break;
                            case 10:
                                gamemanager.Speak(new talkform("這裡叫做心向館，是某個人的心理世界。", " ", " ", " "));
                                break;
                            case 11:
                                gamemanager.Speak(new talkform("柯斯莫和喵可等人稱呼他為主人。", " ", " ", " "));
                                break;
                            case 12:
                                gamemanager.Speak(new talkform("包括我，出現在心向館的所有人都是「一份記憶」的實體化。", " ", " ", " "));
                                break;
                            case 13:
                                gamemanager.Speak(new talkform("老實說我已經開始聽不懂了。", " ", " ", " "));
                                break;
                            case 14:
                                gamemanager.Speak(new talkform("所以我只是一份記憶？", " ", " ", " "));
                                break;
                            case 15:
                                gamemanager.Speak(new talkform("但我什麼都想不起來啊？", " ", " ", " "));
                                break;
                            case 16:
                                gamemanager.Speak(new talkform("發生在我身上的情形，似乎是前所未聞。", " ", " ", " "));
                                break;
                            case 17:
                                gamemanager.Speak(new talkform("其他人都能夠記得他們跟主人之間的回憶，這只讓我非常擔心。", " ", " ", " "));
                                break;
                            case 18:
                                gamemanager.Speak(new talkform("究竟為什麼我什麼都記不起來呢？", " ", " ", " "));
                                break;
                            case 19:
                                gamemanager.Speak(new talkform("喵可鼓勵我繼續努力嘗試回想，在那之前可以先開始了解心向館的每個角落。", "", " ", " "));
                                break;
                            case 20:
                                gamemanager.Speak(new talkform("我想這對我是很好的。", " ", " ", " "));
                                break;
                            case 21:
                                gamemanager.Speak(new talkform("因為我收到的資訊量已經大到我的腦子裡一片空白。", " ", " ", " "));
                                break;
                            case 22:
                                gamemanager.Speak(new talkform("雖然沒有記憶，但常識我當然還是有。", " ", " ", " "));
                                break;
                            case 23:
                                gamemanager.Speak(new talkform("太難以置信了……難不成我正在體驗穿越到異世界的感覺嗎？", " ", " ", " "));
                                break;
                            case 24:
                                gamemanager.Speak(new talkform("我準備在早餐過後，跟著喵可到處去轉轉。", " ", " ", " "));
                                break;
                            case 25:
                                gamemanager.Speak(new talkform("但似乎有位夥伴一直到我們聊完都還沒到用餐區。", " ", " ", " "));
                                break;
                            case 26:
                                gamemanager.Speak(new talkform("作為一名新人以及他們未來的夥伴，一方面也是因為我很好奇剩下的一位夥伴是什麼樣子的人。", " ", " ", " "));
                                break;
                            case 27:
                                gamemanager.Speak(new talkform("我自告奮勇的決定去提醒對方下來用餐。", " ", " ", " "));
                                break;
                            case 28:
                                gamemanager.Speak(new talkform("…….要是我沒有迷路的話。", " ", " ", " "));
                                break;
                            case 29:
                                gamemanager.Speak(new talkform("喵可很自然而然的跟著我一起來了。", " ", " ", " "));
                                break;
                            case 30:
                                gamemanager.Speak(new talkform("否則在這麼大的空間，讓我迷路大概不難。", " ", " ", " "));
                                break;
                            case 31:
                                gamemanager.Speak(new talkform("但是，當我們到了房間後，卻沒有人回應我們的敲門聲。", " ", " ", " "));
                                break;
                            case 32:
                                gamemanager.Speak(new talkform("擔心會發生事情的我，小心的開了房門，卻發現門並沒有上鎖。", "", " ", " "));
                                break;
                            case 33:
                                gamemanager.Speak(new talkform("然後，我們看到的卻是——", " ", " ", " "));
                                break;
                            case 34:
                                gamemanager.Speak(new talkform("在地上昏迷不醒的女性，喵可等人稱呼她為老師的埃爾維娜小姐。", " ", " ", " "));
                                break;
                            case 35:
                                gamemanager.Speak(new talkform("喵可通知過後，柯斯莫小心的檢查過埃爾維娜有沒有外傷。", " ", " ", " "));
                                break;
                            case 36:
                                gamemanager.Speak(new talkform("聽他的說法，後腦和後頸有紅腫，像是被撞擊或敲擊到。", " ", " ", " "));
                                break;
                            case 37:
                                gamemanager.Speak(new talkform("……有種我才剛來不久就發生了不太好的事情的感覺。", " ", " ", " "));
                                break;
                            case 38:
                                gamemanager.Speak(new talkform("其實心向館是個多災多難的地方？", " ", " ", " "));
                                break;
                            case 39:
                                gamemanager.Speak(new talkform("但我其實不害怕被人或者是靈異現象之類的東西襲擊就是了。", " ", " ", " "));
                                break;
                            case 40:
                                gamemanager.Speak(new talkform("不過這裡是常理之外的地方……", " ", " ", " "));
                                break;
                            case 41:
                                gamemanager.Speak(new talkform("嗯…..有意思。", " ", " ", " "));
                                break;
                            case 42:
                                gamemanager.Speak(new talkform("我其實還是沒有很害怕。", " ", " ", " "));
                                break;
                            case 43:
                                gamemanager.Speak(new talkform("幸好埃爾維娜小姐是暫時性昏迷，但我還是覺得有點可惜。", " ", " ", " "));
                                break;
                            case 44:
                                gamemanager.Speak(new talkform("我還來不及說上一句話呢。", " ", " ", " "));
                                break;
                            case 45:
                                gamemanager.Speak(new talkform("要是能幫上什麼忙就好了……", " ", " ", " "));
                                break;
                            case 46:
                                gamemanager.Speak(new talkform("等遭遇到襲擊的對象清醒是一個做法，可惜的是我並不喜歡坐著等待結果。", " ", " ", " "));
                                break;
                            case 47:
                                gamemanager.Speak(new talkform("我決定調查事發的地點，也就是埃爾維娜小姐的房間。", " ", " ", " "));
                                break;
                            case 48:
                                gamemanager.Speak(new talkform("然而卻發現她倒在地上失去了意識....", " ", " ", " "));
                                break;
                            case 49:
                                gamemanager.Speak(new talkform("要找出這裡究竟發生了什麼事！", " ", " ", " "));
                                break;
                            case 50:
                                gamemanager.effect("blackfadeout");
                                gamemanager.charactercontrol(1,"exit", "slideout");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;

                    case "bookshelflv2":
                         if (gamemanager.flag.Contains("pianolv2unlock"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("翻了面的樂譜櫃上掛著好幾把小刀，以及一把鐵製的大提琴。", " ", " ", " "));
                                    openzoom(3);
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("這麼多武器.......？你有看過這面的櫃子嗎？", "我", " ", " "));
                                    break;
                                case 3:
                                    
                                    gamemanager.Speak(new talkform("沒、沒有！我是第一次看到這個......", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("雖然不是沒有看過，但這麼多的刀具擺在一起還是很嚇人。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("不過旁邊這把大提琴更令人在意了，既不是古典的木製大提琴，也不是常見的電子大提琴。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("大提琴的上面好像有什麼？", "喵可", " ", " "));
                                    changzoomimage(zoomobjectlist[0],"cello2");
                                    break;
                                case 7:
                                    
                                    gamemanager.Speak(new talkform("看起來是一組密碼，讓我試試能不能把他解開。", " ", " ", " "));
                                    break;
                                case 8:
                                    puzzlelist[1].GetComponent<cellocode>().abled=true;
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("bookshelflv2"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("書櫃上放滿了樂譜，寫著簡譜規則的書被我們翻開來放在一旁。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("一個巨大的書櫃，裡頭放滿了較薄的書本。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("全部都是樂譜。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.charactercontrol(1,"enter", "popout");
                                    gamemanager.Speak(new talkform("畢竟老師很喜歡音樂嘛。", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("被叫做老師又是放滿樂譜。", "喵可", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("音樂老師？", "我", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("沒錯！聽說老師還有其他的工作，但她本人不怎麼願意講。", "喵可", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("所以詳細是什麼我也不太清楚....", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("不為人知的工作啊.......", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("不，還是別想了。", " ", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("越想越覺得不妙。", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("我隨意地拿起一本樂譜來翻看。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("啊，是數字譜呢！", "喵可", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("是簡譜。", "我", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("恕我失禮，但簡譜很沒有感覺.......", "我", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("感覺整個房間的格調都被這些數字拉低了。", " ", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("老師也說過類似的話呢，但是我真的看不懂那些黑色的豆子想表達什麼.....", "喵可", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("黑色的豆子......算了。", "我", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("的確對太多接觸樂器的人來說，簡譜比較容易吧。", " ", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("話說回來......會這樣想的我，應該是學過音樂的？", " ", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("這或許是幫助我找到記憶的一個關鍵。", " ", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.charactercontrol(1,"exit", "slideout");
                                    gamemanager.flag.Add("bookshelflv2");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                  case "cellotrigger":
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                        gamemanager.Speak(new talkform("大提琴發出了齒輪運轉的聲音，音箱的上蓋被打開了。", " ", " ", " "));
                        break;
                    case 2:
                                changzoomimage(zoomobjectlist[0], "cello3");
                        gamemanager.Speak(new talkform("打開了！", "喵可", " ", " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform("獲得了音樂盒！", " ", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("音樂盒的上面是抱在一起的家族木偶。", " ", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("我打開了音樂盒，奏響了曲子。", " ", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("聽起來不像是常見的古典樂曲。", "我", " ", " "));
                        break;
                    case 7:
                        gamemanager.Speak(new talkform(".......這首曲子老師很常彈呢，老師說是她自己做的曲子。", "喵可", " ", " "));
                        break;
                    case 8:
                        gamemanager.Speak(new talkform("是首很溫暖的曲子呢。", "我", " ", " "));
                        break;
                    case 9:
                        gamemanager.Speak(new talkform("明明是第一次聽到的曲子，卻能沒來由地讓我感到一陣鼻酸。", " ", " ", " "));
                        break;
                    case 10:
                        gamemanager.Speak(new talkform("啊。", "我", " ", " "));
                        break;
                    case 11:
                        gamemanager.Speak(new talkform("我打算把音樂盒翻過來端詳，但盒子卻瞬間在我手上解體了。", " ", " ", " "));
                                gamemanager.effect("blackfadein");
                                break;
                    case 12:
                        gamemanager.Speak(new talkform("欸？我弄壞了嗎？", " ", " ", " "));
                        break;
                    case 13:
                        gamemanager.Speak(new talkform("不，可是我什麼都沒碰啊.......", " ", " ", " "));
                        break;
                    case 14:
                        gamemanager.Speak(new talkform("嗚啊！你、你、你！", "喵可", " ", " "));
                        break;
                    case 15:
                        gamemanager.Speak(new talkform("我發誓我什麼都沒做喔。", "我", " ", " "));
                        break;
                    case 16:
                        gamemanager.Speak(new talkform(".....", "喵可", " ", " "));
                        break;
                    case 17:
                        gamemanager.Speak(new talkform("別一臉惋惜地看著我，我的心臟都愧疚起來了。", " ", " ", " "));
                        break;
                    case 18:
                        gamemanager.Speak(new talkform("有什麼東西在音樂盒解體時落到了地上。", " ", " ", " "));
                        break;
                    case 19:
                        gamemanager.Speak(new talkform("相片？", "我", " ", " "));
                        break;
                    case 20:
                        gamemanager.Speak(new talkform("啪答。", " ", " ", " "));
                        break;
                    case 21:
                        gamemanager.Speak(new talkform("在我彎下腰，撿起相片時，肩膀上突然有股濕濕黏黏的感覺。", " ", " ", " "));
                        break;
                    case 22:
                        gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                        break;
                    case 23:
                        gamemanager.Speak(new talkform("艾德先生！別動！", "喵可", " ", " "));
                        break;
                    case 24:
                        gamemanager.Speak(new talkform("濕濕黏黏的感覺跑到了頭上，我照著喵可說的不動。", " ", " ", " "));
                        break;
                    case 25:
                        gamemanager.Speak(new talkform("不如說那感覺太噁心了，我僵著根本不敢動。", " ", " ", " "));
                        break;
                    case 26:
                        gamemanager.Speak(new talkform("喝啊！！！", "喵可", " ", " "));
                        break;
                    case 27:
                        gamemanager.Speak(new talkform("呼！的一下，什麼東西的重量從我的頭上消失了。地板上隨機傳來啪嗒地一聲響。", " ", " ", " "));
                        break;
                    case 28:
                        gamemanager.Speak(new talkform("相片的觸覺也從指尖溜走了，不過我還僵著，不敢轉頭去確認。", " ", " ", " "));
                        break;
                    case 29:
                        gamemanager.Speak(new talkform("艾德先生，沒事了。", "喵可", " ", " "));
                        break;
                    case 30:
                        gamemanager.Speak(new talkform("我轉身看向聲音傳來的方向。只見喵可拿起了一旁放在刀鞘內的武士刀，呈現了揮棒完了的姿勢。", " ", " ", " "));
                        break;
                    case 31:
                        gamemanager.Speak(new talkform("她剛剛是拿那個從我的頭上揮過去嗎？", " ", " ", " "));
                        break;
                    case 32:
                        gamemanager.Speak(new talkform("咕嚕，我嚥了一口口水。", " ", " ", " "));
                        break;
                    case 33:
                        gamemanager.Speak(new talkform("要是我再高出個3公分，剛才那下大概會讓我腦震盪。", " ", " ", " "));
                        break;
                    case 34:
                        gamemanager.Speak(new talkform("啊！別跑！", "喵可", " ", " "));
                        break;
                    case 35:
                        gamemanager.Speak(new talkform("我這才往地上確認，那坨濕黏的東西跑得飛快，糊著相片鑽往通風口滑去。", " ", " ", " "));
                        break;
                    case 36:
                        gamemanager.Speak(new talkform("不過似乎因為太胖了，那坨「生物」他......", " ", " ", " "));
                        break;
                    case 37:
                        gamemanager.Speak(new talkform("完美地堵塞在通風口，也就是卡住了。", " ", " ", " "));
                        break;
                    case 38:
                        gamemanager.Speak(new talkform("好茨好茨！", "生物", " ", " "));
                        break;
                    case 39:
                        gamemanager.Speak(new talkform("貓咪......嗎？", "我", " ", " "));
                        break;
                    case 40:
                        gamemanager.Speak(new talkform("兩個尖尖的突起像是貓耳朵形狀，身體則是軟軟的一糊。", " ", " ", " "));
                        break;
                    case 41:
                        gamemanager.Speak(new talkform("身體兩側延伸出兩條細細的軀幹，末端則是圓圓的一球。", " ", " ", " "));
                        break;
                    case 42:
                        gamemanager.Speak(new talkform("那是...手？不對，這整坨糊糊的到底是什麼？", " ", " ", " "));
                        break;
                    case 43:
                        gamemanager.Speak(new talkform("等一下！給我把相片吐出來！", "喵可", " ", " "));
                        break;
                    case 44:
                        gamemanager.Speak(new talkform("好茨好ㄘ——好ㄘ…….", "生物", " ", " "));
                        break;
                    case 45:
                        gamemanager.Speak(new talkform("咚。", " ", " ", " "));
                        break;
                    case 46:
                        gamemanager.Speak(new talkform("喵可的劍鞘又一次揮了下去。", " ", " ", " "));
                        break;
                    case 47:
                        gamemanager.Speak(new talkform("異樣的生物身體整個被砸扁了，但是他完全沒有要把嘴裡的相片放開的樣子。", "", " ", " "));
                        break;
                    case 48:
                        gamemanager.charactercontrol(1, "exit", "slideout");
                        gamemanager.Speak(new talkform("這....超出常識了，難以理解。", " ", " ", " "));
                        break;
                    case 49:

                        gamemanager.Speak(new talkform("於是，遊戲就在這裡告一段落，感謝您的遊玩～", "謎之聲", " ", " "));
                        break;
                    case 50:

                        gamemanager.talk("end");
                        gamemanager.load("mian_menu");
                        break;
                    default:
                        break;
                }
                        break;
            case "violinlv2":
                        if (gamemanager.flag.Contains("violinlv2"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(1);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("曲面的提琴櫃，裡面放了五把小提琴。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("小提琴上有著不明顯的標記。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(1);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("曲面的提琴櫃，裡面放了五把小提琴。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("我拿了一把小提琴擺弄了一下。但沒有聲音。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.charactercontrol(1,"enter", "popout");
                                    gamemanager.Speak(new talkform("喔！姿勢一百分！艾德先生很有架式呢。", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("嗯......？沒有聲音？", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("我應該沒有拉錯才對。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("等等，這股自信是從哪裡冒出來的？", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("不可能，老師平常都拉得出聲音喔！", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("喵可接過小提琴試著拉了一下，還是沒有聲音。", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("看起來不是我們兩個的問題。", "我", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("嗯！不過這裡有個數字標記呢。", "喵可", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("喵可手上的提琴尾部標上了一個數字。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.charactercontrol(1, "exit", "slideout");
                                    gamemanager.Speak(new talkform("我翻了翻櫃子上的其他提琴，尾部同樣有著標記，但幾乎都快看不清楚了。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("真虧你能注意到......看起來並沒有照著順序排。", "我", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("....有一股想照順序擺好的衝動。", " ", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("不過要是反而是弄亂好像就有點不好意思了。", " ", " ", " "));
                                    break;
                                case 16:
                                    
                                    gamemanager.flag.Add("violinlv2");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "bedlv2":
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("有著絨毛被的床鋪，非常柔軟的樣子。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("如果這是我的床，我會很想躺在上面。", " ", " ", " "));
                                break;
                            case 3:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;
                    case "pianolv2":
                        if (gamemanager.flag.Contains("pianolv2unlock"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(4);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("彈奏了找到的旋律後，好像啟動了什麼機關，書櫃整個翻過來了，發出巨大的聲響。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("過去看看吧。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("pianolv2"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(4);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("鋼琴的琴鍵上標識著記號。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("這是什麼記號呢？", "喵可", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("大概是讓摸都沒摸過鋼琴的人認識「這個鍵是中央C，從這裡開始彈，別忘記了喔」的標識吧。", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("喔——原來這個是Do喔，我一直以為Do是最左邊的那個鍵欸。", "喵可", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("............不一樣的鋼琴最左邊的那個鍵都不一樣啦。", "我", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("傳統的三腳鋼琴，保養得非常好。", " ", " ", " "));
                                    openzoom(4);
                                    break;
                                case 2:
                                    gamemanager.charactercontrol(1,"enter", "popout");
                                    gamemanager.Speak(new talkform("雖然我不會彈，但只要聽到老師演奏鋼琴，心情就會非常好呢。", "喵可", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("........", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("喵可看起來心情不太好的樣子。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("也是，畢竟老師受到了襲擊。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("得趕快找找看有沒有什麼線索才行。", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.charactercontrol(1,"exit", "slideout");
                                    gamemanager.flag.Add("pianolv2");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "pianotrigger":
                switch (level)
                {
                    case 0:
                        gamemanager.talk("begin");
                        break;
                    case 1:
                        gamemanager.Speak(new talkform("按照提琴上的音階彈奏後，鋼琴發出了輕脆的旋律後，身後傳來了巨大的撞擊聲。", " ", " ", " "));
                        break;
                    case 2:
                        gamemanager.charactercontrol(1, "enter", "popout");
                        gamemanager.Speak(new talkform("艾德快看！櫃子翻過來了。", "喵可", " ", " "));
                        break;
                    case 3:
                        gamemanager.Speak(new talkform("我轉身往後看，在原先書桌旁邊，書櫃的位置變成了一面黑色的...櫃子？裡面掛著各式不像是樂器的東西...", " ", " ", " "));
                        break;
                            case 4:
                                gamemanager.Speak(new talkform("趕快過去確認看看吧。", " ", " ", " "));
                                break;
                            case 5:
                        gamemanager.charactercontrol(1, "exit", "slideout");
                        gamemanager.flag.Add("pianolv2unlock");
                        gamemanager.talk("end");
                        break;
                    default:
                        break;
                }
                        break;
                    case "bedsidetablelv2":
                        if (gamemanager.flag.Contains("bedsidetablelv2"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(2);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("精細的床頭櫃，每一層抽屜都有著漂亮的花紋。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("好想打開來看看，但仍然是鎖住的狀態，而且也看不到鎖孔之類的地方。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("....", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("感受到了來自喵可的灼熱視線。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    openzoom(2);
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("可愛的四層櫃子，但放在這間房間裡並不突兀。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("雖然不該翻開來看，但一想到裡面會不會有線索就好好奇啊......", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("艾德先生，我覺得不要亂翻淑女的私人物品比較好喔。", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("為了找到真相，我認為不該放過任何可能的線索。", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("我伸手拉櫃子的抽屜，結果櫃子是卡住的，拉不開。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("啊，居然鎖住了，那就沒辦法了。", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("盯——————", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.flag.Add("bedsidetablelv2");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                
                    case "sofalv2":
                        if (gamemanager.flag.Contains("sofalv2"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("柔軟的家具，坐在上面感覺自己的骨頭也變軟了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("惡魔的陷阱。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("柔軟的家具，坐在上面感覺自己的骨頭也變軟了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("身體慢慢地往下沉......再這樣下去的話...會被吞噬的！", " ", " ", " "));
                                    break;

                                case 3:
                                    gamemanager.charactercontrol(1,"enter", "popout");
                                    gamemanager.Speak(new talkform("艾德先生！快振作起來，不然....", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("不要！別管我了，你也會遭殃的！", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("剩下的....就交給你了....", "我", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("艾德先生，艾德先生！不～～～", "喵可", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.charactercontrol(1,"exit", "slideout");
                                    gamemanager.flag.Add("sofalv2");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                }
                        break;
            case "stage_three":
                switch (name)
                {
                    case "story":
                        switch (level)
                        {
                            case 0:
                                gamemanager.black.state = "on";
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak(new talkform("找到音樂盒後的我們，卻發現音樂盒缺少了應該有的零件。", " "," "," "));
break;
                            case 2:
                                gamemanager.Speak(new talkform("但羅瑟帶來了好消息，埃爾維娜醒了。", " "," "," "));
break;
                            case 3:
                                gamemanager.Speak(new talkform("回到大廳之後，喵可也提到了剛才讓我深感噁心的黏軟生物。", " "," "," "));
break;
                            case 4:
                                gamemanager.Speak(new talkform("我們大膽的推論牠就是襲擊埃爾維娜的生物，埃爾維娜也證實了我們的推論。", " "," "," "));
break;
                            case 5:
                                gamemanager.Speak(new talkform("但這個生物卻是喵可等人從來沒有見過的。", " "," "," "));
break;
                            case 6:
                                gamemanager.Speak(new talkform("不過在喵可……驚人的打擊之下，我想那個生物已經不會再出現了。", " "," "," "));
break;
                            case 7:
                                gamemanager.Speak(new talkform("我突然想起在大提琴裡找到的音樂盒，把音樂盒交給了埃爾維娜。", " "," "," "));
break;
                            case 8:
                                gamemanager.Speak(new talkform("她看起來非常驚訝，我們才知道她今天早上正好要找音樂盒。", " "," "," "));
break;
                            case 9:
                                gamemanager.Speak(new talkform("埃爾維娜告訴我們，她一早醒來就發現房間裡的物品被移動過。", " "," "," "));
break;
                            case 10:
                                gamemanager.Speak(new talkform("說不定是那個生物做的，她提出的論點我覺得不失為一種可能。", " "," "," "));
break;
                            case 11:
                                gamemanager.Speak(new talkform("……雖然一想到找到音樂盒的過程…..如果也是那個生物把音樂盒放到那種地方….. ", " "," "," "));
break;
                            case 12:
                                gamemanager.Speak(new talkform("不，不可能的吧？也太沒有意義了？", " "," "," "));
break;
                            case 13:
                                gamemanager.Speak(new talkform("我和喵可跟著埃爾維娜回到了她的房間，解釋了在這裡發現的一切。", " "," "," "));
break;
                            case 14:
                                gamemanager.Speak(new talkform("當然，過深的去探究一名女性的閨房這種事情，我是沒有做的。", " "," "," "));
break;
                            case 15:
                                gamemanager.Speak(new talkform("真的沒有，我可是紳士。", " "," "," "));
break;
                            case 16:
                                gamemanager.Speak(new talkform("喵可補充到音樂盒缺少了零件，她和我都很樂意協助埃爾維娜尋找那些零件。", " "," "," "));
break;
                            case 17:
                                gamemanager.Speak(new talkform("埃爾維娜很快地就答應了，反而讓我有點不好意思起來。", " "," "," "));
break;
                            case 18:
                                gamemanager.Speak(new talkform("雖然現在有些晚了，但我一個大男人在這裡真的沒問題嗎？", " "," "," "));
break;
                            case 19:
                                gamemanager.Speak(new talkform("…..不管怎麼說還是專心找吧。", " "," "," "));
break;
                            case 20:
                                gamemanager.Speak(new talkform(" "," "," "," "));
break;
                            case 21:
                                gamemanager.Speak(new talkform("經過一番翻找與聊天之後，我和埃爾維娜也逐漸的認識彼此。", " "," "," "));
break;
                            case 22:
                                gamemanager.Speak(new talkform("但沒想到在我說出自己並不記得自己的記憶時，她也告訴我，受到襲擊後她好像也失去了一部分的記憶。", " "," "," "));
break;
                            case 23:
                                gamemanager.Speak(new talkform("我有點擔心，畢竟失憶的現象一直以來不適都前所未聞嗎？", " "," "," "));
break;
                            case 24:
                                gamemanager.Speak(new talkform("如果真的是因為那奇妙生物的襲擊，讓埃爾維娜失去記憶，身為一個因失憶而痛苦的人——也開始想給那個生物多補幾腳了。", " "," "," "));
break;
                            case 25:
                                gamemanager.Speak(new talkform("我想我的情緒可能寫在臉上太多，埃爾維娜反而安慰起我，別為了記憶而太著急。", " "," "," "));
break;
                            case 26:
                                gamemanager.Speak(new talkform("這就是熟齡人沉穩的魅力嗎？突然感到了安心。", " "," "," "));
break;
                            case 27:
                                gamemanager.Speak(new talkform("我相信我總有一天會知道自己的身分。", " "," "," "));
break;
                            case 28:
                                gamemanager.Speak(new talkform("不久過後，我們在房間各處找回了零件，就連埃爾維娜都想不清為什麼這些零件會在那些地方。", " "," "," "));
break;
                            case 29:
                                gamemanager.Speak(new talkform("在埃爾維娜演奏音樂盒後，我卻突然一陣暈眩。", " "," "," "));
break;
                            case 30:
                                gamemanager.Speak(new talkform("腦與視神經都像是炸開來的暈，但不會痛。", " "," "," "));
break;
                            case 31:
                                gamemanager.Speak(new talkform("我感覺閉上眼之後還是在眼前看到一些「畫面」。", " "," "," "));
break;
                            case 32:
                                gamemanager.Speak(new talkform("這會不會就是所謂的人生跑馬燈？", " "," "," "));
break;
                            case 33:
                                gamemanager.Speak(new talkform("我看見一間空曠的房間，裏頭有懸掛小提琴的牆櫃、也有放著鋼琴的小高台。", " "," "," "));
break;
                            case 34:
                                gamemanager.Speak(new talkform("就像埃爾維娜的房間，而埃爾維娜也出現在畫面裡。", " "," "," "));
break;
                            case 35:
                                gamemanager.Speak(new talkform("我感覺我像是自己看著她，但她的衣著並不是我所知道的。", " "," "," "));
break;
                            case 36:
                                gamemanager.Speak(new talkform("這到底是…..？", " "," "," "));
break;
                            case 37:
                                gamemanager.Speak(new talkform("她開始教導我音樂，直到埃爾維娜對著「我」說。", " "," "," "));
break;
                            case 38:
                                gamemanager.Speak(new talkform("今天的課程已經結束了。", "埃爾維娜"," "," "));
break;
                            case 39:
                                gamemanager.Speak(new talkform("「我」感覺到失落，但「我」卻非常清楚自己失落的原因是因為我不想見到父母不在的家。", " "," "," "));
break;
                            case 40:
                                gamemanager.Speak(new talkform("難道說，這會是我的記憶嗎？", " "," "," "));
break;
                            case 41:
                                gamemanager.Speak(new talkform("……", " "," "," "));
break;
                            case 42:
                                gamemanager.Speak(new talkform("但除了失落的原因之外我什麼都不知道。", " "," "," "));
break;
                            case 43:
                                gamemanager.Speak(new talkform("我不知道埃爾維娜對於「我」來說是什麼人。", " "," "," "));
break;
                            case 44:
                                gamemanager.Speak(new talkform("我不知道我為什麼會在這裡。", " "," "," "));
break;
                            case 45:
                                gamemanager.Speak(new talkform("我就像是一個看著故事的人——", " "," "," "));
break;
                            case 46:
                                gamemanager.Speak(new talkform("你想不想學大提琴呢？即使只有9歲，我認為你在這方面也是有天分的。", "埃爾維娜"," "," "));
break;
                            case 47:
                                gamemanager.Speak(new talkform("不，我的心情隨著改變，所以與其說像是看著故事的人", " "," "," "));
break;
                            case 48:
                                gamemanager.Speak(new talkform("不如說我像是經歷了「我」，經歷了「某個人」的故事。", " "," "," "));
break;
                            case 49:
                                gamemanager.Speak(new talkform("我看著他們從練習大提琴到開始聊起埃爾維娜的經歷。", " "," "," "));
break;
                            case 50:
                                gamemanager.Speak(new talkform("埃爾維娜對「他」抱有同情與關愛，因為埃爾維娜失去了家人。", " "," "," "));
break;
                            case 51:
                                gamemanager.Speak(new talkform("她的丈夫，和他的兒子。", " "," "," "));
break;
                            case 52:
                                gamemanager.Speak(new talkform("開一間兒童音樂教室，讓埃爾維娜有心靈上的慰藉。", " "," "," "));
break;
                            case 53:
                                gamemanager.Speak(new talkform("埃爾維娜曾經因為工作在身，而疏忽了她的親人。", " "," "," "));
break;
                            case 54:
                                gamemanager.Speak(new talkform("埃爾維娜告訴「他」，看著因為父母忙碌而孤獨著的「他」，會讓埃爾維娜想起自己的兒子。", " "," "," "));
break;
                            case 55:
                                gamemanager.Speak(new talkform("所以，能被他這樣的孩子信賴，作為一個老師很榮幸也很高興。埃爾維娜"," "," "," "));
break;
                            case 56:
                                gamemanager.Speak(new talkform("好近？", " "," "," "));
break;
                            case 57:
                                gamemanager.Speak(new talkform("我才發現我從眼前的畫面回到了埃爾維娜的房間。", " "," "," "));
break;
                            case 58:
                                gamemanager.Speak(new talkform("剛才的一切就像是夢一樣。", " "," "," "));
break;
                            case 59:
                                gamemanager.Speak(new talkform("但是那個感覺真實的讓我起了一身的雞皮疙瘩。", " "," "," "));
break;
                            case 60:
                                gamemanager.Speak(new talkform("……剛剛那是？", "我 "," "," "));
break;
                            case 61:
                                gamemanager.Speak(new talkform("…....我不知道發生這個情況的原因，但艾德里安你看到了我和那孩子的過去吧？", "埃爾維娜 "," "," "));
break;
                            case 62:
                                gamemanager.Speak(new talkform("之後，埃爾維娜告訴我，那是屬於她和「主人」的記憶。", " "," "," "));
break;
                            case 63:
                                gamemanager.Speak(new talkform("除此之外，這個片段也是她失去的記憶。", " "," "," "));
break;
                            case 64:
                                gamemanager.Speak(new talkform("看著一旁非常疑惑的喵可，似乎只有我和埃爾維娜看到了那些片段。", " "," "," "));
break;
                            case 65:
                                gamemanager.Speak(new talkform("……雖然是被迫的。", " "," "," "));
break;
                            case 66:
                                gamemanager.Speak(new talkform("啊、啊啊。", " "," "," "));
break;
                            case 67:
                                gamemanager.Speak(new talkform("我是個罪人。", " "," "," "));
break;
                            case 68:
                                gamemanager.Speak(new talkform("偷看別人過去隱私的罪人。", " "," "," "));
break;
                            case 69:
                                gamemanager.Speak(new talkform("我、我的紳士形象……", " "," "," "));
break;
                            case 70:
                                gamemanager.Speak(new talkform("咳咳，總之，很高興埃爾維娜的記憶回來了。", " "," "," "));
break;
                            case 71:
                                gamemanager.Speak(new talkform("這也使我對能夠找回記憶多了一點信心。", " "," "," "));
break;
                            case 72:
                                gamemanager.Speak(new talkform("看著埃爾維娜手上被修好的音樂盒，我想起進入那段回憶以前正好修好了音樂盒這件事。", " "," "," "));
break;
                            case 73:
                                gamemanager.Speak(new talkform("…..誰知道呢，修好音樂盒看起來像是關鍵。", " "," "," "));
break;
                            case 74:
                                gamemanager.Speak(new talkform("但也只是看起來罷了。", " "," "," "));
break;
                            case 75:
                                gamemanager.Speak(new talkform("我只希望之後不會再有這樣的情況。", " "," "," "));
break;
                            case 76:
                                gamemanager.Speak(new talkform("我不想當個專業偷窺狂啊……", " "," "," "));
break;
                            case 77:
                                gamemanager.Speak(new talkform("......"," "," "," "));
break;
                            case 78:
                                gamemanager.Speak(new talkform("多災多難的第一天就這樣結束了。", " "," "," "));
break;
                            case 79:
                                gamemanager.Speak(new talkform("當我以為我真的能平安順利的開始我的心向館之找尋回憶大作戰之旅時，那個謎樣的生物卻再次出現了。", " "," "," "));
break;
                            case 80:
                                gamemanager.Speak(new talkform("事情發生在幾天內，我們偶爾就會在心向館的各個地方看見牠。", " "," "," "));
break;
                            case 81:
                                gamemanager.Speak(new talkform("擔心的襲擊事件雖然沒有再發生，但那些生物卻會把心向館弄得亂七八糟。", " "," "," "));
break;
                            case 82:
                                gamemanager.Speak(new talkform("代表記憶的書被亂仍，甚至被牠們啃食。", " "," "," "));
break;
                            case 83:
                                gamemanager.Speak(new talkform("我們也因此開始叫那個生物——「書蟲」。", " "," "," "));
break;
                            case 84:
                                gamemanager.Speak(new talkform("照著喵可的方式，每個人每看到書蟲一次，就打一次書蟲。", " "," "," "));
break;
                            case 85:
                                gamemanager.Speak(new talkform("畢竟書蟲也不是那麼常出現。", " "," "," "));
break;
                            case 86:
                                gamemanager.Speak(new talkform("有時甚至一整天都不會看到牠的出現。", " "," "," "));
break;
                            case 87:
                                gamemanager.Speak(new talkform("雖然少量的書蟲只要打死就好，但我很好奇。", " "," "," "));
break;
                            case 88:
                                gamemanager.Speak(new talkform("這些從來沒有出現過的書蟲到底是從哪裡來的呢？", " "," "," "));
break;
                            case 89:
                                gamemanager.Speak(new talkform("在不合邏輯的世界裡，什麼都可能發生。", " "," "," "));
break;
                            case 90:
                                gamemanager.Speak(new talkform("但，真的沒有原因嗎？", " "," "," "));
break;
                            case 91:
                                gamemanager.Speak(new talkform("聽到我的說法，喵可也認同了我的觀點。", " "," "," "));
break;
                            case 92:
                                gamemanager.Speak(new talkform("凡事都要嘗試看看——她是這麼說的。", " "," "," "));
break;
                            case 93:
                                gamemanager.Speak(new talkform("於是好幾天，在我認識心向館的期間，我們也尋找了書蟲的足跡。", " "," "," "));
break;
                            case 94:
                                gamemanager.Speak(new talkform("這件事成為我們兩人的日常，但就在某天，這個日常遇到了突然的災難。", " "," "," "));
break;
                            case 95:
                                gamemanager.Speak(new talkform("我們沒有人同時看過這麼大量的書蟲。", " "," "," "));
break;
                            case 96:
                                gamemanager.Speak(new talkform("要形容那個畫面的話，大概就是會行走的布丁乘以N。", " "," "," "));
break;
                            case 97:
                                gamemanager.Speak(new talkform("就在大家都剛清醒甚至還沒睡醒的時刻，書蟲們跑進了大家的房間。", " "," "," "));
break;
                            case 98:
                                gamemanager.Speak(new talkform("特別是酒保先生——柯斯莫的房間跑進了最多的書蟲。", " "," "," "));
break;
                            case 99:
                                gamemanager.Speak(new talkform("書蟲將他的房間弄得亂七八糟，經過的人都能看的出來災情慘重。", " "," "," "));
break;
                            case 100:
                                gamemanager.Speak(new talkform("柯斯莫可能不需要我的同情，但看到這個狀況還是讓我想要出手相助。", " "," "," "));
break;
                            case 101:
                                gamemanager.Speak(new talkform("早餐過後，我和喵可就來到了他的房間想要幫忙。", " "," "," "));
break;
                            case 102:
                                gamemanager.Speak(new talkform("但柯斯莫不愧是柯斯莫。", " "," "," "));
break;
                            case 103:
                                gamemanager.Speak(new talkform("每個堅強的職場女強人肯定都需要一個這麼會收拾的家政夫。", " "," "," "));
break;
                            case 104:
                                gamemanager.Speak(new talkform("或者…..每個堅強的職場男性也需要？", " "," "," "));
break;
                            case 105:
                                gamemanager.Speak(new talkform("柯斯莫已經將房間打理得差不多，但他好像正因為找不到東西而困擾著……", "  ", " ", " "));
                                break;
                            case 106:
                                gamemanager.effect("blackfadeout");
                                gamemanager.charactercontrol(1,"exit", "slideout");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                        break;

                    case "fish":
                        if (gamemanager.flag.Contains("case")&& gamemanager.flag.Contains("keylv3"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("迷你的鑰匙與小巧的鎖對上，喀的一聲打開了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("太好了！是這把鑰匙沒錯。", "喵可", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("那麼，裡面究竟裝著什麼呢？", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("…..！", "柯斯莫", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("柯斯莫從公事包裡摸出一個方柱狀的東西。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("唔…….這個是什麼？", "喵可", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("我……我也沒有頭緒。", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("是獎盃的底座，這裡刻了我的名字，柯斯莫．西蘭托。", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("原來酒保先生姓西蘭托啊……", "我", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("回想一下自己的姓氏，果然也是一片空白。", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("我從房間醒來時，就只記得自己的名字。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("還真是有點氣餒啊，直到現在，還是沒有想起關於自己的事情。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("不過在這裡只要知道彼此的名字就夠了！畢竟我們都是直稱名字啊！", "喵可", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("分辨的出來就夠了。", "柯斯莫", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("雖然不知道柯斯莫先生如何，但喵可大概是真的在安慰我吧。", " ", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("我沒想起來的事情還堆積如山的多，但還有時間。", " ", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("我還有很漫長的時間可以在這裡找尋自己。", " ", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("並且，不是孤單一個人。", " ", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("也是。回歸正題，這個底座有讓柯斯莫先生想起什麼嗎？", "我", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("是我在和心向館的主人分享這場比賽的事，不過前因後果，更詳細的就想不起來了。", "柯斯莫", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("但要想起來大概不難，畢竟有獎盃的底座，就一定有獎盃的上半部分。", "柯斯莫", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.Speak(new talkform("上面有一個可以插入東西的凹槽呢！", "喵可", " ", " "));
                                    break;
                                case 23:
                                    gamemanager.Speak(new talkform("只要找到上半部分，把他鑲進獎盃的底座，或許就能讓酒保想起失去的部分記憶。", " ", " ", " "));
                                    break;
                                case 24:
                                    gamemanager.Speak(new talkform("就差一步了。", " ", " ", " "));
                                    break;
                                case 25:
                                    gamemanager.Speak(new talkform("將「獎盃底座」放入了背包。", " ", " ", " "));
                                    break;
                                case 26:
                                    gamemanager.flag.Add("base");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("case"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("從水族箱裡撈出了溼答答的公事包，上頭有個小巧的鐵鎖。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("找找看解鎖的鑰匙吧。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("fish")&& gamemanager.flag.Contains("string") && gamemanager.flag.Contains("hook"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("柯斯莫拉了一張吧檯的高腳椅讓我踩著上去。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("我把綁著鉤子的線丟入水族箱，沒有因為太輕而浮起來真是太好了。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("好，勾起來看看。", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("喔喔！看起來很有機會！", "喵可", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("鉤子順著重力慢慢的沉到底部，我調整它的角度，勾住公事包上頭的提把。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("吸飽水的公事包有些重，這不太妙，我擔心釣魚線會從鉤子上脫落。", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("要是公事包裡面裝的東西太重，或許真的要潛下去拿了。", " ", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("還好實際拉上來的過程並沒有大礙，我很快就抓到了濕漉漉的公事包。", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("嗯？比想像中的輕。", "我", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("避免大量的水淋到地上，我簡單的擰了擰公事包。", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("公事包扁扁的，摸起來像是沒裝任何東西。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("只有接近底部的地方，能夠摸到方型的柱狀物。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("酒保先生在裡面裝了什麼呢？", "喵可", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("…..我不記得。", "柯斯莫", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("是因為很久沒打開過的關係嗎？", "喵可", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("不。", "柯斯莫", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("我從椅子上爬下來，把公事包交給柯斯莫先生。", " ", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("我大概知道他想說什麼，畢竟我實際目睹過書蟲橫掃過這間房間的瞬間。", " ", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("估計是書蟲搗亂的關係，這間房間的記憶被打亂了。", "柯斯莫", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("所以連帶影響到我的記憶，就像伊芙琳的音樂盒被弄壞了一樣。", "柯斯莫", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("大概我的房間裡也有什麼與記憶有關的東西壞掉了吧。", "柯斯莫", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.Speak(new talkform("想起今天與柯斯莫先生見面時，滿房間的書蟲。", " ", " ", " "));
                                    break;
                                case 23:
                                    gamemanager.Speak(new talkform("希望書蟲只是弄壞而不是帶走房間的物品。", " ", " ", " "));
                                    break;
                                case 24:
                                    gamemanager.Speak(new talkform("沒事的！只要一邊找一邊收拾，總會知道的！我們也才整理到一半啊。", "喵可", " ", " "));
                                    break;
                                case 25:
                                    gamemanager.Speak(new talkform("的確，要是現在就這麼悲觀的話，也無法解決事情。", " ", " ", " "));
                                    break;
                                case 26:
                                    gamemanager.Speak(new talkform("不如先做盡嘗試再說。", " ", " ", " "));
                                    break;
                                case 27:
                                    gamemanager.Speak(new talkform("況且我們連公事包都還沒打開。", " ", " ", " "));
                                    break;
                                case 28:
                                    gamemanager.Speak(new talkform("總之，打開來看看就會知道是什麼了。", "我", " ", " "));
                                    break;
                                case 29:
                                    gamemanager.Speak(new talkform("這個嘛，他鎖住了。", "柯斯莫", " ", " "));
                                    break;
                                case 30:
                                    gamemanager.Speak(new talkform("咦？", " ", " ", " "));
                                    break;
                                case 31:
                                    gamemanager.Speak(new talkform("溼答答的公事包上有個鐵鎖，緊緊的將他扣緊。", " ", " ", " "));
                                    break;
                                case 32:
                                    gamemanager.Speak(new talkform("酒保先生，你知道鑰匙……", "喵可", " ", " "));
                                    break;
                                case 33:
                                    gamemanager.Speak(new talkform("被我藏在某個地方……但在哪裡屬於不記得的範疇。", "柯斯莫", " ", " "));
                                    break;
                                case 34:
                                    gamemanager.Speak(new talkform("果然是這個樣子啊…….", "喵可", " ", " "));
                                    break;
                                case 35:
                                    gamemanager.Speak(new talkform("(吸氣", "喵可", " ", " "));
                                    break;
                                case 36:
                                    gamemanager.Speak(new talkform("(吐氣", "喵可", " ", " "));
                                    break;
                                case 37:
                                    gamemanager.Speak(new talkform("好！來找鑰匙吧！", "喵可", " ", " "));
                                    break;
                                case 38:
                                    gamemanager.Speak(new talkform("一想到柯斯莫先生和我一樣失去了一些記憶，心情就跟著有點低落了起來。", " ", " ", " "));
                                    break;
                                case 39:
                                    gamemanager.Speak(new talkform("這時候有喵可在真是太好了。", " ", " ", " "));
                                    break;
                                case 40:
                                    gamemanager.Speak(new talkform("有她在的時候，總是會讓我感覺事情會好起來。", " ", " ", " "));
                                    break;
                                case 41:
                                    gamemanager.Speak(new talkform("嗯，找找吧。既然被好好藏起來了，就不會不見。", "我", " ", " "));
                                    break;
                                case 42:
                                    gamemanager.Speak(new talkform("只要找出來就行了。", "我", " ", " "));
                                    break;
                                case 43:
                                    gamemanager.Speak(new talkform("……", "柯斯莫", " ", " "));
                                    break;
                                case 44:
                                    gamemanager.Speak(new talkform("唉……我知道了，我也會嘗試回想。", "柯斯莫", " ", " "));
                                    break;
                                case 45:
                                    gamemanager.Speak(new talkform("太好了，柯斯莫先生看起來放鬆了一點。", " ", " ", " "));
                                    break;
                                case 46:
                                    gamemanager.Speak(new talkform("把手頭上的東西整理好，找找看鑰匙吧", " ", " ", " "));
                                    break;
                                case 47:
                                    gamemanager.Speak(new talkform("說起來，那幾本撿到的書，也要找地方放好才行呢。", "我", " ", " "));
                                    break;
                    
                                case 48:
                                    gamemanager.flag.Add("case");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("string"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("不曉得找不找的到鉤子。", "柯斯莫", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("柯斯莫先生想的到有什麼類似的東西嗎？", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("想到的話就告訴你了。", "柯斯莫", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("說的也是，再找找看吧。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("總之，找到什麼就拿去用吧，我不是很在意。", "柯斯莫", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("hook"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("這個窗簾鉤應該是取代鉤子的好東西。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("要找到一條線綁住它才行。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("fish"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("巨大的水族箱，魚兒在裏頭隨意游動，看的我也不禁放鬆了起來。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("但現在還是快點幫柯斯莫先生恢復房間吧，得快點找到遺失的物品，確定有沒有被書蟲弄壞了才行。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("在找到可以釣起公事包的東西以前，似乎沒有回來的必要。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("一個比我還高的大型水族箱，正發出螢藍的光。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("從進門後我就很在意這裏。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("這麼大的水族箱放在房間裡也太不可思議了……", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("簡直像是在水族館裡一樣。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("哇哇！好大喔！", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("這個是藍帶神仙魚、小丑魚、親嘴魚！", "喵可", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("喔？喵可認得出這麼多啊。", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("欸嘿嘿…小動物的話我都很擅長分辨種類的喔！", "喵可", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("那邊那個橫紋的是六線狐，那邊游過來的是紅尾蝶，還有還有！直條紋的是三間雀，紅白色像花瓣的那幾隻是玩具虎，下面還有獅子魚……", "喵可", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("……這孩子是魚類圖鑑嗎？", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("除了小丑魚和神仙魚，我還真沒有看到半隻認識的魚類。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("不，要一般人知道也太難了。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("話說回來這些魚通通放在一起養是沒問題的嗎！？", " ", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("他們被照料的很好呢！呣呣！我也好想在房間裡養寵物！", "喵可", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("大概沒辦法？來到這裡，我們的房間就已經是長這樣。", "柯斯莫", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("回想那間到現在都還讓我有著陌生的熟悉感的房間，還是覺得很不可思議。", " ", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("但起初我也沒有想認真飼養。", "柯斯莫", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("不過想到裡面數不清的傢伙都是備用糧食，就突然覺得可以認真養一下了。", "柯斯莫", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("你要吃牠們嗎……？", "喵可", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("我有把握可以做的很美味，給各位當早餐。", "柯斯莫", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("不，請你不要，拜託不要。", "我", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.Speak(new talkform("不懂魚類如我，但彩度這麼高的一群魚吃下肚一定會出事。", " ", " ", " "));
                                    break;
                                case 23:
                                    gamemanager.Speak(new talkform("處理掉有毒的部分還是能吃的。", "柯斯莫", " ", " "));
                                    break;
                                case 24:
                                    gamemanager.Speak(new talkform("咦——", "我", " ", " "));
                                    break;
                                case 25:
                                    gamemanager.Speak(new talkform("等等，他是認真的嗎？", " ", " ", " "));
                                    break;
                                case 26:
                                    gamemanager.Speak(new talkform("但是肉都偏少呢，嘖。", "柯斯莫", " ", " "));
                                    break;
                                case 27:
                                    gamemanager.Speak(new talkform("還請你放過這些備用糧食。", " ", " ", " "));
                                    break;
                                case 28:
                                    gamemanager.Speak(new talkform("說起來，下面那些是什麼？", " ", " ", " "));
                                    break;
                                case 29:
                                    gamemanager.Speak(new talkform("我有把握可以做的很美味，給各位當早餐。", "柯斯莫", " ", " "));
                                    break;
                                case 30:
                                    gamemanager.Speak(new talkform("搖來晃去，細的像原子筆的生物一隻一隻的插在水族箱的底部。", " ", " ", " "));
                                    break;
                                case 31:
                                    gamemanager.Speak(new talkform("這麼奇葩的外型，卻隱約讓我覺得有點可愛。", " ", " ", " "));
                                    break;
                                case 32:
                                    gamemanager.Speak(new talkform("那些是花園鰻喔！是一種盯著會讓人想睡覺的鰻類。", "喵可", " ", " "));
                                    break;
                                case 33:
                                    gamemanager.Speak(new talkform("啊，我可以理解。有種身心都放鬆的感覺。", "我", " ", " "));
                                    break;
                                case 34:
                                    gamemanager.Speak(new talkform("旁邊也有海星跟……嗯？", "喵可", " ", " "));
                                    break;
                                case 35:
                                    gamemanager.Speak(new talkform("她輕輕拉了我一下，我跟她一起看向了某個方向。", " ", " ", " "));
                                    break;
                                case 36:
                                    gamemanager.Speak(new talkform("那是造景……不，那好像是……", "我", " ", " "));
                                    break;
                                case 37:
                                    gamemanager.Speak(new talkform("我換了一個角度重新觀察。", " ", " ", " "));
                                    break;
                                case 38:
                                    gamemanager.Speak(new talkform("雖然造型跟擺在我房間裡的那一個不太一樣，但在水族箱角落的確實是個「公事包」。", " ", " ", " "));
                                    break;
                                case 39:
                                    gamemanager.Speak(new talkform("公事包在這種地方突兀的讓我很難不去在意他，究竟為什麼這種格格不入的東西會放在房間裡呢？", " ", " ", " "));
                                    break;
                                case 40:
                                    gamemanager.Speak(new talkform("是公事包！不過怎麼會在裡面？", "喵可", " ", " "));
                                    break;
                                case 41:
                                    gamemanager.Speak(new talkform("書蟲丟進去的？", "柯斯莫", " ", " "));
                                    break;
                                case 42:
                                    gamemanager.Speak(new talkform("我感受到柯斯莫先生語氣裡的困惑，看來不是他刻意放在水族箱裡的了。", " ", " ", " "));
                                    break;
                                case 43:
                                    gamemanager.Speak(new talkform("如果真的是他做的我也不會訝異就是了。", " ", " ", " "));
                                    break;
                                case 44:
                                    gamemanager.Speak(new talkform("先拿起來吧？", "我", " ", " "));
                                    break;
                                case 45:
                                    gamemanager.Speak(new talkform("墊著酒吧的椅子可以進去拿，不過你想要全身溼透？", "柯斯莫", " ", " "));
                                    break;
                                case 46:
                                    gamemanager.Speak(new talkform("可以的話請饒了我。", "我", " ", " "));
                                    break;
                                case 47:
                                    gamemanager.Speak(new talkform("雖然是換件衣服就可以解決的事情，但當然是可以不要就不要。", " ", " ", " "));
                                    break;
                                case 48:
                                    gamemanager.Speak(new talkform("如果用釣起來的呢？酒保先生有沒有釣竿？", "喵可", " ", " "));
                                    break;
                                case 49:
                                    gamemanager.Speak(new talkform("非常抱歉，但我沒有。", "柯斯莫", " ", " "));
                                    break;
                                case 50:
                                    gamemanager.Speak(new talkform("用釣的是一個很好的主意，我回憶過伊芙琳小姐的房間，也並沒有見過釣魚桿的印象。", " ", " ", " "));
                                    break;
                                case 51:
                                    gamemanager.Speak(new talkform("雖然麻煩了一點，看來我們得想點別的辦法。", " ", " ", " "));
                                    break;
                                case 52:
                                    gamemanager.Speak(new talkform("或許，我們可以做個類似的東西。", "我", " ", " "));
                                    break;
                                case 53:
                                    gamemanager.Speak(new talkform("只要能夠把東西鉤起來就行，比方說用線綁著鉤子……", "我", " ", " "));
                                    break;
                                case 54:
                                    gamemanager.Speak(new talkform("鉤子不確定，但我記得某處的櫃子裡有線。", "柯斯莫", " ", " "));
                                    break;
                                case 55:
                                    gamemanager.Speak(new talkform("希望不要被書蟲亂拿就好，不然就要認真考慮下水了。", "柯斯莫", " ", " "));
                                    break;
                                case 56:
                                    gamemanager.Speak(new talkform("這麼說著的柯斯莫先生，卻銳利的盯著我看。", " ", " ", " "));
                                    break;
                                case 57:
                                    gamemanager.Speak(new talkform("他看起來真的很想推我下水，各種層面上的。", " ", " ", " "));
                                    break;
                                case 58:
                                    gamemanager.Speak(new talkform("為了阻止自己成為犧牲者，我想我最好找到線與可以用來作為鉤子的東西。", " ", " ", " "));
                                    break;
                                case 59:
                                    gamemanager.flag.Add("fish");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "bed":
                        if (gamemanager.flag.Contains("book_wolf"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("簡約的被單整齊的折放在上頭。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("剛剛在上面找到了一本書。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("床單上放著一本書。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("「森林守護者：狼」。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("看起來是一本講述狼在食物鏈中扮演的角色的書。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("真是好書名。", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("很多人總是會認為狼會攻擊人和其它動物，而把牠視為掠奪者。這其實是個天大的誤會呢。", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("真虧喵可你能知道，很多人都害怕狼所以沒有深入理解過呢。", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("狼很帥啊！我很喜歡喔。", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("狼是種優雅的動物，我也很喜歡。", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("那本順便拿下來吧，一起放回書櫃。", "柯斯莫", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("將「森林守護者：狼」放入了背包。", " ", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.flag.Add("book_wolf");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "bookshelfbed":
                        if (gamemanager.flag.Contains("string"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("下層放滿書櫃的雙層床，雖然很特別，但放在酒吧感覺的房間內一點都不突兀。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("好特別的雙層床，下層竟然全部都是書櫃。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("一般來說會是另一個床或是書桌之類的吧？", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("在書之間找到了一捆釣魚線。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("放在這裡啊。", "柯斯莫", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("要用到的話就拿走吧。", "柯斯莫", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("將「釣魚線」放入了背包。", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.flag.Add("string");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "bar":
                        if (gamemanager.flag.Contains("bar"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("簡約時尚的酒吧吧檯，已經被柯斯莫先生整理過了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("一個非常大的酒吧吧檯，連後面的酒櫃都能看的一清二楚。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("我終於理解為什麼喵可要叫柯斯莫先生「酒保先生」了。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("呵，關於酒的問題儘管來問我。", "柯斯莫", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("或者要來杯特製的雞尾酒、One Shot，我都能馬上現做。", "柯斯莫", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("沒有，我是第一次來酒保先生的房間。會這麼叫他只是因為一提到酒，他就會變這樣而已。", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("看的出來，從冰山變成沸騰的岩漿大概就是這種感覺。", " ", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("所以艾德放輕鬆一點和酒保先生相處沒關係的，他的臉皮很厚。", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("不厚臉皮一點，無法成為一個優秀的調酒師。", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("對吧？", "喵可", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("這樣子直接說出來沒有問題嗎？", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("不，應該說優秀的調酒師不需要具備厚臉皮的能力吧。", " ", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("我腦袋中關於柯斯莫先生的世界觀刷新了一次。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("所以，艾德里安，要來一杯酒嗎？", "柯斯莫", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("這還真是，同時具備了壓迫、慫恿與期待的、熱切的目光。", " ", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("這、這個嘛……抱歉，我不清楚我是不是已經成年了，所以就讓我婉拒吧。", "我", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("呼呣，真可惜。整理完房間後，問問伊芙琳或羅瑟要不要來一杯好了。", "柯斯莫", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("酒鬼先生，還請收斂一點。", "喵可", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("我想不起來自己的歲數，但事實上我的確對調酒充滿了興趣，也對於酒的知識有或多或少的印象。", " ", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("……", " ", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("不知道他特調出來的酒會是怎麼樣的。", " ", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("有機會的話看看菜單好了。", " ", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.flag.Add("bar");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "sofa":
                        if (gamemanager.flag.Contains("book_fox"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("矮矮的多人沙發……等等，現在不是該睡覺的時候，冷靜。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("矮矮的多人沙發，躺上去感覺會起不來。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("說不定在上面睡覺都沒問題。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("沙發的扶手上有一本孤單的書。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("「王子與狐」", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("是一本圖文小說呢。", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("不知道是什麼樣的內容？", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("是一對狐狸兄弟的故事，哥哥拯救了精靈，得到了變成人類的機會。", "柯斯莫", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("他要替弟弟去看更廣闊的世界，哥哥也的確憑著非凡的成就，被國王收養為王子，和公主過著美滿的日子。但他卻逐漸忘了回去森林找弟弟。", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("某次在森林狩獵實，王子遭到了刺客的襲擊。但一隻狐狸卻衝出來咬住了刺客的手，王子也因此有機會反擊。", "柯斯莫", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("刺客雖然被阻止，但那隻狐狸卻重傷而死了。", "柯斯莫", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("那隻狐狸是……", "喵可", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("……", "我", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("王子發現了那隻狐狸是自己的弟弟，悲痛的離開了王國。沒有人知道他到底去了哪裡。", "柯斯莫", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("在那之後的很多年，那座森林出現了一個傳說。凡是遭遇危機的旅人，都會被兩隻狐狸拯救而平安無事。", "柯斯莫", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("大概就是這樣的傳說故事。", "柯斯莫", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("其實是個不壞的結局呢。", "我", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("兄弟姊妹的情誼啊……我是獨生女所以沒有什麼機會感受到呢。", "喵可", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("但也不是兄弟姊妹都會這麼要好。", "柯斯莫", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("這種時候就別潑冷水了啊！", "喵可", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("將「王子與狐」放進了背包。", " ", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.flag.Add("book_fox");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "menu":
                        if (gamemanager.flag.Contains("book_mink"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("寫著推薦調酒的菜單，名字的由來和這個房間的景物有關。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("「一、爵士明星，二、高枕無憂，三、浸染星空。」", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("菜單上寫著三款推薦調酒，清一色都無法從名字看出喝起來會是什麼感覺。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("為什麼會叫這三個名字呢？", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("調酒的命名有幾種依據。", "柯斯莫", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("像是味道的感覺、使用的材料、顏色，當然也有抽象的命名方式，像是用「景物」來命名。", "柯斯莫", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("……", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("常見的調酒就有不少是用這樣的方式命名對吧？", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("沒錯。我想你既然有所了解，應該可以喝酒吧？", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("不知怎麼的，我清晰的記得有人跟我提過這件事情。", " ", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("難道，我開始回想起記憶了嗎？", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("這三種調酒的命名方式，莫非也是以景物為主題嗎？", "喵可", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("嗯…….我總覺得，有點眼熟？", "喵可", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("眼熟？", "我", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("呵呵，調酒師原創的調酒，當然就該冠上屬於自己的名字。", "柯斯莫", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("為了紀念在這個酒吧裡被創造出來的調酒，這三款調酒都是以房間裡的景物命名的。", "柯斯莫", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("唔……總覺得突然少了很大一部分的情調……", "喵可", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("如果知道名字的由來的話確實……", "我", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("確實失去了某種浪漫的感覺。", " ", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("不過柯斯莫先生似乎不太在意的樣子。", " ", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("菜單的旁邊有本落單的書。", " ", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("「貂的生態」", " ", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.Speak(new talkform("貂啊，感覺不太常見呢。", "我", " ", " "));
                                    break;
                                case 23:
                                    gamemanager.Speak(new talkform("其實在20世紀末期以後，把貂當作寵物的人越來越多了喔。", "喵可", " ", " "));
                                    break;
                                case 24:
                                    gamemanager.Speak(new talkform("我還看過有人在馬路上遛貂呢！腿短短的非常可愛！", "喵可", " ", " "));
                                    break;
                                case 25:
                                    gamemanager.Speak(new talkform("這、這種動物是這麼容易遛的嗎？", " ", " ", " "));
                                    break;
                                case 26:
                                    gamemanager.Speak(new talkform("將「貂的生態」放進了背包。", " ", " ", " "));
                                    break;
                                case 27:
                                    gamemanager.flag.Add("book_mink");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "window":
                        if (gamemanager.flag.Contains("hook"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("連接星空的落地窗，剛開始看覺得有些恐怖，但久了就習慣了。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("比起我房間裡的一片黑已經好很多了。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("從天花板直接接到地板上的大落地窗，外面是一片星空。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("很漂亮呢，我的房間窗戶外面直接就是暗的了。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("缺點就是這扇窗站太近會有點可怕，還不如黑的一片好。", "柯斯莫", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("嗚哇，星空沒有接到地板！好像飄在星空裡面。", "喵可", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("嗯……其實我覺得意外的有趣。跟在外太空有異曲同工之妙。", "我", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("我是不是該跟你們換房間。", "柯斯莫", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("酒保先生應該捨不得這些酒吧……", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("合理。", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("那一聲合理真是鏗鏘有力。", " ", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("窗戶一旁有一根很長的桿子。", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("好大的桿子，這跟也是需要收起來的東西嗎？", "喵可", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("那是要掛窗簾用的，本來是今天要裝，但一大早就被書蟲吵醒，就放到現在。", "柯斯莫", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("走近一看，桿子下面堆著一環環鐵鉤，應該是用來鉤窗簾布的鉤子。我將其中一個鐵鉤拿了起來。", " ", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("把「窗簾鉤」放進了背包。", " ", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.flag.Add("hook");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "table":
                        if (gamemanager.flag.Contains("table"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("被整理乾淨的桌子上留著柯斯莫先生的便條紙。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("「紅酒/狼」、「威士忌/雪貂」、「萊姆酒/狐狸」", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("不管看幾次都覺得動物搭配酒的方法很有趣。", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("這大概是目前最亂的地方了。", "我", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("我和柯斯莫合力清裡掉了破掉的玻璃碎屑，喵可則將桌子擦了乾淨。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("柯斯莫很快的拿出一張便條紙，在上頭寫了些什麼。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("「紅酒/狼」、「威士忌/雪貂」、「萊姆酒/狐狸」", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("這是什麼？", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("我的小興趣，一種酒要對應一種杯子。", "柯斯莫", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("吧檯後面的櫃子有很多動物造型的玻璃杯，也有酒杯。", "柯斯莫", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("這個是方便我記得哪些杯子打破，要換新的。", "柯斯莫", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("有機會的話還真想看看這些杯子完好的樣子。", " ", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("歡迎找我喝酒。", "柯斯莫", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("酒鬼先生真的是酒鬼先生。", "喵可", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("喵可果然是故意的吧。", " ", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.flag.Add("table");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "mixshelf":
                        if (gamemanager.flag.Contains("keylv3"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("琳瑯滿目的酒櫃，上頭也陳列著書籍。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("已經把散落的書放回去了。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("mixshelf")&& gamemanager.flag.Contains("table")&& gamemanager.flag.Contains("book_wolf")&& gamemanager.flag.Contains("book_fox")&& gamemanager.flag.Contains("book_mink"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("把三本書照著柯斯莫寫的提示擺了上去。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("喀。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("鏗鏗。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("有東西掉落在地板上的聲音。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("欸咻！是艾德掉的吧？給你。", "喵可", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("謝謝，不過它好像是從其他地方掉下來的……", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("是一把小鑰匙，鐵製的。", "我", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("這麼小的一把鑰匙，會是用來鎖什麼的呢？", "喵可", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("這間房間大部分是銅或鋼作成的鎖……", "我", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("把「鐵製小鑰匙」放進了背包。", " ", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.flag.Add("keylv3");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("mixshelf")  && gamemanager.flag.Contains("book_wolf") && gamemanager.flag.Contains("book_fox") && gamemanager.flag.Contains("book_mink"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("把三本書對著書櫃的空位塞了進去。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("雖然書本放了上去，卻凸了出來。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("我：嗯……明明跟旁邊的書寬度一樣啊？", "我", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("總覺得不太對勁。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (gamemanager.flag.Contains("mixshelf"))
                        {
                            switch (level)
                            {
                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("琳瑯滿目的酒櫃，上頭也陳列著書籍。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("還有空位可以將書本放進去。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("好多種酒喔……", "喵可", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("還真是壯觀。", "我", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("四個酒櫃擺放著琳瑯滿目的酒，但有些地方空了下來。", " ", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("硬要說起來，也只是看起來多。", "柯斯莫", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("除了左手邊收藏酒專用的櫃子外，其它三個櫃子分別放了紅酒、萊姆酒、威士忌三種酒而已。", "柯斯莫", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("而且因為書蟲亂跑，已經有不少摔破的被清掉了。", "柯斯莫", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("酒瓶基本上佔了最上層與最下層，意外的是除了酒以外，中間那一層卻是獨立出來放書的。", " ", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.Speak(new talkform("心向館裡每個人的房間都充滿了書本啊。", " ", " ", " "));
                                    break;
                                case 9:
                                    gamemanager.Speak(new talkform("還真是特別的設計。", "我", " ", " "));
                                    break;
                                case 10:
                                    gamemanager.Speak(new talkform("畢竟是儲藏記憶的圖書館啊。", "柯斯莫", " ", " "));
                                    break;
                                case 11:
                                    gamemanager.Speak(new talkform("不過上面還缺了幾本，如果收拾途中有撿到的話就放過來吧。", "柯斯莫", " ", " "));
                                    break;
                                case 12:
                                    gamemanager.Speak(new talkform("難道是寫著跟酒保先生記憶有關的書嗎！", "喵可", " ", " "));
                                    break;
                                case 13:
                                    gamemanager.Speak(new talkform("這樣的話…….我不會翻開來看的。", "我", " ", " "));
                                    break;
                                case 14:
                                    gamemanager.Speak(new talkform("雖然在這裡的人們負責整理記憶，對他們而言，看到書本上記錄的「記憶」或許是家常便飯吧。", " ", " ", " "));
                                    break;
                                case 15:
                                    gamemanager.Speak(new talkform("但我還是不太想在未經過允許的狀況下看到。", " ", " ", " "));
                                    break;
                                case 16:
                                    gamemanager.Speak(new talkform("不必擔心，缺的那三本是純粹的資料書跟故事集。", "柯斯莫", " ", " "));
                                    break;
                                case 17:
                                    gamemanager.Speak(new talkform("裡面並不會寫到我本人有多麼愛喝酒之類的。", "柯斯莫", " ", " "));
                                    break;
                                case 18:
                                    gamemanager.Speak(new talkform("哎呀好可惜。", "喵可", " ", " "));
                                    break;
                                case 19:
                                    gamemanager.Speak(new talkform("等等，如果是的話你真的有打算看嗎？", "我", " ", " "));
                                    break;
                                case 20:
                                    gamemanager.Speak(new talkform("開玩笑的啦！真的想要看的話，我會好好問過的。", "喵可", " ", " "));
                                    break;
                                case 21:
                                    gamemanager.Speak(new talkform("不過，我已經很習慣有她在的氛圍了。", " ", " ", " "));
                                    break;
                                case 22:
                                    gamemanager.Speak(new talkform("這孩子偶爾會有點調皮呢……", " ", " ", " "));
                                    break;
                                case 23:
                                    gamemanager.Speak(new talkform("總之，有找到的話會拿過來吧。", "我", " ", " "));
                                    break;
                                case 24:
                                    gamemanager.flag.Add("mixshelf");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case " liqueurshelf":
                        if (gamemanager.flag.Contains("sofalv2"))
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("精細的床頭櫃，每一層抽屜都有著漂亮的花紋。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("好想打開來看看，但仍然是鎖住的狀態，而且也看不到鎖孔之類的地方。", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("....", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("感受到了來自喵可的灼熱視線。", " ", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            switch (level)
                            {

                                case 0:
                                    gamemanager.talk("begin");
                                    break;
                                case 1:
                                    gamemanager.Speak(new talkform("可愛的四層櫃子，但放在這間房間裡並不突兀。", " ", " ", " "));
                                    break;
                                case 2:
                                    gamemanager.Speak(new talkform("雖然不該翻開來看，但一想到裡面會不會有線索就好好奇啊......", " ", " ", " "));
                                    break;
                                case 3:
                                    gamemanager.Speak(new talkform("艾德先生，我覺得不要亂翻淑女的私人物品比較好喔。", "喵可", " ", " "));
                                    break;
                                case 4:
                                    gamemanager.Speak(new talkform("為了找到真相，我認為不該放過任何可能的線索。", "我", " ", " "));
                                    break;
                                case 5:
                                    gamemanager.Speak(new talkform("我伸手拉櫃子的抽屜，結果櫃子是卡住的，拉不開。", " ", " ", " "));
                                    break;
                                case 6:
                                    gamemanager.Speak(new talkform("啊，居然鎖住了，那就沒辦法了。", "我", " ", " "));
                                    break;
                                case 7:
                                    gamemanager.Speak(new talkform("盯——————", "喵可", " ", " "));
                                    break;
                                case 8:
                                    gamemanager.flag.Add("liqueurshelf");
                                    gamemanager.talk("end");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                }
                break;
        }
    }
    public void puzzletrigger(string name)
    {
        
    }
    public string combine(string a, string b)
    {
        if (a == "match" && b == "matchbox" || b == "match" && a == "matchbox")
            return "setthefire";
        else
            return "fail";
    }
    public void clickbag(string type)
    {
        switch (type)
        {
            case "bussinesscase":
                break;
        }
    }
    public void quite()
    {
        //zoom.SetActive(false);
        gamemanager.camerachange(0);
    }
    public void openzoom(int num) {
        //zoomlist[num].SetActive(true);
        gamemanager.camerachange(num);
    }
    public void changzoomimage(GameObject target,string image)
    {
        target.GetComponent<zoomin_basic>().changeimage(spriteDATA[image]);
    }
}