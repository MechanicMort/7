using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayer : MonoBehaviour
{
    public bool isTurn;
    public GameObject[] hand = new GameObject[8];
    public GameObject[] handCards = new GameObject[8];
    // Start is called before the first frame update
    void Start()
    {
        isTurn = true;
    }

    

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hand.Length; i++)
        {
            if (handCards[i] != null)
            {
                handCards[i].transform.position = hand[i].transform.position;
            }
        }
    }
    
    public void AddCard(GameObject cardToAdd)
    {
        for (int i = 0; i < handCards.Length; i++)
        {
            if (handCards[i] == null)
            {
                handCards[i] = cardToAdd;
                break;
            }
            
        }
    }
}
