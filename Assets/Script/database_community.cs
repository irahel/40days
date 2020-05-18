using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class database_community : MonoBehaviour
{
    public ArrayList community_questions;
    
    void Start()
    {
        community_questions = new ArrayList();
        community_questions.Add(new Question("As pessoas estão questionando sobre a segurança da população com relação a disseminação desse novo vírus. O que você fará?",
        "Tudo está sob controle do seu líder.", 0, 0, -2, 0, 0, "",
        "Todas as medidas necessárias estão sendo tomadas.", 0, 0, 2, 0, 0, "",
        "Esse vírus não é uma ameaça para vocês.", 0, -2, 0, 0, 0, "",
        "Cada um é responsável pela sua própria segurança. Não podemos dar conta de tudo.", 0, 0, -2, -5, 0, "",
        1));


        community_questions.Add(new Question("O conselho comunitário está convidando você para uma reunião no centro comunitário para discutir as medidas a serem tomadas. Estão pedindo a confirmação da sua presença.",
        "Não posso. Minha agenda está lotada.", 0, 0, -5, -3, 0, "",
        "Claro! Precisamos dialogar.", 0, 0, 3, 5, 0, "",
        "Eu tenho capacidade para lidar com isso sozinho.", 0, 0, -3, 0, 0, "",
        "Chamem os vereadores da cidade.", 0, 0, -2, -2, 0, "",
        1));


        community_questions.Add(new Question("A população está organizando uma marcha contra o Coronavírus e estão pedindo o seu apoio. Você vai às ruas contra esse novo inimigo?",
        "Vamos às ruas contra essa peste.", -5, -10, 0, 0, 0,"Ao aglomerar pessoas você causou à transmissão acelerada do vírus e incapacitou várias pessoas de suas funções de sociais.",
        "Acho melhor fazer uma carreata.",0,0,3,0,0,"",
        "Nós temos que ficar em casa.",0,2,0,0,0,"",
        "Minha agenda está lotada. Mas, vou enviar um representante.",-5,-10,-5,-3,0,"Ao aglomerar pessoas você causou à transmissão acelerada do vírus e incapacitou várias pessoas de suas funções de sociais.",
        1));


        community_questions.Add(new Question("Os moradores de rua estavam perguntando porque tem tanta gente de máscara na rua. Agora eles estão se concentrando no centro comunitário da cidade para se proteger da doença. O que devemos fazer?",
        "Procurem o líder comunitário!", 0, 0, -2, -2, 0, "",
        "Dispersem todos. Mande-os para casa... ou rua.", 0, -2, -5, -5, 0, "",
        "Vamos dar algumas máscaras para eles e resolver o problema.", 0, -2, 2, 0, 0, "",
        "Recebam eles e ofereçam materiais de higiene pessoal.", 0, 3, 5, 3, 0, "",
        2));


        community_questions.Add(new Question("Um dos bairros pobre da cidade está sem água. Os moradores estão furiosos porque não consegue tomar banho, muito menos lavar as mãos com sabão. Temos que tomar uma providência.",
        "Façam racionamento.", 0, -3, -3, -2, 0, "",
        "Vou demitir algumas pessoas responsáveis por isso.", 2, -2, 2, 0, 0, "",
        "Desviem parte da água da região nobre da cidade.", 0, 3, 5, -2, 0, "",
        "Diminuam a produção industrial para economizar água.", -5, 2, 0, 0, 0, "",
        2));


        community_questions.Add(new Question("Um líder comunitário conhecido da cidade está oferecendo o centro comunitário da cidade para hospedar os pacientes suspeitos de estarem infectados com esse novo vírus. O que você acha dessa idéia.",
        "Acho uma ótima ideia!", 0, -5, 3, 0, 0,"Ao aglomerar casos suspeitos no Centro comunitário, e sem profissionais especializados você faz com que os casos negativos do vírus, se tornem positivos e aumenta à transmissão.",
"Vamos evitar aglomerações.",0,0,2,0,0,"",
"Sim e vou mandar enviar alguns EPI’s para ajudar.",0,-2,5,3,0,"",
"Esse pseudolíder deveria ser preso.",0,0,-10,-5,0,"Nunca se deve censurar à voz do povo sem antes corrigi - la, isso causa instabilidade e descontentamento.",
2));


        community_questions.Add(new Question("As lojas e a indústria continuam em funcionamento. O movimento frenético de pessoas pode facilitar a transmissão do vírus. O que devemos fazer?",
        "Suspendam todas as atividades.", -10, 5, -5, 0, 0, "",
        "Vamos manter os serviços essenciais.", -5, 3, 2, 0, 0, "",
        "Não podemos parar o comércio e a indústria. Nós vamos quebrar!", 5, -10, 0, 0, 0, "",
        "Vamos deixar a critério dos lojistas e empresários.", -3, -3, 0, 0, 0, "",
        3));


        community_questions.Add(new Question("As pessoas estão se questionando quando devem procurar a assistência médica. O que você tem para dizer?",
        "Quando estiverem doentes.", 0, -2, 2, 0, 0, "",
        "Sigam as instruções dos profissionais na área.", 0, 3, 2, 0, 0, "",
        "Evitem as aglomerações.", 0, 0, -2, 0, 0, "",
        "Quando estiverem com sintomas graves.", 0, 5, 0, 0, 0, "",
        3));


        community_questions.Add(new Question("A campanha de vacinação para o H1N1 começou e o centro comunitário ficou lotado no primeiro dia de aplicação das vacinas. A grande maioria são idosos entre 60 e 80 anos. Devemos interferir?",
        "Sim. Suspendam essa campanha.", 0, 0, -3, 0, 0, "",
        "Não. Precisamos vacina-los.", 0, 0, 2, 0, 0, "",
        "Sim. Dividam os dias de vacina por faixa etária.", 0, 2, 3, 0, 0, "",
        "Sim. Vacinem todos em casa.", -3, 5, 2, 0, 0, "",
        4));


        community_questions.Add(new Question("A população decidiu ficar em casa por alguns dias por conta do medo que gera a presença desse vírus na cidade. Muitos estão ansiosos e tristes. O que podemos fazer?",
        "Vamos entregar alguns medicamentos para acalmá-los.", -5, 3, 5, 0, 0, "",
        "Vou falar com a mídia para oferecer entretenimento de qualidade.", -2, 2, 3, 0, 0, "",
        "É um sacrifício a se fazer em tempos extremos.", -2, 0, -2, -2, 0, "",
        "Sugiro que saiam para passear 1 vez por semana.", 2, -5, 3, 0, 0, "",
        4));


        community_questions.Add(new Question("A casa de acolhimento da cidade  abriga aproximadamente 120 idosos em sua estalagens. O administradores estão pedindo ajuda para evitar que eles sejam infectados. Qual a sua resposta?",
        "Vou enviar alguns materiais de proteção individual.", 0, 3, 3, 0, 0, "",
        "Levem alguns dos idosos para o centro comunitário.", 0, -2, 2, 0, 0, "",
        "Não posso ajudar no momento. Tenho muitos problemas para resolver.", 3, -3, 0, -3, 0, "",
        "Isolem a instituição. Impeçam a circulação  de pessoas dentro do lar.", 0, 3, -3, 0, 0, "",
        5));


        community_questions.Add(new Question("O Centro Comunitário quer ajudar na produção de algumas máscaras de tecido para ajudar a população e estão solicitando a sua ajuda. Qual a sua resposta?",
        "Gostei da ideia. Take my money!", -2, 2, 0, 0, 0, "",
        "Essas máscaras não servem para nada. Esqueçam isso!", 2, 0, -2, 0, 0, "",
        "Certo. Mas, essas máscaras só servem para os doentes.", 0, 3, 0, 0, 0, "",
        "Vou recrutar alguns voluntários.", -2, 2, 2, 0, 0, "",
        5));


    }


}
