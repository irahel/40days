using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game_over_controller : MonoBehaviour
{
    [SerializeField] Text inflences;
    void Start()
    {
        inflences.text = PlayerPrefs.GetString("lose_message");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
