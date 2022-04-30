using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPScr : MonoBehaviour
{
    public Text TextValue;
    public Image XPLine;

    private Slider Slider; 
    void Start()
    {
        Slider = GetComponent<Slider>();
        UpdateTextValue();
        UpdateXP();
    }

    // Update is called once per frame
    public void UpdateTextValue()
    {
        TextValue.text = Slider.value.ToString();
    }

    public void UpdateXP()
    {
        var coeff = Slider.value / Slider.maxValue;
        XPLine.fillAmount = coeff;
    }
}
