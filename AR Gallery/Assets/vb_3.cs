using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class vb_3 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbBtnObj;
    public Animator cubeAn1;
    public GameObject txt5; 
    public GameObject txt6; 
    void Start()
    {
   vbBtnObj = GameObject.Find("vb_3");  
   txt5 = GameObject.Find("txt5"); 
   txt6 = GameObject.Find("txt6"); 
   txt6.gameObject.SetActive(false);
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
txt5.gameObject.SetActive(false);
txt6.gameObject.SetActive(true);
} 

 public void OnButtonReleased(VirtualButtonBehaviour vb) 
{
Debug.Log("test3");
print("test3");
txt5.gameObject.SetActive(true);
txt6.gameObject.SetActive(false);
       
    }
}
