using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonPlayAgain : MonoBehaviour
{
    public void ClickEnPlayAgain(){
        SceneManager.LoadScene(0);
    }
}
