using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FireCooldownVisualizer : MonoBehaviour
{
    public Player player;
    public Slider cooldownSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldownSlider.value = player.currentCooldown / player.Cooldown;
    }
}
