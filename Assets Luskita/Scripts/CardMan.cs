using System.Collections.Generic;
using UnityEngine;

public class CardMan : MonoBehaviour
{
    public Card manage;
    public List<Card> allCards; // Coloque todas as cartas dispon?veis aqui
    public List<Card> playerHand; // M?o do jogador
    public int startingHandSize = 6; // Tamanho inicial da m?o do jogador

    void Start()
    {
        // Distribua cartas aleat?rias para a m?o do jogador
        for (int i = 0; i < startingHandSize; i++)
        {
            int randomIndex = Random.Range(0, allCards.Count);
            Card randomCard = allCards[randomIndex];
            playerHand.Add(randomCard);
            allCards.RemoveAt(randomIndex);
        }
    }
}
