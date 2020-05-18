using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_university : MonoBehaviour
{
    public ArrayList university_questions;
    void Start()
    {
        university_questions = new ArrayList();
        university_questions.Add(new Question("Os estudiosos da universidade estão querendo mudar o nome do Coronavírus para COVID-19. O que você acha dessa proposta?",
        "Que seja COVID-19 então. O outro nome era impreciso.", 0, 0, 0, 0, 2, "",
        "Não importa o nome.", 0, 0, 0, 0, 0, "",
        "Isso vai melhorar a comunicação de informações.", 0, 0, 0, 0, 3, "",
        "Vou me referir a ele com o nome anterior.", 0, 0, 0, 0, -2, "",
        1));


        university_questions.Add(new Question("Os cientistas da Universidade estão preocupados com a circulação de pessoas nas rodovias que cortam a nossa cidade. O que você dirá a eles?",
        "Não vamos fechar as estradas da cidade por causa de um vírus.", 0, -3, 2, 0, 0, "",
        "Vou entrar em contato com os policiais rodoviários. Fecharemos as rodovias.", 0, 3, -2, 3, 0, "",
        "Vamos limitar o fluxo. Apenas 1 carro a cada 100m.", 0, 2, 0, 3, 0, "",
        "Vamos aumentar o pedágio para carros pequenos e ônibus.", 3, 0, -3, 2, 0, "",
        1));


        university_questions.Add(new Question("O Reitor da Universidade pediu para você fazer uma visita ao laboratório de pesquisa para mostrar as instalações e debater algumas medidas. Qual a sua resposta?",
        "Vou ver e te aviso.", 0, 0, -2, -3, 0, "",
        "Eles guardam as amostras do vírus lá?", 0, 0, 0, -2, 0, "",
        "O Reitor que venha até mim.", 0, 0, 0, -3, 0, "",
        "Claro. Vamos lá!", 0, 0, 0, 2, 3, "",
        1));


        university_questions.Add(new Question("Uma droga usada para o tratamento de outras doenças mostrou ser efetiva contra o Coronavírus. Apenas testes em laboratório foram realizados. Você viu essa notícia?",
        "Sim. Vamos investir em mais pesquisa.", -3, 0, 0, 0, 5, "",
        "Sim. Vamos comprar e enviar para o hospital.", -2, -2, 3, 0, 0,"Usar medicamentos não devidamente testados pode causar efeitos colaterais desconhecidos.",
        "Não. Mas, precisamos esperar mais pesquisas.", 0, 0, 0, 0, 0, "",
        "O vírus se cura sozinho.", 2, -3, 0, 0, 0, "",
        2));


        university_questions.Add(new Question("A universidade criou um site para divulgar suas pesquisas e combater notícias falsas. Eles pedem que você ajude divulgando esse site. Qual é sua resposta?",
        "Vou gravar um vídeo ainda hoje para ajudá-los.", 0, 2, 2, 0, 3, "Tornar as informações sobre pesquisa mais transparentes facilita o entendimento sobre o assunto, e assim pode engajar mais pessoas.",
        "Não tenho tempo para mídias.", 0, -2, 0, 0, 0, "",
        "Isso não faz diferença.", 0, 0, -2, 0, -2, "",
        "Vou fazer uma pequena publicação.", 0, 0, 2, 0, 0, "",
        2));


        university_questions.Add(new Question("Os pesquisadores criaram uma material de divulgação com os métodos mais eficazes de prevenção da infecção e enviaram para você. Onde você deseja enviar?",
        "Enviem para os hospitais. Lá eles vão precisar.", 0, 3, 0, 0, 5, "",
        "Divulguem na mídia local.", 0, 2, 5, 0, 3, "",
        "Vamos mandar primariamente para o Lar de Idosos.", 0, 5, 0, 0, 2, "",
        "Mandem para o Centro comunitário. Lá eles vão saber o que fazer.", 0, 3, 5, 0, 0, "",
        2));


        university_questions.Add(new Question("A Universidade precisa de amostras do COVID-19. Eles querem enviar 10 pesquisadores e 5 estudantes para entrar no hospital e coletar o material de pacientes doentes. Eles precisam da sua autorização.",
        "Claro. Tudo em prol da Ciência.", 0, -2, 0, 3, 5, "",
        "Não. Acho mais seguro os profissionais colherem e enviar para a Universidade.", 0, 0, 0, 5, 3, "",
        "Vou autorizar a entrada apenas de 5 pesquisadores.", 0, 0, 0, 0, 2, "",
        "Vou autorizar se os EPIs de todos forem garantidos.", 0, 0, 0, 5, 5, "",
        3));


        university_questions.Add(new Question("Os pesquisadores da universidade conseguiram sequenciar os genes da doença. Eles não estão de parabéns?",
        "É a obrigação deles.", 0, 0, -5, -3, 0, "",
        "Claro. Vou fazer um pronunciamento para divulgar.", 0, 2, 2, 0, 5, "",
        "No que isso vai ajudar?", 0, 0, -3, -5, 0, "",
        "Vou investir nesse grupo de pesquisadores.", -3, 0, 0, 3, 10, "O investimento em ciência é sempre recompensado principalmente em situações como a que nos encontramos.",
        3));


        university_questions.Add(new Question("A Universidade acabou de anunciar que descobriram um novo teste que identifica se as pessoas estão ou já foram infectados pelo coronavírus. Esse novo teste é um pouco mais caro. O que você vai fazer?",
        "Vamos comprar apenas esse teste agora.", -3, 5, 0, 0, 3, "",
        "Não precisamos de mais testes.", 2, 0, 0, 0, 0, "",
        "Vamos testar os profissionais da saúde assim.", -2, 0, 0, 0, 3, "",
        "Vamos testar os idosos assim.", -2, 3, 0, 0, 0, "",
        4));


        university_questions.Add(new Question("A universidade tem uma farmácia que produz Álcool em Gel por conta própria. Eles querem produzir em larga escala para doar ao hospital. Porém, eles precisam de investimento. O que você acha?",
        "Já temos Álcool o suficiente. Se riscar um fósforo", 0, 0, 0, -2, 0, "",
        "Claro. Vamos investir nessa produção.", -2, 0, 0, 0, 5, "",
        "Vamos pedir auxílio externo para ajudar no investimento", 2, 0, 0, -5, 5, "",
        "Vamos fazer uma campanha na internet para arrecadar dinheiro.", 0, 0, 0, -2, 3, "",
        4));


        university_questions.Add(new Question("Um dos professores da universidade foi contaminado pelo vírus durante a análise de uma amostra e está isolado. Agora a população está questionando a eficácia dos estudos realizados nesse laboratório. O que você vai fazer?",
        "Foi apenas um acidente. Não temos motivos para preocupações.", 0, -3, 2, 2, 2, "",
        "Erros Acontecem. A pesquisa não pode parar, desinfectem o local.", 0, 0, 0, 3, 5, "",
        "Temos que investigar o que aconteceu. Após as apurações eu me manifesto!", 0, 0, 0, -2, 0, "",
        "Vamos suspender temporariamente as pesquisas.", 0, 0, -2, 0, -10, "Alguns erros fazem partes do processo cientifico, porem parar esse processo dificulta o encontro de soluções mais viáveis para lidar com o vírus.",
5));


        university_questions.Add(new Question("A universidade está desenvolvendo uma vacina e precisa testar em algumas pessoas. O que você acha?",
        "Procurem voluntários.", 0, -2, -2, 0, 10, "Teste de vacinas são um ótimo meio de se encontrar uma cura ou prevenção definitiva de uma doença.",
        "Eles estão querendo injetar esse bixo nas pessoas?", 0, 0, 2, 0, -10, "",
        "Não devemos nos envolver com isso.", 0, 0, 0, -2, -10, "",
        "Vacinas causam autismo!", 0, -5, -5, -5, -10,"Vacinas não causam autismo… é fato.",
        5));




    }


}
