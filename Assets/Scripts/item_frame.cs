using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_frame : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager_s gamemanager;
    public List<Image>itemimage;
    
    public Animator anime;
    private bool animating()
    {
        bool animating = false;
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_show")|| anime.GetCurrentAnimatorStateInfo(0).IsName("item_hide"))
        {
            animating = true;
        }
        return animating;
    }
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        anime = GetComponent<Animator>();
    }
    public void enter()
    {
        loaditems();
        anime.SetBool("in",true);
    }
    public void exit()
    {
        if (anime.GetCurrentAnimatorStateInfo(0).IsName("item_on"))
            anime.SetTrigger("hide");
        anime.SetBool("in",false);
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
        for (int i = 0; i < itemlist.Count; i++) {
            loaditemimage(itemimage[i + 1], gamemanager.spriteDATA[itemlist[i]]);
        }
        yield return null;
    }
}
