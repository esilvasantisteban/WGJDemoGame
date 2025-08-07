using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyStrokeVisualizer : MonoBehaviour
{
    public List<KeyStrokeVisualizerData> keys;

    private void Update()
    {
        keys.ForEach(keyStrokeData =>
        {
            if (Input.GetKey(keyStrokeData.key)) {
                keyStrokeData.img.sprite = keyStrokeData.heldSprite;
            }
            else
            {
                keyStrokeData.img.sprite = keyStrokeData.sprite;
            }
        });
    }
}

[System.Serializable]
public class KeyStrokeVisualizerData
{
    public Image img;
    public Sprite sprite;
    public Sprite heldSprite;
    public string key;
}

