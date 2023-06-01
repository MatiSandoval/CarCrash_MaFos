using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorVidaEnemigos : MonoBehaviour
{
    Transform target;
    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.Find("Jugador").GetComponent<Transform>();
        tf=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ControlarVida();
    }
    void ControlarVida(){
        if(target.position.x*(-1)-tf.position.x*(-1)>30){
            Destroy(gameObject);
        }
    }
}
