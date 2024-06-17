#1. Nome, Descrição e Instruções para Jogabilidade do Jogo “Não Caia”

      Nome do Jogo: “Não Caia”
      
      Descrição: O jogo “Não Caia” é um desafio de plataforma em 3D onde o jogador deve subir uma série de blocos sem cair. A câmera acompanha o jogador à medida que ele avança pelas plataformas.
      Instruções para Jogabilidade:
      
      Use as setas direcionais ou as teclas W, A, S, D para mover o jogador para a esquerda, direita, frente e trás.
      Pressione a barra de espaço para fazer o jogador pular.
      
      O mouse controla a câmera do jogador, permitindo que ele olhe ao redor enquanto se movimenta.


#2. Link do video: https://drive.google.com/drive/folders/1Ob2ul2t8CceDvFAaVwgB6bWK8ERvGmJA?usp=sharing


#3. 3 Prints de tela
![naocaia3](https://github.com/DanielMoscardini/nao-caia-marcio/assets/77151927/cc06cc39-9c8b-43e7-9706-bf4b5451edfe)
![naocaia2](https://github.com/DanielMoscardini/nao-caia-marcio/assets/77151927/614213e4-aebf-49c9-b032-45c66e4dd3e6)
![naocaia1](https://github.com/DanielMoscardini/nao-caia-marcio/assets/77151927/1fe4de47-3e66-402e-ae11-de22305d7413)


#4. Citar funcionalidades: 
  4.1 Funcionalidade para Calcular os pontos:
  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altura : MonoBehaviour
{

    public Transform personagem;
    Text texto_altura;
    //public Transform personagem;
    // Start is called before the first frame update
    void Start()
    {
        texto_altura = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(personagem.position.y);
       texto_altura.text = Mathf.RoundToInt(personagem.position.y).ToString();
    }
}

Obs: A movimentação do jogador foi utilizado o Standard assets da unity
