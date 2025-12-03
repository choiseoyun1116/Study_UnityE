//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;
//using UnityEngine.UI;

//public class StarrailControl : ControlBase<StarrailControl>
//{
//    protected override void Start()
//    {
//        base.Start();
//    }
//    // MonoBehaviour의 Start 함수 기본 동작 수행

//    public override void Open(PlayerData _pData)
//    {
//        base.Open(_pData);
//    }
//    // 플레이어 데이터를 받아 컨트롤러를 활성화

//    public override void Initialize()
//    {
//        base.Initialize();

//        nowData = SData.GetStarRailRandomWorld(PData.StarRail.NowWorldID);
//        RefreshUI();
//    }
//    // 컨트롤러의 초기 데이터 설정 및 UI 갱신
    
//    StarrailData nowData; // 현재 표시 중인 Starrail 관련 데이터

//    [SerializeField] Image[] img_BG; // 배경 이미지 배열
//    [SerializeField] Image img_Pom; // 폼폼 캐릭터 이미지

//    [SerializeField] TextMeshProUGUI txt_Title; // 제목 텍스트
//    [SerializeField] TextMeshProUGUI txt_Text; // 본문 텍스트
//    [SerializeField] Image img_Icon; // 아이콘 이미지

//    public void ChangeWorld()
//    {
//        PData.StarRail.NowWorldID = PData.StarRail.NowWorldID == 2001 ? 2002 : 2001; // 삼항연산자를 이용해 NowWorldID를 2001 또는 2002로 전환

//        Click();
//    }
//    // 현재 월드 ID를 변경하고 새로운 데이터로 UI를 갱신

//    public void ChangeLocalize()
//    {
//        if (PData.Language == LANGUAGE.KOREAN)
//        {
//            PData.Language = LANGUAGE.ENGLISH;
//        }
//        else
//        {
//            PData.Language = LANGUAGE.KOREAN;
//        }

//        RefreshTextUI();
//    }
//    // 현재 언어를 한국어와 영어 사이에서 전환하고 텍스트 UI를 갱신

//    public void Click()
//    {
//        nowData = SData.GetStarRailRandomWorld(PData.StarRail.NowWorldID);
//        RefreshUI();
//    }
//    // 현재 월드 ID에 맞는 무작위 데이터를 가져와 UI를 갱신

//    public void RefreshUI()
//    {
//        for (int i = 0; i < img_BG.Length; i++)
//        {
//            img_BG[i].sprite = Resources.Load<Sprite>(GetResourcePath(nowData.World)); // 배경 이미지 변경
//        }

//        img_Pom.sprite = Resources.Load<Sprite>(GetResourcePath(nowData.World + 100)); // 폼폼 이미지 변경

//        img_Icon.sprite = Resources.Load<Sprite>(GetResourcePath(nowData.Icon));

//        RefreshTextUI();
//    }
//    // 현재 nowData에 기반하여 이미지 요소를 모두 갱신

//    void RefreshTextUI()
//    {
//        switch (PData.Language)
//        {
//            case LANGUAGE.KOREAN:
//                txt_Title.text = SData.GetLocalizeData(nowData.Titletext).Kor;
//                txt_Text.text = SData.GetLocalizeData(nowData.Text).Kor;
//                break;
//            case LANGUAGE.ENGLISH:
//                txt_Title.text = SData.GetLocalizeData(nowData.Titletext).En;
//                txt_Text.text = SData.GetLocalizeData(nowData.Text).En;
//                break;
//            default:
//                txt_Title.text = SData.GetLocalizeData(nowData.Titletext).Kor;
//                txt_Text.text = SData.GetLocalizeData(nowData.Text).Kor;
//                break;
//        }
//    }
//    // 현재 설정된 언어에 따라 제목과 본문 텍스트를 갱신

//    string GetResourcePath(int _id)
//    {
//        return SData.GetResourceData(_id).Path;
//    }
//    // 주어진 ID에 해당하는 리소스 경로를 반환
//}