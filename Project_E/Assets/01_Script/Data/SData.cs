using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SData : SingletonBehabiour<SData>
{
    [SerializeField] Test testDatas; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static TestData[] TestData { get { return Instance.testDatas.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static TestData GetTestData(int _id)
    {
        for (int i = 0; i < TestData.Length; i++)
            if (TestData[i].ID == _id)
                return TestData[i];
        return null;
    }


    [SerializeField] RenpyStory renpyStory; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static RenpyStoryData[] RenpyStoryData { get { return Instance.renpyStory.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static RenpyStoryData GetRenpyStoryData(int _id)
    {
        for (int i = 0; i < RenpyStoryData.Length; i++)
            if (RenpyStoryData[i].ID == _id)
                return RenpyStoryData[i];
        return null;
    }

    [SerializeField] RenpyCharacter renpyCharacter; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static RenpyCharacterData[] RenpyCharacterData { get { return Instance.renpyCharacter.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static RenpyCharacterData GetRenpyCharacterData(int _id)
    {
        for (int i = 0; i < RenpyCharacterData.Length; i++)
            if (RenpyCharacterData[i].ID == _id)
                return RenpyCharacterData[i];
        return null;
    }

    [SerializeField] Starrail starrail; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name


    [SerializeField] Localize localizeData; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static LocalizeData[] LocalizeData { get { return Instance.localizeData.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static LocalizeData GetLocalizeData(int _id)
    {
        for (int i = 0; i < LocalizeData.Length; i++)
            if (LocalizeData[i].ID == _id)
                return LocalizeData[i];
        return null;
    }

    [SerializeField] Resource resourceData; // DataTableÀÇ µ¥ÀÌÅÍ ÅÇ Name
    public static ResourceData[] ResourceData { get { return Instance.resourceData.dataArray; } } // µ¥ÀÌÅÍ ÅÇ Name + Data
    public static ResourceData GetResourceData(int _id)
    {
        for (int i = 0; i < ResourceData.Length; i++)
            if (ResourceData[i].ID == _id)
                return ResourceData[i];
        return null;
    }
}
