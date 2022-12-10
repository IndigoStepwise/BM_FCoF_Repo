using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleJSON;
using LoLSDK;
using TMPro;


public class BM_LevelManager : MonoBehaviour
{
    // Buttons
    public Button flipButton;
    public Button submitButton;
    public Button nextButton;
    public Button retryButton;
    public Button newGameButton;
    public Button continueButton;
    public Button clearButton;

    // question nodes
    public GameObject questionNodeSurveyHun;
    public GameObject questionNodeSurveyThou;
    public GameObject questionNodeBigFraction;
    public GameObject questionNodeSmolFraction;

    // question image ref
    public GameObject sun0Image0;
    public GameObject sun0Image1;

    public GameObject sun1BImage0;

    public GameObject moon1BImage0;
    public GameObject moon1BImage1;

    public GameObject sun2AImage0;
    public GameObject sun2AImage1;

    public GameObject moon2AImage0;
    public GameObject moon2AImage1;

    public GameObject sun2BImage0;

    public GameObject moon2BImage0;

    public GameObject sun2CImage0;
    public GameObject sun2CImage1;

    public GameObject moon2CImage0;
    public GameObject moon2CImage1;

    public GameObject moon2DImage0;

    public GameObject finalImage0;
    public GameObject finalImage1;

    // Hundred Snap Box Ref
    public GameObject snapHunHundred;
    public GameObject snapHunTen;
    public GameObject snapHunOne;

    // Thousand Snap Box Ref
    public GameObject snapThouThousand;
    public GameObject snapThouHundred;
    public GameObject snapThouTen;
    public GameObject snapThouOne;

    // Smol Fraction snap box Ref
    public GameObject smolBoxTop0;
    public GameObject smolBoxTop1;
    public GameObject smolBoxTop2;
    public GameObject smolBoxBot0;
    public GameObject smolBoxBot1;
    public GameObject smolBoxBot2;

    // Big Fraction snap box Ref
    public GameObject bigBoxTop0;
    public GameObject bigBoxTop1;
    public GameObject bigBoxTop2;
    public GameObject bigBoxBot0;
    public GameObject bigBoxBot1;
    public GameObject bigBoxBot2_0;
    public GameObject bigBoxBot2_1;

    // coin reference
    public GameObject sunCoin;
    public GameObject moonCoin;

    // world state level

    public GameObject tutorGameNode;
    public GameObject level0GameNode;

    public GameObject sun0GameNode;
    public GameObject moon0GameNode;

    public GameObject sun1AGameNode;
    public GameObject moon1AGameNode;
    public GameObject sun1BGameNode;
    public GameObject moon1BGameNode;

    public GameObject sun2AGameNode;
    public GameObject moon2AGameNode;
    public GameObject sun2BGameNode;
    public GameObject moon2BGameNode;
    public GameObject sun2CGameNode;
    public GameObject moon2CGameNode;
    public GameObject sun2DGameNode;
    public GameObject moon2DGameNode;

    public GameObject finalGameNode;

    // spell cards
    public GameObject spellCardT;

    public GameObject spellCard0;

    public GameObject spellCardSun0;
    public GameObject spellCardMoon0;

    public GameObject spellCardSun1A;
    public GameObject spellCardMoon1A;
    public GameObject spellCardSun1B;
    public GameObject spellCardMoon1B;

    public GameObject spellCardSun2A_0;
    public GameObject spellCardSun2A_1;
    public GameObject spellCardMoon2A_0;
    public GameObject spellCardMoon2A_1;
    public GameObject spellCardSun2B_0;
    public GameObject spellCardSun2B_1;
    public GameObject spellCardMoon2B_0;
    public GameObject spellCardMoon2B_1;
    public GameObject spellCardSun2C_0;
    public GameObject spellCardSun2C_1;
    public GameObject spellCardMoon2C_0;
    public GameObject spellCardMoon2C_1;
    public GameObject spellCardSun2D_0;
    public GameObject spellCardSun2D_1;
    public GameObject spellCardMoon2D_0;
    public GameObject spellCardMoon2D_1;

    public GameObject spellCardFractionFinal_0;
    public GameObject spellCardFinalSurvey;
    public GameObject spellCardFractionFinal_1;

    // map
    public GameObject flipMap;

    public GameObject levelTNode;
    public GameObject connect_T_0;

    public GameObject level0MapNode;
    public GameObject connect0_Sun0;
    public GameObject connect0_Moon0;
    public GameObject levelSun0MapNode;
    public GameObject levelMoon0MapNode;

    public GameObject connectSun0_Sun1A;
    public GameObject connectSun0_Moon1A;
    public GameObject connectMoon0_Sun1B;
    public GameObject connectMoon0_Moon1B;
    public GameObject levelSun1AMapNode;
    public GameObject levelMoon1AMapNode;
    public GameObject levelSun1BMapNode;
    public GameObject levelMoon1BMapNode;

    public GameObject connectSun1A_Sun2B;
    public GameObject connectSun1A_Moon2B;
    public GameObject connectMoon1A_Sun2A;
    public GameObject connectMoon1A_Moon2A;
    public GameObject connectSun1B_Sun2D;
    public GameObject connectSun1B_Moon2D;
    public GameObject connectMoon1B_Sun2C;
    public GameObject connectMoon1B_Moon2C;
    public GameObject levelSun2AMapNode;
    public GameObject levelMoon2AMapNode;
    public GameObject levelSun2BMapNode;
    public GameObject levelMoon2BMapNode;
    public GameObject levelSun2CMapNode;
    public GameObject levelMoon2CMapNode;
    public GameObject levelSun2DMapNode;
    public GameObject levelMoon2DMapNode;

    public GameObject connectFinal0;
    public GameObject connectFinal1;
    public GameObject levelFinalMapNode;

    // final map
    public TextMeshProUGUI congratsText;
    public TextMeshProUGUI finalMath0Text;
    public TextMeshProUGUI finalMath1Text;
    public TextMeshProUGUI finalMath2Text;

    public GameObject flipMap_Final;

    public GameObject levelTNode_Final;
    public GameObject connect_T_0_Final;

    public GameObject level0MapNode_Final;
    public GameObject connect0_Sun0_Final;
    public GameObject connect0_Moon0_Final;
    public GameObject levelSun0MapNode_Final;
    public GameObject levelMoon0MapNode_Final;

    public GameObject connectSun0_Sun1A_Final;
    public GameObject connectSun0_Moon1A_Final;
    public GameObject connectMoon0_Sun1B_Final;
    public GameObject connectMoon0_Moon1B_Final;
    public GameObject levelSun1AMapNode_Final;
    public GameObject levelMoon1AMapNode_Final;
    public GameObject levelSun1BMapNode_Final;
    public GameObject levelMoon1BMapNode_Final;

    public GameObject connectSun1A_Sun2B_Final;
    public GameObject connectSun1A_Moon2B_Final;
    public GameObject connectMoon1A_Sun2A_Final;
    public GameObject connectMoon1A_Moon2A_Final;
    public GameObject connectSun1B_Sun2D_Final;
    public GameObject connectSun1B_Moon2D_Final;
    public GameObject connectMoon1B_Sun2C_Final;
    public GameObject connectMoon1B_Moon2C_Final;
    public GameObject levelSun2AMapNode_Final;
    public GameObject levelMoon2AMapNode_Final;
    public GameObject levelSun2BMapNode_Final;
    public GameObject levelMoon2BMapNode_Final;
    public GameObject levelSun2CMapNode_Final;
    public GameObject levelMoon2CMapNode_Final;
    public GameObject levelSun2DMapNode_Final;
    public GameObject levelMoon2DMapNode_Final;

    public GameObject connectFinal0_Final;
    public GameObject connectFinal1_Final;
    public GameObject levelFinalMapNode_Final;

    // text Ref
    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    public TextMeshProUGUI questionT_Text;

    public TextMeshProUGUI question0Text;
    public TextMeshProUGUI questionSun0Text;
    public TextMeshProUGUI questionMoon0Text;

    public TextMeshProUGUI questionSun1AText;
    public TextMeshProUGUI questionMoon1AText;
    public TextMeshProUGUI questionSun1BText;
    public TextMeshProUGUI questionMoon1BText;

    public TextMeshProUGUI questionSun2A_0Text;
    public TextMeshProUGUI questionSun2A_1Text;

    public TextMeshProUGUI questionMoon2A_0Text;
    public TextMeshProUGUI questionMoon2A_1Text;

    public TextMeshProUGUI questionSun2B_0Text;
    public TextMeshProUGUI questionSun2B_1Text;

    public TextMeshProUGUI questionMoon2B_0Text;
    public TextMeshProUGUI questionMoon2B_1Text;

    public TextMeshProUGUI questionSun2C_0Text;
    public TextMeshProUGUI questionSun2C_1Text;

    public TextMeshProUGUI questionMoon2C_0Text;
    public TextMeshProUGUI questionMoon2C_1Text;

    public TextMeshProUGUI questionSun2D_0Text;
    public TextMeshProUGUI questionSun2D_1Text;

    public TextMeshProUGUI questionMoon2D_0Text;
    public TextMeshProUGUI questionMoon2D_1Text;

    public TextMeshProUGUI questionFinalSurveyText0;
    public TextMeshProUGUI questionFinalFractionText0;
    public TextMeshProUGUI questionFinalFractionText1;

    // Big Fraction number arrays
    public GameObject[] bigTop0;
    public GameObject[] bigTop1;
    public GameObject[] bigTop2;
    public GameObject[] bigBottom0;
    public GameObject[] bigBottom1;
    public GameObject[] bigBottom2_0;
    public GameObject[] bigBottom2_1;

    // Smol fraction number arrays
    public GameObject[] smolTop0;
    public GameObject[] smolTop1;
    public GameObject[] smolTop2;
    public GameObject[] smolBottom0;
    public GameObject[] smolBottom1;
    public GameObject[] smolBottom2;

    // hundred number array
    public GameObject[] hunHundredNum;
    public GameObject[] hunTenNum;
    public GameObject[] hunOneNum;

    // Thousand number array
    public GameObject[] thouThousandNum;
    public GameObject[] thouHundredNum;
    public GameObject[] thouTenNum;
    public GameObject[] thouOneNum;

    // level variable
    public float level = 0f;

    // attempt bools
    public bool attempt1;
    public bool attempt2;
    public bool attempt3;

    // runs at start
    private void Start()
    { 
        correctText.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(false);

        flipButton.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        newGameButton.gameObject.SetActive(true);
        continueButton.gameObject.SetActive(true);
        clearButton.gameObject.SetActive(false);

        questionT_Text.gameObject.SetActive(false);
        
        question0Text.gameObject.SetActive(false);
        questionSun0Text.gameObject.SetActive(false);
        questionMoon0Text.gameObject.SetActive(false);

        questionSun1AText.gameObject.SetActive(false);
        questionMoon1AText.gameObject.SetActive(false);
        questionSun1BText.gameObject.SetActive(false);
        questionMoon1BText.gameObject.SetActive(false);

        questionSun2A_0Text.gameObject.SetActive(false);
        questionSun2A_1Text.gameObject.SetActive(false);
        questionMoon2A_0Text.gameObject.SetActive(false);
        questionMoon2A_1Text.gameObject.SetActive(false);

        questionSun2B_0Text.gameObject.SetActive(false);
        questionSun2B_1Text.gameObject.SetActive(false);
        questionMoon2B_0Text.gameObject.SetActive(false);
        questionMoon2B_1Text.gameObject.SetActive(false);

        questionSun2C_0Text.gameObject.SetActive(false);
        questionSun2C_1Text.gameObject.SetActive(false);
        questionMoon2C_0Text.gameObject.SetActive(false);
        questionMoon2C_1Text.gameObject.SetActive(false);

        questionSun2D_0Text.gameObject.SetActive(false);
        questionSun2D_1Text.gameObject.SetActive(false);
        questionMoon2D_0Text.gameObject.SetActive(false);
        questionMoon2D_1Text.gameObject.SetActive(false);

        questionFinalSurveyText0.gameObject.SetActive(false);
        questionFinalFractionText0.gameObject.SetActive(false);
        questionFinalFractionText1.gameObject.SetActive(false);

        spellCardT.gameObject.SetActive(false);

        spellCard0.gameObject.SetActive(false);
        spellCardSun0.gameObject.SetActive(false);
        spellCardMoon0.gameObject.SetActive(false);
        spellCardSun1A.gameObject.SetActive(false);
        spellCardMoon1A.gameObject.SetActive(false);
        spellCardSun1B.gameObject.SetActive(false);
        spellCardMoon1B.gameObject.SetActive(false);

        spellCardSun2A_0.gameObject.SetActive(false);
        spellCardSun2A_1.gameObject.SetActive(false);
        spellCardMoon2A_0.gameObject.SetActive(false);
        spellCardMoon2A_1.gameObject.SetActive(false);

        spellCardSun2B_0.gameObject.SetActive(false);
        spellCardSun2B_1.gameObject.SetActive(false);
        spellCardMoon2B_0.gameObject.SetActive(false);
        spellCardMoon2B_1.gameObject.SetActive(false);

        spellCardSun2C_0.gameObject.SetActive(false);
        spellCardSun2C_1.gameObject.SetActive(false);
        spellCardMoon2C_0.gameObject.SetActive(false);
        spellCardMoon2C_1.gameObject.SetActive(false);

        spellCardSun2D_0.gameObject.SetActive(false);
        spellCardSun2D_1.gameObject.SetActive(false);
        spellCardMoon2D_0.gameObject.SetActive(false);
        spellCardMoon2D_1.gameObject.SetActive(false);

        spellCardFractionFinal_0.gameObject.SetActive(false);
        spellCardFinalSurvey.gameObject.SetActive(false);
        spellCardFractionFinal_1.gameObject.SetActive(false);

        flipMap.gameObject.SetActive(false);
        sunCoin.gameObject.SetActive(false);
        moonCoin.gameObject.SetActive(false);

        questionNodeSurveyHun.SetActive(false);
        questionNodeSurveyThou.SetActive(false);
        questionNodeBigFraction.SetActive(false);
        questionNodeSmolFraction.SetActive(false);

        flipMap_Final.gameObject.SetActive(false);

        congratsText.gameObject.SetActive(false);
        finalMath0Text.gameObject.SetActive(false);
        finalMath1Text.gameObject.SetActive(false);
        finalMath2Text.gameObject.SetActive(false);

        tutorGameNode.gameObject.SetActive(true);
        level0GameNode.gameObject.SetActive(false);
        sun0GameNode.gameObject.SetActive(false);
        moon0GameNode.gameObject.SetActive(false);

        sun1AGameNode.gameObject.SetActive(false);
        moon1AGameNode.gameObject.SetActive(false);
        sun1BGameNode.gameObject.SetActive(false);
        moon1BGameNode.gameObject.SetActive(false);

        sun2AGameNode.gameObject.SetActive(false);
        moon2AGameNode.gameObject.SetActive(false);
        sun2BGameNode.gameObject.SetActive(false);
        moon2BGameNode.gameObject.SetActive(false);
        sun2CGameNode.gameObject.SetActive(false);
        moon2CGameNode.gameObject.SetActive(false);
        sun2DGameNode.gameObject.SetActive(false);
        moon2DGameNode.gameObject.SetActive(false);

        finalGameNode.gameObject.SetActive(false);

    }

    // run on awake
    private void Awake()
    {
        flipButton.onClick.AddListener(OnClickFlip);
        submitButton.onClick.AddListener(OnClickSubmit);
        nextButton.onClick.AddListener(OnClickNext);
        retryButton.onClick.AddListener(OnClickRetry);
        newGameButton.onClick.AddListener(OnClickNew);
        continueButton.onClick.AddListener(OnClickContinue);
        clearButton.onClick.AddListener(OnClickClear);
    }

    // on click new button
    private void OnClickNew()
    {
        spellCardT.gameObject.SetActive(true);
        newGameButton.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);

        level = 0.1f;
    }

    // on click continue button
    private void OnClickContinue()
    {
        Debug.Log("Clicked Continue");
    }

    // on click retry button
    private void OnClickRetry()
    {
        Clear();

        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        if (level == 0.1f)
        {
            spellCardT.gameObject.SetActive(true);

            questionT_Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            retryButton.gameObject.SetActive(false);
        }

        if (level == 0.5f)
        {
            spellCard0.gameObject.SetActive(true);

            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            retryButton.gameObject.SetActive(false);
        }

        if (level == 1.1f || level == 1.2f)
        {
            if (sun0GameNode.gameObject.activeInHierarchy)
            {
                spellCardSun0.gameObject.SetActive(true);

                questionSun0Text.gameObject.SetActive(false);
                sun0Image0.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                retryButton.gameObject.SetActive(false);
            }

            if (moon0GameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon0.gameObject.SetActive(true);

                questionMoon0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                retryButton.gameObject.SetActive(false);
            }
        }

        if (level == 2.1f || level == 2.2f || level == 2.3f || level == 2.4f)
        {
            if (sun1AGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun1A.gameObject.SetActive(true);

                questionSun1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                retryButton.gameObject.SetActive(false);
            }

            if (moon1AGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon1A.gameObject.SetActive(true);

                questionMoon1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                
                retryButton.gameObject.SetActive(false);
            }

            if ( sun1BGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun1B.gameObject.SetActive(true);

                questionSun1BText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                sun1BImage0.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon1BGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon1B.gameObject.SetActive(true);

                questionMoon1BText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                moon1BImage0.gameObject.SetActive(false);
                moon1BImage1.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }
        }

        if (level == 3.1f || level == 3.2f || level == 3.3f || level == 3.4f || level == 3.5f || level == 3.6f || level == 3.7f || level == 3.8f)
        {

            if (sun2AGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2A_0.gameObject.SetActive(true);

                questionSun2A_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                sun2AImage0.gameObject.SetActive(false);
                sun2AImage1.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);

            }
            
            if (moon2AGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2A_0.gameObject.SetActive(true);

                questionMoon2A_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                moon2AImage0.gameObject.SetActive(false);
                moon2AImage1.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2BGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2B_0.gameObject.SetActive(true);

                questionSun2B_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                sun2BImage0.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2BGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2B_0.gameObject.SetActive(true);

                questionMoon2B_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                moon2BImage0.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2CGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2C_0.gameObject.SetActive(true);

                questionSun2C_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                sun2CImage0.gameObject.SetActive(false);
                sun2CImage1.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2CGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2C_0.gameObject.SetActive(true);

                questionMoon2C_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2DGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2D_0.gameObject.SetActive(true);

                questionSun2D_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2DGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2D_0.gameObject.SetActive(true);

                questionMoon2D_0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                moon2DImage0.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }
        }

        if (level == 3.15f || level == 3.25f || level == 3.35f || level == 3.45f || level == 3.55f || level == 3.65f || level == 3.75f || level == 3.85f)
        {

            if (sun2AGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2A_1.gameObject.SetActive(true);

                questionSun2A_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2AGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2A_1.gameObject.SetActive(true);

                questionMoon2A_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2BGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2B_1.gameObject.SetActive(true);

                questionSun2B_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2BGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2B_1.gameObject.SetActive(true);

                questionMoon2B_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2CGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2C_1.gameObject.SetActive(true);

                questionSun2C_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2CGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2C_1.gameObject.SetActive(true);

                questionMoon2C_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                moon2CImage0.gameObject.SetActive(false);
                moon2CImage1.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (sun2DGameNode.gameObject.activeInHierarchy)
            {
                spellCardSun2D_1.gameObject.SetActive(true);

                questionSun2D_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }

            if (moon2DGameNode.gameObject.activeInHierarchy)
            {
                spellCardMoon2D_1.gameObject.SetActive(true);

                questionMoon2D_1Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                retryButton.gameObject.SetActive(false);
            }
        }

        if (level == 4.1f)
        {
            spellCardFractionFinal_0.gameObject.SetActive(true);

            questionFinalFractionText0.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }

        if (level == 4.2f)
        {
            spellCardFinalSurvey.gameObject.SetActive(true);

            questionFinalSurveyText0.gameObject.SetActive(false);
            finalImage0.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }

        if (level == 4.3f)
        {
            spellCardFractionFinal_1.gameObject.SetActive(true);

            questionFinalFractionText1.gameObject.SetActive(false);
            finalImage1.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }
    }

    private void Clear()
    {
        snapHunHundred.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        snapHunTen.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        snapHunOne.gameObject.GetComponent<BoxCollider>().enabled = enabled;

        snapHunHundred.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapHunHundred.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapHunTen.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapHunTen.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapHunOne.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapHunOne.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapThouThousand.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        snapThouHundred.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        snapThouTen.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        snapThouOne.gameObject.GetComponent<BoxCollider>().enabled = enabled;

        snapThouThousand.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapThouThousand.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapThouHundred.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapThouHundred.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapThouTen.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapThouTen.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        snapThouOne.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        snapThouOne.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxTop0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        smolBoxTop1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        smolBoxTop2.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        smolBoxBot0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        smolBoxBot1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        smolBoxBot2.gameObject.GetComponent<BoxCollider>().enabled = enabled;

        smolBoxTop0.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxTop0.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxTop1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxTop1.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxTop2.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxTop2.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxBot0.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxBot0.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxBot1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxBot1.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        smolBoxBot2.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        smolBoxBot2.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxTop0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxTop1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxTop2.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxBot0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxBot1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxBot2_0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        bigBoxBot2_1.gameObject.GetComponent<BoxCollider>().enabled = enabled;

        bigBoxTop0.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxTop0.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxTop1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxTop1.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxTop2.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxTop2.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxBot0.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxBot0.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxBot1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxBot1.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxBot2_0.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxBot2_0.gameObject.transform.GetChild(9).gameObject.SetActive(false);

        bigBoxBot2_1.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(1).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(2).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(4).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(5).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(6).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(7).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(8).gameObject.SetActive(false);
        bigBoxBot2_1.gameObject.transform.GetChild(9).gameObject.SetActive(false);
    }

    // on click clear button
    private void OnClickClear()
    {
        Clear();

    }

    // runs on click flip button
    private void OnClickFlip()
    {
        Clear();

        if (level == 0.5f)
        {
            StartCoroutine(CoinFlip0());
        }

        if (level == 1.1f || level == 1.2f)
        {
            StartCoroutine(CoinFlip1());
        }

        if (level == 2.1f || level == 2.2f || level == 2.3f || level == 2.4f)
        {
            StartCoroutine(CoinFlip2());
        }
    }

    // coin flip level 0 function, call above
    IEnumerator CoinFlip0()
    {
        float randomNumber = Random.Range(0, 2);
        flipButton.gameObject.SetActive(false);
        BM_AudioManager.instance.Play("Button");

        // and ranNum is 0, output Sun
        if (randomNumber == 0)
        {
            sunCoin.gameObject.SetActive(true);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            yield return new WaitForSecondsRealtime(3);
            sun0GameNode.gameObject.SetActive(true);
            Debug.Log("SUN0");
            sunCoin.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);

            questionNodeSurveyHun.gameObject.SetActive(false);

            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            spellCardSun0.gameObject.SetActive(true);

            level = 1.1f;
        }

        // and ranNum is 1, output Moon
        if (randomNumber == 1)
        {
            moonCoin.gameObject.SetActive(true);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            moon0GameNode.gameObject.SetActive(true);
            Debug.Log("MOON0");
            moonCoin.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);

            questionNodeSurveyHun.gameObject.SetActive(false);

            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            spellCardMoon0.gameObject.SetActive(true);

            level = 1.2f;
        }

        LOLSDK.Instance.SubmitProgress(100, 20, 100);
        Debug.Log("Timer Done");
    }

    // coin flip level 1 function, call above
    IEnumerator CoinFlip1()
    {
        float randomNumber = Random.Range(0, 2);
        flipButton.gameObject.SetActive(false);
        BM_AudioManager.instance.Play("Button");

        // if current state is Sun0
        if (sun0GameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);
                sun1AGameNode.gameObject.SetActive(true);

                sunCoin.gameObject.SetActive(false);
                Debug.Log("SUN1A");
                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);

                questionSun0Text.gameObject.SetActive(false);
                sun0Image0.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardSun1A.gameObject.SetActive(true);

                level = 2.1f;
            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                moon1AGameNode.gameObject.SetActive(true);

                Debug.Log("MOON1A");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);
                sun0Image0.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                questionSun0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardMoon1A.gameObject.SetActive(true);

                level = 2.2f;
            }

        }

        // if current state is Moon0
        if (moon0GameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                sun1BGameNode.gameObject.SetActive(true);

                Debug.Log("SUN1B");
                sunCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);

                questionMoon0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardSun1B.gameObject.SetActive(true);

                level = 2.3f;
            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);
                moon1BGameNode.gameObject.SetActive(true);

                Debug.Log("MOON1B");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);

                questionMoon0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardMoon1B.gameObject.SetActive(true);

                level = 2.4f;
            }
        }

        LOLSDK.Instance.SubmitProgress(100, 40, 100);
        Debug.Log("Timer Done");
    }

    // coin flip level 2 function, call above
    IEnumerator CoinFlip2()
    {
        float randomNumber = Random.Range(0, 2);
        flipButton.gameObject.SetActive(false);
        BM_AudioManager.instance.Play("Button");

        // if world state is Sun1A
        if (sun1AGameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if ( randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                sun2BGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2B");
                sunCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeSurveyHun.gameObject.SetActive(false);
                questionSun1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.3f;

                spellCardSun2B_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if ( randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);;
                moon2BGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2B");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeSurveyHun.gameObject.SetActive(false);
                questionSun1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.4f;

                spellCardMoon2B_0.gameObject.SetActive(true);
            }
        }

        // if world state Moon1A
        if (moon1AGameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);
                sun2AGameNode.gameObject.SetActive(true);
 
                Debug.Log("SUN2A");
                sunCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeSurveyHun.gameObject.SetActive(false);
                questionMoon1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.1f;

                spellCardSun2A_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                moon2AGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2A");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeSurveyHun.gameObject.SetActive(false);
                questionMoon1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.2f;

                spellCardMoon2A_0.gameObject.SetActive(true);
            }
        }

        // if world state is Sun1B
        if (sun1BGameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);
                sun2DGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2D");
                sunCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);
                sun1BImage0.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionSun1BText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.8f;

                spellCardSun2D_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                moon2DGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2D");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);
                sun1BImage0.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionSun1BText.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.7f;

                spellCardMoon2D_0.gameObject.SetActive(true);
            }
        }

        // if world state is Moon1B
        if (moon1BGameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                yield return new WaitForSecondsRealtime(3);
                sun2CGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2C");
                sunCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);
                questionMoon1BText.gameObject.SetActive(false);
                moon1BImage0.gameObject.SetActive(false);
                moon1BImage1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.5f;

                spellCardSun2C_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(3);
                moon2CGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2C");
                moonCoin.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(false);

                questionNodeBigFraction.gameObject.SetActive(false);
                questionMoon1BText.gameObject.SetActive(false);
                moon1BImage0.gameObject.SetActive(false);
                moon1BImage1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                level = 3.6f;

                spellCardMoon2C_0.gameObject.SetActive(true);
            }
        }

        LOLSDK.Instance.SubmitProgress(100, 60, 100);
        Debug.Log("Timer Done");
    }

    // next button during stages with more
    private void OnClickNext()
    {
        Debug.Log("Next");
        BM_AudioManager.instance.Play("Button");
        clearButton.gameObject.SetActive(false);

        Clear();

        if (level == 0.1f)
        {
            StartCoroutine(Next_T());
        }

        if (level == 3.1f || level == 3.2f ||  level == 3.3f || level == 3.4f || level == 3.5f || level == 3.6f || level == 3.7f ||level == 3.8f)
        {
            StartCoroutine(Next_4());
        }

        if (level == 3.15f || level == 3.25f || level == 3.35f || level == 3.45f || level == 3.55f || level == 3.65f || level == 3.75f || level == 3.85f)
        {
            StartCoroutine(Next_4_5());
        }

        if (level == 4.1f)
        {
            StartCoroutine(Next_Final0());
        }

        if (level == 4.2f)
        {
            StartCoroutine(Next_Final1());
        }

        if (level == 4.3f)
        {
            StartCoroutine(Next_Final2());
        }
    }

    IEnumerator Next_T()
    {
        flipMap.gameObject.SetActive(true);

        nextButton.gameObject.SetActive(false);

        connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

        level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

        yield return new WaitForSecondsRealtime(3);
        level0GameNode.gameObject.SetActive(true);
        questionT_Text.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        correctText.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(false);

        level = 0.5f;

        flipMap.gameObject.SetActive(false);
        spellCard0.gameObject.SetActive(true);

        LOLSDK.Instance.SubmitProgress(100, 10, 100);
    }

    IEnumerator Next_4()
    {

        if (level == 3.1f)
        {

            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            sun2AImage0.gameObject.SetActive(false);
            sun2AImage1.gameObject.SetActive(false);
            questionSun2A_0Text.gameObject.SetActive(false);

            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardSun2A_1.gameObject.SetActive(true);

            level = 3.15f;
        }

        if (level == 3.2f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            moon2AImage0.gameObject.SetActive(false);
            moon2AImage1.gameObject.SetActive(false);
            questionMoon2A_0Text.gameObject.SetActive(false);

            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardMoon2A_1.gameObject.SetActive(true);

            level = 3.25f;
        }

        if (level == 3.3f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            questionSun2B_0Text.gameObject.SetActive(false);
            sun2BImage0.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false); correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardSun2B_1.gameObject.SetActive(true);

            level = 3.35f;
        }

        if (level == 3.4f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            moon2BImage0.gameObject.SetActive(false);
            questionMoon2B_0Text.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardMoon2B_1.gameObject.SetActive(true);

            level = 3.45f;
        }

        if (level == 3.5f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            sun2CImage0.gameObject.SetActive(false);
            sun2CImage1.gameObject.SetActive(false);
            questionSun2C_0Text.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardSun2C_1.gameObject.SetActive(true);

            level = 3.55f;
        }

        if (level == 3.6f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            questionMoon2C_0Text.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardMoon2C_1.gameObject.SetActive(true);

            level = 3.65f;
        }

        if (level == 3.7f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            questionSun2D_0Text.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardSun2D_1.gameObject.SetActive(true);

            level = 3.75f;
        }

        if (level == 3.8f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);

            moon2DImage0.gameObject.SetActive(false);
            questionMoon2D_0Text.gameObject.SetActive(false);
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardMoon2D_1.gameObject.SetActive(true);

            level = 3.85f;
        }

        LOLSDK.Instance.SubmitProgress(100, 70, 100);
    }

    IEnumerator Next_4_5()
    {

        if (level == 3.15f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(false);
            sun0GameNode.gameObject.SetActive(true);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(true);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(false);

            sun2AGameNode.gameObject.SetActive(true);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionSun2A_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from sun2A");
        }

        if (level == 3.25f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(false);
            sun0GameNode.gameObject.SetActive(true);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(true);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(false);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(true);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionMoon2A_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from moon2A");
        }

        if (level == 3.35f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(false);
            sun0GameNode.gameObject.SetActive(true);

            sun1AGameNode.gameObject.SetActive(true);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(false);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(true);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionSun2B_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from sun2B");
        }

        if (level == 3.45f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(false);
            sun0GameNode.gameObject.SetActive(true);

            sun1AGameNode.gameObject.SetActive(true);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(false);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(true);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionMoon2B_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from moon2B");
        }

        if (level == 3.55f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(true);
            sun0GameNode.gameObject.SetActive(false);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(true);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(true);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionSun2C_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from sun2C");
        }

        if (level == 3.65f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(true);
            sun0GameNode.gameObject.SetActive(false);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(true);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(true);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);

            moon2CImage0.gameObject.SetActive(false);
            moon2CImage1.gameObject.SetActive(false);
            questionMoon2C_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from moon2C");
        }

        if (level == 3.75f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(true);
            sun0GameNode.gameObject.SetActive(false);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(true);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(true);
            moon2DGameNode.gameObject.SetActive(false);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionSun2D_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from sun2D");
        }

        if (level == 3.85f)
        {
            tutorGameNode.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);

            moon0GameNode.gameObject.SetActive(true);
            sun0GameNode.gameObject.SetActive(false);

            sun1AGameNode.gameObject.SetActive(false);
            moon1AGameNode.gameObject.SetActive(false);
            sun1BGameNode.gameObject.SetActive(false);
            moon1BGameNode.gameObject.SetActive(true);

            sun2AGameNode.gameObject.SetActive(false);
            moon2AGameNode.gameObject.SetActive(false);
            sun2BGameNode.gameObject.SetActive(false);
            moon2BGameNode.gameObject.SetActive(false);
            sun2CGameNode.gameObject.SetActive(false);
            moon2CGameNode.gameObject.SetActive(false);
            sun2DGameNode.gameObject.SetActive(false);
            moon2DGameNode.gameObject.SetActive(true);

            finalGameNode.gameObject.SetActive(true);

            flipMap.gameObject.SetActive(true);

            nextButton.gameObject.SetActive(false);

            connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

            levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

            yield return new WaitForSecondsRealtime(3);
            questionMoon2D_1Text.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            flipMap.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            level = 4.1f;

            Debug.Log("Final from moon2D");
        }

        LOLSDK.Instance.SubmitProgress(100, 80, 100);

        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);
    }

    IEnumerator Next_Final0()
    {

        if (level == 4.1f)
        {
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);
            questionFinalFractionText0.gameObject.SetActive(false);
            finalImage0.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            spellCardFinalSurvey.gameObject.SetActive(true);

            level = 4.2f;
            LOLSDK.Instance.SubmitProgress(100, 90, 100);
        }

        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);
    }

    IEnumerator Next_Final1()
    {

        if (level == 4.2f)
        {
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);
            questionFinalSurveyText0.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            spellCardFractionFinal_1.gameObject.SetActive(true);

            level = 4.3f;

            LOLSDK.Instance.SubmitProgress(100, 95, 100);
        }

        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);
    }

    IEnumerator Next_Final2()
    {

        if (level == 4.3f)
        {
            questionNodeBigFraction.gameObject.SetActive(false);
            questionNodeSmolFraction.gameObject.SetActive(false);
            questionNodeSurveyThou.gameObject.SetActive(false);
            questionNodeSurveyHun.gameObject.SetActive(false);
            questionFinalFractionText1.gameObject.SetActive(false);

            finalImage1.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);

            // if final was reach through sun2A
            if (sun2AGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelMoon1AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Moon1A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1A_Sun2A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);

            }

            // if final was reach through moon2A
            if (moon2AGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);
                finalImage1.gameObject.SetActive(false);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon1AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Moon1A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon2AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1A_Moon2A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through sun2B
            if (sun2BGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1A_Sun2B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through moon2B
            if (moon2BGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1AMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon2BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1A_Moon2B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through sun2C
            if (sun2CGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Moon1B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2CMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2CMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon1B_Sun2C_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon1B_Moon2C_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through moon2C
            if (moon2CGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Moon0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon1BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Moon1B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon2CMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1B_Moon2C_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through sun2D
            if (sun2DGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Moon0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2DMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1B_Sun2D_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }

            // if final was reach through moon2D
            if (moon2DGameNode.gameObject.activeInHierarchy)
            {
                flipMap_Final.gameObject.SetActive(true);
                congratsText.gameObject.SetActive(true);

                connect_T_0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon0MapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Moon0_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelMoon2DMapNode_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1B_Moon2D_Final.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                yield return new WaitForSecondsRealtime(1);
                finalMath0Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath1Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
                finalMath2Text.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(1);
            }
        }

        LOLSDK.Instance.SubmitProgress(100, 100, 100);
        LOLSDK.Instance.CompleteGame();
    }

    // runs on click submit button
    private void OnClickSubmit()
    {
        Debug.Log("Submit");
        BM_AudioManager.instance.Play("Button");
        clearButton.gameObject.SetActive(false);

        // if Tutorial
        if (level == 0.1f)
        {
            if ( // 1/2 X 1/2 = 1/4
                smolTop0[1].gameObject.activeInHierarchy && smolTop1[1].gameObject.activeInHierarchy && smolTop2[1].gameObject.activeInHierarchy &&
                smolBottom0[2].gameObject.activeInHierarchy && smolBottom1[2].gameObject.activeInHierarchy && smolBottom2[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                flipMap.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if level 0
        if (level == 0.5f)
        {
            if (// 110
                hunHundredNum[1].gameObject.activeInHierarchy && hunTenNum[1].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

            }
            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

            // if current world state is Sun0
            if (sun0GameNode.gameObject.activeInHierarchy && level == 1.1f)
            {
                if (// 1/4 X 1/8 = 1/32
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[4].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy 
                    ||
                    // 1/8 X 1/4 = 1/32
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[4].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy )
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);

                    flipMap.gameObject.SetActive(true);
                    Debug.Log("Correct");
                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }

            }

            // if current world state is Moon0
            if (moon0GameNode.gameObject.activeInHierarchy && level == 1.2f)
            {
                if (// 1/2 X 1/6 = 1/12
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[2].gameObject.activeInHierarchy && bigBottom1[6].gameObject.activeInHierarchy && bigBottom2_0[1].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy
                    ||
                    // 1/6 X 1/2 = 1/12
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[6].gameObject.activeInHierarchy && bigBottom1[2].gameObject.activeInHierarchy && bigBottom2_0[1].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    flipMap.gameObject.SetActive(true);

                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }
            }

            // if current state is sun1A
            if (sun1AGameNode.gameObject.activeInHierarchy && level == 2.1f)
            {
                if (// 400
                hunHundredNum[4].gameObject.activeInHierarchy && hunTenNum[0].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    flipMap.gameObject.SetActive(true);

                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }
            }

            // if current state moon1A
            if (moon1AGameNode.gameObject.activeInHierarchy && level == 2.2f)
            {
                if (// 475
                hunHundredNum[4].gameObject.activeInHierarchy && hunTenNum[7].gameObject.activeInHierarchy && hunOneNum[5].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    flipMap.gameObject.SetActive(true);

                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }
            }

            // if state is sun1B
            if (sun1BGameNode.gameObject.activeInHierarchy && level == 2.3f)
            {
                if (// 3/8 X 1/8 = 3/64
                    bigTop0[3].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[6].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy
                    ||
                    // 1/8 X 3/8 = 3/64
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[3].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[6].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    flipMap.gameObject.SetActive(true);

                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }
            }

            // if state is moon1B
            if (moon1BGameNode.gameObject.activeInHierarchy && level == 2.4f)
            {
                if (// 3/8 X 1/6 = 3/48
                    bigTop0[3].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[6].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[8].gameObject.activeInHierarchy
                    ||
                    // 1/6 X 3/8 = 3/48
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[3].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[6].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[8].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    flipMap.gameObject.SetActive(true);

                    connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                    connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                    levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                    levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                    connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

                    levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                    levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                }

                // wrong input
                else
                {
                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                }
            }

        // if Sun2A world state and 1st question
        if (sun2AGameNode.gameObject.activeInHierarchy && level == 3.1f)
        {
            if ( // 3/8 X 2/5 = 3/20
                    bigTop0[3].gameObject.activeInHierarchy && bigTop1[2].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[5].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy
                    ||
                 // 2/5 X 3/8 = 3/20
                    bigTop0[2].gameObject.activeInHierarchy && bigTop1[3].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                    bigBottom0[5].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if Sun2A world state and 2nd question
        if (sun2AGameNode.gameObject.activeInHierarchy && level == 3.15f)
        {
            if ( // 560
                hunHundredNum[5].gameObject.activeInHierarchy && hunTenNum[6].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy )
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                flipMap.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if Moon2A world state and 1st question
        if (moon2AGameNode.gameObject.activeInHierarchy && level == 3.2f)
        {
            if ( // 1/9 X 2/5 = 2/45
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[2].gameObject.activeInHierarchy && bigTop2[2].gameObject.activeInHierarchy &&
                    bigBottom0[9].gameObject.activeInHierarchy && bigBottom1[5].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[5].gameObject.activeInHierarchy
                    ||
                 // 2/5 X 1/9 = 2/45
                    bigTop0[2].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[2].gameObject.activeInHierarchy &&
                    bigBottom0[5].gameObject.activeInHierarchy && bigBottom1[9].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if Moon2A world state and 2nd question
        if (moon2AGameNode.gameObject.activeInHierarchy && level == 3.25f)
        {
            if ( // 2315 
                 thouThousandNum[2].gameObject.activeInHierarchy && thouHundredNum[3].gameObject.activeInHierarchy && thouTenNum[1].gameObject.activeInHierarchy && thouOneNum[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                flipMap.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1A_Sun2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon1A_Moon2A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2B state and 1st question
        if (sun2BGameNode.gameObject.activeInHierarchy && level == 3.3f)
        {
            if ( // 1/8 X 3/8 = 3/64
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[3].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[6].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy
                 ||
                 // 3/8 X 1/8 = 3/64
                 bigTop0[3].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[3].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[6].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2B state and 2nd question
        if (sun2BGameNode.gameObject.activeInHierarchy && level == 3.35f)
        {
            if ( // 625
                 hunHundredNum[6].gameObject.activeInHierarchy && hunTenNum[2].gameObject.activeInHierarchy && hunOneNum[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                flipMap.gameObject.SetActive(true);

                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if moon2B state and 1st question
        if (moon2BGameNode.gameObject.activeInHierarchy && level == 3.4f)
        {
            if ( // 1/8 X 1/9 = 1/72
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[9].gameObject.activeInHierarchy && bigBottom2_0[7].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy
                    ||
                 // 1/9 X 1/8 = 1/72
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[9].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[7].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if moon2B state and 2nd question
        if (moon2BGameNode.gameObject.activeInHierarchy && level == 3.45f)
        {
            if ( // 728
                 hunHundredNum[7].gameObject.activeInHierarchy && hunTenNum[2].gameObject.activeInHierarchy && hunOneNum[8].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1AMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun0_Sun1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun0_Moon1A.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1A_Moon2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun1A_Sun2B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2C state and 1st question
        if (sun2CGameNode.gameObject.activeInHierarchy && level == 3.5f)
        {
            if ( // 1/8 X 2/5 = 1/20
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[2].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[5].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy
                    ||
                 // 2/5 X 1/8 = 1/20
                 bigTop0[2].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[5].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2C state and 2nd question
        if (sun2CGameNode.gameObject.activeInHierarchy && level == 3.55f)
        {
            if (// 1800 
                 thouThousandNum[1].gameObject.activeInHierarchy && thouHundredNum[8].gameObject.activeInHierarchy && thouTenNum[0].gameObject.activeInHierarchy && thouOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }
            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if moon2C state and 1st question
        if (moon2CGameNode.gameObject.activeInHierarchy && level == 3.6f)
        {
            if (// 944
                 hunHundredNum[9].gameObject.activeInHierarchy && hunTenNum[4].gameObject.activeInHierarchy && hunOneNum[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if moon2C and 2nd question
        if (moon2CGameNode.gameObject.activeInHierarchy && level == 3.65f)
        {
            if (// 1/9 X 1/5 = 1/45
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[9].gameObject.activeInHierarchy && bigBottom1[5].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[5].gameObject.activeInHierarchy
                    ||
                 // 1/5 X 1/9 = 1/45
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[5].gameObject.activeInHierarchy && bigBottom1[9].gameObject.activeInHierarchy && bigBottom2_0[4].gameObject.activeInHierarchy && bigBottom2_1[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2CMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectMoon1B_Sun2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectMoon1B_Moon2C.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2D state and 1st question
        if (sun2DGameNode.gameObject.activeInHierarchy && level == 3.7f)
        {
            if (// 1/2 X 1/4 = 1/8
                smolTop0[1].gameObject.activeInHierarchy && smolTop1[1].gameObject.activeInHierarchy && smolTop2[1].gameObject.activeInHierarchy &&
                smolBottom0[2].gameObject.activeInHierarchy && smolBottom1[4].gameObject.activeInHierarchy && smolBottom2[8].gameObject.activeInHierarchy
                ||
                // 1/4 X 1/2 = 1/8
                smolTop0[1].gameObject.activeInHierarchy && smolTop1[1].gameObject.activeInHierarchy && smolTop2[1].gameObject.activeInHierarchy &&
                smolBottom0[4].gameObject.activeInHierarchy && smolBottom1[2].gameObject.activeInHierarchy && smolBottom2[8].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if sun2D state and 2nd question
        if (sun2DGameNode.gameObject.activeInHierarchy && level == 3.75f)
        {
            if ( // 870
                 hunHundredNum[8].gameObject.activeInHierarchy && hunTenNum[7].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // moon2D state and 1st question
        if (moon2DGameNode.gameObject.activeInHierarchy && level == 3.8f)
        {
            if ( // 1/8 X 1/4 = 1/32
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[4].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy
                    ||
                 // 1/4 X 1/8 = 1/32
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[4].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // moon2D state and 2nd question
        if (moon2DGameNode.gameObject.activeInHierarchy && level == 3.85f)
        {
            if (// 1840 
                 thouThousandNum[1].gameObject.activeInHierarchy && thouHundredNum[9].gameObject.activeInHierarchy && thouTenNum[4].gameObject.activeInHierarchy && thouOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");
                connect_T_0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelTNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                level0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon0MapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connect0_Sun0.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connect0_Moon0.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                levelSun1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                levelMoon1BMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                connectMoon0_Sun1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                connectMoon0_Moon1B.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;

                levelSun2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                levelMoon2DMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectSun1B_Sun2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
                connectSun1B_Moon2D.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

                connectFinal0.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                connectFinal1.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
                levelFinalMapNode.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;

            }
            // wrong input
            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && level == 4.1f)
        {
            if (// 1/5 X 1/4 = 1/20
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[5].gameObject.activeInHierarchy && bigBottom1[4].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy
                    ||
                 // 1/4 X 1/5 = 1/20
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[4].gameObject.activeInHierarchy && bigBottom1[5].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && level == 4.2f)
        {
            if (// 3124 
                 thouThousandNum[3].gameObject.activeInHierarchy && thouHundredNum[1].gameObject.activeInHierarchy && thouTenNum[2].gameObject.activeInHierarchy && thouOneNum[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && level == 4.3f)
        {
            if (// 1/9 X 3/8 = 1/24
                 bigTop0[1].gameObject.activeInHierarchy && bigTop1[3].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[9].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy
                    ||
                 // 3/8 X 1/9 = 1/24
                 bigTop0[3].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                 bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[9].gameObject.activeInHierarchy && bigBottom2_0[2].gameObject.activeInHierarchy && bigBottom2_1[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
            }

            else
            {
                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }
    }
}

