using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public GameObject[] Players;
    public float currentTurn;
    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("PLayer");
        currentTurn = 0;
    }

    // Update is called once per frame
    public void NextTurn()
    {
        print("f");
        if (currentTurn !=3)
        {
            Players[(int)currentTurn].GetComponent<PLayer>().isTurn = false;
            currentTurn++;
            Players[(int)currentTurn].GetComponent<PLayer>().isTurn = true;
        }
        else
        {
            Players[(int)currentTurn].GetComponent<PLayer>().isTurn = false;
            currentTurn = 0;
            Players[(int)currentTurn].GetComponent<PLayer>().isTurn = true;
        }
    }
}
