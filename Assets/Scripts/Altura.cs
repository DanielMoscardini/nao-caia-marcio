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
