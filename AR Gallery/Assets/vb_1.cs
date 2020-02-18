using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 
public class vb_1 : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject vbBtnObj;
    public Animator cubeAn1;
    public GameObject txt; 
    public GameObject txt2; 
    void Start()
    {
   vbBtnObj = GameObject.Find("vb_1");  
   txt = GameObject.Find("txt"); 
   txt2 = GameObject.Find("txt2"); 
   txt2.gameObject.SetActive(false);
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
txt.gameObject.SetActive(false);
txt2.gameObject.SetActive(true);
} 

 public void OnButtonReleased(VirtualButtonBehaviour vb) 
{
Debug.Log("test3");
print("test3");
txt.gameObject.SetActive(true);
txt2.gameObject.SetActive(false);
       
    }
}
