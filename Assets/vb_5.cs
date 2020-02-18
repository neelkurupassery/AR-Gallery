using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class vb_5 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbBtnObj;
    public Animator cubeAn1;
    public GameObject txt9; 
    public GameObject txt10; 
    void Start()
    {
   vbBtnObj = GameObject.Find("vb_5");  
   txt9 = GameObject.Find("txt9"); 
   txt10 = GameObject.Find("txt10"); 
   txt10.gameObject.SetActive(false);
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
txt9.gameObject.SetActive(false);
txt10.gameObject.SetActive(true);
} 

 public void OnButtonReleased(VirtualButtonBehaviour vb) 
{
Debug.Log("test3");
print("test3");
txt9.gameObject.SetActive(true);
txt10.gameObject.SetActive(false);
       
    }
}
