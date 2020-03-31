using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintSupplies : MonoBehaviour
{
    public GameObject card;
    public GameObject spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SpawnCard()
    {
        card = Instantiate(card);
        card.transform.position = spawnLocation.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
