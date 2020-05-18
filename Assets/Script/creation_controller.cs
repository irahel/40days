using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class creation_controller : MonoBehaviour
{
    private string chracter_name;
    private string city_name;

    [SerializeField] Sprite[] hairs;
    [SerializeField] Sprite[] eyes;
    [SerializeField] Sprite[] masks;

    [SerializeField] SpriteRenderer hair_controller;
    [SerializeField] SpriteRenderer eye_controller;
    [SerializeField] SpriteRenderer mask_controller;

    [SerializeField] InputField input_character_name;
    [SerializeField] InputField input_city_name;

    private int atual_hair;
    private int atual_eye;
    private int atual_mask;

    void Start()
    {
        chracter_name = "Eudes";
        city_name = "Coronopolis";

        atual_hair = -1;
        atual_eye = -1;
        atual_mask = -1;
    }

    public void rigth_hair()
    {
        switch (atual_hair)
        {
            case -1:
                atual_hair = 0;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 0:
                atual_hair++;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 1:
                atual_hair++;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 2:
                atual_hair++;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 3:
                atual_hair = 0;
                hair_controller.sprite = hairs[atual_hair];
                break;

        }
    }
    public void left_hair()
    {
        switch (atual_hair)
        {
            case -1:
                atual_hair = 3;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 0:
                atual_hair = 3;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 1:
                atual_hair--;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 2:
                atual_hair--;
                hair_controller.sprite = hairs[atual_hair];
                break;
            case 3:
                atual_hair--;
                hair_controller.sprite = hairs[atual_hair];
                break;
        }
    }

    public void rigth_eye()
    {
        switch (atual_eye)
        {
            case -1:
                atual_eye++;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 0:
                atual_eye++;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 1:
                atual_eye++;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 2:
                atual_eye++;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 3:
                atual_eye = 0;
                eye_controller.sprite = eyes[atual_eye];
                break;
        }
    }
    public void left_eye()
    {
        switch (atual_eye)
        {
            case -1:
                atual_eye = 3;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 0:
                atual_eye = 3;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 1:
                atual_eye--;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 2:
                atual_eye--;
                eye_controller.sprite = eyes[atual_eye];
                break;
            case 3:
                atual_eye--;
                eye_controller.sprite = eyes[atual_eye];
                break;
        }
    }

    public void rigth_mask()
    {
        switch (atual_mask)
        {
            case -1:
                atual_mask++;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 0:
                atual_mask++;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 1:
                atual_mask++;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 2:
                atual_mask++;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 3:
                atual_mask = 0;
                mask_controller.sprite = masks[atual_mask];
                break;
        }
    }
    public void left_mask()
    {
        switch (atual_mask)
        {
            case -1:
                atual_mask = 3;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 0:
                atual_mask = 3;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 1:
                atual_mask--;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 2:
                atual_mask--;
                mask_controller.sprite = masks[atual_mask];
                break;
            case 3:
                atual_mask--;
                mask_controller.sprite = masks[atual_mask];
                break;
        }
    }

    public void init_button()
    {
        //player
        if(input_character_name.text == "")
        {
            PlayerPrefs.SetString("player_name", chracter_name);
        }
        else
        {
            PlayerPrefs.SetString("player_name", input_character_name.text);
        }

        //city
        if (input_city_name.text == "")
        {
            PlayerPrefs.SetString("city_name", city_name);
        }
        else
        {
            PlayerPrefs.SetString("city_name", input_city_name.text);
        }

        //hair
        if (atual_hair == -1)
        {
            PlayerPrefs.SetInt("player_hair", 0);
        }
        else
        {
            PlayerPrefs.SetInt("player_hair", atual_hair);
        }

        //eye
        if (atual_eye == -1)
        {
            PlayerPrefs.SetInt("player_eye", 0);
        }
        else
        {
            PlayerPrefs.SetInt("player_eye", atual_eye);
        }

        //mask
        if (atual_mask == -1)
        {
            PlayerPrefs.SetInt("player_mask", 0);
        }
        else
        {
            PlayerPrefs.SetInt("player_mask", atual_mask);
        }

        SceneManager.LoadScene(2);

    }

    private void Update()
    {
        if (input_character_name.isFocused |  input_city_name.isFocused)
        {
            if(TouchScreenKeyboard.visible == false)
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
                Debug.Log("open");
            }
            
        }
        
    }
}

