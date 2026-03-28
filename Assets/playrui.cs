using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class playrui : MonoBehaviour
{

    public giop giop;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;





    \
    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = giop.maxHealth;
        healthSlider.value = giop.health;

        coinsCounterText.text = giop.coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
