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
    public Dictionary<string, Sprite> spriteDATA=new Dictionary<string, Sprite>();
    public List<GameObject> cameralist;
    public List<GameObject> zoomlist;
    public void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        StartCoroutine(Getimage());
        gamemanager.spriteDATA = spriteDATA;
    }
    IEnumerator Getimage()
    {
        for (int i = 0; i < imagename.Count; i++)
        {
            spriteDATA.Add(imagename[i],DATAimage[i]);
        }
        imagename.Clear();
        DATAimage.Clear();
        yield return null;
    }
    // Update is called once per frame
    void Update()
    {

    }
    /*public int skipvalue(string name)
    {
        int value = 0;
        switch (name)
        {
            case "story":
                value = 46;
                break;
            default:
                value = 0;
                break;
        }
        return value;
    }*/
    public void story(string name, float level)
    {
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
                        gamemanager.Speak(new talkform("血液在大雨滂沱中漫開。", " ", " ", " "));
                        
                        break;
                    case 2:
                        gamemanager.Speak(new talkform("我緊緊的握住了那雙逐漸冰冷的手。"," ", " ", " "));
                        
                        break;
                    case 3:
                        gamemanager.Speak(new talkform( "視線是模糊的，分不清是雨水還是淚。"," ", " ", " "));
                        break;
                    case 4:
                        gamemanager.Speak(new talkform("我做了一個夢，很長，很久。"," ", " ", " "));
                        break;
                    case 5:
                        gamemanager.Speak(new talkform("我感覺到有人在呼喊我的名字，很遙遠、很遙遠。"," ", " ", " "));
                        break;
                    case 6:
                        gamemanager.Speak(new talkform("在辨認出那是誰的聲音之前，我感受到了一陣疼痛。", " ", " ", " "));
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
                        gamemanager.CGcontrol("enter","popout");
                        break;
                    case 15:
                        gamemanager.Speak(new talkform("……？", "我", " ", " "));
                        break;
                    case 16:
                        gamemanager.Speak(new talkform("非常對不起！！！", "？？？", " ", " "));
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
                        gamemanager.Speak(new talkform("我稍微環視了一下整個空間。"," ", " ", " "));
                        break;
                    case 35:
                        gamemanager.Speak(new talkform("這裡的擺設我完全沒有印象，我是怎麼睡的，會在這裡醒來？"," ", " ", " "));
                        break;
                    case 36:
                        gamemanager.Speak(new talkform("這裡...是哪裡呢？","我", " ", " "));
                        break;
                    case 37:
                        gamemanager.Speak(new talkform("這個……我也不知道怎麼解釋……酒保先生在的話就好了……", "？？？", " ", " "));
                        break;
                    case 38:
                        gamemanager.Speak(new talkform("………","我", " ", " "));
                        break;
                    case 39:
                        gamemanager.Speak(new talkform("………", "？？？", " ", " "));
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
                        gamemanager.Speak(new talkform("聽你剛才的意思，去找那個酒保先生，他就有辦法跟我解釋現在的情況嗎？","我", " ", " "));
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
                        gamemanager.Speak(new talkform("啊，失禮了，我還沒有自我介紹吧。我叫喵可，可以告訴我你的名字嗎？","？？？", " ", " "));
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
                    case 69 :
                        gamemanager.CGcontrol("exit", "slide");
                        gamemanager.talk("end");
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
                            gamemanager.Speak(new talkform("一張雙人大床，我們剛檢查過它。。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("哈啾！", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("可惡的灰塵", "", " ", " "));
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
                                gamemanager.Speak(new talkform("房間裡的光源，燈火在裏頭搖曳著。"," "," "," "));
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
                                gamemanager.Speak(new talkform("一盞壁燈，房間的光源似乎全都來自於他。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("唔、好亮。", "我", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("壁燈裡面有什麼東西在一閃一閃的。", " ", " ", " "));
                                break;
                        case 4:
                            gamemanager.Speak(new talkform("獲得了密碼碎片。", " ", " ", " "));
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
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("書櫃上頭擺滿了書本，但有些似乎落在了地板上頭。"," "," "," "));
                            break;
                        case 2:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
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
                                gamemanager.Speak(new talkform("窗戶似乎無法看出去，外面只有一片漆黑。", " ", " ", " "));
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
                                gamemanager.Speak(new talkform("怎麼了？", "喵可", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("這裡房間的窗戶是看不到外面的嗎？", "我", " ", " "));
                                break;
                            case 4:
                                gamemanager.Speak(new talkform("不……我的房間是看的到外面的呢。", "喵可", " ", " "));
                                break;
                            case 5:
                                gamemanager.Speak(new talkform("所以是只有這間房間看不到外面的嗎？", " ", " ", " "));
                                break;
                            case 6:
                                gamemanager.flag.Add("window");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
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
                                gamemanager.Speak(new talkform("我撿起幾本書翻看。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("書頁裡夾著一片透明的碎片", " ", " ", " "));
                                break;
                            case 4:
                                gamemanager.Speak(new talkform("獲得了密碼碎片。", " ", " ", " "));
                                break;
                            case 5:
                                gamemanager.flag.Add("book");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
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
                                gamemanager.Speak(new talkform("毛茸茸的地毯，邊角有狼的花紋裝飾。", " ", " ", " "));
                                break;
                            case 2:
                                gamemanager.Speak(new talkform("邊角的地方下面好像有什麼東西？", " ", " ", " "));
                                break;
                            case 3:
                                gamemanager.Speak(new talkform("藏在地毯底下的地板刻著字。", " ", " ", " "));
                                break;
                            case 4:
                            gamemanager.Speak(new talkform("獲得了密碼碎片。", " ", " ", " "));
                            break;
                            case 5:
                                gamemanager.flag.Add("carpet");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
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
                case "dressingtable":
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak("一組造型典雅的梳妝台，上面的鏡子倒映著房間。");
                            break;
                        case 2:
                            gamemanager.Speak("邊邊刻上了貓咪的雕花，真是細緻。");
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
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
                case "bedsidetable":
                    switch (level)
                    {

                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:

                            gamemanager.Speak("造型簡單的床頭櫃，櫃子似乎還打不開。");
                            break;
                        case 2:
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

                            gamemanager.Speak("結實的木頭椅子，上面躺著一顆軟墊。");
                            break;
                        case 2:
                            gamemanager.Speak("坐起來感覺很舒服的樣子。");
                            break;
                        case 3:
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                    break;
                case "bussinesscase":
                    if (gamemanager.resentitem == "carrot") {
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:

                                gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                                break;
                            case 2:

                                gamemanager.Speak("我：這根蘿蔔應該可以從鎖孔裡面督進去.....嗎？");
                                break;
                            case 3:

                                gamemanager.Speak("總之先試試看吧！");
                                break;
                            case 4:

                                gamemanager.Speak("啊。蘿蔔壞掉了....");
                                break;
                            case 5:
                                gamemanager.resentitem = "empty";
                                gamemanager.playeritem.Remove("carrot");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                        else {
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:

                                gamemanager.Speak("規矩的黑色公事包，在房裡顯得有些突兀。");
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "clock":
                    if (gamemanager.flag.Contains("key"))
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("一個貓咪時鐘，我真的沒想到他居然是貓咪時鐘……");
                                break;
                            case 2:
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    else if (gamemanager.flag.Contains("curtain") && gamemanager.flag.Contains("carpet") && gamemanager.flag.Contains("book") && gamemanager.flag.Contains("lamp"))
                    {
                        switch (level)
                        {
                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("我：這個四字的密碼，很像一個時間呢");
                                break;
                            case 2:
                                gamemanager.Speak("我：這個布穀鳥鐘有沒有辦法調整呢？");
                                break;
                            case 3:
                                gamemanager.Speak("我將房間一旁的椅子搬了過來，取下軟墊踩上去拿下時鐘。");
                                break;
                            case 4:
                                gamemanager.Speak("我：太好了，似乎可以調看看。");
                                break;
                            case 5:
                                gamemanager.Speak("我把時鐘的時間調整到與找到的數字一致，時鐘叮了一聲後，一隻貓咪從裡面彈了出來");
                                break;
                            case 6:
                                gamemanager.Speak("我：居然是貓咪嗎？");
                                break;
                            case 7:
                                gamemanager.Speak("喵可：雖然跟想像的不一樣，但是好可愛喔~我也想裝一個在房間裡了。");
                                break;
                            case 8:
                                gamemanager.Speak("如果是這麼可愛的東西，的確很適合她。");
                                break;
                            case 9:
                                gamemanager.Speak("我觀察了一下沒有回到時鐘裡的貓咪。");
                                break;
                            case 10:
                                gamemanager.Speak("牠的嘴上叼著一根鑰匙。");
                                break;
                            case 11:
                                gamemanager.Speak("喵可：看起來跟門鎖的裝飾一樣呢，應該就是門的要是沒錯了。馬上試試看吧！");
                                break;
                            case 12:
                                gamemanager.flag.Add("key");
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
                                gamemanager.Speak("木製樹屋外觀的時鐘，這麼說來應該是個布穀鳥鐘了。");
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
                                gamemanager.Speak("我：這種房子的造型應該是布穀鳥鐘吧？");
                                break;
                            case 2:
                                gamemanager.Speak("喵可：我還是第一次看到實體的布穀鳥鐘呢。");
                                break;
                            case 3:
                                gamemanager.Speak("我：那你的房間時鐘是什麼樣子的？");
                                break;
                            case 4:
                                gamemanager.Speak("喵可：我是用懷錶在看時間的，所以房間裡沒有擺時鐘呢。");
                                break;
                            case 5:
                                gamemanager.flag.Add("clock");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case "door":
                    if (gamemanager.flag.Contains("key"))
                    {
                        switch (level)
                        {

                            case 0:
                                gamemanager.talk("begin");
                                break;
                            case 1:
                                gamemanager.Speak("鑰匙剛剛好的放入了鎖裡。");
                                break;
                            case 2:
                                gamemanager.Speak("門喀嗤一聲，被打開了。");
                                break;
                            case 3:
                                gamemanager.Speak("喵可：打開了！");
                                break;
                            case 4:
                                gamemanager.Speak("我：真是太好了！你能玩到這邊就代表沒有BUG。第一關BETA已結束！");
                                break;
                            case 5:
                                gamemanager.Speak("目前做到的功能與寫好的文本加起來就到這邊，感謝您的遊玩！");
                                break;
                            case 6:
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
                                gamemanager.Speak("上了鎖的門，想要出去只能快點找到鑰匙了。");
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
                                gamemanager.Speak("轉了轉手把，絲紋不動。");
                                break;
                            case 2:
                                gamemanager.Speak("真的被鎖上了呢……");
                                break;
                            case 3:
                                gamemanager.flag.Add("door");
                                gamemanager.talk("end");
                                break;
                            default:
                                break;
                        }
                    }
                    break;*/
                    
        }
    }
    public void clickbag(string type) {
        switch (type) {
            case "bussinesscase":
                break;
        }
    }
    public void quite(GameObject zoom)
    {
        zoom.SetActive (false);
    }
    }