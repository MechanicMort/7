using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardColour : MonoBehaviour
{
    public GameObject[] paintsArray;
    public GameObject[] paintsColours = new GameObject[5];
    // Update is called once per frame

    private void Start()
    {
        if (paintsColours[0] == null)
        {
            paintsColours[0] = GameObject.FindGameObjectWithTag("Red");
        }
            if (paintsColours[1] == null)
        {
            paintsColours[1] = GameObject.FindGameObjectWithTag("Orange");
        }
         if (paintsColours[2] == null)
        {
            paintsColours[2] = GameObject.FindGameObjectWithTag("Purple");
        }
         if (paintsColours[3] == null)
        {
            paintsColours[3] = GameObject.FindGameObjectWithTag("Yellow");
        }
         if (paintsColours[4] == null)
        {
            paintsColours[4] = GameObject.FindGameObjectWithTag("Green");
        }
    }
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
