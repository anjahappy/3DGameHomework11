using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEvent : MonoBehaviour,IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour[] vbs;
    public GameObject snow;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        button.GetComponent<MeshRenderer>().material.color = Color.white;

        //VirtualButtonBehaviour vbb = vb.GetComponent<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        //     ani.gameObject.transform.Rotate(Vector3.up * 180);
        button.GetComponent<MeshRenderer>().material.color = Color.red;
        snow.transform.Rotate(Vector3.up * 180);
       // snow.transform.position=new Vector3(100,100,100);

        Debug.Log(vb.VirtualButtonName);
        //throw new System.NotImplementedException();
    }
   

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        button.GetComponent<MeshRenderer>().material.color = Color.white;
       // snow.transform.position = new Vector3(0, 0, 0);

    }
}

