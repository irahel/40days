using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_hospital : MonoBehaviour
{
    public ArrayList hospital_questions;
    
    void Start()
    {
        hospital_questions = new ArrayList();
        hospital_questions.Add(new Question("Todos os profissionais da saúde estão assustados com a disseminação desse novo vírus, o que você vai fazer?",
         "Ignoro completamente.", 0, -5, 0, 0, 0, "",
         "Farei uma visita ao hospital.", 0, 0, 0, 2, 0, "",
         "Lançarei uma nota para acalmá-los.", 0, 0, 3, 3, 0, "",
         "Vou aumentar o salário deles.", -5, 5, 2, 0, 0, "",
         1));


        hospital_questions.Add(new Question("Os médicos dizem que vamos precisar de mais leitos de UTI para internar os pacientes, o que vamos fazer?",
        "Vamos construir um hospital!", -5, 3, 0, 0, 0, "",
        "Vamos liberar os paciente já internados com doenças simples.", 2, -2, 0, 0, 0, "",
        "Eu vou suspender as cirurgias e procedimentos desnecessários.", 0, 2, -2, -2, 0, "",
        "Já temos leitos de sobra!", 0, -5, 0, 0, 0, "",
        1));


        hospital_questions.Add(new Question("Temos muitos estudantes dentros dos hospitais. Eles estão com medo de serem infectados, o que faremos?",
        "O que eles estão fazendo aqui? Mandem eles para casa.", 0, 0, 3, 0, 0, "",
        "Eles também precisam ajudar.", 0, 3, -3, 0, 0, "",
        "Vamos liberar os que estão em grupo de risco.", 0, 5, 0, 0, 0, "",
        "Deixo eles decidirem.", 0, 0, -2, 0, 0, "",
        1));


        hospital_questions.Add(new Question("Nossa campanha de Vacinação para o vírus da gripe (H1N1) vai ser daqui a 2 semanas. Nós deveríamos antecipa-la?",
        "Claro! Vacinem todos!", 0, 5, 2, 0, 0, "",
        "Primeiro vacinem os profissionais da saúde.", 0, 2, 0, 0, 0, "",
        "Não vejo motivos para antecipar.", 0, -2, 0, 0, 0, "",
        "Vamos vacinar primeiro os idosos.", 0, 2, 0, 0, 0, "",
        2));


        hospital_questions.Add(new Question("Precisamos de Testes rápidos para diagnóstico dos pacientes suspeitos. Você vai fazer o que? ",
        "Precisamos comprar!", -3, 3, 0, 0, 0, "",
        "O que não sabemos...não existe.", 0, -3, 0, 0, 0, "",
        "Vamos mandar os pesquisadores produzir.", -2, +2, 0, 0, 2, "",
        "Testem todos as outras doenças. Se todos derem negativos...já sabemos o que é!", -10, 0, -2, 0, 0, "Testar todas as doenças exige muito mais testes do que testar apenas uma.",
        2));


        hospital_questions.Add(new Question("Alguns milionários da cidade querem doar respiradores mecânicos para o hospital!",
        "Vamos aceitar!", 5, 3, 0, 5, 0, "",
        "Não precisamos de respiradores agora. Vamos pedir EPIs.", 3, 5, 0, 5, 0, "",
        "Doem o dinheiro para o hospital.", 10, 2, 0, 0, 0, "",
        "Vamos pegar o dinheiro e investir em pesquisa para a cura.", 10, -2, 0, 0, 0, "",
        2));


        hospital_questions.Add(new Question("Começou a faltar máscaras dentro das unidades. O que devemos fazer?",
        "Vou comprar mais máscaras.", -3, 2, 0, 0, 0, "",
        "Suspendam os atendimentos.", 0, -5, -5, 0, 0, "",
        "Peçam para os estabelecimentos particulares doarem suas máscaras.", 2, 0, 0, -3, 0, "",
        "Reutilizem!", 0, -10, -5, 0, 0, "Máscaras descartáveis não podem ser reutilizadas",
        3));


        hospital_questions.Add(new Question("Alguns profissionais da saúde estão de férias nesse momento. Eles não deveriam está trabalhando nessa pandemia?",
        "Vamos cancelar essas férias.", 0, 3, -3, -2, 0, "",
        "Eles merecem descansar.", 0, -2, 2, 0, 0, "",
        "Vamos chamar apenas os mais jovens.", 0, 0, -2, 0, 0, "",
        "Vamos oferecer benefícios para quem voltar a trabalhar.", -3, 2, 2, 0, 0, "",
        3));


        hospital_questions.Add(new Question("Os profissionais da saúde querem criar uma área de isolamento apenas para pacientes com o novo Coronavírus. O que você gostaria de fazer?",
        "Claro. Liberem uma das alas do hospital.", 0, 3, 0, 0, 0, "",
        "Não é necessário no momento.", 0, -3, 0, 0, 0, "",
        "Vamos criar um hospital de campanha no estacionamento.", -3, 5, 0, 0, 0, "",
        "Escolham algumas salas.", 0, 0, 0, 0, 0, "",
        4));


        hospital_questions.Add(new Question("Está faltando Álcool em Gel para higienizar as mãos dos profissionais e pacientes. O que vamos fazer?",
        "Precisamos comprar mais!", -2, 2, 0, 0, 0, "",
        "Vamos pedir para as fábricas de cachaça mudarem o foco da produção.", 0, 0, -2, 0, 0, "",
        "Envie água e sabão!", 0, 0, 0, -3, 0, "",
        "Ainda estou resolvendo o problema das máscaras.", 0, -2, 0, -2, 0, "",
        4));


        hospital_questions.Add(new Question("Os médicos estão trabalhando muito e estão começando a ficar cansados. Como podemos ajudá-los?",
        "Eles que escolheram essa profissão…", 0, 0, -2, -2, 0, "",
        "Convoquem mais médicos!", -5, 5, 0, 0, 0, "",
        "Vamos convocar estudantes de medicina para ajudar.", 0, 3, 0, 0, 0, "",
        "Vamos melhorar os ambientes de descanso.", -2, 0, 2, 0, 0, "",
        5));


        hospital_questions.Add(new Question("Muitos pacientes estão procurando assistência médica nesse momento. Não podemos atender a todos.",
        "Todos devem ser atendidos!", -2, -2, 0, 0, 0, "",
        "Vamos fazer triagem dos casos leves e envia-los para casa.", 2, 2, 0, 0, 0, "",
        "Mandem todos para casa.", 5, -10, 0, 0, 0, "",
        "Testem todos e atendem apenas os infectados.", 0, 3, 3, 0, 0, "",
        5));



    }


}
