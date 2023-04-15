using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {
        SetupHand();        
    }

    //手札の用意（カードの生成）
    void SetupHand()
    {
        for (int i = 0; i < 8; i++)
        {
            Card card = CardGenerator.instance.Spawn(i);
            card.ClickAction = SelectCard;
        }
    }

    //カードをクリックしたら中央に置く
    public void SelectCard(Card card)
    {
        Debug.Log("SelectCard:" + card.number);
    }

    //決定ボタンを押したらゲームマスターに通知する
}
