using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_info : MonoBehaviour
{
    public Text iteminfotext;
    private GameManager_s gameManager;
    public GameObject combinebutton;
    public bool sensor_0;
    public bool sensor_1;
    public bool sensor_2;
    public bool sensor_3;
    public bool sensor_4;
    public int sensorstage;
    // Start is called before the first frame update
    void Start()
    {
        gameManager= GameObject.Find("GameManager").GetComponent<GameManager_s>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sensor_1&&gameManager.playeritem.Count>0)
        {
            sensorstage = 1;
        }
        else if (sensor_2 && gameManager.playeritem.Count > 1)
        {
            sensorstage = 2;
        }
        else if (sensor_3 && gameManager.playeritem.Count > 2)
        {
            sensorstage = 3;
        }
        else if (sensor_4 && gameManager.playeritem.Count > 3)
        {
            sensorstage = 4;
        }
        else if (sensor_0)
        {
        }
        else {
            sensorstage = -1;
        }
        switch (sensorstage)
        {
            case 1:
                transform.localPosition = new Vector3(0, 290, 0);
                info();
                break;
            case 2:
                transform.localPosition = new Vector3(0, 110, 0);
                info();
                break;
            case 3:
                transform.localPosition = new Vector3(0, -70, 0);
                info();
                break;
            case 4:
                transform.localPosition = new Vector3(0, -250, 0);
                info();
                break;
            case 0:
                break;
            case -1:
                transform.position = new Vector3(-760, 290, 0);
                break;
        }
    }
    public void sensor0(bool sense)
    {
        sensor_0 = sense;
    }
    
    public void sensor1(bool sense) {
        sensor_1 = sense;
    }
    public void sensor2(bool sense)
    {
        sensor_2 = sense;
    }
    public void sensor3(bool sense)
    {
        sensor_3 = sense;
    }
    public void sensor4(bool sense)
    {
        sensor_4 = sense;
    }
    private void info()
    {
        iteminfotext.text = gameManager.getiteminfo(gameManager.playeritem[sensorstage-1]);
        if (gameManager.combinable())
        {
            combinebutton.SetActive(true);
        }
        else
        {
            combinebutton.SetActive(false);
        }
    }
}
