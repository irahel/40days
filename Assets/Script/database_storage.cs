using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_storage : MonoBehaviour
{
    public ArrayList storage_questions;
    void Start()
    {
        storage_questions = new ArrayList();
        storage_questions.Add(new Question("Com a disseminação desse novo vírus as pessoas ficaram com medo e correram para os mercados e compraram muitas coisas para armazenar em casa. Muitos estão reclamando que está faltando tudo. Temos que fazer alguma coisa.",
"Lançarei uma nota tranquilizando a população e pedindo para evitar esses atos.", -2, 0, 3, 0, 0,"",
"Vamos limitar as compras de bens essenciais.", 3, 0, -2, 2, 0, "",
"Não vejo problema em criar estoques.", -2, 0, -5, -2, 0, "",
"Vamos fechar todos os mercados.", -10, 0, -10, -10, 0, "Devido ao coronavírus, as pessoas tem de se isolar, porém o fechamento de todos os mercados, sem um plano alternativo, para evitar aglomerações estagnaria a economia e dificultaria muito o acesso à produtos essenciais à vida",
1));


        storage_questions.Add(new Question("O papel higiênico está em falta no mercado. As pessoas compraram muitas unidades e estão guardando em casa. O que vamos fazer?",
        "Quem se importa com papel higiênico?", 0, -2, -2, 0, 0, "",
        "Todos precisamos nos precaver em tempos difíceis.", 0, -2, 0, 0, 0, "",
        "Vamos importar mais papel.", -2, 0, 0, 0, 0, "",
        "Vamos investir na produção local de papel higiênico.", 3, -3, 0, 0, 0,"",
        1));


        storage_questions.Add(new Question("Com a demanda crescente por Álcool em Gel nas farmácias e Mercados, os donos de estabelecimento estão aumentando abusivamente o preço deste produto. O que você faz com relação a isso?",
        "Eu não posso interferir no preço dos produtos no mercado.", 3, -3, -3, 0, 0, "",
        "Vamos fiscalizar e punir esses abusadores.", -2, 0, 0, -2, 0, "",
        "Eu vou sugerir um preço justo para os comerciantes.", 0, 0, 2, 2, 0, "",
        "Vamos fazer campanhas de substituição do Álcool por sabão.", 2, 0, 0, 0, 0, "",
        1));


        storage_questions.Add(new Question("Muitos produtos importados que vinham da china estão parados nos contêineres de transporte porque os fiscais não querem abrir. Eles solicitam sua ajuda.",
        "Não precisamos desse produtos. Deixem aí.", -5, 0, -5, 0, 0, "",
        "Vamos esperar 14 dias para poder abrir os contêineres.", -3, 0, 0, 0, 0, "",
        "Os contêineres levam muito tempo para chegar até aqui, não oferecem riscos.", 5, 0, 5, 0, 0,"Estava certo.O período que o vírus sobrevive, é muito menor que o tempo que os contêineres e mercadorias levam para chegar na cidade.",
        "Perguntem aos universitários.", 2, 0, 0, -3, 2, "",
        2));


        storage_questions.Add(new Question("O dono de um restaurante famoso da cidade chamado “Lasca de pau” está ligando para você e pedindo que não estabeleça uma quarentena e não feche os estabelecimentos. Qual resposta ele merece?",
        "Claro. Vamos fazer uma campanha. #OBondeNãoPara!", 5, -5, 0, -3, 0, "",
        "Eu sou o prefeito e eu faço o que achar melhor para a população.", 0, 0, 0, -2, 0, "",
        "Sugiro o fechamento, porém ainda podem e devem fazer delivery.", 3, 2, 0, 5, 0, "",
        "Deixo a critério dos donos de restaurantes.", 2, -3, 0, 0, 0, "",
        2));


        storage_questions.Add(new Question("Os restaurantes estão começando a trabalhar em regime de delivery. o senhor incentiva essa prática?",
        "Não, prefiro restaurantes normais.", 2, -3, 0, -2, 0, "",
        "Claro. Vamos pedir um “BigMegaUltraHiper explosão de gordura nas artérias do meu coração” e um refrigerante light para não engordar", 2, 0, 0, -3, 0, "",
        "Não! como eu teria meu jantar romântico no restaurante chique hoje?", 2, -3, -3, -5, 0, "",
        "Claro. vou até pedir uma salada verde e um peixe para me manter saudável e com a imunidade alta.", 3, 3, 0, 3, 0,"Ao se lidar com uma doença nova que ainda não possui cura ou vacina, sempre se lembrar de manter a imunidade alta por meio praticar bons hábitos alimentares é essencial",
        2));


        storage_questions.Add(new Question("Os moradores estão questionando a eficácia do gargarejo com vinagre contra a infecção por Coronavírus. Nós temos muito vinagre no armazém. O que vamos fazer?",
        "Eu faço meu gargarejo todas as manhãs.", 0, -2, 0, -2, 0, "",
        "Vamos mandar a Universidade pesquisar sobre isso.", 0, 0, 0, 0, 3, "",
        "Vou ligar para um médico e pedir esclarecimentos.", 0, 2, 0, 2, 0, "",
        "Eu acredito no poder do efeito placebo.", 0, -2, 0, 0, 0, "",
        3));


        storage_questions.Add(new Question("O administrador do armazém está prestes a confirmar uma compra de vários carregamentos de Vitamina C para distribuir com a população. Ele viu em um vídeo dessa substância melhora a imunidade e quer ser o herói dessa cidade!",
        "Detenham esse homem agora mesmo. Eu sou o único herói dessa cidade!", 0, 0, -2, -2, 0, "",
        "Vamos com calma. Vamos comprar apenas uma parte da carga.", -3, 0, 0, 2, 0, "",
        "Vitamina C não serve pra nada!", 0, -3, 0, -3, 0, "",
        "Onde está o link desse vídeo? Melhor verificar a veracidade das informações.", 0, 3, 0, 0, 3, "Sempre checar a veracidade das informações é o primeiro passo para evitar disseminação de mentiras, e em caso da informação ser verdadeira, você ao menos saberá mais sobre o assunto.",
        3));


        storage_questions.Add(new Question("A produção agrícola diminuiu drasticamente nos arredores da nossa cidade. Se continuarmos assim as pessoas vão passar fome. O que vamos fazer?",
        "Vamos investir em máquinas agrícolas para a produção.", -5, 0, 5, 0, 0, "",
        "Temos que investir em agricultura familiar, isso ajudará a amenizar a crise.", 2, 2, -2, 0, 0, "",
        "Vamos comprar produtos agrícolas de outras cidades.", -3, 0, 0, 2, 0, "",
        "Vamos fazer um racionamento e usar os excedentes das últimas colheitas.", 3, 0, 0, 3, 0, "Saber dividir e racionar quando necessário é importante em momentos de crise como uma epidemia, para evitar estocagem",
        4));


        storage_questions.Add(new Question("Os trabalhadores do armazém estão preocupados com a higienização da embalagem dos produtos. O que eles devem fazer?",
        "Vamos passar álcool em tudo!", -3, 0, 0, -5, 0, "",
        "Joga na banheira com sabão e esfrega.", -10, 0, -5, -5, 0, "",
        "Limpa com água sanitária diluída.", 2, 2, 0, 2, 0, "Limpar a embalagem de produtos com água sanitária diluída é a indicação da OMS, parabéns.",
        "Joga tudo fora.", -10, -5, -10, -10, 0, "",
        4));


        storage_questions.Add(new Question("Os criadores de gado disseram ter achado a solução para a crise do Coronavírus. Eles querem usar a mesma vacina que usam no gado para imunizar a população da cidade. O que você acha disso?",
        "Essa é a maior idiotice que eu já ouvi desde que comecei a jogar esse negócio", 5, 5, 5, 5, 5,"Sim… realmente aquela era a maior idiotice desde que você começou o jogo.",
        "Porque ninguém pensou nisso antes?", -5, -5, -5, -5, -5,"Você só quer ver o circo pegar fogo né! ?",
        "O gado pega Coronavírus?", 0, 0, 0, 0, 0, "Sim, o gado pega coronavírus, e é até bem comum.porém o coronavírus do gado não é transmissível para seres humanos.",
"Eu desisto desse povo.",0,0,0,0,0, "Não desista do povo ainda… por favor.",
5));


        storage_questions.Add(new Question("O administrador do armazém quer fazer uma reunião presencial com os fornecedores da cidade para aprovar um pacote de medidas de fornecimento básico. O que você acha?",
        "Claro! Eu também estarei presente.", 3, -3, 2, 0, 0, "",
        "É melhor fazer uma videoconferência.", 3, 0, 2, 0, 0, "",
        "Não precisamos disso. Eles devem comprir os contratos.", -3, 0, 0, -3, 0, "",
        "Já encontramos outros fornecedores.", 3, 0, 0, 2, 0, "",
        5));



    }

}
