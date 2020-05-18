using System.Collections;
using System.Collections.Generic;


public class Question
{    
    public string enunciated;

    public string awn_1;
    public Influence_modification influence_awn_1 = new Influence_modification();
    public string phrase_1;

    public string awn_2;
    public Influence_modification influence_awn_2 = new Influence_modification();
    public string phrase_2;

    public string awn_3;
    public Influence_modification influence_awn_3 = new Influence_modification();
    public string phrase_3;

    public string awn_4;
    public Influence_modification influence_awn_4 = new Influence_modification();
    public string phrase_4;

    public int week;

    public Question(string title,
        string awns_1, int awn_1_economy, int awn_1_health, int awn_1_population, int awn_1_politics, int awn_1_research, string solver_1,
        string awns_2, int awn_2_economy, int awn_2_health, int awn_2_population, int awn_2_politics, int awn_2_research, string solver_2,
        string awns_3, int awn_3_economy, int awn_3_health, int awn_3_population, int awn_3_politics, int awn_3_research, string solver_3,
        string awns_4, int awn_4_economy, int awn_4_health, int awn_4_population, int awn_4_politics, int awn_4_research, string solver_4,
        int week_to_go)
    {
        phrase_1 = solver_1;
        phrase_2 = solver_2;
        phrase_3 = solver_3;
        phrase_4 = solver_4;

        enunciated = title;

        awn_1 = awns_1;
        influence_awn_1.modification_economy = awn_1_economy;
        influence_awn_1.modification_health = awn_1_health;
        influence_awn_1.modification_population = awn_1_population;
        influence_awn_1.modification_politics = awn_1_politics;
        influence_awn_1.modification_research = awn_1_research;

        awn_2 = awns_2;
        influence_awn_2.modification_economy = awn_2_economy;
        influence_awn_2.modification_health = awn_2_health;
        influence_awn_2.modification_population = awn_2_population;
        influence_awn_2.modification_politics = awn_2_politics;
        influence_awn_2.modification_research = awn_2_research;

        awn_3 = awns_3;
        influence_awn_3.modification_economy = awn_3_economy;
        influence_awn_3.modification_health = awn_3_health;
        influence_awn_3.modification_population = awn_3_population;
        influence_awn_3.modification_politics = awn_3_politics;
        influence_awn_3.modification_research = awn_3_research;

        awn_4 = awns_4;
        influence_awn_4.modification_economy = awn_4_economy;
        influence_awn_4.modification_health = awn_4_health;
        influence_awn_4.modification_population = awn_4_population;
        influence_awn_4.modification_politics = awn_4_politics;
        influence_awn_4.modification_research = awn_4_research;

        week = week_to_go;
    }

}
