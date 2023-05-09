using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
[RequireComponent (typeof(Text))]

public class OptionButton : MonoBehaviour
{
    private Text my_text = null;
    private Button my_button = null;
    private Image my_image = null;
    private Color Color_Original = Color.black;

    public Options Option { get; set; }

    private void Awake()
    {
        my_text = transform.GetChild(0).GetComponent<Text>();
        my_button = GetComponent<Button>();
        my_image = GetComponent<Image>();
        Color_Original = my_image.color;

    }
    public void Construtor(Options option, Action<OptionButton> callback)
    {
        my_text.text = option.text;
        my_button.onClick.RemoveAllListeners();
        my_button.enabled = true;
        my_image.color = Color_Original;
        Option = option;
        //my_button.onClick.AddListener(delegate { callback(malditasea()); });
    }
    public void SetColor(Color c)
    {
        my_button.enabled = false;
        my_image.color = c;
    }

}
    
    

