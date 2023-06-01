using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeVelocidad : MonoBehaviour
{
    public int velocidadInicialDeAuto;
    public int velocidadInicialDeEnemigos;
    public int velocidadLateralDeAuto;
    public float tiempo;
    void Start()
    {
        velocidadInicialDeAuto=15;
        velocidadLateralDeAuto=20;
        velocidadInicialDeEnemigos=10;
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo>10){
            tiempo=0;
            IncrementarVelocidades();
        }
        else{
            tiempo+=Time.deltaTime;
        }
    }
    void IncrementarVelocidades(){
        velocidadInicialDeAuto++;
        velocidadInicialDeEnemigos++;
        velocidadLateralDeAuto++;
    }
}
