using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_bank : MonoBehaviour
{
    public ArrayList bank_questions;

    void Start()
    {
        bank_questions = new ArrayList();
        bank_questions.Add(new Question("As pessoas da cidade começaram a ficar com medo da disseminação desse novo vírus e correram para as agências bancárias em busca de retirar o dinheiro guardado. Assim nós vamos quebrar...",
        "O dinheiro é deles...O que posso fazer?", -5, -2, 2, 0, 0, "Infelizmente todos correram ao mesmo tempo para tirar todo o dinheiro que tinham guardado, e isso causou aglomeração, além de travar um pouco à circulação do dinheiro no banco.","Fechem todas as agências.",5,0,-10,0,0,"",
        "Vamos restringir a quantidade de dinheiro por saque a 1000 reais.",2,0,-2,0,0,"",
        "Vamos diminuir o horário de funcionamento das agências.",-3,2,-2,2,0,"",
        1));



        bank_questions.Add(new Question("A famosa Feira de Importados da nossa cidade estava marcada para próxima semana. Vamos mantê-la?",
        "Vamos adia-la para outra ocasião.", 0, 0, 0, 0, 0, "",
        "Vamos mantê-la. Essa feira rende muito lucro!", 10, -10, 0, 0, 0, "",
        "Vamos cancelar o evento.", -2, 0, -2, 0, 0, "",
        "Vamos fazer uma amostra com os produtos online.", 5, 0, 0, 0, 0, "",
        1));


        bank_questions.Add(new Question("Os empresários estão reclamando porque os funcionários não querem trabalhar e querem continuar recebendo salário. O que você acha disso?",
        "Botem esses vagabundos para trabalhar.", 5, -5, -5, 0, 0, "",
        "Diminuam a jornada de trabalho.", -2, 0, 0, 0, 0, "",
        "Continuem trabalhando. Mas, tomem cuidado com a prevenção.", 0, -2, 0, 0, 0, "",
        "Cessem os trabalhos. Vamos ajudar a pagar os salários.", -5, 0, 3, 0, 0, "",
        1));


        bank_questions.Add(new Question("Os nossos fornecedores de insumos para a indústria parou de enviar matéria-prima por conta das medidas de contenção das cidades vizinhas. O que vamos fazer agora?",
        "Procurem outros fornecedores próximos.", 3, 0, 0, 0, 0, "",
        "Parem as máquinas de produção.", -3, 0, 0, 0, 0, "",
        "Procurem uma forma de produzir esses insumos aqui!", 2, 0, 0, 0, 0, "",
        "Vou ligar para esses fornecedores e negociar.", 0, 0, 0, 0, 0, "",
        2));


        bank_questions.Add(new Question("As pessoas estão reclamando do seu salário e do luxo dos vereadores. Temos que tomar uma decisão com relação a isso!",
        "Nós estamos cuidando de tudo enquanto vocês estão em casa.", 0, 0, -3, 0, 0, "",
        "Tá certo. Vamos diminuir os luxos dos vereadores.", 5, 0, 2, -5, 0, "",
        "Eu vou diminuir o meu próprio salário.", 2, 0, 2, 0, 0, "",
        "Finjo demência.", 0, 0, -5, -5, 0, "",
        2));


        bank_questions.Add(new Question("O banco da cidade foi roubado ontem a noite. Os ladrões levaram mais de 500.000 reais em espécie. Agora nós estamos falidos de verdade.",
        "Os policiais não podem parar enquanto não encontrarem esse dinheiro.", 10, -3, 0, 0, 0,"Alguns policiais foram contaminados por ainda estarem trabalhando… mas felizmente acharam os bandidos, e eles tinha roubado mais coisas",
        "Não posso fazer nada com relação a isso.", -10, 0, 0, -10, 0, "",
        "Eu disse que éramos pra ter investido em Bitcoins.", -10, 0, 0, -5, 0, "",
        "Vamos pedir dinheiro emprestado.", 5, 0, 0, -5, 0, "",
        2));


        bank_questions.Add(new Question("Nós estamos tendo muitos gastos com as medidas de prevenção para a infecção. Se continuarmos assim vamos falir. Você tem que tomar uma decisão.",
        "Vamos cortar gastos desnecessários.", 5, 0, -2, 0, 0, "",
        "Vamos salvar as pessoas depois salvamos a economia.", -5, 5, 0, 5, 0, "",
        "Vamos pedir empréstimos de fora.", 3, 0, 0, -5, 0, "",
        "Vamos taxar os milionários.", 10, 0, 0, -10, 0, "",
        3));


        bank_questions.Add(new Question("Os fundos para produção de álcool aumentaram consideravelmente por causa de doações. Agora temos álcool em gel sobrando. O que eu devo fazer com isso?",
        "Mandem o excedente para os hospitais.", 0, 5, 0, 0, 0, "",
        "Vamos vender álcool para as cidades vizinhas.", 5, 0, 0, 3, 0, "",
        "Distribuam para a população.", 0, 5, 5, 0, 0, "",
        "Vamos guardar. Manter um estoque sempre é bom.", 2, 0, 0, 5, 0, "",
        3));


        bank_questions.Add(new Question("Uma empresa de reciclagem quer produzir protetores de face com garrafas PET. Porém, eles precisam de máquinas. O que você aconselha?",
        "Já temos máscaras de sobra.", 3, -2, 0, -2, 0, "",
        "Vamos pedir algumas máquinas ociosas de outros setores da indústria.", 2, 3, 0, 2, 0, "",
        "Vamos patrocinar esse projeto.", -5, 2, 0, 3, 0, "",
        "Usem trabalho manual.", 0, 0, 0, -3, 0, "",
        4));


        bank_questions.Add(new Question("Com a diminuição do fluxo de pessoas nas lojas, muitos pequenos empresários estão a beira da falência. O que vamos fazer?",
        "Vamos deixar o fluxo normal do mercado cuidar disso.", -2, 0, -5, 0, 0, "",
        "Ofereçam empréstimos a eles.", -5, 0, 5, 0, 0, "",
        "Vamos bancar as despesas deles durante esse período.", -10, 0, 10, 0, 0, "",
        "Estimulem as pessoas a sair de casa e comprar mais.", 5, -3, 0, -2, 0, "",
        4));


        bank_questions.Add(new Question("O gerente do banco geral está doente. Ele viajou recentemente para o exterior em busca de aprimoramento nos negócios internacionais e agora está com febre, tosse e coriza. O que vamos fazer?",
        "Vamos afastá-lo de suas atribuições temporariamente.", -3, 2, 0, 0, 0, "",
        "Isso é apenas um resfriado. O banco não pode ficar sem o seu gerente!", 0, -2, 0, 0, 0, "",
        "Isolem o banco geral e cessem as atividades temporariamente.", -10, 2, 0, 0, 0, "",
        "Mandem ele trabalhar em Home office.", 5, 2, -2, 0, 0, "",
        5));


        bank_questions.Add(new Question("Muitas pessoas foram contaminadas pelo vírus e estão precisando de UTI. Os custos com esses pacientes são altos. O que vamos fazer agora?",
        "Não podemos fazer nada. Os paciente precisam ser atendidos.", -5, 2, 0, 0, 0, "",
        "Vamos investir em quem tem mais chance de sobreviver.", 3, 0, -3, 0, 0, "Priorizar pacientes em estados graves que tem mais chance de sobreviver, é difícil, mas é à escolha certa a se fazer.",
        "Não vamos aceitar mais pacientes.", 3, 0, -10, 0, 0, "",
        "Eu não sei o que fazer.", -5, 0, -5, -5, 0, "",
        5));


    }


}
