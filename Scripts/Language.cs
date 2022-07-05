using Assets.SimpleLocalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    void Awake()
    {
        LocalizationManager.Read();
        LocalizationManager.Language = "English";
    }
}
