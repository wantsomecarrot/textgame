using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemget : MonoBehaviour
{
    // Start is called before the first frame update
    public Text title;
    public Text infotext;
    public Image itemimage;
    private Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void enter(string name,string info,Sprite image)
    {
        title.text = "物品「"+name+"」被加入背包了！";
        infotext.text = info;
        itemimage.sprite = image;
        anime.SetTrigger("enter");
    }
    public void exit()
    {
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("itemget_in"))
        anime.SetTrigger("exit");
    }
}
