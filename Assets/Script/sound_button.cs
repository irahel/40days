using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound_button : MonoBehaviour
{
    [SerializeField] Image sound_image;
    [SerializeField] Sprite sound_active;
    [SerializeField] Sprite sound_inactive;    
    private bool sound_status;
    void Start()
    {
        sound_status = true;
        sound_image.sprite = sound_active;
        PlayerPrefs.SetString("sound", "true");
    }

    public void sound_clicked()
    {
        if (sound_status)
        {
            sound_status = false;
            sound_image.sprite = sound_inactive;
            PlayerPrefs.SetString("sound", "false");
        }
        else
        {
            sound_status = true;
            sound_image.sprite = sound_active;
            PlayerPrefs.SetString("sound", "true");
        }
        
    }
}
