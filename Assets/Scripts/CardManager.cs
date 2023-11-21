using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> allCards = new List<Card>(); // Coloque todas as cartas disponíveis aqui
    public List<Card> playerHand; // Mão do jogador
    public int startingHandSize = 6; // Tamanho inicial da mão do jogador

    void Start()
    {
        // Certifique-se de que allCards está inicializado
        if (allCards == null)
        {
            Debug.LogError("A lista de cartas não foi inicializada.");
            return;
        }

        // Verifique se há cartas suficientes para distribuir
        if (allCards.Count < startingHandSize)
        {
            Debug.LogError("Não há cartas suficientes para a mão inicial.");
            return;
        }

            // Distribua cartas aleatórias para a mão do jogador
            for (int i = 0; i < startingHandSize; i++)
            {
                int randomIndex = Random.Range(0, allCards.Count);
                Card randomCard = allCards[randomIndex];
                playerHand.Add(randomCard);
                allCards.RemoveAt(randomIndex);
            }
        }
}