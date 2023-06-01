using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarAutos : MonoBehaviour
{
    public GameObject Auto1;
    public GameObject Auto2;
    public GameObject Auto3;
    Transform posicion;
    void Start()
    {
        posicion=GameObject.Find("Jugador").GetComponent<Transform>();
    }
    void Generar(){
        int azar=(int)Random.Range(0,3);
        int azarx=(int)Random.Range(150,230);
        int azarz=0;
        azarz=(int)Random.Range(7,14);
        
        int azarx1=azarx-(int)Random.Range(30,60);
        int azarz1;
        if(azarz>9){azarz1=(int)Random.Range(-4,0);}
        else{azarz1=(int)Random.Range(0,4);}
        int azarx2=azarx1+(int)Random.Range(50,100);
        int azarz2;
        if(azarz>9){azarz2=(int)Random.Range(-4,0);}
        else{azarz2=(int)Random.Range(0,4);}
        if(azar==0){
                GameObject nuevaAuto=Instantiate(Auto1,new Vector3(posicion.position.x-azarx,posicion.position.y,azarz),Quaternion.Euler(0,90,0));    
        }
        if(azar==1){
                GameObject nuevaAuto=Instantiate(Auto1,new Vector3(posicion.position.x-azarx,posicion.position.y,azarz),Quaternion.Euler(0,90,0)); 
                GameObject nuevaAuto2=Instantiate(Auto2,new Vector3(posicion.position.x-azarx1,posicion.position.y,posicion.position.z+azarz1),Quaternion.Euler(0,90,0));
            
        }
        if(azar==2){
                GameObject nuevaAuto=Instantiate(Auto1,new Vector3(posicion.position.x-azarx,posicion.position.y,azarz),Quaternion.Euler(0,90,0));
                GameObject nuevaAuto2=Instantiate(Auto2,new Vector3(posicion.position.x-azarx1,posicion.position.y,posicion.position.z+azarz1),Quaternion.Euler(0,90,0)); 
                GameObject nuevaAuto3=Instantiate(Auto3,new Vector3(posicion.position.x-azarx2,posicion.position.y,posicion.position.z+azarz2),Quaternion.Euler(0,90,0));
            
        }
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Jugador"){
            Generar();
        }
    }
}
