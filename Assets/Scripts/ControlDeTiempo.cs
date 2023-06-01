using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDeTiempo : MonoBehaviour
{
    GameManager gm;
    public float tiempo;
    public Text textoTiempo;
    int numeroSegundos;
    int numeroMinutos;
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

        void Update()
    {
        if(gm.estaIniciadoElJuego && gm.estaTerminadoElJuego==false){
            ActualizarTiempo();
            ActualizarTexto();
        }
    }
    void ActualizarTiempo(){
        tiempo+=Time.deltaTime;
        if(tiempo<60){
            numeroSegundos=(int)tiempo;
        }
        else{
            numeroMinutos=(int)tiempo/60;
            numeroSegundos=(int)tiempo-(numeroMinutos*60);
        }
    }
    void ActualizarTexto(){
        if(numeroMinutos<10){
            textoTiempo.text="0"+numeroMinutos.ToString()+":";
        }
        else{
            textoTiempo.text=numeroMinutos.ToString()+":";
        }
        if(numeroSegundos<10){
            textoTiempo.text+="0"+numeroSegundos.ToString();
        }
        else{
            textoTiempo.text+=numeroSegundos.ToString();
        }
    }
}
