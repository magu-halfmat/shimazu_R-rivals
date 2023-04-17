using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    PlayerHand hand;//手札を揃える

    
    
    private void Start()
    {
        SetupHand();        
    }

    //手札の用意（カードの生成）
    void SetupHand()
    {
        List<Card> cards = new List<Card>();

        for (int i = 0; i < 8; i++)
        {
            Card card = CardGenerator.instance.Spawn(i);
            card.ClickAction = SelectCard;
            cards.Add(card);
        }

        hand.SetHandCards(cards);
    }

    //カードをクリックしたら中央に置く
    public void SelectCard(Card card)
    {
        Debug.Log("SelectCard:" + card.number);
    }

    //決定ボタンを押したらゲームマスターに通知する
}
