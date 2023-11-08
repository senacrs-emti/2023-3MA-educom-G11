using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

    public string nome;
    public string descricao;

    public Sprite arteCard;

    public int manaCusto;
    public int ataque;
    public int defesa;

   
}
