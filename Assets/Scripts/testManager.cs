using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testManager : MonoBehaviour
{
    [SerializeField] private Challenge[] challenges;
    // Start is called before the first frame update
    void Start()
    {
        challenges = new Challenge[10];
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


        challenges[0] = new Challenge(
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

    // Update is called once per frame
    void Update()
    {

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