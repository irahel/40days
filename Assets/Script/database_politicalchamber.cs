using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_politicalchamber : MonoBehaviour
{
    public ArrayList Political_questions;
    //economia -> saude -> população -> politica -> pesquisa
    void Start()
    {
        Political_questions = new ArrayList();
        Political_questions.Add(new Question("Um novo vírus começou a circular no Brasil. O que se sabe é que ele se transmite facilmente, porém sua letalidade é baixa. Você acha que estamos em risco?",
            "Mantenha a calma. Nossa cidade está segura.", 0, -3, 2, 2, 0, "",
            "É só uma gripezinha.", 0, -3, 0, 0, 0, "",
            "Vou pensar em medidas de contenção para esse vírus.", 0, 0, 2, 5, 0, "",
            "Não consigo opinar ainda.", 0, 0, 0, -3, 0, "",
            1));

        Political_questions.Add(new Question("As cidades vizinhas estão registrando casos do novo Coronavírus. Eles estão iniciando medidas de contenção. Será que devemos nos preocupar?",
            "Ainda é cedo.", 0, -3, 2, 0, 0, "",
            "Vamos iniciar algumas medidas de contenção.", 0, 2, -2, 0, 0, "",
            "Quando tivermos algum caso confirmado nós pensamos no assunto.", 0, 0, 2, 2, 0, "",
            "Fechem todas as fronteiras.", 0, 3, -5, -5, 0, "",
            1));

        Political_questions.Add(new Question("Um morador de uma cidade vizinha apareceu no hospital com tosse, coriza e febre. Ele disse que veio de Madagascar há poucos dias. O que vamos fazer com ele?",
            "Mandem ele de volta para Madagascar!", 0, 0, -2, -2, 0, "",
            "Vamos interná-lo no  hospital e mantê-lo em isolamento.", 0, 0, 0, 0, 0, "",
            "Vamos colocá-lo em quarentena na casa dele.", 0, 0, 2, 0, 0, "",
            "Madagascar não tem casos confirmados. Entreguem umas dipironas.", 0, -2, 0, 0, 0, "só porque um lugar não possui casos confirmados, não significa que esse lugar não possui casos.",
            1));

        Political_questions.Add(new Question("As pesquisas mostraram que apenas os Idoso morrem por causa desse vírus. O que você acha?",
           "Devemos proteger os nossos sexagenários.", 0, 2, 3, 5, 0, "",
           "Por que não disseram isso antes?", 0, -2, -2, 0, 0, "",
           "Isso não muda nada.", 0, 0, 0, 0, 0, "",
           "Vamos isolar só eles então! ", 0, -3, 0, 0, 0, "Só por que apenas os idosos morrem, isolar apenas eles não contém o avanço da doença.",
           2));

        Political_questions.Add(new Question("O aeroporto da cidade está funcionando. Muitos dos nossos habitantes viajam para o exterior. O que devemos fazer?",
           "Vamos parar apenas as viagens internacionais.", 0, -2, 0, 3, 0, "",
           "O aeroporto não pode parar.", 0, -5, 3, -2, 0, "",
           "Eu tenho uma viagem para Disney próximo mês.", 0, -5, 0, -10, 0, "",
           "Fechem o aeroporto agora!", 0, 0, -5, 2, 0, "",
           2));

        Political_questions.Add(new Question("Estão querendo fechar nossas escolas para proteger os moradores dessa doença. O que você acha?",
           "Não tem motivos para isso. As crianças não morrem dessa doença. ", 0, -3, 0, -3, 0, "",
           "Faz sentido. Crianças brincam com os avós.", 0, 3, 0, 3, 0, "",
           "Não. Fechar o Lar dos Idosos faz mais sentido.", 0, -3, -2, -5, 0, "",
           "Deixo para os diretores decidirem. ", 0, -2, 0, -2, 0, "",
           2));

        Political_questions.Add(new Question("Nós tivemos os primeiros casos da doença confirmados. Devemos pensar em mais medidas de contenção agora?",
           "Sim. Vamos apenas fechar as fronteiras da cidade. ", 0, 2, 2, 5, 0, "",
           "Sim. Vamos colocar toda a população de quarentena.", 0, 3, -3, 5, 0, "",
           "Não. São poucos casos para nossa enorme população.", 0, -5, 0, -3, 0, "",
           "Não. Nossa maravilhosa cidade não pode parar.", 0, -5, 0, -5, 0, "",
           3));

        Political_questions.Add(new Question("Os milionários da cidade estão te ligando para reservar leitos na UTI. Qual resposta eles merecem?",
          "Claro. Seu leito já está reservado Senhor.", 0, 0, -10, 5, 0, "A maioria da população não gosta dos privilégios dos ricos, mas eles têm influência na política.",
          "Não posso fazer isso. Não temos leitos o suficiente.", 0, 0, 0, -3, 0, "",
          "Tá achando que é hotel?", 0, 0, 2, -5, 0, "",
          "Se você sentir algo procure o hospital. Antes disso não podemos fazer nada.", 0, 0, 0, 0, 0, "",
          3));

        Political_questions.Add(new Question("A câmara dos vereadores está querendo suspender as atividades por tempo indeterminado. O que você acha dias?",
          "E quem vai me ajudar a administrar a cidade?", 0, -2, 0, 2, 0, "",
          "Acho uma boa ideia. Deixem que eu cuido de tudo.", 3, 2, 0, -2, 0, "",
          "Acho melhor diminuir a frequência das audiências.", 2, 0, 0, 2, 0, "",
          "Acho que deveríamos liberar apenas os vereadores com mais de 60 anos.", 0, 2, 0, 0, 0, "",
          4));

        Political_questions.Add(new Question("Um vereador da cidade fez algumas postagens em uma rede social criticando a sua postura com relação a nova epidemia de Coronavírus. Qual é a sua conduta?",
          "O que vem de baixo não me atinge.", 0, 0, 0, -2, 0, "",
          "Estou fazendo o meu melhor. Desculpe se não estou agradando. ", 0, 0, 0, 0, 0, "",
          "Acho que ele deveria se preocupar com o trabalho dele.", 0, 0, 0, 0, 0, "",
          "Vou processar ele! Liguem para os meus advogados.", 0, 0, 0, -3, 0, "",
          4));

        Political_questions.Add(new Question("O seu cônjuge está com vômitos e diarréia. O que vamos fazer?",
          "Meus Deus! Levem-o para o Hospital.", 0, 0, 0, 0, 0, "",
          "Ele está bem. Só precisa de atenção. S2.", 0, 0, 0, 0, 0, "",
          "Ele é um atleta! Vai ficar tudo bem.", 0, -1, 0, 0, 0, "",
          "Chamem um médico para atendê-lo em casa.", 0, 0, -3, 0, 0, "",
          5));

        Political_questions.Add(new Question("Durante uma visita ao hospital da cidade para demonstrar sua preocupação com a saúde da população um dos paciente correu e te abraçou em um ato de amor incondicional. Qual é a sua reação?",
          "Mantenho a postura e abraço o homem.", 0, -3, 0, +5, 0, "",
          "Peço para ele manter a distância por medida de precaução.", 0, +3, 0, 0, 0, "",
          "Eu corro!", 0, 0, 0, -3, 0, "",
          "Seguranças! Contenham esse homem.", 0, -5, 0, -3, 0, "",
          5));



    }

}
