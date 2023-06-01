using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeColision : MonoBehaviour
{
    AudioSource audio1;
    AudioSource audio2;
    AudioSource audio3;
    ControlDeVidasDePlayer vidasPlayer;
    ControlDePuntajeDePlayer puntajePlayer;
    public GameObject explosion;
    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        puntajePlayer=GameObject.Find("ControlDePuntaje").GetComponent<ControlDePuntajeDePlayer>();
        vidasPlayer=GameObject.Find("Jugador").GetComponent<ControlDeVidasDePlayer>();
        audio1=GetComponent<AudioSource>();
        audio2=GameObject.Find("ControlDeGameOver").GetComponent<AudioSource>();
        audio3=GameObject.Find("ControlDePuntaje").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Enemigo"){
            if(vidasPlayer.vidas>0){
            vidasPlayer.QuitarVidas();}
            if(vidasPlayer.vidas>0){audio1.Play();}
            
            else if(vidasPlayer.vidas==0){audio2.Play();}
            tf=other.GetComponent<Transform>();
            Destroy(other.gameObject);
            GameObject explosionn=Instantiate(explosion,new Vector3(tf.position.x,tf.position.y,tf.position.z),Quaternion.identity);

        }
        
        if(other.tag=="Recolectables"){
            audio3.Play();
            puntajePlayer.IncrementarPuntaje();
            Destroy(other.gameObject);
        }
        
    }
}
