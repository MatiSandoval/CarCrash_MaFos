using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject ciudad1;
    public GameObject ciudad2;
    public GameObject ciudad3;
    
    Transform tfPadre;
    // Start is called before the first frame update
    void Start()
    {
        tfPadre=GetComponent<Transform>().parent;

    }
    void Generar(){
        int azar=(int)Random.Range(0,3);
        
        if(azar==0){
            
                GameObject nuevaCiudad=Instantiate(ciudad1,new Vector3(tfPadre.position.x-236,tfPadre.position.y,tfPadre.position.z),Quaternion.identity);
            
            
        }
        if(azar==1){
            
                GameObject nuevaCiudad=Instantiate(ciudad2,new Vector3(tfPadre.position.x-236,tfPadre.position.y,tfPadre.position.z),Quaternion.identity);
            
        }
        if(azar==2){
                GameObject nuevaCiudad=Instantiate(ciudad3,new Vector3(tfPadre.position.x-236,tfPadre.position.y,tfPadre.position.z),Quaternion.identity);
            
        }
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Jugador"){
            Generar();
        }
    }
}
