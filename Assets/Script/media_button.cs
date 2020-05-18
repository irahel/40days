using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class media_button : MonoBehaviour
{
    public string url_lav = "https://www.instagram.com/laviniaunder/";
    public string url_rahel = "https://www.instagram.com/rahel_und/";
    public string url_gabriel = "https://www.instagram.com/gabrielsousa589/";
    public string url_danilo = "https://www.instagram.com/danilo.nmaia/";


    public void open_medias()
    {
        Application.OpenURL(url_lav);
        Application.OpenURL(url_gabriel);
        Application.OpenURL(url_rahel);
        Application.OpenURL(url_danilo);
      

    }
}
