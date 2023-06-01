using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPlay : MonoBehaviour
{
    GameManager gm;
    GameObject teclas;

    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
        teclas=GameObject.Find("teclas");
    }
    public void ClickEnPlay(){
        gm.estaIniciadoElJuego=true;
        Destroy(teclas);
        Destroy(gameObject);
    }
}
