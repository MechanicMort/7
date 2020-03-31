using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    GameObject painting;
    // Start is called before the first frame update
    void Start()
    {
        painting = GameObject.FindGameObjectWithTag("Painting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void take()
    {
        print(painting.GetComponent<Painting>().Players[(int)painting.GetComponent<Painting>().currentTurn].name);
        painting.GetComponent<Painting>().Players[(int)painting.GetComponent<Painting>().currentTurn].GetComponent<PLayer>().AddCard(transform.root.gameObject);
    }
}
