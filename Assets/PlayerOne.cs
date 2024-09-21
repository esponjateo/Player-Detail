using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI Domain;

    string Name = "Charlie Olof";
    string Race = "Gremor";
    string Origin = "Cast Away";
    string Attunements = "Flamecharm";
    int Strength = 26;
    int Fortitude = 69;
    int Agility = 25;
    int Intelligence = 70;
    int Willpower = 82;
    int Charisma = 6;


    public void CharlieOlof()
    {
        Domain.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nOrigin: " + Origin + "\r\nAttunements: " + Attunements + "\nStrength: " + Strength + "\nFortitude: " + Fortitude + "\nAgility: " + Agility + "\nIntelligence: " + Intelligence + "\nWillpower: " + Willpower + "\nCharisma: " + Charisma);
    }


}
