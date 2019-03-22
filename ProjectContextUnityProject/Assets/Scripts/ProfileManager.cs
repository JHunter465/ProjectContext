using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileManager : MonoBehaviour
{
    public List<ProfileData> DataList = new List<ProfileData>();

    public void SetProfileData(int _dataIndex)
    {
        ProfileData _profileData = DataList[_dataIndex];

        SetProfileData(_profileData);
    }

    public void SetProfileData(ProfileData _profileData)
    {
        _profileData.Value = _profileData.Inputfield.text;
        _profileData.OutputTextfield.text = _profileData.Name + ": " + _profileData.Value;
    }
}

[System.Serializable]
public class ProfileData
{
    public string Name;
    [HideInInspector] public string Value;
    public TMP_InputField Inputfield;
    public TMP_Text OutputTextfield;
}
