using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandleNormalDoorCollider : MonoBehaviour
{
    public bool doorRotation = false;
    private GameObject openUI;
    private GameObject door;
    public bool isOpened = false;


    void OnTriggerEnter(Collider other){
        openUI.SetActive(true);
    }
    void OnTriggerExit(Collider other){ 
        openUI.SetActive(false);
    }
    void Start()
    {
        openUI = transform.GetChild(0).GetChild(0).gameObject;
    
    }





}
