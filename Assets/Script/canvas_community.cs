using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class canvas_community : MonoBehaviour
{
    string text_to_write = "";
    string text_complete = "";
    char text_unity;

    bool advanced;

    [SerializeField] Text text_area;

    int atual_question;

    [SerializeField] GameObject button_up_left;
    [SerializeField] GameObject button_up_right;
    [SerializeField] GameObject button_down_left;
    [SerializeField] GameObject button_down_right;

    [SerializeField] database_community database;

    [SerializeField] Game_Controller controller;
    [SerializeField] Community struture_controller;

    int questions_solved_in_this_week;

    int max_questions_1 = 3;
    int max_questions_2 = 3;
    int max_questions_3 = 2;
    int max_questions_4 = 2;
    int max_questions_5 = 2;

    void Start()
    {
        
        advanced = false;

        button_up_left.SetActive(false);
        button_up_right.SetActive(false);
        button_down_left.SetActive(false);
        button_down_right.SetActive(false);

        questions_solved_in_this_week = 0;

    }

    IEnumerator TypeRight()
    {
        controller.sound_tc.Play();
        text_complete = "";
        for (int i = 0; i < text_to_write.Length; i++)
        {
            if (advanced)
            {
                text_complete = text_to_write;
                break;
            }

            text_unity = text_to_write[i];
            text_complete += text_unity;
            yield return new WaitForSeconds(Random.Range(0f, .04f));
        }

        controller.sound_tc.Stop();
        button_up_left.SetActive(true);
        button_up_right.SetActive(true);
        button_down_left.SetActive(true);
        button_down_right.SetActive(true);

    }

    public void make_question(int week)
    {

        switch (week)
        {

            case 1:

                atual_question = Random.Range(0, 3);
                while (struture_controller.maked_questions[atual_question] == true)
                {
                    atual_question = Random.Range(0, 3);
                }
                break;
            case 2:

                atual_question = Random.Range(3, 6);
                while (struture_controller.maked_questions[atual_question] == true)
                {
                    atual_question = Random.Range(3, 6);
                }
                break;
            case 3:
                atual_question = Random.Range(6, 8);
                while (struture_controller.maked_questions[atual_question] == true)
                {
                    atual_question = Random.Range(6, 8);
                }
                break;
            case 4:
                atual_question = Random.Range(8, 10);
                while (struture_controller.maked_questions[atual_question] == true)
                {
                    atual_question = Random.Range(8, 10);
                }
                break;
            case 5:
                atual_question = Random.Range(10, 12);
                while (struture_controller.maked_questions[atual_question] == true)
                {
                    atual_question = Random.Range(10, 12);
                }
                break;
        }

        text_to_write = (database.community_questions[atual_question] as Question).enunciated;
        button_up_left.GetComponentInChildren<Text>().text = (database.community_questions[atual_question] as Question).awn_1;
        button_up_right.GetComponentInChildren<Text>().text = (database.community_questions[atual_question] as Question).awn_2;
        button_down_left.GetComponentInChildren<Text>().text = (database.community_questions[atual_question] as Question).awn_3;
        button_down_right.GetComponentInChildren<Text>().text = (database.community_questions[atual_question] as Question).awn_4;

        StartCoroutine(TypeRight());

    }

    public void next_week()
    {
        struture_controller.available_to_event = true;        
        questions_solved_in_this_week = 0;

    }


    public void awns_1_clicked()
    {

        controller.clear_influences_color();
        controller.third_notice = controller.second_notice;
        controller.second_notice = controller.fist_notice;
        controller.fist_notice = (database.community_questions[atual_question] as Question).phrase_1 + " ";

        //economy
        if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_economy > 0)
        {
            controller.increase_influence(1, (database.community_questions[atual_question] as Question).influence_awn_1.modification_economy);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_1.modification_economy * 2 + " economia ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_economy < 0)
        {
            controller.decrease_influence(1, (database.community_questions[atual_question] as Question).influence_awn_1.modification_economy);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_1.modification_economy * 2 + " economia ";
        }

        //health
        if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_health > 0)
        {
            controller.increase_influence(2, (database.community_questions[atual_question] as Question).influence_awn_1.modification_health);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_1.modification_health * 2 + " saúde ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_health < 0)
        {
            controller.decrease_influence(2, (database.community_questions[atual_question] as Question).influence_awn_1.modification_health);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_1.modification_health * 2 + " saúde ";
        }

        //politics
        if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_politics > 0)
        {
            controller.increase_influence(3, (database.community_questions[atual_question] as Question).influence_awn_1.modification_politics);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_1.modification_politics * 2 + " política ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_politics < 0)
        {
            controller.decrease_influence(3, (database.community_questions[atual_question] as Question).influence_awn_1.modification_politics);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_1.modification_politics * 2 + " política ";
        }

        //population
        if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_population > 0)
        {
            controller.increase_influence(4, (database.community_questions[atual_question] as Question).influence_awn_1.modification_population);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_1.modification_population * 2 + " população ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_population < 0)
        {
            controller.decrease_influence(4, (database.community_questions[atual_question] as Question).influence_awn_1.modification_population);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_1.modification_population * 2 + " população ";
        }

        //research
        if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_research > 0)
        {
            controller.increase_influence(5, (database.community_questions[atual_question] as Question).influence_awn_1.modification_research);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_1.modification_research * 2 + " pesquisa ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_1.modification_research < 0)
        {
            controller.decrease_influence(5, (database.community_questions[atual_question] as Question).influence_awn_1.modification_research);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_1.modification_research * 2 + " pesquisa ";
        }

        struture_controller.maked_questions[atual_question] = true;
        questions_solved_in_this_week++;
        if (controller.current_week == 1)
        {
            if (questions_solved_in_this_week >= max_questions_1)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 2)
        {
            if (questions_solved_in_this_week >= max_questions_2)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 3)
        {
            if (questions_solved_in_this_week >= max_questions_3)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 4)
        {
            if (questions_solved_in_this_week >= max_questions_4)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 5)
        {
            if (questions_solved_in_this_week >= max_questions_5)
            {
                struture_controller.available_to_event = false;
            }
        }

        button_up_left.SetActive(false);
        button_up_right.SetActive(false);
        button_down_left.SetActive(false);
        button_down_right.SetActive(false);

        advanced = false;
        struture_controller.solved();
        controller.solve_one_question();

    }
    public void awns_2_clicked()
    {
        controller.clear_influences_color();
        controller.third_notice = controller.second_notice;
        controller.second_notice = controller.fist_notice;
        controller.fist_notice = (database.community_questions[atual_question] as Question).phrase_2 + " ";
        //economy
        if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_economy > 0)
        {
            controller.increase_influence(1, (database.community_questions[atual_question] as Question).influence_awn_2.modification_economy);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_2.modification_economy * 2 + " economia ";

        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_economy < 0)
        {
            controller.decrease_influence(1, (database.community_questions[atual_question] as Question).influence_awn_2.modification_economy);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_2.modification_economy * 2 + " economia ";
        }

        //health
        if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_health > 0)
        {
            controller.increase_influence(2, (database.community_questions[atual_question] as Question).influence_awn_2.modification_health);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_2.modification_health * 2 + " saúde ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_health < 0)
        {
            controller.decrease_influence(2, (database.community_questions[atual_question] as Question).influence_awn_2.modification_health);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_2.modification_health * 2 + " saúde ";
        }

        //politics
        if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_politics > 0)
        {
            controller.increase_influence(3, (database.community_questions[atual_question] as Question).influence_awn_2.modification_politics);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_2.modification_politics * 2 + " política ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_politics < 0)
        {
            controller.decrease_influence(3, (database.community_questions[atual_question] as Question).influence_awn_2.modification_politics);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_2.modification_politics * 2 + " política ";
        }

        //population
        if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_population > 0)
        {
            controller.increase_influence(4, (database.community_questions[atual_question] as Question).influence_awn_2.modification_population);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_2.modification_population * 2 + " população ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_population < 0)
        {
            controller.decrease_influence(4, (database.community_questions[atual_question] as Question).influence_awn_2.modification_population);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_2.modification_population * 2 + " população ";
        }

        //research
        if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_research > 0)
        {
            controller.increase_influence(5, (database.community_questions[atual_question] as Question).influence_awn_2.modification_research);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_2.modification_research * 2 + " pesquisa ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_2.modification_research < 0)
        {
            controller.decrease_influence(5, (database.community_questions[atual_question] as Question).influence_awn_2.modification_research);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_2.modification_research * 2 + " pesquisa ";
        }

        struture_controller.maked_questions[atual_question] = true;
        questions_solved_in_this_week++;
        if (controller.current_week == 1)
        {
            if (questions_solved_in_this_week >= max_questions_1)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 2)
        {
            if (questions_solved_in_this_week >= max_questions_2)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 3)
        {
            if (questions_solved_in_this_week >= max_questions_3)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 4)
        {
            if (questions_solved_in_this_week >= max_questions_4)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 5)
        {
            if (questions_solved_in_this_week >= max_questions_5)
            {
                struture_controller.available_to_event = false;
            }
        }

        button_up_left.SetActive(false);
        button_up_right.SetActive(false);
        button_down_left.SetActive(false);
        button_down_right.SetActive(false);

        advanced = false;
        struture_controller.solved();
        controller.solve_one_question();


    }
    public void awns_3_clicked()
    {
        controller.clear_influences_color();
        controller.third_notice = controller.second_notice;
        controller.second_notice = controller.fist_notice;
        controller.fist_notice = (database.community_questions[atual_question] as Question).phrase_3 + " ";

        //economy
        if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_economy > 0)
        {
            controller.increase_influence(1, (database.community_questions[atual_question] as Question).influence_awn_3.modification_economy);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_3.modification_economy * 2 + " economia ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_economy < 0)
        {
            controller.decrease_influence(1, (database.community_questions[atual_question] as Question).influence_awn_3.modification_economy);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_3.modification_economy * 2 + " economia ";
        }

        //health
        if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_health > 0)
        {
            controller.increase_influence(2, (database.community_questions[atual_question] as Question).influence_awn_3.modification_health);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_3.modification_health * 2 + " saúde ";

        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_health < 0)
        {
            controller.decrease_influence(2, (database.community_questions[atual_question] as Question).influence_awn_3.modification_health);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_3.modification_health * 2 + " saúde ";
        }

        //politics
        if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_politics > 0)
        {
            controller.increase_influence(3, (database.community_questions[atual_question] as Question).influence_awn_3.modification_politics);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_3.modification_politics * 2 + " política ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_politics < 0)
        {
            controller.decrease_influence(3, (database.community_questions[atual_question] as Question).influence_awn_3.modification_politics);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_3.modification_politics * 2 + " política ";
        }

        //population
        if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_population > 0)
        {
            controller.increase_influence(4, (database.community_questions[atual_question] as Question).influence_awn_3.modification_population);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_3.modification_population * 2 + " população ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_population < 0)
        {
            controller.decrease_influence(4, (database.community_questions[atual_question] as Question).influence_awn_3.modification_population);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_3.modification_population * 2 + " população ";
        }

        //research
        if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_research > 0)
        {
            controller.increase_influence(5, (database.community_questions[atual_question] as Question).influence_awn_3.modification_research);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_3.modification_research * 2 + " pesquisa ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_3.modification_research < 0)
        {
            controller.decrease_influence(5, (database.community_questions[atual_question] as Question).influence_awn_3.modification_research);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_3.modification_research * 2 + " pesquisa ";
        }

        struture_controller.maked_questions[atual_question] = true;
        questions_solved_in_this_week++;
        if (controller.current_week == 1)
        {
            if (questions_solved_in_this_week >= max_questions_1)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 2)
        {
            if (questions_solved_in_this_week >= max_questions_2)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 3)
        {
            if (questions_solved_in_this_week >= max_questions_3)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 4)
        {
            if (questions_solved_in_this_week >= max_questions_4)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 5)
        {
            if (questions_solved_in_this_week >= max_questions_5)
            {
                struture_controller.available_to_event = false;
            }
        }


        button_up_left.SetActive(false);
        button_up_right.SetActive(false);
        button_down_left.SetActive(false);
        button_down_right.SetActive(false);

        advanced = false;
        struture_controller.solved();
        controller.solve_one_question();

    }
    public void awns_4_clicked()
    {
        controller.clear_influences_color();
        controller.third_notice = controller.second_notice;
        controller.second_notice = controller.fist_notice;
        controller.fist_notice = (database.community_questions[atual_question] as Question).phrase_4 + " ";
        //economy
        if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_economy > 0)
        {
            controller.increase_influence(1, (database.community_questions[atual_question] as Question).influence_awn_4.modification_economy);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_4.modification_economy * 2 + " economia ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_economy < 0)
        {
            controller.decrease_influence(1, (database.community_questions[atual_question] as Question).influence_awn_4.modification_economy);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_4.modification_economy * 2 + " economia ";
        }

        //health
        if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_health > 0)
        {
            controller.increase_influence(2, (database.community_questions[atual_question] as Question).influence_awn_4.modification_health);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_4.modification_health * 2 + " saúde ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_health < 0)
        {
            controller.decrease_influence(2, (database.community_questions[atual_question] as Question).influence_awn_4.modification_health);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_4.modification_health * 2 + " saúde ";
        }

        //politics
        if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_politics > 0)
        {
            controller.increase_influence(3, (database.community_questions[atual_question] as Question).influence_awn_4.modification_politics);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_4.modification_politics * 2 + " política ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_politics < 0)
        {
            controller.decrease_influence(3, (database.community_questions[atual_question] as Question).influence_awn_4.modification_politics);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_4.modification_politics * 2 + " política ";
        }

        //population
        if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_population > 0)
        {
            controller.increase_influence(4, (database.community_questions[atual_question] as Question).influence_awn_4.modification_population);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_4.modification_population * 2 + " população ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_population < 0)
        {
            controller.decrease_influence(4, (database.community_questions[atual_question] as Question).influence_awn_4.modification_population);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_4.modification_population * 2 + " população ";
        }

        //research
        if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_research > 0)
        {
            controller.increase_influence(5, (database.community_questions[atual_question] as Question).influence_awn_4.modification_research);
            controller.fist_notice += "+" + (database.community_questions[atual_question] as Question).influence_awn_4.modification_research * 2 + " pesquisa ";
        }
        else if ((database.community_questions[atual_question] as Question).influence_awn_4.modification_research < 0)
        {
            controller.decrease_influence(5, (database.community_questions[atual_question] as Question).influence_awn_4.modification_research);
            controller.fist_notice += (database.community_questions[atual_question] as Question).influence_awn_4.modification_research * 2 + " pesquisa ";
        }

        struture_controller.maked_questions[atual_question] = true;
        questions_solved_in_this_week++;
        if (controller.current_week == 1)
        {
            if (questions_solved_in_this_week >= max_questions_1)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 2)
        {
            if (questions_solved_in_this_week >= max_questions_2)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 3)
        {
            if (questions_solved_in_this_week >= max_questions_3)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 4)
        {
            if (questions_solved_in_this_week >= max_questions_4)
            {
                struture_controller.available_to_event = false;
            }
        }
        else if (controller.current_week == 5)
        {
            if (questions_solved_in_this_week >= max_questions_5)
            {
                struture_controller.available_to_event = false;
            }
        }

        button_up_left.SetActive(false);
        button_up_right.SetActive(false);
        button_down_left.SetActive(false);
        button_down_right.SetActive(false);

        advanced = false;
        struture_controller.solved();
        controller.solve_one_question();


    }

    public void closed()
    {
        text_complete = text_to_write;
        button_up_left.SetActive(true);
        button_up_right.SetActive(true);
        button_down_left.SetActive(true);
        button_down_right.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !advanced)
        {
            advanced = true;
        }
        text_area.text = text_complete;
    }
}
