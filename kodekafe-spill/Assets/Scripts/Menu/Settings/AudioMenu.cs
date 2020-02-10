using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioMenu : MonoBehaviour
{

    public AudioMixer mixer;



    public void SetVolume (float volume)
    {
        mixer.SetFloat("Master", volume);
    }

}
