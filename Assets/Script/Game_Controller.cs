using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_Controller : MonoBehaviour
{

    //influences
    public enum influences {ECONOMY, HEALTH, POPULATION, POLITICS, RESEARCH}

    //0 = neutral, 1 = increased, -1 = decreased
    public int influence_economy;
    public int influence_economy_increased;

    public int influence_health;
    public int influence_health_increased;

    public int influence_population;
    public int influence_population_increased;

    public int influence_politics;
    public int influence_politics_increased;

    public int influence_research;
    public int influence_research_increased;

    [SerializeField] int initial_value_influency;

    //days
    public int current_week;
    private int week_decisions;

    //locals    
    [SerializeField] Transform[] local_exclamation_points;
    [SerializeField] GameObject[] local_scripts;

    //Events
    [SerializeField] GameObject prefab_exclamation_event;
    public bool solving_event;
    ArrayList events;
    ArrayList events_locals_numbers;
    

    //week
    [SerializeField] Text week_show;
    [SerializeField] Text city_name_show;
    [SerializeField] Transform spawn_week;
    [SerializeField] GameObject[] prefab_week_alert;

    //influences
    [SerializeField] GameObject hud_influences;

    [SerializeField] Sprite[] hairs;
    [SerializeField] Sprite[] eyes;
    [SerializeField] Sprite[] masks;

    [SerializeField] Image hair1;
    [SerializeField] Image hair2;
    [SerializeField] Image hair3;
    [SerializeField] Image hair4;

    [SerializeField] Image eye_img;
    [SerializeField] Image mask_img;

    [SerializeField] Text player_name_box;

    //last relatory
    public string fist_notice;
    public string second_notice;
    public string third_notice;


    //sounds
    [SerializeField] public AudioSource sound_week;

    [SerializeField] public AudioSource sound_tc;
    void Start()
    {
        fist_notice = "";
        second_notice = "";
        third_notice = "";

        influence_economy_increased = 0;    
        influence_health_increased = 0;    
        influence_population_increased = 0;    
        influence_politics_increased = 0;    
        influence_research_increased = 0;

        hud_influences.SetActive(true);
        player_name_box.text = PlayerPrefs.GetString("player_name");
        int hair = PlayerPrefs.GetInt("player_hair");
        int eye = PlayerPrefs.GetInt("player_eye");
        int mask = PlayerPrefs.GetInt("player_mask");

        if (hair == 0)
        {
            hair1.sprite = hairs[0];
        }
        else if (hair == 1)
        {
            hair2.sprite = hairs[1];
        }
        else if (hair == 2)
        {
            hair3.sprite = hairs[2];
        }
        else if (hair == 3)
        {
            hair4.sprite = hairs[3];
        }

        eye_img.sprite = eyes[eye];
        mask_img.sprite = masks[mask];

        hud_influences.SetActive(false);
             
        city_name_show.text = PlayerPrefs.GetString ("city_name");
        influence_economy = initial_value_influency;
        influence_health = initial_value_influency;
        influence_population = initial_value_influency;
        influence_politics = initial_value_influency;
        influence_research = initial_value_influency;

        current_week = 1;

        //solving_event = false;

        week_decisions = 0;
        
        events = new ArrayList();
        events_locals_numbers = new ArrayList();

        
        

        
    }

    public void really_start()
    {
        sound_week.Play();
        Instantiate(prefab_week_alert[0], spawn_week);
        spawn_events();
    }

    void Update()
    {
        
        /*
        if (Input.GetButtonDown("Fire1"))
        {
            spawn_events();
        }
        */
        
        
    }

    public void clear_influences_color()
    {
        influence_economy_increased = 0;
        influence_health_increased = 0;
        influence_population_increased = 0;
        influence_politics_increased = 0;
        influence_research_increased = 0;
    }

    public void solve_one_question()
    {
        foreach(Object event_to_destroy in events)
        {
            Destroy((event_to_destroy as GameObject));
        }

        foreach (Integer local_to_unevent in events_locals_numbers)
        {
            
            switch (local_to_unevent.value)
            {
                case 0:                    
                    local_scripts[0].GetComponent<Bank>().event_here = false;
                    break;
                case 1:                    
                    local_scripts[1].GetComponent<Community>().event_here = false;
                    break;
                case 2:                    
                    local_scripts[2].GetComponent<Hospital>().event_here = false;
                    break;
                case 3:                    
                    local_scripts[3].GetComponent<media_center>().event_here = false;
                    break;
                case 4:                    
                    local_scripts[4].GetComponent<Political_chamber>().event_here = false;
                    break;
                case 5:                    
                    local_scripts[5].GetComponent<Storage>().event_here = false;
                    break;
                case 6:                    
                    local_scripts[6].GetComponent<University>().event_here = false;
                    break;
            }
            
        }

        events = new ArrayList();
        events_locals_numbers = new ArrayList();

        week_decisions++;
        if (week_decisions == 5)
        {
            //next week
            week_decisions = 0;
            current_week++;
            sound_week.Play();

            if (current_week < 6)
            {
                Instantiate(prefab_week_alert[current_week - 1], spawn_week);
            }
            

            week_show.text = "Semana " + current_week.ToString();

            local_scripts[0].GetComponent<Bank>().next_week();
            local_scripts[1].GetComponent<Community>().next_week();
            local_scripts[2].GetComponent<Hospital>().next_week();
            local_scripts[3].GetComponent<media_center>().next_week();
            local_scripts[4].GetComponent<Political_chamber>().next_week();
            local_scripts[5].GetComponent<Storage>().next_week();
            local_scripts[6].GetComponent<University>().next_week();

            if (current_week == 6)
            {
                PlayerPrefs.SetInt("economy", influence_economy);
                PlayerPrefs.SetInt("health", influence_health);
                PlayerPrefs.SetInt("politics", influence_politics);
                PlayerPrefs.SetInt("population", influence_population);
                PlayerPrefs.SetInt("research", influence_research);

                PlayerPrefs.SetString("lose_message", "Você chegou ao fim da quarentena sem atingir o colapso da sociedade, parabéns. \n" +
                    "Apesar de não ser bem uma vitória definitiva, essa situação é a que mais se encaixa na realidade.");

                SceneManager.LoadScene(3);
            }
        }
        print_influences();

        spawn_events();
    }

    public void print_influences()
    {
        Debug.Log("----------------");
        Debug.Log("economia = " + influence_economy);
        Debug.Log("saude = " + influence_health);
        Debug.Log("politica = " + influence_politics);
        Debug.Log("população = " + influence_population);
        Debug.Log("pesquisa = " + influence_research);
    }

    public void spawn_events()
    {
        bool can_firs_event = false;        

        int first_event = 0;
        while (can_firs_event == false)
        {            
            first_event = Random.Range(0, 7);
            switch (first_event)
            {
                case 0:
                    can_firs_event = local_scripts[0].GetComponent<Bank>().get_viability(); 
                    break;
                case 1:
                    can_firs_event = local_scripts[1].GetComponent<Community>().get_viability();
                    break;
                case 2:
                    can_firs_event = local_scripts[2].GetComponent<Hospital>().get_viability();
                    break;
                case 3:
                    can_firs_event = local_scripts[3].GetComponent<media_center>().get_viability();
                    break;
                case 4:
                    can_firs_event = local_scripts[4].GetComponent<Political_chamber>().get_viability();
                    break;
                case 5:
                    can_firs_event = local_scripts[5].GetComponent<Storage>().get_viability();
                    break;
                case 6:
                    can_firs_event = local_scripts[6].GetComponent<University>().get_viability();
                    break;
            }
            
        }

        bool can_second_event = false;
        int second_event = 0;
        while (can_second_event == false )
        {            
            second_event = Random.Range(0, 7);            
            switch (second_event)
            {
                case 0:
                    can_second_event = local_scripts[0].GetComponent<Bank>().get_viability();
                    break;
                case 1:
                    can_second_event = local_scripts[1].GetComponent<Community>().get_viability();
                    break;
                case 2:
                    can_second_event = local_scripts[2].GetComponent<Hospital>().get_viability();
                    break;
                case 3:
                    can_second_event = local_scripts[3].GetComponent<media_center>().get_viability();
                    break;
                case 4:
                    can_second_event = local_scripts[4].GetComponent<Political_chamber>().get_viability();
                    break;
                case 5:
                    can_second_event = local_scripts[5].GetComponent<Storage>().get_viability();
                    break;
                case 6:
                    can_second_event = local_scripts[6].GetComponent<University>().get_viability();
                    break;
            }

            if (second_event == first_event)
            {
                can_second_event = false;
            }
        }

        spawn_event(first_event);
        spawn_event(second_event);
       
    }
    private void spawn_event(int local_type)
    {
        switch (local_type)
        {
            case 0:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[0]));
                events_locals_numbers.Add(new Integer(0));
                local_scripts[0].GetComponent<Bank>().event_here = true;
                break;
            case 1:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[1]));
                events_locals_numbers.Add(new Integer(1));
                local_scripts[1].GetComponent<Community>().event_here = true;
                break;
            case 2:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[2]));
                events_locals_numbers.Add(new Integer(2));
                local_scripts[2].GetComponent<Hospital>().event_here = true;
                break;
            case 3:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[3]));
                events_locals_numbers.Add(new Integer(3));
                local_scripts[3].GetComponent<media_center>().event_here = true;
                break;
            case 4:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[4]));
                events_locals_numbers.Add(new Integer(4));
                local_scripts[4].GetComponent<Political_chamber>().event_here = true;
                break;
            case 5:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[5]));
                events_locals_numbers.Add(new Integer(5));
                local_scripts[5].GetComponent<Storage>().event_here = true;
                break;
            case 6:
                events.Add(Instantiate(prefab_exclamation_event, local_exclamation_points[6]));
                events_locals_numbers.Add(new Integer(6));
                local_scripts[6].GetComponent<University>().event_here = true;
                break;

        }
        
    }

    public void increase_influence(int influence_type, int value)
    {
        value *= 2;
        switch (influence_type)
        {
            case 1:
                influence_economy_increased = 1;
                if (influence_economy + value > 100)
                {
                    influence_economy = 100;
                    if (influence_research == 100)
                    {
                        PlayerPrefs.SetString("win_message", "Pesquisa e Economia chegaram a 100  \n" +
                            "A cura foi achada e temos recursos para distribuí-la.");
                        SceneManager.LoadScene(4);
                    }
                }
                else
                {
                    influence_economy += value;
                    if (influence_economy >= 80 
                        && influence_health >= 80
                        && influence_politics >= 80
                        && influence_population >= 80
                        && influence_research >= 80)
                    {
                        PlayerPrefs.SetString("win_message", "Todas as áreas chegaram a 80  \n" +
                         "Uma ótima administração, o vírus foi controlado.");
                        SceneManager.LoadScene(4);
                    }
                }
                break;
            case 2:
                influence_health_increased = 1;
                if (influence_health + value > 100)
                {
                    influence_health = 100;
                    if (influence_population == 100)
                    {
                        PlayerPrefs.SetString("win_message", "Saúde e População chegaram a 100  \n" +
                            " O isolamento foi bem sucedido e os casos foram tratados.");
                        SceneManager.LoadScene(4);
                    }
                }
                else
                {
                    influence_health += value;
                    if (influence_economy >= 80
                        && influence_health >= 80
                        && influence_politics >= 80
                        && influence_population >= 80
                        && influence_research >= 80)
                    {
                        PlayerPrefs.SetString("win_message", "Todas as áreas chegaram a 80  \n" +
                         "Uma ótima administração, o vírus foi controlado.");
                        SceneManager.LoadScene(4);
                    }
                }
                break;                
            case 3:
                influence_politics_increased = 1;
                if (influence_politics + value > 100)
                {
                    influence_politics = 100;
                }
                else
                {
                    influence_politics += value;
                    if (influence_economy >= 80
                        && influence_health >= 80
                        && influence_politics >= 80
                        && influence_population >= 80
                        && influence_research >= 80)
                    {
                        PlayerPrefs.SetString("win_message", "Todas as áreas chegaram a 80  \n" +
                         "Uma ótima administração, o vírus foi controlado.");
                        SceneManager.LoadScene(4);
                    }
                }
                break;
            case 4:
                influence_population_increased = 1;
                if (influence_population + value > 100)
                {
                    influence_population = 100;
                    if (influence_health == 100)
                    {
                        PlayerPrefs.SetString("win_message", "Saúde e População chegaram a 100  \n" +
                            " O isolamento foi bem sucedido e os casos foram tratados.");
                        SceneManager.LoadScene(4);
                    }
                }
                else
                {
                    influence_population += value;
                    if (influence_economy >= 80
                        && influence_health >= 80
                        && influence_politics >= 80
                        && influence_population >= 80
                        && influence_research >= 80)
                    {
                        PlayerPrefs.SetString("win_message", "Todas as áreas chegaram a 80  \n" +
                         "Uma ótima administração, o vírus foi controlado.");
                        SceneManager.LoadScene(4);
                    }
                }
                break;
            case 5:
                influence_research_increased = 1;
                if (influence_research + value > 100)
                {
                    influence_research = 100;
                    if (influence_economy == 100)
                    {
                        PlayerPrefs.SetString("win_message", "Pesquisa e Economia chegaram a 100  \n" +
                            "A cura foi achada e temos recursos para distribuí-la.");
                        SceneManager.LoadScene(4);
                    }
                }
                else
                {
                    influence_research += value;
                    if (influence_economy >= 80
                        && influence_health >= 80
                        && influence_politics >= 80
                        && influence_population >= 80
                        && influence_research >= 80)
                    {
                        PlayerPrefs.SetString("win_message", "Todas as áreas chegaram a 80  \n" +
                         "Uma ótima administração, o vírus foi controlado.");
                        SceneManager.LoadScene(4);
                    }
                }
                break;

        }

    }
    public void decrease_influence(int influence_type, int value)
    {

        value *= -1;
        value *= 2;
        switch (influence_type)
        {
            case 1:
                influence_economy_increased = -1;
                if (influence_economy - value <=0 )
                {
                    influence_economy = 0;


                    if (influence_economy == 0)
                    {
                        PlayerPrefs.SetString("lose_message", "Economia chegou a 0  \n" +
                        "Sua cidade não tem mais recursos para investir.");
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    influence_economy -= value;
                    if (influence_economy <= 20
                        && influence_health <= 20
                        && influence_politics <= 20
                        && influence_population <= 20
                        && influence_research <= 20)
                    {
                        PlayerPrefs.SetString("lose_message", "Todas as áreas chegaram a 20  \n" +
                         "Uma péssima administração, o vírus causou uma anarquia social.");
                        SceneManager.LoadScene(3);
                    }

                }
                break;
            case 2:
                influence_health_increased = -1;
                if (influence_health - value <= 0)
                {
                    influence_health = 0;

                    if (influence_health == 0)
                    {
                        PlayerPrefs.SetString("lose_message", "Saúde chegou a 0  \n" +
                        "Todo o seu povo está contaminado.");
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    influence_health -= value;
                    if (influence_economy <= 20
                       && influence_health <= 20
                       && influence_politics <= 20
                       && influence_population <= 20
                       && influence_research <= 20)
                    {
                        PlayerPrefs.SetString("lose_message", "Todas as áreas chegaram a 20  \n" +
                         "Uma péssima administração, o vírus causou uma anarquia social.");
                        SceneManager.LoadScene(3);
                    }


                }
                break;                
            case 3:
                influence_politics_increased = -1;
                if (influence_politics - value <= 0)
                {
                    influence_politics = 0;

                    if (influence_politics == 0)
                    {
                        PlayerPrefs.SetString("lose_message", "Política chegou a 0  \n" +
                        "Sua péssima administração levou a ser deposto pelo povo.");
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    influence_politics -= value;
                    if (influence_economy <= 20
                       && influence_health <= 20
                       && influence_politics <= 20
                       && influence_population <= 20
                       && influence_research <= 20)
                    {
                        PlayerPrefs.SetString("lose_message", "Todas as áreas chegaram a 20  \n" +
                         "Uma péssima administração, o vírus causou uma anarquia social.");
                        SceneManager.LoadScene(3);
                    }


                }
                break;
            case 4:
                influence_population_increased = -1;
                if (influence_population - value <= 0)
                {
                    influence_population = 0;

                    if (influence_population == 0)
                    {
                        PlayerPrefs.SetString("lose_message", "População chegou a 0  \n" +
                        "A satisfação da população está péssima, problemas mentais são comuns agora.");
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    influence_population -= value;
                    if (influence_economy <= 20
                       && influence_health <= 20
                       && influence_politics <= 20
                       && influence_population <= 20
                       && influence_research <= 20)
                    {
                        PlayerPrefs.SetString("lose_message", "Todas as áreas chegaram a 20  \n" +
                         "Uma péssima administração, o vírus causou uma anarquia social.");
                        SceneManager.LoadScene(3);
                    }


                }
                break;
            case 5:
                influence_research_increased = -1;
                if (influence_research - value <= 0)
                {
                    influence_research = 0;

                    if (influence_research == 0)
                    {
                        PlayerPrefs.SetString("lose_message", "Pesquisa chegou a 0  \n" +
                        "A pesquisa foi descontinuada, será impossivel achar uma cura.");
                        SceneManager.LoadScene(3);
                    }
                }
                else
                {
                    influence_research -= value;
                    if (influence_economy <= 20
                       && influence_health <= 20
                       && influence_politics <= 20
                       && influence_population <= 20
                       && influence_research <= 20)
                    {
                        PlayerPrefs.SetString("lose_message", "Todas as áreas chegaram a 20  \n" +
                         "Uma péssima administração, o vírus causou uma anarquia social.");
                        SceneManager.LoadScene(3);
                    }


                }
                break;

        }

    }
}
