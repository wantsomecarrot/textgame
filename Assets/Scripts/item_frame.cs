using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Image>itemimage;
    public Sprite realempty;
    public Animator anime;
    /*private bool animating()
    {
        bool animating = false;
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_show")|| anime.GetCurrentAnimatorStateInfo(0).IsName("item_hide"))
        {
            animating = true;
        }
        return animating;
    }*/
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        anime = GetComponent<Animator>();
    }
    public void enter()
    {
        loaditems();
        anime.SetTrigger("enter");
    }
    public void exit()
    {
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_on"))
            anime.SetTrigger("hide");
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_out")==false)
            anime.SetTrigger("exit");
    }
    public void click()
    {
        
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_on"))
            anime.SetTrigger("hide");
        else if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_off"))
            anime.SetTrigger("show");
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
        
        for (int i = 1; i < itemimage.Count; i++) {
            if (i <= itemlist.Count)
                loaditemimage(itemimage[i], gamemanager.spriteDATA[itemlist[i-1]]);
            else
                loaditemimage(itemimage[i], realempty);
           
        }
        
        yield return null;
    }
}
