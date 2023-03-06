using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SimpleJSON;
using LoLSDK;
using TMPro;

[System.Serializable]
public class BM_SaveData
{
    public float level = 0.0f;

    public float sunWallet = 0.0f;
    public float moonWallet = 0.0f;
}
public class BM_LevelManager : MonoBehaviour
{
    [SerializeField] BM_SaveData bm_SaveData;
    JSONNode _langNode;
    string _langCode = "en";
    bool _init;

    // Buttons
    public Button flipButton;
    public Button submitButton;
    public Button nextButton;
    public Button retryButton;
    [SerializeField] Button newGameButton;
    [SerializeField] Button continueButton;
    [SerializeField] TextMeshProUGUI 
    continueText, newGameText, retryText, clearText, submitText, nextText, flipText, speakTutorButtonText, cancelQuestButtonText,
    cancelTutorButtonText, speakQuestButtonText, tutorButtonText0, tutorButtonText1, tutorButtonText2, tutorButtonText2_1, tutorButtonText3,
    tutorButtonText3_1, tutorButtonText3_2, tutorButtonText4;
    public Button speakTutorButton;
    public Button cancelSpeakTutorButton;
    public Button speakQuestionButton;
    public Button cancelSpeakQuestButton;
    public Button clearButton;
    public Button tutorNextButton0;
    public Button tutorNextButton1;
    public Button tutorNextButton2;
    public Button tutorNextButton2_1;
    public Button tutorNextButton3;
    public Button tutorNextButton3_1;
    public Button tutorNextButton3_2;
    public Button tutorNextButton4;

    AudioSource _ttsAudioSource;

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
    public Button snapHunHundred;
    public Button snapHunTen;
    public Button snapHunOne;

    // Thousand Snap Box Ref
    public Button snapThouThousand;
    public Button snapThouHundred;
    public Button snapThouTen;
    public Button snapThouOne;

    // Smol Fraction snap box Ref
    public Button smolBoxTop0;
    public Button smolBoxTop1;
    public Button smolBoxTop2;
    public Button smolBoxBot0;
    public Button smolBoxBot1;
    public Button smolBoxBot2;

    // Big Fraction snap box Ref
    public Button bigBoxTop0;
    public Button bigBoxTop1;
    public Button bigBoxTop2;
    public Button bigBoxBot0;
    public Button bigBoxBot1;
    public Button bigBoxBot2_0;
    public Button bigBoxBot2_1;

    // coin reference
    public GameObject sunCoin;
    public GameObject moonCoin;

    // world state level
    public GameObject tutorGameNode;
    public GameObject tutorDFIdle;
    public GameObject tutorDFTalk;
    public GameObject tutorDFCheer;
    //public GameObject tutorDFTrap;

    public GameObject level0GameNode;
    public GameObject blob0;
    //public GameObject level0DFIdle;
    //public GameObject level0DFTalk;
    public GameObject level0DFCheer;
    public GameObject level0DFTrap;

    public GameObject sun0GameNode;
    public GameObject blobSun0;
    //public GameObject levelSun0DFIdle;
    //public GameObject levelSun0DFTalk;
    public GameObject levelSun0DFCheer;
    public GameObject levelSun0DFTrap;

    public GameObject moon0GameNode;
    public GameObject blobMoon0;
    //public GameObject levelMoon0DFIdle;
    //public GameObject levelMoon0DFTalk;
    public GameObject levelMoon0DFCheer;
    public GameObject levelMoon0DFTrap;

    public GameObject sun1AGameNode;
    public GameObject blobSun1A;
    //public GameObject levelSun1ADFIdle;
    //public GameObject levelSun1ADFTalk;
    public GameObject levelSun1ADFCheer;
    public GameObject levelSun1ADFTrap;

    public GameObject moon1AGameNode;
    public GameObject blobMoon1A;
    //public GameObject levelMoon1ADFIdle;
    //public GameObject levelMoon1ADFTalk;
    public GameObject levelMoon1ADFCheer;
    public GameObject levelMoon1ADFTrap;

    public GameObject sun1BGameNode;
    public GameObject blobSun1B;
    //public GameObject levelSun1BDFIdle;
    //public GameObject levelSun1BDFTalk;
    public GameObject levelSun1BDFCheer;
    public GameObject levelSun1BDFTrap;

    public GameObject moon1BGameNode;
    public GameObject blobMoon1B;
    //public GameObject levelMoon1BDFIdle;
    //public GameObject levelMoon1BDFTalk;
    public GameObject levelMoon1BDFCheer;
    public GameObject levelMoon1BDFTrap;

    public GameObject sun2AGameNode;
    public GameObject blobSun2A;
    //public GameObject levelSun2ADFIdle;
    //public GameObject levelSun2ADFTalk;
    public GameObject levelSun2ADFCheer;
    public GameObject levelSun2ADFTrap;

    public GameObject moon2AGameNode;
    public GameObject blobMoon2A;
    //public GameObject levelMoon2ADFIdle;
    //public GameObject levelMoon2ADFTalk;
    public GameObject levelMoon2ADFCheer;
    public GameObject levelMoon2ADFTrap;

    public GameObject sun2BGameNode;
    public GameObject blobSun2B;
    //public GameObject levelSun2BDFIdle;
    //public GameObject levelSun2BDFTalk;
    public GameObject levelSun2BDFCheer;
    public GameObject levelSun2BDFTrap;

    public GameObject moon2BGameNode;
    public GameObject blobMoon2B;
    //public GameObject levelMoon2BDFIdle;
    //public GameObject levelMoon2BDFTalk;
    public GameObject levelMoon2BDFCheer;
    public GameObject levelMoon2BDFTrap;

    public GameObject sun2CGameNode;
    public GameObject blobSun2C;
    //public GameObject levelSun2CDFIdle;
    //public GameObject levelSun2CDFTalk;
    public GameObject levelSun2CDFCheer;
    public GameObject levelSun2CDFTrap;

    public GameObject moon2CGameNode;
    public GameObject blobMoon2C;
    public GameObject levelMoon2CDFIdle;
    public GameObject levelMoon2CDFTalk;
    public GameObject levelMoon2CDFCheer;
    public GameObject levelMoon2CDFTrap;

    public GameObject sun2DGameNode;
    public GameObject blobSun2D;
    //public GameObject levelSun2DDFIdle;
    //public GameObject levelSun2DDFTalk;
    public GameObject levelSun2DDFCheer;
    public GameObject levelSun2DDFTrap;

    public GameObject moon2DGameNode;
    public GameObject blobMoon2D;
    //public GameObject levelMoon2DDFIdle;
    //public GameObject levelMoon2DDFTalk;
    public GameObject levelMoon2DDFCheer;
    public GameObject levelMoon2DDFTrap;

    public GameObject finalGameNode;
    public GameObject blobFinal;

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
    public GameObject mapT_0;
    public GameObject map0Confirm;

    public GameObject map0_Sun0_Moon0;
    public GameObject map0_Sun0Confirm;
    public GameObject map0_Moon0Confirm;
    public GameObject mapSun0_Sun1A_Moon1A;
    public GameObject mapSun0_Sun1AConfirm;
    public GameObject mapSun0_Moon1AConfirm;
    public GameObject mapMoon0_Sun1B_Moon1B;
    public GameObject mapMoon0_Sun1BConfirm;
    public GameObject mapMoon0_Moon1BConfirm;

    public GameObject mapSun1A_Sun2B_Moon2B;
    public GameObject mapSun1A_Sun2BConfirm;
    public GameObject mapSun1A_Moon2BConfirm;
    public GameObject mapMoon1A_Sun2A_Moon2A;
    public GameObject mapMoon1A_Sun2AConfirm;
    public GameObject mapMoon1A_Moon2AConfirm;

    public GameObject mapSun1B_Sun2D_Moon2D;
    public GameObject mapSun1B_Sun2DConfirm;
    public GameObject mapSun1B_Moon2DConfirm;
    public GameObject mapMoon1B_Sun2C_Moon2C;
    public GameObject mapMoon1B_Sun2CConfirm;
    public GameObject mapMoon1B_Moon2CConfirm;

    public GameObject mapSun2A_Final;
    public GameObject mapSun2A_FinalConfirm;
    public GameObject mapMoon2A_Final;
    public GameObject mapMoon2A_FinalConfirm;
    public GameObject mapSun2B_Final;
    public GameObject mapSun2B_FinalConfirm;
    public GameObject mapMoon2B_Final;
    public GameObject mapMoon2B_FinalConfirm;
    public GameObject mapSun2C_Final;
    public GameObject mapSun2C_FinalConfirm;
    public GameObject mapMoon2C_Final;
    public GameObject mapMoon2C_FinalConfirm;
    public GameObject mapSun2D_Final;
    public GameObject mapSun2D_FinalConfirm;
    public GameObject mapMoon2D_Final;
    public GameObject mapMoon2D_FinalConfirm;

    public GameObject finalMap_Sun2AFinal;
    public GameObject finalMap_Moon2AFinal;
    public GameObject finalMap_Sun2BFinal;
    public GameObject finalMap_Moon2BFinal;
    public GameObject finalMap_Sun2CFinal;
    public GameObject finalMap_Moon2CFinal;
    public GameObject finalMap_Sun2DFinal;
    public GameObject finalMap_Moon2DFinal;


    // final map text
    public TextMeshProUGUI congratsText;
    public TextMeshProUGUI finalMath0Text;
    public TextMeshProUGUI finalMath1Text;
    public TextMeshProUGUI finalMath2Text;

    // text Ref
    public GameObject textBackBox;
    public GameObject textBackBoxTutor;
    public GameObject walletBackdrop;

    public TextMeshProUGUI textSunWallet;
    public TextMeshProUGUI textMoonWallet;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    public TextMeshProUGUI questionT_Text;
    public TextMeshProUGUI tutorText0;
    public TextMeshProUGUI tutorText1;
    public TextMeshProUGUI tutorText2;
    public TextMeshProUGUI tutorText2_1;
    public TextMeshProUGUI tutorText3;
    public TextMeshProUGUI tutorText3_1;
    public TextMeshProUGUI tutorText3_2;
    public TextMeshProUGUI tutorText4;
    public TextMeshProUGUI tutorText5;
    public TextMeshProUGUI tutorText6;

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

    public TextMeshProUGUI hint1Text;
    public TextMeshProUGUI hint2Text;

    public TextMeshProUGUI skipButtonText;
    public TextMeshProUGUI hintButtonText;

    public TextMeshProUGUI skipButtonTextSample;
    public TextMeshProUGUI hintButtonTextSample;

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

    Coroutine _feedbackMethod;
    WaitForSeconds _feedbackTimer = new WaitForSeconds(2);
    [SerializeField]
    TextMeshProUGUI feedbackText;

    // level variable
    public float level = 0f;

    // wallet variable
    public float sunWallet = 0f;
    public float moonWallet = 0f;

    // hint objects
    public Button hintButton;
    public Button skipButton;
    public Button hintButtonSample;
    public Button skipButtonSample;
    public GameObject hintTextBox;

    // attempt bools
    public bool attempt1 = true;
    public bool attempt2 = false;
    public bool attempt3 = false;

    // runs at start
    private void Start()
    {
        _ttsAudioSource = gameObject.AddComponent<AudioSource>();

        textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
        textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
        walletBackdrop.gameObject.SetActive(false);

        textBackBox.gameObject.SetActive(false);
        textBackBoxTutor.gameObject.SetActive(false);

        correctText.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(false);

        hintButton.gameObject.SetActive(false);
        hintTextBox.gameObject.SetActive(false);
        skipButton.gameObject.SetActive(false);
        skipButtonSample.gameObject.SetActive(false);
        hintButtonSample.gameObject.SetActive(false);

        flipButton.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
        retryButton.gameObject.SetActive(false);
        clearButton.gameObject.SetActive(false);
        speakTutorButton.gameObject.SetActive(false);
        speakQuestionButton.gameObject.SetActive(false);
        cancelSpeakTutorButton.gameObject.SetActive(false);
        cancelSpeakQuestButton.gameObject.SetActive(false);

        tutorNextButton0.gameObject.SetActive(false);
        tutorNextButton1.gameObject.SetActive(false);
        tutorNextButton2.gameObject.SetActive(false);
        tutorNextButton2_1.gameObject.SetActive(false);
        tutorNextButton3.gameObject.SetActive(false);
        tutorNextButton3_1.gameObject.SetActive(false);
        tutorNextButton3_2.gameObject.SetActive(false);
        tutorNextButton4.gameObject.SetActive(false);

        questionT_Text.gameObject.SetActive(false);
        tutorText0.gameObject.SetActive(false);
        tutorText1.gameObject.SetActive(false);
        tutorText2.gameObject.SetActive(false);
        tutorText2_1.gameObject.SetActive(false);
        tutorText3.gameObject.SetActive(false);
        tutorText3_1.gameObject.SetActive(false);
        tutorText3_2.gameObject.SetActive(false);
        tutorText4.gameObject.SetActive(false);
        tutorText5.gameObject.SetActive(false);
        tutorText6.gameObject.SetActive(false);

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

        hint1Text.gameObject.SetActive(false);
        hint2Text.gameObject.SetActive(false);

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

        sunCoin.gameObject.SetActive(false);
        moonCoin.gameObject.SetActive(false);

        questionNodeSurveyHun.SetActive(false);
        questionNodeSurveyThou.SetActive(false);
        questionNodeBigFraction.SetActive(false);
        questionNodeSmolFraction.SetActive(false);

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

        mapT_0.gameObject.SetActive(false);
        map0Confirm.gameObject.SetActive(false);

        map0_Sun0_Moon0.gameObject.SetActive(false);
        map0_Sun0Confirm.gameObject.SetActive(false);
        map0_Moon0Confirm.gameObject.SetActive(false);
        mapSun0_Sun1A_Moon1A.gameObject.SetActive(false);
        mapSun0_Sun1AConfirm.gameObject.SetActive(false);
        mapSun0_Moon1AConfirm.gameObject.SetActive(false);
        mapMoon0_Sun1B_Moon1B.gameObject.SetActive(false);
        mapMoon0_Sun1BConfirm.gameObject.SetActive(false);
        mapMoon0_Moon1BConfirm.gameObject.SetActive(false);

        mapSun1A_Sun2B_Moon2B.gameObject.SetActive(false);
        mapSun1A_Sun2BConfirm.gameObject.SetActive(false);
        mapSun1A_Moon2BConfirm.gameObject.SetActive(false);
        mapMoon1A_Sun2A_Moon2A.gameObject.SetActive(false);
        mapMoon1A_Sun2AConfirm.gameObject.SetActive(false);
        mapMoon1A_Moon2AConfirm.gameObject.SetActive(false);

        mapSun1B_Sun2D_Moon2D.gameObject.SetActive(false);
        mapSun1B_Sun2DConfirm.gameObject.SetActive(false);
        mapSun1B_Moon2DConfirm.gameObject.SetActive(false);
        mapMoon1B_Sun2C_Moon2C.gameObject.SetActive(false);
        mapMoon1B_Sun2CConfirm.gameObject.SetActive(false);
        mapMoon1B_Moon2CConfirm.gameObject.SetActive(false);

        mapSun2A_Final.gameObject.SetActive(false);
        mapSun2A_FinalConfirm.gameObject.SetActive(false);
        mapMoon2A_Final.gameObject.SetActive(false);
        mapMoon2A_FinalConfirm.gameObject.SetActive(false);
        mapSun2B_Final.gameObject.SetActive(false);
        mapSun2B_FinalConfirm.gameObject.SetActive(false);
        mapMoon2B_Final.gameObject.SetActive(false);
        mapMoon2B_FinalConfirm.gameObject.SetActive(false);
        mapSun2C_Final.gameObject.SetActive(false);
        mapSun2C_FinalConfirm.gameObject.SetActive(false);
        mapMoon2C_Final.gameObject.SetActive(false);
        mapMoon2C_FinalConfirm.gameObject.SetActive(false);
        mapSun2D_Final.gameObject.SetActive(false);
        mapSun2D_FinalConfirm.gameObject.SetActive(false);
        mapMoon2D_Final.gameObject.SetActive(false);
        mapMoon2D_FinalConfirm.gameObject.SetActive(false);

        finalMap_Sun2AFinal.gameObject.SetActive(false);
        finalMap_Moon2AFinal.gameObject.SetActive(false);
        finalMap_Sun2BFinal.gameObject.SetActive(false);
        finalMap_Moon2BFinal.gameObject.SetActive(false);
        finalMap_Sun2CFinal.gameObject.SetActive(false);
        finalMap_Moon2CFinal.gameObject.SetActive(false);
        finalMap_Sun2DFinal.gameObject.SetActive(false);
        finalMap_Moon2DFinal.gameObject.SetActive(false);

        LOLSDK.Instance.LanguageDefsReceived += new LanguageDefsReceivedHandler(LanguageUpdate);

        Helper.StateButtonInitialize<BM_SaveData>(newGameButton, continueButton, OnLoad);

    }

    // run on awake
    private void Awake()
    {
        hintButton.onClick.AddListener(OnClickHint);
        skipButton.onClick.AddListener(OnClickSkip);
        flipButton.onClick.AddListener(OnClickFlip);
        submitButton.onClick.AddListener(OnClickSubmit);
        nextButton.onClick.AddListener(OnClickNext);
        retryButton.onClick.AddListener(OnClickRetry);
        clearButton.onClick.AddListener(OnClickClear);
        newGameButton.onClick.AddListener(OnClickNew);
        speakTutorButton.onClick.AddListener(OnClickSpeakTutor);
        speakQuestionButton.onClick.AddListener(OnClickSpeakQuestion);
        cancelSpeakTutorButton.onClick.AddListener(OnClickCancelTutor);
        cancelSpeakQuestButton.onClick.AddListener(OnClickCancelQuestion);
        tutorNextButton0.onClick.AddListener(OnClickNextT0);
        tutorNextButton1.onClick.AddListener(OnClickNextT1);
        tutorNextButton2.onClick.AddListener(OnClickNextT2);
        tutorNextButton2_1.onClick.AddListener(OnClickNextT2_1);
        tutorNextButton3.onClick.AddListener(OnClickNextT3);
        tutorNextButton3_1.onClick.AddListener(OnClickNextT3_1);
        tutorNextButton3_2.onClick.AddListener(OnClickNextT3_2);
        tutorNextButton4.onClick.AddListener(OnClickNextT4);

    }

    private void OnDestroy()
    {
#if UNITY_EDITOR
        if (!UnityEditor.EditorApplication.isPlayingOrWillChangePlaymode)
            return;
#endif
        LOLSDK.Instance.SaveResultReceived -= OnSaveResult;
    }

    void Save()
    {
        LOLSDK.Instance.SaveState(bm_SaveData);
    }

    void OnSaveResult(bool success)
    {
        if (!success)
        {
            Debug.LogWarning("Saving not successful");
            return;
        }

        if (_feedbackMethod != null)
            StopCoroutine(_feedbackMethod);
        // ...Auto Saving Complete
        _feedbackMethod = StartCoroutine(_Feedback(GetText("autoSave")));
    }

    void StartGame(string startGameJSON)
    {
        if (string.IsNullOrEmpty(startGameJSON))
            return;

        JSONNode startGamePayload = JSON.Parse(startGameJSON);
        // Capture the language code from the start payload. Use this to switch fonts
        _langCode = startGamePayload["languageCode"];
    }

    void LanguageUpdate(string langJSON)
    {
        if (string.IsNullOrEmpty(langJSON))
            return;

        _langNode = JSON.Parse(langJSON);

        TextDisplayUpdate();
    }

    string GetText(string key)
    {
        string value = _langNode?[key];
        return value ?? "--missing--";
    }

    void TextDisplayUpdate()
    {
        newGameText.text = GetText("newGame");
        continueText.text = GetText("continue");
        retryText.text = GetText("retry");
        clearText.text = GetText("clear");
        submitText.text = GetText("submit");
        nextText.text = GetText("next");
        flipText.text = GetText("flip");

        correctText.text = GetText("correct");
        incorrectText.text = GetText("incorrect");

        skipButtonText.text = GetText("SkipButtonText");
        hintButtonText.text = GetText("HintButtonText");

        skipButtonTextSample.text = GetText("SkipButtonTextSample");
        hintButtonTextSample.text = GetText("HintButtonTextSample");

        speakTutorButtonText.text = GetText("Speak");
        speakQuestButtonText.text = GetText("Speak");
        cancelTutorButtonText.text = GetText("Cancel");
        cancelQuestButtonText.text = GetText("Cancel");
        tutorButtonText0.text = GetText("next");
        tutorButtonText1.text = GetText("next");
        tutorButtonText2.text = GetText("next");
        tutorButtonText2_1.text = GetText("next");
        tutorButtonText3.text = GetText("next");
        tutorButtonText3_1.text = GetText("next");
        tutorButtonText3_2.text = GetText("next");
        tutorButtonText4.text = GetText("next");

        tutorText0.text = GetText("TutorText0");
        tutorText1.text = GetText("TutorText1");
        tutorText2.text = GetText("TutorText2");
        tutorText2_1.text = GetText("TutorText2_1");
        tutorText3.text = GetText("TutorText3");
        tutorText3_1.text = GetText("TutorText3_1");
        tutorText3_2.text = GetText("TutorText3_2");
        tutorText4.text = GetText("TutorText4");
        tutorText5.text = GetText("TutorText5");
        tutorText6.text = GetText("TutorText6");

        hint1Text.text = GetText("HintText1");
        hint2Text.text = GetText("HintText2");

        questionT_Text.text = GetText("TutorQuestionText");
        question0Text.text = GetText("Question0Text");
        questionSun0Text.text = GetText("QuestionSun0Text");
        questionMoon0Text.text = GetText("QuestionMoon0Text");
        questionSun1AText.text = GetText("QuestionSun1AText");
        questionMoon1AText.text = GetText("QuestionMoon1AText");
        questionSun1BText.text = GetText("QuestionSun1BText");
        questionMoon1BText.text = GetText("QuestionMoon1BText");

        questionSun2A_0Text.text = GetText("QuestionSun2AText_0");
        questionSun2A_1Text.text = GetText("QuestionSun2AText_1");
        questionMoon2A_0Text.text = GetText("QuestionMoon2AText_0");
        questionMoon2A_1Text.text = GetText("QuestionMoon2AText_1");
        questionSun2B_0Text.text = GetText("QuestionSun2BText_0");
        questionSun2B_1Text.text = GetText("QuestionSun2BText_1");
        questionMoon2B_0Text.text = GetText("QuestionMoon2BText_0");
        questionMoon2B_1Text.text = GetText("QuestionMoon2BText_1");
        questionSun2C_0Text.text = GetText("QuestionSun2CText_0");
        questionSun2C_1Text.text = GetText("QuestionSun2CText_1");
        questionMoon2C_0Text.text = GetText("QuestionMoon2CText_0");
        questionMoon2C_1Text.text = GetText("QuestionMoon2CText_1");
        questionSun2D_0Text.text = GetText("QuestionSun2DText_0");
        questionSun2D_1Text.text = GetText("QuestionSun2DText_1");
        questionMoon2D_0Text.text = GetText("QuestionMoon2DText_0");
        questionMoon2D_1Text.text = GetText("QuestionMoon2DText_1");

        questionFinalFractionText0.text = GetText("QuestionFinalText_0");
        questionFinalSurveyText0.text = GetText("QuestionFinalText_1");
        questionFinalFractionText1.text = GetText("QuestionFinalText_2");


    }

    void OnLoad(BM_SaveData loadedSaveData)
    {
        // Overrides serialized state data or continues with editor serialized values.
        if (loadedSaveData != null)
            bm_SaveData = loadedSaveData;

            level = bm_SaveData.level;
            
            PickLevel();

            _init = true;
    }

    public void PickLevel()
    {
        BM_AudioManager.instance.Play("Button");

        if (bm_SaveData.level == 0.1f)
        {
            Debug.Log("LoadTutor");
            spellCardT.gameObject.SetActive(true);
            tutorGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 0.5f)
        {
            Debug.Log("LoadLevel0");
            spellCard0.gameObject.SetActive(true);
            level0GameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 1.1f)
        {
            Debug.Log("LoadSun0");
            spellCardSun0.gameObject.SetActive(true);
            sun0GameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 1.2f)
        {
            Debug.Log("LoadMoon0");
            spellCardMoon0.gameObject.SetActive(true);
            moon0GameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 2.1f)
        {
            Debug.Log("LoadSun1A");
            spellCardSun1A.gameObject.SetActive(true);
            sun1AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 2.2f)
        {
            Debug.Log("LoadMoon1A");
            spellCardMoon1A.gameObject.SetActive(true);
            moon1AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 2.3f)
        {
            Debug.Log("LoadSun1B");
            spellCardSun1B.gameObject.SetActive(true);
            sun1BGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 2.4f)
        {
            Debug.Log("LoadMoon1B");
            spellCardMoon1B.gameObject.SetActive(true);
            moon1BGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.1f)
        {
            Debug.Log("LoadSun2A");
            spellCardSun2A_0.gameObject.SetActive(true);
            sun2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.15f)
        {
            Debug.Log("LoadSun2A");
            spellCardSun2A_1.gameObject.SetActive(true);
            sun2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.2f)
        {
            Debug.Log("LoadMoon2A");
            spellCardMoon2A_0.gameObject.SetActive(true);
            moon2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.25f)
        {
            Debug.Log("LoadMoon2A");
            spellCardMoon2A_1.gameObject.SetActive(true);
            moon2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.3f)
        {
            Debug.Log("LoadSun2B");
            spellCardSun2B_0.gameObject.SetActive(true);
            sun2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.35f)
        {
            Debug.Log("LoadSun2B");
            spellCardSun2B_1.gameObject.SetActive(true);
            sun2AGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.4f)
        {
            Debug.Log("LoadMoon2B");
            spellCardMoon2B_0.gameObject.SetActive(true);
            moon2BGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.45f)
        {
            Debug.Log("LoadMoon2B");
            spellCardMoon2B_1.gameObject.SetActive(true);
            moon2BGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.5f)
        {
            Debug.Log("LoadSun2C");
            spellCardSun2C_0.gameObject.SetActive(true);
            sun2CGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.55f)
        {
            Debug.Log("LoadSun2C");
            spellCardSun2C_1.gameObject.SetActive(true);
            sun2CGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.6f)
        {
            Debug.Log("LoadMoon2C");
            spellCardMoon2C_0.gameObject.SetActive(true);
            moon2CGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.65f)
        {
            Debug.Log("LoadMoon2C");
            spellCardMoon2C_1.gameObject.SetActive(true);
            moon2CGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.7f)
        {
            Debug.Log("LoadSun2D");
            spellCardSun2D_0.gameObject.SetActive(true);
            sun2DGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.75f)
        {
            Debug.Log("LoadSun2D");
            spellCardSun2D_1.gameObject.SetActive(true);
            sun2DGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.8f)
        {
            Debug.Log("LoadMoon2D");
            spellCardMoon2D_0.gameObject.SetActive(true);
            moon2DGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 3.85f)
        {
            Debug.Log("LoadMoon2D");
            spellCardMoon2D_1.gameObject.SetActive(true);
            moon2DGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 4.1f)
        {
            Debug.Log("LoadFinal 1");
            spellCardFractionFinal_0.gameObject.SetActive(true);
            finalGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 4.2f)
        {
            Debug.Log("LoadFinal 2");
            spellCardFinalSurvey.gameObject.SetActive(true);
            finalGameNode.gameObject.SetActive(true);
        }

        if (bm_SaveData.level == 4.3f)
        {
            Debug.Log("LoadFinal 3");
            spellCardFractionFinal_1.gameObject.SetActive(true);
            finalGameNode.gameObject.SetActive(true);
        }
    }

    private void OnClickSpeakTutor()
    {
        if (tutorText0.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText0");

        }

        if (tutorText1.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText1");

        }

        if (tutorText2.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText2");

        }

        if (tutorText2_1.gameObject.activeInHierarchy)
        {
            LOLSDK.Instance.SpeakText("TutorText2_1");
        }

        if (tutorText3.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText3");

        }

        if (tutorText3_1.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText3_1");

        }

        if (tutorText3_2.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText3_2");

        }

        if (tutorText4.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText4");

        }

        if (tutorText5.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText5");

        }

        if (tutorText6.gameObject.activeInHierarchy)
        {

            LOLSDK.Instance.SpeakText("TutorText6");

        }
    }

    private void OnClickSpeakQuestion()
    {
        if (bm_SaveData.level == 0.1f)
        {

            LOLSDK.Instance.SpeakText("TutorQuestionText");

        }

        if (bm_SaveData.level == 0.5f)
        {

            LOLSDK.Instance.SpeakText("Question0Text");

        }

        if (bm_SaveData.level == 1.1f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun0Text");

        }

        if (bm_SaveData.level == 1.2f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon0Text");
        }

        if (bm_SaveData.level == 2.1f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun1AText");
        }

        if (bm_SaveData.level == 2.2f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon1AText");
            
        }

        if (bm_SaveData.level == 2.3f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun1BText");

        }

        if (bm_SaveData.level == 2.4f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon1BText");

        }

        if (bm_SaveData.level == 3.1f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2AText_0");

        }

        if (bm_SaveData.level == 3.15f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2AText_1");

        }

        if (bm_SaveData.level == 3.2f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2AText_0");

        }

        if (bm_SaveData.level == 3.25f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2AText_1");

        }

        if (bm_SaveData.level == 3.3f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2BText_0");

        }

        if (bm_SaveData.level == 3.35f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2BText_1");

        }

        if (bm_SaveData.level == 3.4f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2BText_0");

        }

        if (bm_SaveData.level == 3.45f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2BText_1");

        }

        if (bm_SaveData.level == 3.5f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2CText_0");

        }

        if (bm_SaveData.level == 3.55f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2CText_1");

        }

        if (bm_SaveData.level == 3.6f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2CText_0");

        }

        if (bm_SaveData.level == 3.65f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2CText_1");

        }

        if (bm_SaveData.level == 3.7f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2DText_0");

        }

        if (bm_SaveData.level == 3.75f)
        {

            LOLSDK.Instance.SpeakText("QuestionSun2DText_1");

        }

        if (bm_SaveData.level == 3.8f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2DText_0");

        }

        if (bm_SaveData.level == 3.85f)
        {

            LOLSDK.Instance.SpeakText("QuestionMoon2DText_1");

        }

        if (bm_SaveData.level == 4.1f)
        {

            LOLSDK.Instance.SpeakText("QuestionFinalText_0");

        }


        if (bm_SaveData.level == 4.2f)
        {

            LOLSDK.Instance.SpeakText("QuestionFinalText_1");

        }

        if (bm_SaveData.level == 4.3f)
        {

            LOLSDK.Instance.SpeakText("QuestionFinalText_2");

        }

    }

    private void OnClickCancelTutor()
    {
        LOLSDK.Instance.SpeakText("Cancel");
    }

    private void OnClickCancelQuestion()
    {
        LOLSDK.Instance.SpeakText("Cancel");

    }

    private void OnClickNextT0()
    {
      //StartCoroutine(TutorText1());

        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton0.gameObject.SetActive(false);
        tutorText0.gameObject.SetActive(false);
        tutorText1.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
      //yield return new WaitForSecondsRealtime(5);
        tutorNextButton1.gameObject.SetActive(true);

    }

    private void OnClickNextT1()
    {
      //StartCoroutine(TutorText2());

        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton1.gameObject.SetActive(false);
        tutorText1.gameObject.SetActive(false);
        tutorText2.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
      //yield return new WaitForSecondsRealtime(5);
        tutorNextButton2.gameObject.SetActive(true);
    }

    private void OnClickNextT2()
    {
      //StartCoroutine(TutorText3());

        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton2.gameObject.SetActive(false);
        tutorText2.gameObject.SetActive(false);
        tutorText2_1.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        //yield return new WaitForSecondsRealtime(5);
        tutorNextButton2_1.gameObject.SetActive(true);
    }

    private void OnClickNextT2_1()
    {
        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton2_1.gameObject.SetActive(false);
        tutorText2_1.gameObject.SetActive(false);
        tutorText3.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        tutorNextButton3.gameObject.SetActive(true);
    }

    private void OnClickNextT3()
    {
      //StartCoroutine(TutorText4());

        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton3.gameObject.SetActive(false);
        tutorText3.gameObject.SetActive(false);
        tutorText3_1.gameObject.SetActive(true);
        tutorDFTalk.gameObject.SetActive(false);
        tutorDFCheer.gameObject.SetActive(false);
        tutorDFIdle.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        //yield return new WaitForSecondsRealtime(5);
        tutorNextButton3_1.gameObject.SetActive(true);
        walletBackdrop.gameObject.SetActive(true);
   
    }

    private void OnClickNextT3_1()
    {
        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton3_1.gameObject.SetActive(false);
        tutorText3_1.gameObject.SetActive(false);
        tutorText3_2.gameObject.SetActive(true);
        tutorDFTalk.gameObject.SetActive(true);
        tutorDFCheer.gameObject.SetActive(false);
        tutorDFIdle.gameObject.SetActive(false);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        //yield return new WaitForSecondsRealtime(5);
        tutorNextButton3_2.gameObject.SetActive(true);
        hintTextBox.gameObject.SetActive(true);
        hintButtonSample.gameObject.SetActive(true);
        skipButtonSample.gameObject.SetActive(true);
    }

    private void OnClickNextT3_2()
    {
        LOLSDK.Instance.SpeakText("Next");
        BM_AudioManager.instance.Play("Button");
        tutorNextButton3_2.gameObject.SetActive(false);
        tutorText3_2.gameObject.SetActive(false);
        tutorText4.gameObject.SetActive(true);
        tutorDFTalk.gameObject.SetActive(false);
        tutorDFCheer.gameObject.SetActive(true);
        tutorDFIdle.gameObject.SetActive(false);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        //yield return new WaitForSecondsRealtime(5);
        tutorNextButton4.gameObject.SetActive(true);
        hintTextBox.gameObject.SetActive(false);
        hintButtonSample.gameObject.SetActive(false);
        skipButtonSample.gameObject.SetActive(false);
    }

    private void OnClickNextT4()
    {
        BM_AudioManager.instance.Play("Button");

        LOLSDK.Instance.SpeakText("Next");

        tutorNextButton4.gameObject.SetActive(false);
        tutorText4.gameObject.SetActive(false);
        textBackBoxTutor.gameObject.SetActive(false);
        tutorDFTalk.gameObject.SetActive(false);
        tutorDFCheer.gameObject.SetActive(false);
        tutorDFIdle.gameObject.SetActive(true);
        bm_SaveData.level = 0.1f;
        speakTutorButton.gameObject.SetActive(false);
        cancelSpeakTutorButton.gameObject.SetActive(false);
        spellCardT.gameObject.SetActive(true);
    }

    private void OnClickNew()
    {
        Debug.Log("New Game");
        BM_AudioManager.instance.Play("Button");
        //StartCoroutine(TutorText0());
        newGameButton.gameObject.SetActive(false);
        continueButton.gameObject.SetActive(false);
        tutorDFTalk.gameObject.SetActive(true);
        tutorDFCheer.gameObject.SetActive(false);
        tutorDFIdle.gameObject.SetActive(false);
        textBackBoxTutor.gameObject.SetActive(true);
        tutorText0.gameObject.SetActive(true);
        speakTutorButton.gameObject.SetActive(true);
        cancelSpeakTutorButton.gameObject.SetActive(true);
        //yield return new WaitForSecondsRealtime(5);
        tutorNextButton0.gameObject.SetActive(true);
    }

    //IEnumerator TutorText0()
    //{
    //    BM_AudioManager.instance.Play("Button");
    //    newGameButton.gameObject.SetActive(false);
    //    continueButton.gameObject.SetActive(false);
    //    tutorDFTalk.gameObject.SetActive(true);
    //    tutorDFCheer.gameObject.SetActive(false);
    //    tutorDFIdle.gameObject.SetActive(false);
    //    textBackBoxTutor.gameObject.SetActive(true);
    //    tutorText0.gameObject.SetActive(true);
    //    speakTutorButton.gameObject.SetActive(true);
    //    cancelSpeakTutorButton.gameObject.SetActive(true);
    //    yield return new WaitForSecondsRealtime(5);
    //    tutorNextButton0.gameObject.SetActive(true);

    //}

    //IEnumerator TutorText1()
    //{
    //    BM_AudioManager.instance.Play("Button");
    //    tutorNextButton0.gameObject.SetActive(false);
    //    tutorText0.gameObject.SetActive(false);
    //    tutorText1.gameObject.SetActive(true);
    //    speakTutorButton.gameObject.SetActive(true);
    //    cancelSpeakTutorButton.gameObject.SetActive(true);
    //    yield return new WaitForSecondsRealtime(5);
    //    tutorNextButton1.gameObject.SetActive(true);
    //}

    //IEnumerator TutorText2()
    //{
    //    BM_AudioManager.instance.Play("Button");
    //    tutorNextButton1.gameObject.SetActive(false);
    //    tutorText1.gameObject.SetActive(false);
    //    tutorText2.gameObject.SetActive(true);
    //    speakTutorButton.gameObject.SetActive(true);
    //    cancelSpeakTutorButton.gameObject.SetActive(true);
    //    yield return new WaitForSecondsRealtime(5);
    //    tutorNextButton2.gameObject.SetActive(true);
    //}

    //IEnumerator TutorText3()
    //{
    //    BM_AudioManager.instance.Play("Button");
    //    tutorNextButton2.gameObject.SetActive(false);
    //    tutorText2.gameObject.SetActive(false);
    //    tutorText3.gameObject.SetActive(true);
    //    speakTutorButton.gameObject.SetActive(true);
    //    cancelSpeakTutorButton.gameObject.SetActive(true);
    //    yield return new WaitForSecondsRealtime(5);
    //    tutorNextButton3.gameObject.SetActive(true);
    //}

    //IEnumerator TutorText4()
    //{
    //    BM_AudioManager.instance.Play("Button");
    //    tutorNextButton3.gameObject.SetActive(false);
    //    tutorText3.gameObject.SetActive(false);
    //    tutorText4.gameObject.SetActive(true);
    //    tutorDFTalk.gameObject.SetActive(false);
    //    tutorDFCheer.gameObject.SetActive(true);
    //    tutorDFIdle.gameObject.SetActive(false);
    //    speakTutorButton.gameObject.SetActive(true);
    //    cancelSpeakTutorButton.gameObject.SetActive(true);
    //    yield return new WaitForSecondsRealtime(5);
    //    tutorNextButton4.gameObject.SetActive(true);

    //}

    // on click retry button
    private void OnClickRetry()
    {
        Clear();
        BM_AudioManager.instance.Play("Button");
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);
        speakQuestionButton.gameObject.SetActive(false);
        cancelSpeakQuestButton.gameObject.SetActive(false);
        textBackBox.gameObject.SetActive(false);

        //_ttsAudioSource.Stop();
        LOLSDK.Instance.SpeakText("Retry");
        //((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();

        if (bm_SaveData.level == 0.1f)
        {
            spellCardT.gameObject.SetActive(true);
            tutorText4.gameObject.SetActive(false);
            tutorText6.gameObject.SetActive(false);
            textBackBoxTutor.gameObject.SetActive(false);
            tutorDFTalk.gameObject.SetActive(false);
            tutorDFCheer.gameObject.SetActive(false);
            tutorDFIdle.gameObject.SetActive(true);
            questionT_Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);

            retryButton.gameObject.SetActive(false);
        }

        if (bm_SaveData.level == 0.5f)
        {
            spellCard0.gameObject.SetActive(true);

            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            retryButton.gameObject.SetActive(false);
        }

        if (bm_SaveData.level == 1.1f || bm_SaveData.level == 1.2f)
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

        if (bm_SaveData.level == 2.1f || bm_SaveData.level == 2.2f || bm_SaveData.level == 2.3f || bm_SaveData.level == 2.4f)
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

        if (bm_SaveData.level == 3.1f || bm_SaveData.level == 3.2f || bm_SaveData.level == 3.3f || bm_SaveData.level == 3.4f 
            || bm_SaveData.level == 3.5f || bm_SaveData.level == 3.6f || bm_SaveData.level == 3.7f || bm_SaveData.level == 3.8f)
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

        if (bm_SaveData.level == 3.15f || bm_SaveData.level == 3.25f || bm_SaveData.level == 3.35f || bm_SaveData.level == 3.45f 
            || bm_SaveData.level == 3.55f || bm_SaveData.level == 3.65f || bm_SaveData.level == 3.75f || bm_SaveData.level == 3.85f)
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

        if (bm_SaveData.level == 4.1f)
        {
            spellCardFractionFinal_0.gameObject.SetActive(true);

            questionFinalFractionText0.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }

        if (bm_SaveData.level == 4.2f)
        {
            spellCardFinalSurvey.gameObject.SetActive(true);

            questionFinalSurveyText0.gameObject.SetActive(false);
            finalImage0.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }

        if (bm_SaveData.level == 4.3f)
        {
            spellCardFractionFinal_1.gameObject.SetActive(true);

            questionFinalFractionText1.gameObject.SetActive(false);
            finalImage1.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(false);
        }
    }

    IEnumerator _Feedback(string text)
    {
        feedbackText.text = text;
        yield return _feedbackTimer;
        feedbackText.text = string.Empty;
        _feedbackMethod = null;
    }

    private void Clear()
    {
        //snapHunHundred.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //snapHunTen.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //snapHunOne.gameObject.GetComponent<BoxCollider>().enabled = enabled;

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

        //snapThouThousand.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //snapThouHundred.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //snapThouTen.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //snapThouOne.gameObject.GetComponent<BoxCollider>().enabled = enabled;

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

        //smolBoxTop0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //smolBoxTop1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //smolBoxTop2.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //smolBoxBot0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //smolBoxBot1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //smolBoxBot2.gameObject.GetComponent<BoxCollider>().enabled = enabled;

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

        //bigBoxTop0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxTop1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxTop2.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxBot0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxBot1.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxBot2_0.gameObject.GetComponent<BoxCollider>().enabled = enabled;
        //bigBoxBot2_1.gameObject.GetComponent<BoxCollider>().enabled = enabled;

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
        BM_AudioManager.instance.Play("Button");
    }

    // runs on click flip button
    private void OnClickFlip()
    {
        Clear();
        map0_Sun0_Moon0.gameObject.SetActive(false);
        mapSun0_Sun1A_Moon1A.gameObject.SetActive(false);
        mapMoon0_Sun1B_Moon1B.gameObject.SetActive(false);
        mapSun1A_Sun2B_Moon2B.gameObject.SetActive(false);
        mapMoon1A_Sun2A_Moon2A.gameObject.SetActive(false);
        mapSun1B_Sun2D_Moon2D.gameObject.SetActive(false);
        mapMoon1B_Sun2C_Moon2C.gameObject.SetActive(false);
        mapSun2A_Final.gameObject.SetActive(false);
        mapMoon2A_Final.gameObject.SetActive(false);
        mapSun2B_Final.gameObject.SetActive(false);
        mapMoon2B_Final.gameObject.SetActive(false);
        mapSun2C_Final.gameObject.SetActive(false);
        mapMoon2C_Final.gameObject.SetActive(false);
        mapSun2D_Final.gameObject.SetActive(false);
        mapMoon2D_Final.gameObject.SetActive(false);

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 0.5f)
        {
            StartCoroutine(CoinFlip0());
        }

        if (bm_SaveData.level == 1.1f || bm_SaveData.level == 1.2f)
        {
            StartCoroutine(CoinFlip1());
        }

        if (bm_SaveData.level == 2.1f || bm_SaveData.level == 2.2f || bm_SaveData.level == 2.3f || bm_SaveData.level == 2.4f)
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
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        // and ranNum is 0, output Sun
        if (randomNumber == 0)
        {
            sunCoin.gameObject.SetActive(true);

            map0_Sun0Confirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            sun0GameNode.gameObject.SetActive(true);
            Debug.Log("SUN0");
            sunCoin.gameObject.SetActive(false);
            walletBackdrop.gameObject.SetActive(true);
            map0_Sun0Confirm.gameObject.SetActive(false);

            textBackBox.gameObject.SetActive(false);
            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            spellCardSun0.gameObject.SetActive(true);

            bm_SaveData.level = 1.1f;
        }

        // and ranNum is 1, output Moon
        if (randomNumber == 1)
        {
            moonCoin.gameObject.SetActive(true);

            map0_Moon0Confirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            moon0GameNode.gameObject.SetActive(true);
            Debug.Log("MOON0");
            moonCoin.gameObject.SetActive(false);
            walletBackdrop.gameObject.SetActive(true);
            map0_Moon0Confirm.gameObject.SetActive(false);

            textBackBox.gameObject.SetActive(false);
            question0Text.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);

            spellCardMoon0.gameObject.SetActive(true);

            bm_SaveData.level = 1.2f;
        }

        LOLSDK.Instance.SubmitProgress(100, 20, 100);
        Save();
        Debug.Log("Timer Done");
    }

    // coin flip level 1 function, call above
    IEnumerator CoinFlip1()
    {
        float randomNumber = Random.Range(0, 2);
        flipButton.gameObject.SetActive(false);
        BM_AudioManager.instance.Play("Button");
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        // if current state is Sun0
        if (sun0GameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                mapSun0_Sun1AConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                sun1AGameNode.gameObject.SetActive(true);

                sunCoin.gameObject.SetActive(false);
                Debug.Log("SUN1A");
                walletBackdrop.gameObject.SetActive(true);
                mapSun0_Sun1AConfirm.gameObject.SetActive(false);

                sun0Image0.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                questionSun0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                spellCardSun1A.gameObject.SetActive(true);

                bm_SaveData.level = 2.1f;
            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapSun0_Moon1AConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                moon1AGameNode.gameObject.SetActive(true);

                Debug.Log("MOON1A");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapSun0_Moon1AConfirm.gameObject.SetActive(false);

                sun0Image0.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                questionSun0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardMoon1A.gameObject.SetActive(true);

                bm_SaveData.level = 2.2f;
            }

        }

        // if current state is Moon0
        if (moon0GameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if (randomNumber == 0)
            {
                mapMoon0_Sun1BConfirm.gameObject.SetActive(true);
                sunCoin.gameObject.SetActive(true);
                yield return new WaitForSecondsRealtime(3);
                sun1BGameNode.gameObject.SetActive(true);

                Debug.Log("SUN1B");

                walletBackdrop.gameObject.SetActive(true);
                mapMoon0_Sun1BConfirm.gameObject.SetActive(false);

                textBackBox.gameObject.SetActive(false);
                questionMoon0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardSun1B.gameObject.SetActive(true);

                bm_SaveData.level = 2.3f;
            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapMoon0_Moon1BConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                moon1BGameNode.gameObject.SetActive(true);

                Debug.Log("MOON1B");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapMoon0_Moon1BConfirm.gameObject.SetActive(false);

                textBackBox.gameObject.SetActive(false);
                questionMoon0Text.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);

                spellCardMoon1B.gameObject.SetActive(true);

                bm_SaveData.level = 2.4f;
            }
        }

        LOLSDK.Instance.SubmitProgress(100, 40, 100);
        Save();
        Debug.Log("Timer Done");
    }

    // coin flip level 2 function, call above
    IEnumerator CoinFlip2()
    {
        float randomNumber = Random.Range(0, 2);
        flipButton.gameObject.SetActive(false);
        BM_AudioManager.instance.Play("Button");
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        // if world state is Sun1A
        if (sun1AGameNode.gameObject.activeInHierarchy)
        {
            // and ranNum is 0, output Sun
            if ( randomNumber == 0)
            {
                sunCoin.gameObject.SetActive(true);

                mapSun1A_Sun2BConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                sun2BGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2B");
                sunCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapSun1A_Sun2BConfirm.gameObject.SetActive(false);

                questionSun1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.3f;

                spellCardSun2B_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if ( randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapSun1A_Moon2BConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);;
                moon2BGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2B");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapSun1A_Moon2BConfirm.gameObject.SetActive(false);

                questionSun1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.4f;

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

                mapMoon1A_Sun2AConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                sun2AGameNode.gameObject.SetActive(true);
 
                Debug.Log("SUN2A");
                sunCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapMoon1A_Sun2AConfirm.gameObject.SetActive(false);

                questionMoon1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.1f;

                spellCardSun2A_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapMoon1A_Moon2AConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                moon2AGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2A");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapMoon1A_Moon2AConfirm.gameObject.SetActive(false);

                questionMoon1AText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.2f;

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

                mapSun1B_Sun2DConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                sun2DGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2D");
                sunCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapSun1B_Sun2DConfirm.gameObject.SetActive(false);

                sun1BImage0.gameObject.SetActive(false);
                questionSun1BText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.7f;

                spellCardSun2D_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapSun1B_Moon2DConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                moon2DGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2D");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapSun1B_Moon2DConfirm.gameObject.SetActive(false);

                sun1BImage0.gameObject.SetActive(false);
                questionSun1BText.gameObject.SetActive(false);
                sun0Image1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.8f;

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

                mapMoon1B_Sun2CConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                sun2CGameNode.gameObject.SetActive(true);

                Debug.Log("SUN2C");
                sunCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapMoon1B_Sun2CConfirm.gameObject.SetActive(false);

                questionMoon1BText.gameObject.SetActive(false);
                moon1BImage0.gameObject.SetActive(false);
                moon1BImage1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.5f;

                spellCardSun2C_0.gameObject.SetActive(true);

            }

            // and ranNum is 1, output Moon
            if (randomNumber == 1)
            {
                moonCoin.gameObject.SetActive(true);

                mapMoon1B_Moon2CConfirm.gameObject.SetActive(true);

                yield return new WaitForSecondsRealtime(3);
                moon2CGameNode.gameObject.SetActive(true);

                Debug.Log("MOON2C");
                moonCoin.gameObject.SetActive(false);
                walletBackdrop.gameObject.SetActive(true);
                mapMoon1B_Moon2CConfirm.gameObject.SetActive(false);

                questionMoon1BText.gameObject.SetActive(false);
                moon1BImage0.gameObject.SetActive(false);
                moon1BImage1.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(false);
                correctText.gameObject.SetActive(false);
                textBackBox.gameObject.SetActive(false);
                bm_SaveData.level = 3.6f;

                spellCardMoon2C_0.gameObject.SetActive(true);
            }
        }


        LOLSDK.Instance.SubmitProgress(100, 60, 100);

        Save();
        Debug.Log("Timer Done");
    }

    // next button during stages with more
    private void OnClickNext()
    {
        Debug.Log("Next");
        BM_AudioManager.instance.Play("Button");
        clearButton.gameObject.SetActive(false);

        speakQuestionButton.gameObject.SetActive(false);
        speakTutorButton.gameObject.SetActive(false);
        cancelSpeakQuestButton.gameObject.SetActive(false);
        cancelSpeakTutorButton.gameObject.SetActive(false);

        //_ttsAudioSource.Stop();
        LOLSDK.Instance.SpeakText("Next");
        //((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();

        Clear();

        if (bm_SaveData.level == 0.1f)
        {
            StartCoroutine(Next_T());
        }

        if (bm_SaveData.level == 3.1f || bm_SaveData.level == 3.2f || bm_SaveData.level == 3.3f || bm_SaveData.level == 3.4f 
            || bm_SaveData.level == 3.5f || bm_SaveData.level == 3.6f || bm_SaveData.level == 3.7f || bm_SaveData.level == 3.8f)
        {
            StartCoroutine(Next_4());
        }

        if (bm_SaveData.level == 3.15f || bm_SaveData.level == 3.25f || bm_SaveData.level == 3.35f || bm_SaveData.level == 3.45f 
            || bm_SaveData.level == 3.55f || bm_SaveData.level == 3.65f || bm_SaveData.level == 3.75f || bm_SaveData.level == 3.85f)
        {
            StartCoroutine(Next_4_5());
        }

        if (bm_SaveData.level == 4.1f)
        {
            StartCoroutine(Next_Final0());
        }

        if (bm_SaveData.level == 4.2f)
        {
            StartCoroutine(Next_Final1());
        }

        if (bm_SaveData.level == 4.3f)
        {
            StartCoroutine(Next_Final2());
        }
    }

    IEnumerator Next_T()
    {
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        nextButton.gameObject.SetActive(false);

        map0Confirm.gameObject.SetActive(true);
        mapT_0.gameObject.SetActive(false);

        yield return new WaitForSecondsRealtime(3);
        textBackBox.gameObject.SetActive(false);
        questionT_Text.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);

        tutorText5.gameObject.SetActive(false);
        textBackBoxTutor.gameObject.SetActive(false);
        tutorDFTalk.gameObject.SetActive(false);
        tutorDFCheer.gameObject.SetActive(false);
        tutorDFIdle.gameObject.SetActive(false);

        level0GameNode.gameObject.SetActive(true);
        questionT_Text.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        correctText.gameObject.SetActive(false);
        incorrectText.gameObject.SetActive(false);

        bm_SaveData.level = 0.5f;
        textBackBox.gameObject.SetActive(false);
        map0Confirm.gameObject.SetActive(false);
        spellCard0.gameObject.SetActive(true);

        LOLSDK.Instance.SubmitProgress(100, 10, 100);

        Save();
    }

    IEnumerator Next_4()
    {
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 3.1f)
        {

            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            sun2AImage0.gameObject.SetActive(false);
            sun2AImage1.gameObject.SetActive(false);
            questionSun2A_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardSun2A_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.15f;
        }

        if (bm_SaveData.level == 3.2f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            moon2AImage0.gameObject.SetActive(false);
            moon2AImage1.gameObject.SetActive(false);
            questionMoon2A_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardMoon2A_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.25f;
        }

        if (bm_SaveData.level == 3.3f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            questionSun2B_0Text.gameObject.SetActive(false);
            sun2BImage0.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            spellCardSun2B_1.gameObject.SetActive(true);
            textBackBox.gameObject.SetActive(false);
            bm_SaveData.level = 3.35f;
        }

        if (bm_SaveData.level == 3.4f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            moon2BImage0.gameObject.SetActive(false);
            questionMoon2B_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardMoon2B_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.45f;
        }

        if (bm_SaveData.level == 3.5f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            sun2CImage0.gameObject.SetActive(false);
            sun2CImage1.gameObject.SetActive(false);
            questionSun2C_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardSun2C_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.55f;
        }

        if (bm_SaveData.level == 3.6f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            questionMoon2C_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardMoon2C_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.65f;
        }

        if (bm_SaveData.level == 3.7f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            questionSun2D_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardSun2D_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.75f;
        }

        if (bm_SaveData.level == 3.8f)
        {
            nextButton.gameObject.SetActive(false);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
            bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
            textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
            textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            moon2DImage0.gameObject.SetActive(false);
            questionMoon2D_0Text.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            spellCardMoon2D_1.gameObject.SetActive(true);

            bm_SaveData.level = 3.85f;
        }

        LOLSDK.Instance.SubmitProgress(100, 70, 100);

        Save();
    }

    IEnumerator Next_4_5()
    {
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        mapSun2A_Final.gameObject.SetActive(false);
        mapMoon2A_Final.gameObject.SetActive(false);
        mapSun2B_Final.gameObject.SetActive(false);
        mapMoon2B_Final.gameObject.SetActive(false);
        mapSun2C_Final.gameObject.SetActive(false);
        mapMoon2C_Final.gameObject.SetActive(false);
        mapSun2D_Final.gameObject.SetActive(false);
        mapMoon2D_Final.gameObject.SetActive(false);

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 3.15f)
        {
            nextButton.gameObject.SetActive(false);

            mapSun2A_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionSun2A_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapSun2A_FinalConfirm.gameObject.SetActive(false);

            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from sun2A");
        }

        if (bm_SaveData.level == 3.25f)
        {
            nextButton.gameObject.SetActive(false);

            mapMoon2A_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionMoon2A_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapMoon2A_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from moon2A");
        }

        if (bm_SaveData.level == 3.35f)
        {
            nextButton.gameObject.SetActive(false);
            mapSun2B_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionSun2B_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapSun2B_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from sun2B");
        }

        if (bm_SaveData.level == 3.45f)
        {
            nextButton.gameObject.SetActive(false);

            mapMoon2B_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionMoon2B_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapMoon2B_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from moon2B");
        }

        if (bm_SaveData.level == 3.55f)
        {
            nextButton.gameObject.SetActive(false);
            mapSun2C_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionSun2C_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapSun2C_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from sun2C");
        }

        if (bm_SaveData.level == 3.65f)
        {
            nextButton.gameObject.SetActive(false);

            mapMoon2C_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            moon2CImage0.gameObject.SetActive(false);
            moon2CImage1.gameObject.SetActive(false);
            questionMoon2C_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapMoon2C_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from moon2C");
        }

        if (bm_SaveData.level == 3.75f)
        {
            nextButton.gameObject.SetActive(false);
            mapSun2D_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionSun2D_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapSun2D_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from sun2D");
        }

        if (bm_SaveData.level == 3.85f)
        {
            nextButton.gameObject.SetActive(false);

            mapMoon2D_FinalConfirm.gameObject.SetActive(true);

            yield return new WaitForSecondsRealtime(3);
            walletBackdrop.gameObject.SetActive(true);
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

            questionMoon2D_1Text.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            mapMoon2D_FinalConfirm.gameObject.SetActive(false);
            spellCardFractionFinal_0.gameObject.SetActive(true);

            bm_SaveData.level = 4.1f;

            Debug.Log("Final from moon2D");
        }

        LOLSDK.Instance.SubmitProgress(100, 80, 100);

        Save();
    }

    IEnumerator Next_Final0()
    {
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 4.1f)
        {
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);
            questionFinalFractionText0.gameObject.SetActive(false);
            finalImage0.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            walletBackdrop.gameObject.SetActive(true);
            spellCardFinalSurvey.gameObject.SetActive(true);

            bm_SaveData.level = 4.2f;
        }

        LOLSDK.Instance.SubmitProgress(100, 90, 100);

        Save();
    }

    IEnumerator Next_Final1()
    {

        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 4.2f)
        {
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);
            questionFinalSurveyText0.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            walletBackdrop.gameObject.SetActive(true);
            spellCardFractionFinal_1.gameObject.SetActive(true);

            bm_SaveData.level = 4.3f;

            LOLSDK.Instance.SubmitProgress(100, 95, 100);
        }

        Save();
    }

    IEnumerator Next_Final2()
    {
        questionNodeBigFraction.gameObject.SetActive(false);
        questionNodeSmolFraction.gameObject.SetActive(false);
        questionNodeSurveyThou.gameObject.SetActive(false);
        questionNodeSurveyHun.gameObject.SetActive(false);

        //walletBackdrop.gameObject.SetActive(true);
        //textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
        //textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

        attempt1 = true;
        attempt2 = false;
        attempt3 = false;

        if (bm_SaveData.level == 4.3f)
        {
            questionFinalFractionText1.gameObject.SetActive(false);
            textBackBox.gameObject.SetActive(false);
            finalImage1.gameObject.SetActive(false);

            correctText.gameObject.SetActive(false);
            incorrectText.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(false);
            yield return new WaitForSecondsRealtime(3);

            // if final was reach through sun2A
            if (sun2AGameNode.gameObject.activeInHierarchy)
            {
                congratsText.gameObject.SetActive(true);

                finalMap_Sun2AFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);
                finalImage1.gameObject.SetActive(false);

                finalMap_Moon2AFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Sun2BFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Moon2BFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Sun2CFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Moon2CFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Sun2DFinal.gameObject.SetActive(true);

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
                congratsText.gameObject.SetActive(true);

                finalMap_Moon2DFinal.gameObject.SetActive(true);

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

    // runs on click hint
    private void OnClickHint()
    {
        if (attempt2 == true || attempt3 == true)
        {
            Debug.Log("HINT");
            hintButton.gameObject.SetActive(false);
            hintTextBox.gameObject.SetActive(false);
            skipButton.gameObject.SetActive(false);

            // level 0
            if (bm_SaveData.level == 0.5f)
            {
                hunHundredNum[1].gameObject.SetActive(true);
            }
            
            // level sun0
            if (bm_SaveData.level == 1.1f)
            {
                bigTop0[1].gameObject.SetActive(true);
                bigBottom1[8].gameObject.SetActive(true);
                bigBottom2_0[3].gameObject.SetActive(true);
            }
            
            // level moon0
            if (bm_SaveData.level == 1.2f)
            {
                bigBottom0[2].gameObject.SetActive(true);
                bigTop1[1].gameObject.SetActive(true);
                bigBottom2_1[2].gameObject.SetActive(true);

            }

            // level sun1A
            if (bm_SaveData.level == 2.1f)
            {
                hunOneNum[0].gameObject.SetActive(true);
            }

            // level moon1A
            if (bm_SaveData.level == 2.2f)
            {
                hunTenNum[7].gameObject.SetActive(true);
            }

            // level sun1B
            if (bm_SaveData.level == 2.3f)
            {
                bigTop0[3].gameObject.SetActive(true);
                bigBottom1[8].gameObject.SetActive(true);
                bigBottom2_0[6].gameObject.SetActive(true);
            }

            // level moon1B
            if (bm_SaveData.level == 2.4f)
            {
                bigTop0[3].gameObject.SetActive(true);
                bigBottom1[6].gameObject.SetActive(true);
                bigBottom2_1[8].gameObject.SetActive(true);
            }

            // level sun2A question 1
            if (bm_SaveData.level == 3.1f)
            {
                bigTop0[3].gameObject.SetActive(true);
                bigBottom1[5].gameObject.SetActive(true);
                bigBottom2_1[0].gameObject.SetActive(true);
            }

            // level sun2A question 2
            if (bm_SaveData.level == 3.15f)
            {
                hunTenNum[6].gameObject.SetActive(true);
            }

            // level moon2A question 1
            if (bm_SaveData.level == 3.2f)
            {
                bigBottom0[9].gameObject.SetActive(true);
                bigTop1[2].gameObject.SetActive(true);
                bigBottom2_0[4].gameObject.SetActive(true);
            }

            // level moon2A question 2
            if (bm_SaveData.level == 3.25f)
            {
                thouHundredNum[3].gameObject.SetActive(true);
                thouOneNum[5].gameObject.SetActive(true);
            }

            // level sun2B question 1
            if (bm_SaveData.level == 3.3f)
            {
                bigBottom0[8].gameObject.SetActive(true);
                bigTop1[3].gameObject.SetActive(true);
                bigBottom2_1[4].gameObject.SetActive(true);
            }

            // level sun2B question 2
            if (bm_SaveData.level == 3.35f)
            {
                hunTenNum[2].gameObject.SetActive(true);
            }

            // level moon2B question 1
            if (bm_SaveData.level == 3.4f)
            {
                bigBottom0[8].gameObject.SetActive(true);
                bigTop1[1].gameObject.SetActive(true);
                bigBottom2_1[2].gameObject.SetActive(true);
            }

            // level moon2B question 2
            if (bm_SaveData.level == 3.45f)
            {
                hunOneNum[8].gameObject.SetActive(true);
            }

            // level sun2C question 1
            if (bm_SaveData.level == 3.5f)
            {
                bigBottom0[8].gameObject.SetActive(true);
                bigTop1[2].gameObject.SetActive(true);
                bigBottom2_0[2].gameObject.SetActive(true);
            }

            // level sun2C question 2
            if (bm_SaveData.level == 3.55f)
            {
                thouThousandNum[1].gameObject.SetActive(true);
                thouOneNum[0].gameObject.SetActive(true);
            }
            // level moon2C question 1
            if (bm_SaveData.level == 3.6f)
            {
                hunTenNum[4].gameObject.SetActive(true);
            }

            // level moon2C question 2
            if (bm_SaveData.level == 3.65f)
            {
                bigTop0[1].gameObject.SetActive(true);
                bigBottom1[5].gameObject.SetActive(true);
                bigBottom2_0[4].gameObject.SetActive(true);
            }

            // level sun2D question 1
            if (bm_SaveData.level == 3.7f)
            {
                smolBottom0[2].gameObject.SetActive(true);
                smolTop1[1].gameObject.SetActive(true);
                smolTop2[1].gameObject.SetActive(true);
            }
            // level sun2D question 2
            if (bm_SaveData.level == 3.75f)
            {
                hunTenNum[7].gameObject.SetActive(true);
            }

            // level moon2D question 1
            if (bm_SaveData.level == 3.8f)
            {
                bigTop0[1].gameObject.SetActive(true);
                bigBottom1[4].gameObject.SetActive(true);
                bigBottom2_0[3].gameObject.SetActive(true);
            }

            // level moon2D question 2
            if (bm_SaveData.level == 3.85f)
            {
                thouThousandNum[1].gameObject.SetActive(true);
                thouHundredNum[8].gameObject.SetActive(true);
            }

            //final question 1
            if (bm_SaveData.level == 4.1f)
            {
                bigTop0[1].gameObject.SetActive(true);
                bigBottom1[4].gameObject.SetActive(true);
                bigBottom2_1[0].gameObject.SetActive(true);
            }

            // final question 2
            if (bm_SaveData.level == 4.2f)
            {
                thouHundredNum[1].gameObject.SetActive(true);
                thouOneNum[4].gameObject.SetActive(true);
            }

            // final question 3
            if (bm_SaveData.level == 4.3f)
            {
                bigBottom0[9].gameObject.SetActive(true);
                bigTop1[3].gameObject.SetActive(true);
                bigBottom2_1[4].gameObject.SetActive(true);
            }
        }
    }
    //runs on click skip
    private void OnClickSkip()
    {
        if (attempt3 == true)
        {
            Debug.Log("SKIP");
            BM_AudioManager.instance.Play("Button");

            hintButton.gameObject.SetActive(false);
            hintTextBox.gameObject.SetActive(false);
            skipButton.gameObject.SetActive(false);

            clearButton.gameObject.SetActive(false);

            speakQuestionButton.gameObject.SetActive(false);
            cancelSpeakQuestButton.gameObject.SetActive(false);
            hintButton.gameObject.SetActive(false);
            hintTextBox.gameObject.SetActive(false);
            skipButton.gameObject.SetActive(false);

            sun0Image0.gameObject.SetActive(false);
            sun0Image1.gameObject.SetActive(false);
            sun1BImage0.gameObject.SetActive(false);
            sun2AImage0.gameObject.SetActive(false);
            sun2AImage1.gameObject.SetActive(false);
            sun2BImage0.gameObject.SetActive(false);
            sun2CImage0.gameObject.SetActive(false);
            sun2CImage1.gameObject.SetActive(false);

            moon1BImage0.gameObject.SetActive(false);
            moon1BImage1.gameObject.SetActive(false);
            moon2AImage0.gameObject.SetActive(false);
            moon2AImage1.gameObject.SetActive(false);
            moon2BImage0.gameObject.SetActive(false);
            moon2CImage0.gameObject.SetActive(false);
            moon2CImage1.gameObject.SetActive(false);
            moon2DImage0.gameObject.SetActive(false);

            finalImage0.gameObject.SetActive(false);
            finalImage1.gameObject.SetActive(false);

            // level 0
            if (bm_SaveData.level == 0.5f)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blob0.gameObject.SetActive(false);
                level0DFTrap.gameObject.SetActive(false);
                level0DFCheer.gameObject.SetActive(true);

                map0_Sun0_Moon0.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun0
            if (bm_SaveData.level == 1.1f)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                mapSun0_Sun1A_Moon1A.gameObject.SetActive(true);

                blobSun0.gameObject.SetActive(false);
                levelSun0DFTrap.gameObject.SetActive(false);
                levelSun0DFCheer.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon0
            if (bm_SaveData.level == 1.2f)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                mapMoon0_Sun1B_Moon1B.gameObject.SetActive(true);

                blobMoon0.gameObject.SetActive(false);
                levelMoon0DFTrap.gameObject.SetActive(false);
                levelMoon0DFCheer.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // level sun1A
            if (bm_SaveData.level == 2.1f)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun1A.gameObject.SetActive(false);
                levelSun1ADFTrap.gameObject.SetActive(false);
                levelSun1ADFCheer.gameObject.SetActive(true);

                mapSun1A_Sun2B_Moon2B.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon1A
            if (bm_SaveData.level == 2.2f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon1A.gameObject.SetActive(false);
                levelMoon1ADFTrap.gameObject.SetActive(false);
                levelMoon1ADFCheer.gameObject.SetActive(true);

                mapMoon1A_Sun2A_Moon2A.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun1B
            if (bm_SaveData.level == 2.3f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun1B.gameObject.SetActive(false);
                levelSun1BDFTrap.gameObject.SetActive(false);
                levelSun1BDFCheer.gameObject.SetActive(true);

                mapSun1B_Sun2D_Moon2D.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon1B
            if (bm_SaveData.level == 2.4f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon1B.gameObject.SetActive(false);
                levelMoon1BDFTrap.gameObject.SetActive(false);
                levelMoon1BDFCheer.gameObject.SetActive(true);

                mapMoon1B_Sun2C_Moon2C.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2A question 1
            if (bm_SaveData.level == 3.1f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2A question 2
            if (bm_SaveData.level == 3.15f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun2A.gameObject.SetActive(false);
                levelSun2ADFTrap.gameObject.SetActive(false);
                levelSun2ADFCheer.gameObject.SetActive(true);

                mapSun2A_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2A question 1
            if (bm_SaveData.level == 3.2f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2A question 2
            if (bm_SaveData.level == 3.25f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon2A.gameObject.SetActive(false);
                levelMoon2ADFTrap.gameObject.SetActive(false);
                levelMoon2ADFCheer.gameObject.SetActive(true);

                mapMoon2A_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2B question 1
            if (bm_SaveData.level == 3.3f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2B question 2
            if (bm_SaveData.level == 3.35f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun2B.gameObject.SetActive(false);
                levelSun2BDFTrap.gameObject.SetActive(false);
                levelSun2BDFCheer.gameObject.SetActive(true);

                mapSun2B_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2B question 1
            if (bm_SaveData.level == 3.4f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2B question 2
            if (bm_SaveData.level == 3.45f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon2B.gameObject.SetActive(false);
                levelMoon2BDFTrap.gameObject.SetActive(false);
                levelMoon2BDFCheer.gameObject.SetActive(true);

                mapMoon2B_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2C question 1
            if (bm_SaveData.level == 3.5f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2C question 2
            if (bm_SaveData.level == 3.55f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun2C.gameObject.SetActive(false);
                levelSun2CDFTrap.gameObject.SetActive(false);
                levelSun2CDFCheer.gameObject.SetActive(true);

                mapSun2C_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }
            // level moon2C question 1
            if (bm_SaveData.level == 3.6f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2C question 2
            if (bm_SaveData.level == 3.65f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon2C.gameObject.SetActive(false);
                levelMoon2CDFTrap.gameObject.SetActive(false);
                levelMoon2CDFCheer.gameObject.SetActive(true);

                mapMoon2C_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level sun2D question 1
            if (bm_SaveData.level == 3.7f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }
            // level sun2D question 2
            if (bm_SaveData.level == 3.75f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobSun2D.gameObject.SetActive(false);
                levelSun2DDFTrap.gameObject.SetActive(false);
                levelSun2DDFCheer.gameObject.SetActive(true);

                mapSun2D_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2D question 1
            if (bm_SaveData.level == 3.8f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // level moon2D question 2
            if (bm_SaveData.level == 3.85f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blobMoon2D.gameObject.SetActive(false);
                levelMoon2DDFTrap.gameObject.SetActive(false);
                levelMoon2DDFCheer.gameObject.SetActive(true);

                mapMoon2D_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            //final question 1
            if (bm_SaveData.level == 4.1f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // final question 2
            if (bm_SaveData.level == 4.2f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // final question 3
            if (bm_SaveData.level == 4.3f)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                //bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                //bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

                blobFinal.gameObject.SetActive(false);
            }
        }
    }

    // runs on click submit button
    public void OnClickSubmit()
    {
        Debug.Log("Submit");
        BM_AudioManager.instance.Play("Button");
        clearButton.gameObject.SetActive(false);

        speakQuestionButton.gameObject.SetActive(false);
        cancelSpeakQuestButton.gameObject.SetActive(false);
        hintButton.gameObject.SetActive(false);
        hintTextBox.gameObject.SetActive(false);
        skipButton.gameObject.SetActive(false);

        sun0Image0.gameObject.SetActive(false);
        sun0Image1.gameObject.SetActive(false);
        sun1BImage0.gameObject.SetActive(false);
        sun2AImage0.gameObject.SetActive(false);
        sun2AImage1.gameObject.SetActive(false);
        sun2BImage0.gameObject.SetActive(false);
        sun2CImage0.gameObject.SetActive(false);
        sun2CImage1.gameObject.SetActive(false);

        moon1BImage0.gameObject.SetActive(false);
        moon1BImage1.gameObject.SetActive(false);
        moon2AImage0.gameObject.SetActive(false);
        moon2AImage1.gameObject.SetActive(false);
        moon2BImage0.gameObject.SetActive(false);
        moon2CImage0.gameObject.SetActive(false);
        moon2CImage1.gameObject.SetActive(false);
        moon2DImage0.gameObject.SetActive(false);

        finalImage0.gameObject.SetActive(false);
        finalImage1.gameObject.SetActive(false);

        //_ttsAudioSource.Stop();
        LOLSDK.Instance.SpeakText("Submit");
        //((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();

        // if Tutorial
        if (bm_SaveData.level == 0.1f)
        {
            if ( // 1/2 X 1/2 = 1/4
                smolTop0[1].gameObject.activeInHierarchy && smolTop1[1].gameObject.activeInHierarchy && smolTop2[1].gameObject.activeInHierarchy &&
                smolBottom0[2].gameObject.activeInHierarchy && smolBottom1[2].gameObject.activeInHierarchy && smolBottom2[4].gameObject.activeInHierarchy)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                textBackBox.gameObject.SetActive(false);
                questionT_Text.gameObject.SetActive(false);

                tutorText5.gameObject.SetActive(true);
                textBackBoxTutor.gameObject.SetActive(true);
                tutorDFTalk.gameObject.SetActive(false);
                tutorDFCheer.gameObject.SetActive(true);
                tutorDFIdle.gameObject.SetActive(false);

                mapT_0.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

            }

            else
            {
                BM_AudioManager.instance.Play("MagicNotWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                correctText.gameObject.SetActive(false);
                incorrectText.gameObject.SetActive(true);
                retryButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                textBackBox.gameObject.SetActive(false);
                questionT_Text.gameObject.SetActive(false);

                tutorText6.gameObject.SetActive(true);
                textBackBoxTutor.gameObject.SetActive(true);
                tutorDFTalk.gameObject.SetActive(true);
                tutorDFCheer.gameObject.SetActive(false);
                tutorDFIdle.gameObject.SetActive(false);
                Debug.Log("Incorrect");
            }
        }

        // if level 0
        if (bm_SaveData.level == 0.5f)
        {
            if (// 110
                hunHundredNum[1].gameObject.activeInHierarchy && hunTenNum[1].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
            {
                BM_AudioManager.instance.Play("MagicWork");
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                flipButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                blob0.gameObject.SetActive(false);
                level0DFTrap.gameObject.SetActive(false);
                level0DFCheer.gameObject.SetActive(true);

                map0_Sun0_Moon0.gameObject.SetActive(true);

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }
            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

            // if current world state is Sun0
            if (sun0GameNode.gameObject.activeInHierarchy && bm_SaveData.level == 1.1f)
            {
                if (// 1/4 X 1/8 = 1/32
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[4].gameObject.activeInHierarchy && bigBottom1[8].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy 
                    ||
                    // 1/8 X 1/4 = 1/32
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[8].gameObject.activeInHierarchy && bigBottom1[4].gameObject.activeInHierarchy && bigBottom2_0[3].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy )
                {
                    BM_AudioManager.instance.Play("MagicWork");
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");

                    mapSun0_Sun1A_Moon1A.gameObject.SetActive(true);

                    blobSun0.gameObject.SetActive(false);
                    levelSun0DFTrap.gameObject.SetActive(false);
                    levelSun0DFCheer.gameObject.SetActive(true);

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

                }

                // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }

            }

            // if current world state is Moon0
            if (moon0GameNode.gameObject.activeInHierarchy && bm_SaveData.level == 1.2f)
            {
                if (// 1/2 X 1/6 = 1/12
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[2].gameObject.activeInHierarchy && bigBottom1[6].gameObject.activeInHierarchy && bigBottom2_0[1].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy
                    ||
                    // 1/6 X 1/2 = 1/12
                    bigTop0[1].gameObject.activeInHierarchy && bigTop1[1].gameObject.activeInHierarchy && bigTop2[1].gameObject.activeInHierarchy &&
                    bigBottom0[6].gameObject.activeInHierarchy && bigBottom1[2].gameObject.activeInHierarchy && bigBottom2_0[1].gameObject.activeInHierarchy && bigBottom2_1[2].gameObject.activeInHierarchy)
                {
                    BM_AudioManager.instance.Play("MagicWork");
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");

                    mapMoon0_Sun1B_Moon1B.gameObject.SetActive(true);

                    blobMoon0.gameObject.SetActive(false);
                    levelMoon0DFTrap.gameObject.SetActive(false);
                    levelMoon0DFCheer.gameObject.SetActive(true);

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

                // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");
    
                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }
            }

            // if current state is sun1A
            if (sun1AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 2.1f)
            {
                if (// 400
                hunHundredNum[4].gameObject.activeInHierarchy && hunTenNum[0].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
                {
                    BM_AudioManager.instance.Play("MagicWork");
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");

                    blobSun1A.gameObject.SetActive(false);
                    levelSun1ADFTrap.gameObject.SetActive(false);
                    levelSun1ADFCheer.gameObject.SetActive(true);

                    mapSun1A_Sun2B_Moon2B.gameObject.SetActive(true);

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

                }

            // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }
            }

            // if current state moon1A
            if (moon1AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 2.2f)
            {
                if (// 475
                hunHundredNum[4].gameObject.activeInHierarchy && hunTenNum[7].gameObject.activeInHierarchy && hunOneNum[5].gameObject.activeInHierarchy)
                {
                    correctText.gameObject.SetActive(true);
                    incorrectText.gameObject.SetActive(false);
                    flipButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Correct");
                    //flipMap.gameObject.SetActive(true);

                    blobMoon1A.gameObject.SetActive(false);
                    levelMoon1ADFTrap.gameObject.SetActive(false);
                    levelMoon1ADFCheer.gameObject.SetActive(true);

                    mapMoon1A_Sun2A_Moon2A.gameObject.SetActive(true);

                    BM_AudioManager.instance.Play("MagicWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
                }

                // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }
            }

            // if state is sun1B
            if (sun1BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 2.3f)
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
                    //flipMap.gameObject.SetActive(true);

                    blobSun1B.gameObject.SetActive(false);
                    levelSun1BDFTrap.gameObject.SetActive(false);
                    levelSun1BDFCheer.gameObject.SetActive(true);

                    mapSun1B_Sun2D_Moon2D.gameObject.SetActive(true);

                    BM_AudioManager.instance.Play("MagicWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
                }

                // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }
            }

            // if state is moon1B
            if (moon1BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 2.4f)
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
                    //flipMap.gameObject.SetActive(true);

                    blobMoon1B.gameObject.SetActive(false);
                    levelMoon1BDFTrap.gameObject.SetActive(false);
                    levelMoon1BDFCheer.gameObject.SetActive(true);

                    mapMoon1B_Sun2C_Moon2C.gameObject.SetActive(true);

                    BM_AudioManager.instance.Play("MagicWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    walletBackdrop.gameObject.SetActive(true);
                    bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                    textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                    textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
                }

                // wrong input
                else
                {
                    if (attempt3 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 3");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt2 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 2");

                        attempt1 = false;
                        attempt2 = false;
                        attempt3 = true;
                    }

                    if (attempt1 == true)
                    {
                        BM_AudioManager.instance.Play("MagicNotWork");

                        questionNodeSmolFraction.gameObject.SetActive(false);
                        questionNodeBigFraction.gameObject.SetActive(false);
                        questionNodeSurveyHun.gameObject.SetActive(false);
                        questionNodeSurveyThou.gameObject.SetActive(false);

                        correctText.gameObject.SetActive(false);
                        incorrectText.gameObject.SetActive(true);
                        retryButton.gameObject.SetActive(true);
                        submitButton.gameObject.SetActive(false);
                        Debug.Log("Incorrect");
                        Debug.Log("Attempt 1");

                        attempt1 = false;
                        attempt2 = true;
                        attempt3 = false;
                    }
                }
            }

        // if Sun2A world state and 1st question
        if (sun2AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.1f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if Sun2A world state and 2nd question
        if (sun2AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.15f)
        {
            if ( // 560
                hunHundredNum[5].gameObject.activeInHierarchy && hunTenNum[6].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy )
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                //flipMap.gameObject.SetActive(true);

                blobSun2A.gameObject.SetActive(false);
                levelSun2ADFTrap.gameObject.SetActive(false);
                levelSun2ADFCheer.gameObject.SetActive(true);

                mapSun2A_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if Moon2A world state and 1st question
        if (moon2AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.2f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if Moon2A world state and 2nd question
        if (moon2AGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.25f)
        {
            if ( // 2315 
                 thouThousandNum[2].gameObject.activeInHierarchy && thouHundredNum[3].gameObject.activeInHierarchy && thouTenNum[1].gameObject.activeInHierarchy && thouOneNum[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                //flipMap.gameObject.SetActive(true);

                blobMoon2A.gameObject.SetActive(false);
                levelMoon2ADFTrap.gameObject.SetActive(false);
                levelMoon2ADFCheer.gameObject.SetActive(true);

                mapMoon2A_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2B state and 1st question
        if (sun2BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.3f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2B state and 2nd question
        if (sun2BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.35f)
        {
            if ( // 625
                 hunHundredNum[6].gameObject.activeInHierarchy && hunTenNum[2].gameObject.activeInHierarchy && hunOneNum[5].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");
                //flipMap.gameObject.SetActive(true);

                blobSun2B.gameObject.SetActive(false);
                levelSun2BDFTrap.gameObject.SetActive(false);
                levelSun2BDFCheer.gameObject.SetActive(true);

                mapSun2B_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if moon2B state and 1st question
        if (moon2BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.4f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if moon2B state and 2nd question
        if (moon2BGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.45f)
        {
            if ( // 728
                 hunHundredNum[7].gameObject.activeInHierarchy && hunTenNum[2].gameObject.activeInHierarchy && hunOneNum[8].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                //flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");

                blobMoon2B.gameObject.SetActive(false);
                levelMoon2BDFTrap.gameObject.SetActive(false);
                levelMoon2BDFCheer.gameObject.SetActive(true);

                mapMoon2B_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2C state and 1st question
        if (sun2CGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.5f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2C state and 2nd question
        if (sun2CGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.55f)
        {
            if (// 1800 
                 thouThousandNum[1].gameObject.activeInHierarchy && thouHundredNum[8].gameObject.activeInHierarchy && thouTenNum[0].gameObject.activeInHierarchy && thouOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                //flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");

                blobSun2C.gameObject.SetActive(false);
                levelSun2CDFTrap.gameObject.SetActive(false);
                levelSun2CDFCheer.gameObject.SetActive(true);

                mapSun2C_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if moon2C state and 1st question
        if (moon2CGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.6f)
        {
            if (// 944
                 hunHundredNum[9].gameObject.activeInHierarchy && hunTenNum[4].gameObject.activeInHierarchy && hunOneNum[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if moon2C and 2nd question
        if (moon2CGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.65f)
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

                //flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");

                blobMoon2C.gameObject.SetActive(false);
                levelMoon2CDFTrap.gameObject.SetActive(false);
                levelMoon2CDFCheer.gameObject.SetActive(true);

                mapMoon2C_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2D state and 1st question
        if (sun2DGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.7f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // if sun2D state and 2nd question
        if (sun2DGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.75f)
        {
            if ( // 870
                 hunHundredNum[8].gameObject.activeInHierarchy && hunTenNum[7].gameObject.activeInHierarchy && hunOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                //flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");

                blobSun2D.gameObject.SetActive(false);
                levelSun2DDFTrap.gameObject.SetActive(false);
                levelSun2DDFCheer.gameObject.SetActive(true);

                mapSun2D_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // moon2D state and 1st question
        if (moon2DGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.8f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        // moon2D state and 2nd question
        if (moon2DGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 3.85f)
        {
            if (// 1840 
                 thouThousandNum[1].gameObject.activeInHierarchy && thouHundredNum[8].gameObject.activeInHierarchy && thouTenNum[4].gameObject.activeInHierarchy && thouOneNum[0].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);

                //flipMap.gameObject.SetActive(true);
                Debug.Log("Correct");

                blobMoon2D.gameObject.SetActive(false);
                levelMoon2DDFTrap.gameObject.SetActive(false);
                levelMoon2DDFCheer.gameObject.SetActive(true);

                mapMoon2D_Final.gameObject.SetActive(true);

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 4.1f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 4.2f)
        {
            if (// 3124 
                 thouThousandNum[3].gameObject.activeInHierarchy && thouHundredNum[1].gameObject.activeInHierarchy && thouTenNum[2].gameObject.activeInHierarchy && thouOneNum[4].gameObject.activeInHierarchy)
            {
                correctText.gameObject.SetActive(true);
                incorrectText.gameObject.SetActive(false);
                nextButton.gameObject.SetActive(true);
                submitButton.gameObject.SetActive(false);
                Debug.Log("Correct");

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }

        if (finalGameNode.gameObject.activeInHierarchy && bm_SaveData.level == 4.3f)
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

                BM_AudioManager.instance.Play("MagicWork");

                questionNodeSmolFraction.gameObject.SetActive(false);
                questionNodeBigFraction.gameObject.SetActive(false);
                questionNodeSurveyHun.gameObject.SetActive(false);
                questionNodeSurveyThou.gameObject.SetActive(false);

                walletBackdrop.gameObject.SetActive(true);
                bm_SaveData.sunWallet = bm_SaveData.sunWallet + 50;
                bm_SaveData.moonWallet = bm_SaveData.moonWallet + 50;
                textSunWallet.SetText(bm_SaveData.sunWallet.ToString());
                textMoonWallet.SetText(bm_SaveData.moonWallet.ToString());

                blobFinal.gameObject.SetActive(false);
            }

            // wrong input
            else
            {
                if (attempt3 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 3");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt2 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 2");

                    attempt1 = false;
                    attempt2 = false;
                    attempt3 = true;
                }

                if (attempt1 == true)
                {
                    BM_AudioManager.instance.Play("MagicNotWork");

                    questionNodeSmolFraction.gameObject.SetActive(false);
                    questionNodeBigFraction.gameObject.SetActive(false);
                    questionNodeSurveyHun.gameObject.SetActive(false);
                    questionNodeSurveyThou.gameObject.SetActive(false);

                    correctText.gameObject.SetActive(false);
                    incorrectText.gameObject.SetActive(true);
                    retryButton.gameObject.SetActive(true);
                    submitButton.gameObject.SetActive(false);
                    Debug.Log("Incorrect");
                    Debug.Log("Attempt 1");

                    attempt1 = false;
                    attempt2 = true;
                    attempt3 = false;
                }
            }
        }
    }
}

