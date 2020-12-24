using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class converstation_frame : MonoBehaviour
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
        anime.SetTrigger("open");
    }
    public void exit()
    {
        anime.SetTrigger("close");
    }

}
