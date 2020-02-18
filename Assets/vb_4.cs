using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class vb_4 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbBtnObj;
    public Animator cubeAn1;
    public GameObject txt7; 
    public GameObject txt8; 
    void Start()
    {
   vbBtnObj = GameObject.Find("vb_4");  
   txt7 = GameObject.Find("txt7"); 
   txt8 = GameObject.Find("txt8"); 
   txt8.gameObject.SetActive(false);
   vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
 Debug.Log("test");
print("test");   

    }

  
    // Update is called once per frame
    void Update()
    {
}
 public void OnButtonPressed(VirtualButtonBehaviour vb)
{
Debug.Log("test2");
print("test2"); 
txt7.gameObject.SetActive(false);
txt8.gameObject.SetActive(true);
} 

 public void OnButtonReleased(VirtualButtonBehaviour vb) 
{
Debug.Log("test3");
print("test3");
txt7.gameObject.SetActive(true);
txt8.gameObject.SetActive(false);
       
    }
}
