using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManipHandeler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player"){
            transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    public void OnClickStart(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        
    }
}
