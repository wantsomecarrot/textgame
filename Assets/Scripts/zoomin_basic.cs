using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomin_basic : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeimage(Sprite target)
    {
        sprite.sprite = target;
    }
}
