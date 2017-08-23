using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class DataClass
{
    public int myInt;
    public float myFloat;

}
public class DemoScript: MonoBehaviour {


    public Light MyLight;
    public DataClass[] myClass;
    public AnotherDataClass[] myOtherClass;
     Rigidbody myRigidbody;
     Rigidbody myOtherRigidbody;
   /* void Awake()
    {
        int myVar = AddTwo(9,2);
        Debug.Log(myVar);
        myRigidbody = GetComponent<Rigidbody>();
        myOtherRigidbody = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();
    }*/
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            MyFunction();
        }

        
    }

    void MyFunction()
    {
        MyLight.enabled = !MyLight.enabled;
    }

    int AddTwo(int var1, int var2)
    {
        int returnValue = var1 + var2;
       return returnValue;
    }
}
