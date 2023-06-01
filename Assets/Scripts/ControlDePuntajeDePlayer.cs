using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlDePuntajeDePlayer : MonoBehaviour
{
    public Text textoPuntaje;
    int puntaje;
    // Start is called before the first frame update
    void Start()
    {
        textoPuntaje=GameObject.Find("TextPuntaje").GetComponent<Text>();
    }

    public void IncrementarPuntaje(){
        puntaje+=10;
        ActualizarPuntaje();
    }
    void ActualizarPuntaje(){
        textoPuntaje.text="SCORE: "+puntaje;
    }
}
