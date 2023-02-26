using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;

    public void SetVolume(){
        mixer.SetFloat("Volume", volumeSlider.value);
    }
}
