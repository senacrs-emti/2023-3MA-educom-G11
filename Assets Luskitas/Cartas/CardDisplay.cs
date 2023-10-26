using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public Card card;

    public Text nomeText;
    public Text descricaoText;

    public Image artCard;

    public Text manaText;
    public Text ataqueText;
    public Text defesaText;
    void Start() {

        nomeText.text = card.nome;
        descricaoText.text = card.descricao;
        artCard.sprite = card.arteCard;
        manaText.text = card.manaCusto.ToString();
        ataqueText.text = card.ataque.ToString();
        defesaText.text = card.defesa.ToString();




    }

}
