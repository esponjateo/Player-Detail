using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Expansion;

    string Name = "Maurice Theodore";
    string Race = "Felinor";
    string Origin = "Deep Bound";
    string Attunements = "Shadowcast";
    int Strength = 73;
    int Fortitude = 98;
    int Agility = 5;
    int Intelligence = 24;
    int Willpower = 66;
    int Charisma = 76;

    public void MauriceTheodore()
    {
        Expansion.text = ("Name: " + Name + "\r\nRace: " + Race + "\r\nOrigin: " + Origin + "\r\nAttunements: " + Attunements + "\nStrength: " + Strength + "\nFortitude: " + Fortitude + "\nAgility: " + Agility + "\nIntelligence: " + Intelligence + "\nWillpower: " + Willpower + "\nCharisma: " + Charisma);
    }
}