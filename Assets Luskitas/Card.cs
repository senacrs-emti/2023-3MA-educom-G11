using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova Carta", menuName = "Cartas")]
public class Card : ScriptableObject{

    public string nome;
    public string descricao;

    public Sprite artCard;

    public int CustoMana;
    public int Ataque;
    public int Vida;

}