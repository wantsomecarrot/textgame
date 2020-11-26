using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomin_basic : MonoBehaviour
{
    public Image backimage;
    // Start is called before the first frame update
    public void chamgeimage(Sprite target)
    {
        backimage.sprite = target;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
