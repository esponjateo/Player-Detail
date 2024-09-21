using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Expansion;

    string Name = "Officer Winter";
    string Race = "Celtor";
    string Origin = "Void walker";
    string Attunements = "Ironsing";
    int Strength = 89;
    int Fortitude = 20;
    int Agility = 71;
    int Intelligence = 67;
    int Willpower = 12;
    int Charisma = 46;

    public void OfficerWinter()
    {
        Expansion.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nOrigin: " + Origin + "\r\nAttunements: " + Attunements + "\nStrength: " + Strength + "\nFortitude: " + Fortitude + "\nAgility: " + Agility + "\nIntelligence: " + Intelligence + "\nWillpower: " + Willpower + "\nCharisma: " + Charisma);
    }


}
