using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_init : MonoBehaviour
{
    public void init_clicked()
    {        
        SceneManager.LoadScene(1);
    }
}
