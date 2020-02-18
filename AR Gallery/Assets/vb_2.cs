using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class vb_2 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbBtnObj;
    public Animator cubeAn1;
    public GameObject txt3; 
    public GameObject txt4; 
    void Start()
    {
   vbBtnObj = GameObject.Find("vb_2");  
   txt3 = GameObject.Find("txt3"); 
   txt4 = GameObject.Find("txt4"); 
   txt4.gameObject.SetActive(false);
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
txt3.gameObject.SetActive(false);
txt4.gameObject.SetActive(true);
} 

 public void OnButtonReleased(VirtualButtonBehaviour vb) 
{
Debug.Log("test3");
print("test3");
txt3.gameObject.SetActive(true);
txt4.gameObject.SetActive(false);
       
    }
}
