using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feature : MonoBehaviour
{
    public GameObject[] paintsArray; 
    public GameObject[] paintsColours = new GameObject[5]; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < paintsArray.Length; i++)
        {
            if (paintsArray[i].GetComponent<Paint>().colour == "Red")
            {
                paintsArray[i].GetComponent<MeshRenderer>().material.color = paintsColours[0].GetComponent<MeshRenderer>().material.color;
            }
            else if (paintsArray[i].GetComponent<Paint>().colour == "Orange")
            {
                paintsArray[i].GetComponent<MeshRenderer>().material.color = paintsColours[1].GetComponent<MeshRenderer>().material.color;
            }
            else if (paintsArray[i].GetComponent<Paint>().colour == "Purple")
            {
                paintsArray[i].GetComponent<MeshRenderer>().material.color = paintsColours[2].GetComponent<MeshRenderer>().material.color;
            }
            else if (paintsArray[i].GetComponent<Paint>().colour == "Yellow")
            {
                paintsArray[i].GetComponent<MeshRenderer>().material.color = paintsColours[3].GetComponent<MeshRenderer>().material.color;
            }
            else if (paintsArray[i].GetComponent<Paint>().colour == "Green")
            {
                paintsArray[i].GetComponent<MeshRenderer>().material.color = paintsColours[4].GetComponent<MeshRenderer>().material.color;
            }
        }

    }
}
