using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAutos : MonoBehaviour
{
    Transform tf;
    float velocidad;
    GameManager gm;
    ControlDeVelocidad velocidad_Script;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
        tf=GetComponent<Transform>();
        velocidad_Script=GameObject.Find("ControlDeVelocidad").GetComponent<ControlDeVelocidad>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.estaIniciadoElJuego==true){
        velocidad=velocidad_Script.velocidadInicialDeEnemigos;
        
        tf.Translate(Vector3.forward*velocidad*Time.deltaTime);
        }
    }
}
