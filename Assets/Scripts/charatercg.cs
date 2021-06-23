using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charatercg : MonoBehaviour
{
    private GameManager_s gamemanager;
    private Animator CGanime1;
    private Animator CGanime2;
    private Animator stageanime;
    public Image character1;
    public Image character2;
    public string state;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager_s>();
        CGanime1 =  character1.GetComponent<Animator>();
        CGanime2 = character2.GetComponent<Animator>();
        stageanime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void characterenter(float num, string type)
    {
        if (num == 1)
        {
            if (CGanime1.GetCurrentAnimatorStateInfo(0).IsName("CG_out"))
            {
                switch (type)
                {
                    case "popout":
                        CGanime1.SetTrigger("popin");
                        break;
                    case "slidein":
                        CGanime1.SetTrigger("slidein");
                        break;
                }
            }
        }
        else if (num == 2)
        {
            if (CGanime2.GetCurrentAnimatorStateInfo(0).IsName("CG_out"))
            {
                switch (type)
                {
                    case "popout":
                        CGanime2.SetTrigger("popin");
                        break;
                    case "slidein":
                        CGanime2.SetTrigger("slidein");
                        break;
                }
            }
        }
    }
    public void characterexit(float num, string type)
    {
        if (num == 1) { 
        if (CGanime1.GetCurrentAnimatorStateInfo(0).IsName("CG_centerstage"))
        {
            switch (type)
            {
                case "stretchdown":
                    CGanime1.SetTrigger("stretchdown");
                    break;
                case "slideout":
                    CGanime1.SetTrigger("slideout");
                    break;
            }
        }
    }
        else if (num == 2)
        {
            if (CGanime2.GetCurrentAnimatorStateInfo(0).IsName("CG_centerstage"))
            {
                switch (type)
                {
                    case "stretchdown":
                        CGanime2.SetTrigger("stretchdown");
                        break;
                    case "slideout":
                        CGanime2.SetTrigger("slideout");
                        break;
                }
            }
        }
    }
    void changeCG(Sprite CG)
    {
    }
}
