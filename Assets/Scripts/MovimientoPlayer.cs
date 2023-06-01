using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    Transform tf;
    float velocidad;
    float velocidadLateral;
    ControlDeVelocidad velocidad_Script;
    GameManager gm;
    Transform ciudad;
    // Start is called before the first frame update
    void Start()
    {
        tf=GetComponent<Transform>();
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
        velocidad_Script = GameObject.Find("ControlDeVelocidad").GetComponent<ControlDeVelocidad>();
        ciudad=GameObject.Find("fondociudad").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.estaIniciadoElJuego==true && gm.estaTerminadoElJuego==false){
            velocidad=velocidad_Script.velocidadInicialDeAuto;
            velocidadLateral=velocidad_Script.velocidadLateralDeAuto;
            tf.Translate(Vector3.forward*velocidad*Time.deltaTime);
            ciudad.Translate(Vector3.back*velocidad*Time.deltaTime);
            if(Input.GetKey(KeyCode.A)){
                tf.Rotate(Vector3.up*-velocidadLateral*Time.deltaTime);
            }
            else if(Input.GetKey(KeyCode.D)){
                tf.Rotate(Vector3.up*velocidadLateral*Time.deltaTime);
            }
        }
    }
}
