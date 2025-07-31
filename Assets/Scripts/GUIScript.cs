using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
    public TextMeshProUGUI angleText;
    public Slider angleSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angleText.text = "" + angleSlider.value;
    }
}
