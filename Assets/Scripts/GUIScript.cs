using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GUIScript : MonoBehaviour
{
    public TextMeshProUGUI angleText;
    public Slider angleSlider;
    public TextMeshProUGUI forceText;
    public Slider forceSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angleText.text = "Kulma: " + angleSlider.value;
        forceText.text = "Voima: " + forceSlider.value;
    }
}
