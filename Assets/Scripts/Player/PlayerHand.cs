using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    //手札のカードを保持する
    List<Card> cards = new List<Card>();

    //最初にプレイヤーから手札を受け取る
    public void SetHandCards(List<Card> cards)
    {
        this.cards = cards;
        RefreshHand();
    }

    //手札を整列させる
    void RefreshHand()
    {
        
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            //手札のカードを自分の子要素にする
            card.transform.SetParent(this.transform);

            //ポジションを設定する
            float x = i - cards.Count / 2f;
            card.transform.localPosition = new Vector3(x * 1.2f, 0, 0);
        }


    }

}