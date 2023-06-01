using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoDeCamara : MonoBehaviour
{
    Transform tf;
    Transform target;
    Vector3 posicionRelativa;
    // Start is called before the first frame update
    void Start()
    {
        target=GameObject.Find("Jugador").GetComponent<Transform>();
        tf=GetComponent<Transform>();
        posicionRelativa=tf.position-target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        tf.position=target.position+posicionRelativa;
    }
}
