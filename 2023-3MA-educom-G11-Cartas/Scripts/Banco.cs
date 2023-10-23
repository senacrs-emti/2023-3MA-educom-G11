using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;
    public GameObject card5;
    public GameObject AreadoPlayer;
    public GameObject AreaInimiga;
    
    
    void Start()
    {
        
    }

   public void Onclick()
   {
    for (var i = 0; i < 5; i++)
    {
    GameObject playerCard = Instantiate(card1, new Vector3(0,0,0), Quaternion.identity);
    playerCard.transform setParent(AreadoPlayer.transform, false);
    
    }
   } 
}
