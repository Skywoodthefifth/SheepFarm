using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barn : MonoBehaviour
{
    private List<Card> cards = new List<Card>();
    [SerializeField] private List<GameObject> masks;

    public void AddCard(Card card)
    {
        cards.Add(card);

        foreach (GameObject mask in masks)
        {
            if (mask.transform.childCount == 0)
            {
                card.transform.parent = mask.transform;
                card.transform.position = mask.transform.position;
                Debug.Log("added to barn");
                break;
            }
        }

        Debug.Log("added to barn failed");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
