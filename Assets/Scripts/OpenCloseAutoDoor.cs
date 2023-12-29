using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseAutoDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void Start()
    {
        
    }

     void OnTriggerEnter(Collider other){
        Debug.Log("jhdfaskjhdfliahs");
        if (other.gameObject.tag == "Player"){
            animator.SetBool("open", true);
        }
    }
    void OnTriggerExit(Collider other){ 
        if (other.gameObject.tag == "Player"){

            animator.SetBool("open", false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
