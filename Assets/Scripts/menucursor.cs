using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menucursor : MonoBehaviour
{
    public Sprite images;
    private RectTransform canvas;
    private Image sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<Image>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector2( Input.mousePosition.x-(Camera.main.rect.width / 2), Input.mousePosition.y -(Camera.main.rect.height/2));
    }
}
