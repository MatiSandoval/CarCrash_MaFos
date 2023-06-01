using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDeGameOver : MonoBehaviour
{
    AudioSource camara;
    
    public GameObject panelGameOver;
    public ControlDePuntajeDePlayer puntajePlayer;
    public ControlDeTiempo tiempoPartida;
    public Text textoPuntaje;
    public Text textoTiempo;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
        
        camara=GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.estaTerminadoElJuego){
            camara.Pause();
            panelGameOver.SetActive(true);
            textoPuntaje.text=puntajePlayer.textoPuntaje.text;
            textoTiempo.text="Tiempo: "+tiempoPartida.textoTiempo.text;
        }
    }
}
