using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logpage : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anime;
    void Start()
    {
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enter()
    {
        anime.SetTrigger("enter");
    }
    public void exit()
    {
        anime.SetTrigger("exit");
    }
}
