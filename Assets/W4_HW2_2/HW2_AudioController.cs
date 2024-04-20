using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2_AudioController : MonoBehaviour
{
    public AudioSource audioplayer;
    // Start is called before the first frame update
    void Start()
    {
        audioplayer.Stop();
    }

    // Update is called once per frame
    void AudioPlay()
    {
        audioplayer.Play();
    }

    void AudioStop()
    {
        audioplayer.Stop();
    }

    public void OnClick_Play()
    {
        AudioPlay();
    }

    public void OnClick_Stop()
    {
        AudioStop();
    }
}
