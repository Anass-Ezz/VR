using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class NormalDoorOpenClose : MonoBehaviour
{
    [SerializeField] TMP_Text UIText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void OpenClose(){
        HandleNormalDoorCollider script = transform.parent.parent.GetComponent<HandleNormalDoorCollider>();

        if (!script.isOpened){
            if (script.doorRotation){
                transform.parent.localEulerAngles = new Vector3(0f, 0f, 90);
            }
            else{
                transform.parent.localEulerAngles = new Vector3(0f, 0f, -90);
            }
            script.isOpened = true;
            UIText.text = "Close";
        }
        else {
            transform.parent.localEulerAngles = new Vector3(0f, 0f, 0f);
            script.isOpened = false;
            UIText.text = "Open";
        }
    }
}
