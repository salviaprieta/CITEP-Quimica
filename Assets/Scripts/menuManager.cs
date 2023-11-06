using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [Header("Menu Selector")]
    [SerializeField] private TMP_Text badgeNumber;
    [Header("Inventory")]
    [SerializeField] private GameObject inventoryUI;
    [Header("Camera")]
    [SerializeField] private GameObject scanCameraAssets;
    [SerializeField] private GameObject scanCameraUI;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private TMP_Text cameraScoreText;
    [SerializeField] private TMP_Text cameraMoleculeText;
    [SerializeField] private GameObject notificationCanvas;
    [SerializeField] private Image notificationImage;
    [SerializeField] private TMP_Text notificationText;
    [Header("Main Menu")]
    [SerializeField] private GameObject mainMenu;
    [Header("Challenge")]
    [SerializeField] private GameObject challengeUI;
    [Header("Challenge - Difficulty")]
    [SerializeField] private GameObject challengeDificultyUI;
    [Header("Challenge - Introduction")]
    [SerializeField] private GameObject challengeIntroductionUI;
    [Header("Challenge - Question")]
    [SerializeField] private GameObject challengeQuestionUI;
    [SerializeField] private TMP_Text challengeScoreText;
    [SerializeField] private TMP_Text challengeMoleculeText;
    [SerializeField] private TMP_Text challengeQuestionText;
    [SerializeField] private Text challengeFirstResponseText;
    [SerializeField] private Text challengeSecondResponseText;
    [SerializeField] private Text challengeThirdResponseText;
    [SerializeField] private TMP_Text questionFeedback;
    [SerializeField] private Button continueButton;
    [SerializeField] private Toggle[] responseToggles;
    [Header("Challenge - Geometry")]
    [SerializeField] private GameObject challengeGeometryQuestionUI;
    [SerializeField] private Button firstGeometryOption;
    [SerializeField] private Button secondGeometryOption;
    [SerializeField] private Button thirdGeometryOption;
    [SerializeField] private TMP_Text geometryFeedback;
    [SerializeField] private Button geometryContinueButton;
    [Header("Variables")]
    [SerializeField] private int challengeStep = 1;
    [SerializeField] private int inventoryCounter = 0;

    public void goToInventory()
    {
        scanCameraAssets.SetActive(false);
        scanCameraUI.SetActive(false);
        challengeUI.SetActive(false);
        mainMenu.SetActive(false);
        mainCamera.SetActive(true);
        inventoryUI.SetActive(true);
    }

    public void goToScanCamera()
    {
        inventoryUI.SetActive(false);
        mainCamera.SetActive(false);
        challengeUI.SetActive(false);
        mainMenu.SetActive(false);
        scanCameraAssets.SetActive(true);
        scanCameraUI.SetActive(true);
    }

    public void goToChallenge()
    {
        mainMenu.SetActive(false);
        scanCameraAssets.SetActive(false);
        scanCameraUI.SetActive(false);
        inventoryUI.SetActive(false);
        mainCamera.SetActive(true);
        challengeUI.SetActive(true);
        if (challengeStep == 1)
        {
            challengeIntroductionUI.SetActive(false);
            challengeQuestionUI.SetActive(false);
            challengeGeometryQuestionUI.SetActive(false);
            challengeDificultyUI.SetActive(true);
        }
        else if (challengeStep == 2)
        {
            challengeDificultyUI.SetActive(false);
            challengeQuestionUI.SetActive(false);
            challengeGeometryQuestionUI.SetActive(false);
            challengeIntroductionUI.SetActive(true);
        }
        else if (challengeStep == 3)
        {
            challengeDificultyUI.SetActive(false);
            challengeIntroductionUI.SetActive(false);
            challengeGeometryQuestionUI.SetActive(false);
            challengeQuestionUI.SetActive(true);
        }
        else if (challengeStep == 4)
        {
            challengeDificultyUI.SetActive(false);
            challengeIntroductionUI.SetActive(false);
            challengeQuestionUI.SetActive(false);
            challengeGeometryQuestionUI.SetActive(true);
        }
    }

    public void nextChallengeStep()
    {
        challengeStep++;
        goToChallenge();
    }

    public void updateScoreText(string newText)
    {
        cameraScoreText.text = newText;
        challengeScoreText.text = newText;
    }

    public void updateMoleculeText(string newText)
    {
        cameraMoleculeText.text = newText;
        challengeMoleculeText.text = newText;
    }

    public void updateQuestionText(string question, string firstResponse, string secondResponse, string thirdResponse)
    {
        challengeQuestionText.text = question;
        challengeFirstResponseText.text = firstResponse;
        challengeSecondResponseText.text = secondResponse;
        challengeThirdResponseText.text = thirdResponse;
    }

    public IEnumerator elementAddedToInventory(string elementName, Sprite elementSprite)
    {
        inventoryCounter++;
        badgeNumber.text = inventoryCounter.ToString();
        notificationImage.sprite = elementSprite;
        notificationText.text = elementName;
        notificationCanvas.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        notificationCanvas.SetActive(false);
    }

    public void answerQuestion(string feedback, bool isOk)
    {
        if (isOk)
        {
            questionFeedback.color = Color.green;
            continueButton.interactable = true;
        }
        else
        {
            questionFeedback.color = Color.red;
            continueButton.interactable = false;
        }
        questionFeedback.text = feedback;
    }

    public void updateGeometryOptionImage(Sprite firstOption, Sprite secondOption, Sprite thirdOption)
    {
        firstGeometryOption.GetComponent<Image>().sprite = firstOption;
        secondGeometryOption.GetComponent<Image>().sprite = secondOption;
        thirdGeometryOption.GetComponent<Image>().sprite = thirdOption;
    }

    public void answerGeometryQuestion(string feedback, bool isOk)
    {
        if (isOk)
        {
            geometryFeedback.color = Color.green;
            geometryContinueButton.interactable = true;
        }
        else
        {
            geometryFeedback.color = Color.red;
            geometryContinueButton.interactable = false;
        }
        geometryFeedback.text = feedback;
    }
}
