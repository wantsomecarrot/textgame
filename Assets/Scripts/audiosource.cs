using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosource : MonoBehaviour
{
    private AudioSource Audio;
    public List<AudioClip> clips;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void change(int num)
    {
        Audio.clip = clips[num];
        if (Audio.isPlaying == false)
            Audio.Play();
        
    }
    public void stop()
    {
        Audio.Stop();
    }
}
