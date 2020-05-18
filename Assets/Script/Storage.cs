using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    [SerializeField] Game_Controller controller;
    public bool event_here;
    bool mouse_in;
    bool active;
    bool first_opening;

    [SerializeField] GameObject placeholder;
    [SerializeField] GameObject canvas_item;

    public bool available_to_event;

    public bool[] maked_questions;

    [SerializeField] AudioSource sound;
    void Start()
    {
        placeholder.SetActive(false);
        first_opening = true;
        mouse_in = false;
        active = false;

        available_to_event = true;

        maked_questions = new bool[12];
        maked_questions[0] = false;
        maked_questions[1] = false;
        maked_questions[2] = false;
        maked_questions[3] = false;
        maked_questions[4] = false;
        maked_questions[5] = false;
        maked_questions[6] = false;
        maked_questions[7] = false;
        maked_questions[8] = false;
        maked_questions[9] = false;
        maked_questions[10] = false;
        maked_questions[11] = false;

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0) && mouse_in && event_here && !active && !controller.solving_event && first_opening)
        {
            controller.solving_event = true;
            canvas_item.SetActive(true);
            canvas_item.GetComponent<canvas_storage>().make_question(controller.current_week);
            active = true;
            first_opening = false;
        }
        else if (Input.GetMouseButtonDown(0) && mouse_in && event_here && !active && !controller.solving_event && !first_opening)
        {
            controller.solving_event = true;
            canvas_item.SetActive(true);
            active = true;
        }
    }
    public void closed_clicked()
    {
        if (active)
        {
            canvas_item.GetComponent<canvas_storage>().closed();
            controller.solving_event = false;
            canvas_item.SetActive(false);
            active = false;
        }
    }
    public void solved()
    {
        controller.solving_event = false;
        canvas_item.SetActive(false);
        event_here = false;
        active = false;
        first_opening = true;
    }

    private void OnMouseEnter()
    {
        mouse_in = true;

        if (!controller.solving_event)
        {
            sound.Play();
            placeholder.SetActive(true);
        }

    }

    private void OnMouseExit()
    {
        placeholder.SetActive(false);
        mouse_in = false;
    }

    public void next_week()
    {        
        maked_questions[0] = false;
        maked_questions[1] = false;
        maked_questions[2] = false;
        maked_questions[3] = false;
        maked_questions[4] = false;
        maked_questions[5] = false;
        maked_questions[6] = false;
        maked_questions[7] = false;
        maked_questions[8] = false;
        maked_questions[9] = false;
        maked_questions[10] = false;
        maked_questions[11] = false;

        canvas_item.SetActive(true);
        canvas_item.GetComponent<canvas_storage>().next_week();
        canvas_item.SetActive(false);
    }

    public bool get_viability()
    {
        return available_to_event;
    }

}