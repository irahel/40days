using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_mediacenter : MonoBehaviour
{
    public ArrayList media_questions;

    void Start()
    {
        media_questions = new ArrayList();
        media_questions.Add(new Question("Uma famoso jornal da cidade chamado “A População” chamou você para dar uma entrevista sobre as medidas a serem tomadas. Qual a sua resposta?",
         "Sim. Claro que vou!", 0, 0, 2, 2, 0, "",
         "Chamem um especialista na área.", 0, 2, 2, 0, 0, "",
         "Não posso. Tenho muitos problemas para resolver.", 0, 0, 0, -3, 0, "",
         "Vou mandar meu secretário.", 0, 0, 2, -2, 0, "",
         1));


        media_questions.Add(new Question("A população está com muitas dúvidas sobre como lavar as mãos corretamente. O que você acha disso?",
        "Quem não sabe lavar as mãos?", 0, 0, -2, 0, 0, "",
        "Chamem o Dr. Dionísio Varella para ensiná-los.", 0, 2, 0, 0, 0, "",
        "Eu vou ensinar vocês. É assim ó.", 0, 0, 0, 0, 0, "",
        "Isso não não é importante agora.", 0, -2, 0, -2, 0, "",
        1));


        media_questions.Add(new Question("Um pequeno jornal local está começando a divulgar informações falsas sobre o vírus. O que você fará com relação a isso?",
        "Não vejo problemas com isso.", 0, -3, -3, 0, 0, "",
        "Mandem prender os responsáveis!", 0, 0, -2, 3, 0, "",
        "Eu não posso interferir na mídia.", 0, -3, 0, 0, 0, "",
        "Vamos incentivar os outros jornais a desmentir essas notícias.", 0, 3, 0, 0, 0, "",
        1));


        media_questions.Add(new Question("Um Físico renomado da cidade fez um cálculo de progressão dessa doença. Os resultados mostraram que 90% da população vai morrer independente das nossas medidas. Estamos desesperados!",
        "Acho que ele errou um pouco os cálculos. Peça para ele refazer.", 0, 0, 5, 5, 0, "",
        "Fiquem calmos. Físicos não entendem de saúde.", 0, 0, 2, -3, 0, "",
        "Meu Deus! Se isso for verdade estamos perdidos.", 0, 0, -10, 0, 0, "Transmitir insegurança e desespero causa instabilidade emocional e pânico na população",
        "Vamos perguntar a Universidade.", 0, 0, 5, 2, 0, "",
        2));


        media_questions.Add(new Question("Você está navegando em uma rede social e vê que os médicos estão fazendo uma campanha na internet. Eles estão tirando fotos com a seguinte frase: *Nós estamos aqui por vocês. Fiquem em casa por nós.*",
        "Rolo o feed sem nenhuma reação.", 0, 0, 0, 0, 0, "",
        "Dou um coraçãozinho na imagem.", 0, 0, 0, 0, 0, "",
        "Compartilho a imagem com a #FiqueEmCasa.", 0, 0, 2, 0, 0, "",
        "Denuncio a imagem.", 0, 0, -2, 0, 0, "",
        2));


        media_questions.Add(new Question("Seu cônjuge tem certa influência nas mídias e está pedindo a sua opinião para gravar alguns vídeos para ajudar os seus seguidores. O que você acha?",
        "Acho que ele não deveria se envolver nesses problemas.", 0, 0, 0, 0, 0, "",
        "É uma ótima ideia.", 0, 0, 3, 0, 0, "",
        "Qual é o conteúdo desses vídeos?", 0, 3, 3, 0, 0, "Se certificar que as informações que você transmite são verídicas e úteis antes de transmiti - las é um ótimo passo para ajudar o próximo no combate à uma doença contagiosa.",
        "Acho que ele é adulto o bastante para decidir isso sozinho!", 0, 0, 0, 0, 0, "",
        2));


        media_questions.Add(new Question("Uma notícia nas redes sociais diz que a droga chamada “loló” tem eficácia contra o Coronavírus. O que você acha?",
        "Eu acho que é Fake.", 0, 0, 2, 0, 0, "",
        "Vamos enviar amostras para a universidade.", 0, 0, 0, 2, 3, "",
        "O que é loló?", 0, 0, 0, 0, 0, "",
        "Tenho problemas maiores agora.", 0, 0, 0, -2, 0, "",
        3));


        media_questions.Add(new Question("Devido às pesquisa recentes sobre uma droga que provavelmente tem eficácia contra o novo Coronavírus, muitas pessoas correram para comprá-la nas farmácias. Isso reduziu os estoques e fez com que o medicamento faltasse para os usuários antigos. A mídia solicita a  sua opinião.",
        "Pergunte a universidade!", 0, 0, 0, -5, 2,"Se esquivar de perguntas da mídia desviando à responsabilidade e não compartilhando sua opinião irrita a opinião política com relação a você",
        "Vamos restringir a venda do medicamento. Só 1 caixa por CPF.", 0, 0, 0, 5, 0, "",
        "Não temos estudos para comprovar a eficácia dessa droga. Evite comprar.", 0, 3, -2, 0, 0, "",
        "Eu já garanti as minhas caixas. Garantam a sua antes que acabe!", 0, -10, 0, -5, 0, "Incentivar à compra de medicamento não devidamente testado e incentivar o egoísmo causa caos na opinião política e deixa os doentes que realmente precisam do remédio à mercê de consequências graves",
3));


        media_questions.Add(new Question("Um jornal local quer entrar com uma equipe de jornalistas dentro do hospital para acompanhar os casos em tempo real. Precisam da sua autorização.",
        "Claro que sim! A população merece ser informada em tempo real.", 0, -2, 2, -2, 0, "Apesar de deixar à população informada em tempo real, colocar profissionais que não são da área da saúde em hospitais com doença altamente contagiosa não é uma boa escolha e pode ajudar a disseminar o vírus",
        "Não. O hospital não é local para isso.", 0, 0, 0, 3, 0, "",
        "Eu permito a entrada de 1 jornalista e 1 câmera.", 0, 0, 0, 5, 0, "",
        "O que os médicos acham disso?", 0, 0, 0, 0, 0, "",
        4));


        media_questions.Add(new Question("Um paciente caso suspeito que deveria estar em isolamento está nesse momento dando uma entrevista em plena rede nacional. O que você faz?",
        "Não vejo problema nisso.", 0, -2, 0, -3, 0, "",
        "Vou enviar a polícia para acabar com isso.", 0, 0, -3, 0, 0, "",
        "Ele está de máscara?", 0, 0, 0, 0, 0, "",
        "Vou ligar para o dono da emissora e pedir para acabar com o programa.", 0, 0, -2, 0, 0, "",
        4));


        media_questions.Add(new Question("A notícia de que o seu cônjuge está infectado pelo novo vírus começou a circular em alguns sites de notícias locais. O que você faz com relação a isso.",
        "Vou lançar uma nota de esclarecimento tranquilizando a população.", 0, 0, 2, 0, 0, "",
        "Mandem derrubar todos esse sites.", 0, 0, -5, 0, 0,"Derrubar veículos que transmitem informações falsas sem desmentir as informações causa dúvidas na população",
        "Vou ligar para meu amigo editor de jornal e pedir para desmentir as notícias.", 0, 0, 3, 0, 0, "",
        "Eu não me preocupo com Fake News.", 0, 0, -2, -3, 0, "",
        5));


        media_questions.Add(new Question("Você tossiu algumas vezes durante um pronunciamento importante. Agora todos os jornais  estão especulando que você está infectado. O que você vai fazer?",
        "Vou fazer o maldito teste para desmentir eles.", 0, 0, 3, 2, 0, "",
        "Lançarei uma nota informando que sou um atleta.", 0, 0, -3, 0, 0, "",
        "Vou procurar o hospital da cidade.", 0, -2, 0, 3, 0, "",
        "A partir de hoje vou entrar em quarentena.", 0, 0, 2, 0, 0,"Entrar em quarentena como medida preventiva pelos outros é bom, porém lembre - se sempre de se certificar se possui o vírus se persistir em sintomas.",
        5));



    }


}
