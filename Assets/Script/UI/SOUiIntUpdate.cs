using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUiIntUpdate : MonoBehaviour
{
    public SOint soInt;
    public TextMeshProUGUI uiTextValue;
    public TextMeshProUGUI uiTextFruit;

    private void Start()
    {
        uiTextFruit.text = soInt.fruit.ToString();
        uiTextValue.text = soInt.value.ToString();
    }
    private void Update()
    {
        uiTextFruit.text = soInt.fruit.ToString();
        uiTextValue.text = soInt.value.ToString();
    }
}
