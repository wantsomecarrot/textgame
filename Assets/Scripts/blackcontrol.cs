using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackcontrol : MonoBehaviour
{
    public string state ;
    public Animator anime ;
    // Start is called before the first frame update
    void Start()
    {
        anime = GetComponent<Animator>();
        if (state == "off")
            anime.SetTrigger("fadeout") ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
