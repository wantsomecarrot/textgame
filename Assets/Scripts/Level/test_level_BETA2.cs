using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test_level_BETA2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Sprite> DATAimage;
    public List<string> imagename;
    public Dictionary<string, Sprite> spriteDATA = new Dictionary<string, Sprite>();
    public Dictionary<string, string> iteminfo = new Dictionary<string, string>();
    public string nextsence = "stage_three";
    public characterform Akun;
    public List<Sprite> Akunimage;
    public List<string> Akunimagename;
    public List<GameObject> cameralist;
    public List<GameObject> zoombackgroundlist;
    public List<GameObject> zoomobjectlist;
    public List<GameObject> zoomlist;
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
    }
    public int skipvalue(string name)
    {
        int value = 0;
        switch (name)
        {
            case "story":
                value = 69;
                break;
            default:
                value = 0;
                break;
        }
        return value;
    }
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
                        gamemanager.effect("blackfadeout");
                        gamemanager.CGcontrol("exit", "slide");
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
                            gamemanager.Speak(new talkform("翻了面的樂譜牆上掛著好幾把小刀，以及一把鐵製的大提琴。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("這麼多武器.......？你有看過這面牆嗎？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
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
                            break;
                        case 7:
                            gamemanager.Speak(new talkform("看起來是一些機械的機關，我試著能不能把他解開。", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("大提琴發出了齒輪運轉的聲音，音箱的上蓋被打開了。", " ", " ", " "));
                            break;
                        case 9:
                            gamemanager.Speak(new talkform("打開了！", "喵可", " ", " "));
                            break;
                        case 10:
                            gamemanager.Speak(new talkform("獲得了音樂盒！", " ", " ", " "));
                            break;
                        case 11:
                            gamemanager.Speak(new talkform("音樂盒的上面是抱在一起的家族木偶。", " ", " ", " "));
                            break;
                        case 12:
                            gamemanager.Speak(new talkform("我打開了音樂盒，奏響了曲子。", " ", " ", " "));
                            break;
                        case 13:
                            gamemanager.Speak(new talkform("聽起來不像是常見的古典樂曲。", "我", " ", " "));
                            break;
                        case 14:
                            gamemanager.Speak(new talkform(".......這首曲子老師很常彈呢，老師說是她自己做的曲子。", "喵可", " ", " "));
                            break;
                        case 15:
                            gamemanager.Speak(new talkform("是首很溫暖的曲子呢。", "我", " ", " "));
                            break;
                        case 16:
                            gamemanager.Speak(new talkform("明明是第一次聽到的曲子，卻能沒來由地讓我感到一陣鼻酸。", " ", " ", " "));
                            break;
                        case 17:
                            gamemanager.Speak(new talkform("啊。", "我", " ", " "));
                            break;
                        case 18:
                            gamemanager.Speak(new talkform("我打算把音樂盒翻過來端詳，但盒子卻瞬間在我手上解體了。", " ", " ", " "));
                            break;
                        case 19:
                            gamemanager.Speak(new talkform("欸？我弄壞了嗎？", " ", " ", " "));
                            break;
                        case 20:
                            gamemanager.Speak(new talkform("不，可是我什麼都沒碰啊.......", " ", " ", " "));
                            break;
                        case 21:
                            gamemanager.Speak(new talkform("嗚啊！你、你、你！", "喵可", " ", " "));
                            break;
                        case 22:
                            gamemanager.Speak(new talkform("我發誓我什麼都沒做喔。", "我", " ", " "));
                            break;
                        case 23:
                            gamemanager.Speak(new talkform(".....", "喵可", " ", " "));
                            break;
                        case 24:
                            gamemanager.Speak(new talkform("別一臉惋惜地看著我，我的心臟都愧疚起來了。", " ", " ", " "));
                            break;
                        case 25:
                            gamemanager.Speak(new talkform("有什麼東西在音樂盒解體時落到了地上。", " ", " ", " "));
                            break;
                        case 26:
                            gamemanager.Speak(new talkform("相片？", "我", " ", " "));
                            break;
                        case 27:
                            gamemanager.Speak(new talkform("啪答。", " ", " ", " "));
                            break;
                        case 28:
                            gamemanager.Speak(new talkform("在我彎下腰，撿起相片時，肩膀上突然有股濕濕黏黏的感覺。", " ", " ", " "));
                            break;
                        case 29:
                            gamemanager.Speak(new talkform("嗯？", "我", " ", " "));
                            break;
                        case 30:
                            gamemanager.Speak(new talkform("艾德先生！別動！", "喵可", " ", " "));
                            break;
                        case 31:
                            gamemanager.Speak(new talkform("濕濕黏黏的感覺跑到了頭上，我照著喵可說的不動。", " ", " ", " "));
                            break;
                        case 32:
                            gamemanager.Speak(new talkform("不如說那感覺太噁心了，我僵著根本不敢動。", " ", " ", " "));
                            break;
                        case 33:
                            gamemanager.Speak(new talkform("喝啊！！！", "喵可", " ", " "));
                            break;
                        case 34:
                            gamemanager.Speak(new talkform("呼！的一下，什麼東西的重量從我的頭上消失了。地板上隨機傳來啪嗒地一聲響。", " ", " ", " "));
                            break;
                        case 35:
                            gamemanager.Speak(new talkform("相片的觸覺也從指尖溜走了，不過我還僵著，不敢轉頭去確認。", " ", " ", " "));
                            break;
                        case 36:
                            gamemanager.Speak(new talkform("艾德先生，沒事了。", "喵可", " ", " "));
                            break;
                        case 37:
                            gamemanager.Speak(new talkform("我轉身看向聲音傳來的方向。只見喵可拿起了一旁放在刀鞘內的武士刀，呈現了揮棒完了的姿勢。", " ", " ", " "));
                            break;
                        case 38:
                            gamemanager.Speak(new talkform("她剛剛是拿那個從我的頭上揮過去嗎？", " ", " ", " "));
                            break;
                        case 39:
                            gamemanager.Speak(new talkform("咕嚕，我嚥了一口口水。", " ", " ", " "));
                            break;
                        case 40:
                            gamemanager.Speak(new talkform("要是我再高出個3公分，剛才那下大概會讓我腦震盪。", " ", " ", " "));
                            break;
                        case 41:
                            gamemanager.Speak(new talkform("啊！別跑！", "喵可", " ", " "));
                            break;
                        case 42:
                            gamemanager.Speak(new talkform("我這才往地上確認，那坨濕黏的東西跑得飛快，糊著相片鑽往通風口滑去。", " ", " ", " "));
                            break;
                        case 43:
                            gamemanager.Speak(new talkform("不過似乎因為太胖了，那坨「生物」他......", " ", " ", " "));
                            break;
                        case 44:
                            gamemanager.Speak(new talkform("完美地堵塞在通風口，也就是卡住了。", " ", " ", " "));
                            break;
                        case 45:
                            gamemanager.Speak(new talkform("好茨好茨！", "生物", " ", " "));
                            break;
                        case 46:
                            gamemanager.Speak(new talkform("貓咪......嗎？", "我", " ", " "));
                            break;
                        case 47:
                            gamemanager.Speak(new talkform("兩個尖尖的突起像是貓耳朵形狀，身體則是軟軟的一糊。", " ", " ", " "));
                            break;
                        case 48:
                            gamemanager.Speak(new talkform("身體兩側延伸出兩條細細的軀幹，末端則是圓圓的一球。", " ", " ", " "));
                            break;
                        case 49:
                            gamemanager.Speak(new talkform("那是...手？不對，這整坨糊糊的到底是什麼？", " ", " ", " "));
                            break;
                        case 50:
                            gamemanager.Speak(new talkform("等一下！給我把相片吐出來！", "喵可", " ", " "));
                            break;
                        case 51:
                            gamemanager.Speak(new talkform("好茨好ㄘ——好ㄘ…….", "生物", " ", " "));
                            break;
                        case 52:
                            gamemanager.Speak(new talkform("咚。", " ", " ", " "));
                            break;
                        case 53:
                            gamemanager.Speak(new talkform("喵可的劍鞘又一次揮了下去。", " ", " ", " "));
                            break;
                        case 54:
                            gamemanager.Speak(new talkform("異樣的生物身體整個被砸扁了，但是他完全沒有要把嘴裡的相片放開的樣子。", "", " ", " "));
                            break;
                        case 55:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.Speak(new talkform("這....超出常識了，難以理解。", " ", " ", " "));
                            break;
                        case 56:

                            gamemanager.Speak(new talkform("究竟接下來會如何發展呢....敬請期待囉。", "謎之聲", " ", " "));
                            break;
                        case 57:
                            gamemanager.Speak(new talkform("先讓我睡一下....", "謎之聲", " ", " "));
                            break;
                        case 58:
                            gamemanager.Speak(new talkform("感謝你的遊玩，到這裡就是目前為止的全部內容囉。", "謎之聲", " ", " "));
                            break;
                        case 59:

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
                            gamemanager.CGcontrol("enter", "popout");
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
                            gamemanager.Speak(new talkform("話說回來......會這樣想的我，應該是學過樂理的？", " ", " ", " "));
                            break;
                        case 20:
                            gamemanager.Speak(new talkform("這或許是幫助我找到記憶的一個關鍵。", " ", " ", " "));
                            break;
                        case 21:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("bookshelflv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "violinlv2":
                if (gamemanager.flag.Contains("violinlv2"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
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
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("曲面的提琴櫃，裡面放了五把小提琴。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("我拿了一把小提琴擺弄了一下。但沒有聲音。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.CGcontrol("enter", "popout");
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
                            gamemanager.CGcontrol("exit", "slide");
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
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("琴鍵上有著隨意標示的符號。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("高音譜記號、音符還有低音譜記號？", "我", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("琴鍵上面為什麼會畫上符號呢？", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("說起來這些符號很常在這個房間的一些地方看到呢，老師的床頭櫃也是這些圖案，意外的很可愛呢。", "喵可", " ", " "));
                            break;
                        case 5:
                            gamemanager.Speak(new talkform("該說臻不愧是音樂老師嗎？連家具都是充滿音樂的元素啊。", "我", " ", " "));
                            break;
                        case 6:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                else if(gamemanager.flag.Contains("violinlv2")&& gamemanager.flag.Contains("pianolv2"))
                {
                    switch (level)
                    {
                        case 0:
                            gamemanager.talk("begin");
                            break;
                        case 1:
                            gamemanager.Speak(new talkform("按照提琴上的音階彈奏後，鋼琴發出了輕脆的旋律後，房間傳來了巨大的撞擊聲。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("艾德先生快看！牆壁翻過來了。", "喵可", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("原先書櫃的位置換成了一面黑色的牆。", " ", " ", " "));
                            break;
                        case 4:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("pianolv2unlock");
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
                            break;
                        case 2:
                            gamemanager.CGcontrol("enter", "popout");
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
                            gamemanager.Speak(new talkform("我繞著鋼琴看了一圈，發現了琴鍵上隨意標記著ㄧ些符號。", " ", " ", " "));
                            break;
                        case 8:
                            gamemanager.Speak(new talkform("這些符號似乎有什麼用的樣子，先記起來吧。", "我", " ", " "));
                            break;
                        case 9:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("pianolv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "bedsidetablelv2":
                if (gamemanager.flag.Contains("bedsidetablelv2"))
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
                            gamemanager.Speak(new talkform("好想打開來看看。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("....", " ", " ", " "));
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
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("艾德先生，我覺得不要亂翻比較好喔。", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("我想也是。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.CGcontrol("exit", "slide");
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
                            gamemanager.Speak(new talkform("精細的床頭櫃，每一層抽屜都有著漂亮的花紋。", " ", " ", " "));
                            break;
                        case 2:
                            gamemanager.Speak(new talkform("好想打開來看看。", " ", " ", " "));
                            break;
                        case 3:
                            gamemanager.Speak(new talkform("....", " ", " ", " "));
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
                            gamemanager.CGcontrol("enter", "popout");
                            gamemanager.Speak(new talkform("艾德先生，我覺得不要亂翻比較好喔。", "喵可", " ", " "));
                            break;
                        case 4:
                            gamemanager.Speak(new talkform("我想也是。", " ", " ", " "));
                            break;
                        case 5:
                            gamemanager.CGcontrol("exit", "slide");
                            gamemanager.flag.Add("sofalv2");
                            gamemanager.talk("end");
                            break;
                        default:
                            break;
                    }
                }
                break;
            case "niddleminute":
                zoomobjectlist[6].GetComponent<clockniddle>().Drag();
                break;
            case "niddlehour":
                zoomobjectlist[10].GetComponent<clockniddle>().Drag();
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
    }
    public void puzzletrigger(string name)
    {
        switch (name)
        {
            case "niddleminute":
                zoomobjectlist[6].GetComponent<clockniddle>().Drag();
                break;
            case "niddlehour":
                zoomobjectlist[10].GetComponent<clockniddle>().Drag();
                break;
            default:
                break;
        }
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