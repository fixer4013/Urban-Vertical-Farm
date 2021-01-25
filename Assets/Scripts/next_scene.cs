using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scene : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(1);
        Debug.Log("yo it worksss");
    }
        
    
}
