using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChallengeManager : MonoBehaviour
{
    [SerializeField] private Challenge[] challenges;
    [SerializeField] private Challenge actualChallenge;
    [SerializeField] private bool hasActiveChallenge;
    [SerializeField] public int difficulty;
    [SerializeField] private TMP_Text introductionUI;
    [SerializeField] MenuManager menuManager;

    void Start()
    {
        challenges = new Challenge[2];
        challenges[0] = new Challenge(
            "El amoníaco constituye una fuente de nitrógeno para muchos procesos químicos. En particular, se investiga su uso para capturar CO2, un gas de efecto invernadero. En este desafío el reto es construir una molécula de amoníaco.",
            1,
            "Amoníaco",
            "NH3",
            new string[2] { "N", "H" },
            "¿Cuál es la geometría electrónica que presenta la molécula de amoníaco?",
            "Tetraédrica",
            "Piramidal con base triangular",
            "Plana trigonal",
            1
        );

        challenges[1] = new Challenge(
            "El agua resulta esencial para la vida en la Tierra, y también actúa como gas de efecto invernadero ante el calentamiento global. En este desafío te proponemos construir una molécula de agua.",
            1,
            "Agua",
            "H2O",
            new string[2] { "H", "O" },
            "Sabiendo que la geometría electrónica de una molécula de agua es tetraédrica, ¿qué ángulo de enlace HÔH esperarías?",
            "109,5°",
            "<109°",
            "120°",
            2
        );
    }

    public void StartChallenge(int difficulty)
    {
        this.difficulty = difficulty;
        List<Challenge> availableChallenges = new List<Challenge>();

        for (int i = 0; i < challenges.Length; i++)
        {
            if (challenges[i].difficulty == difficulty)
            {
                availableChallenges.Add(challenges[i]);
            }
        }

        actualChallenge = availableChallenges[Random.Range(0, challenges.Length)];
        hasActiveChallenge = true;

        introductionUI.text = actualChallenge.introduction;
        menuManager.nextChallengeStep();
    }
}

public class Challenge
{
    public string introduction;
    public int difficulty;
    public string moleculeName;
    public string molecularFormula;
    public string[] necessaryElements;
    public string question;
    public string optionA;
    public string optionB;
    public string optionC;
    public int correctOption;

    public Challenge(string introduction, int difficulty, string moleculeName, string molecularFormula, string[] necessaryElements, string question, string optionA, string optionB, string optionC, int correctOption)
    {
        this.introduction = introduction;
        this.difficulty = difficulty;
        this.moleculeName = moleculeName;
        this.molecularFormula = molecularFormula;

        this.necessaryElements = new string[necessaryElements.Length];
        for (int i = 0; i < necessaryElements.Length; i++)
        {
            this.necessaryElements[i] = necessaryElements[i];
        }

        this.question = question;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.correctOption = correctOption;
    }
}