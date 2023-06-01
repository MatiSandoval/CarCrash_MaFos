using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlDeVidasDePlayer : MonoBehaviour
{
    GameManager gm;
   
    public int vidas;
    Text textoVidas;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.Find("GameManager").GetComponent<GameManager>();
        vidas=3;
        
        textoVidas=GameObject.Find("TextVida").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vidas==0){
            gm.estaTerminadoElJuego=true;
            
        }
        
    }
    public void QuitarVidas(){
        vidas--;
        textoVidas.text="VIDAS: "+vidas.ToString();
    }
}
