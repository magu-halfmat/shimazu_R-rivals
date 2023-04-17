using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    PlayerHand hand;//��D�𑵂���

    
    
    private void Start()
    {
        SetupHand();        
    }

    //��D�̗p�Ӂi�J�[�h�̐����j
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

    //�J�[�h���N���b�N�����璆���ɒu��
    public void SelectCard(Card card)
    {
        Debug.Log("SelectCard:" + card.number);
    }

    //����{�^������������Q�[���}�X�^�[�ɒʒm����
}
