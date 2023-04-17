using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField]
    Card cardPrefab;

    //�ǂ�����ł��g����悤�ɂ���
    public static CardGenerator instance;

    private void Awake()
    {
        instance = this;
    }

    public Card Spawn(int number)
    {
        Card card = Instantiate(cardPrefab);
        card.Init(number);
        return card;
    }
   
}
