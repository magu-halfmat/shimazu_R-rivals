using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    //��D�̃J�[�h��ێ�����
    List<Card> cards = new List<Card>();

    //�ŏ��Ƀv���C���[�����D���󂯎��
    public void SetHandCards(List<Card> cards)
    {
        this.cards = cards;
        RefreshHand();
    }

    //��D�𐮗񂳂���
    void RefreshHand()
    {
        
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            //��D�̃J�[�h�������̎q�v�f�ɂ���
            card.transform.SetParent(this.transform);

            //�|�W�V������ݒ肷��
            float x = i - cards.Count / 2f;
            card.transform.localPosition = new Vector3(x * 1.2f, 0, 0);
        }


    }

}