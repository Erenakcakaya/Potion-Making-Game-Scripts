using UnityEngine;
using TMPro;

public class BoilerScript : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public AudioSource success;
    public AudioSource fail;

    void TextSettings(TMP_Text textobj, string text, int size, FontStyles font, Color32 color, AudioSource source) // Textin ayarlarý
    {
        textobj.text = text;
        textobj.fontSize = size;
        textobj.fontStyle = font;
        textobj.color = color;
        source.Play();
    }
    
    public void Potion() // Tarifler
    {
        if (text1.text == "" || text2.text == "" || text3.text == "" || text4.text == "") // Eþya yoksa
        {
            text5.text = "";
        }
        else if (text1.text == "Basic Plant" && text2.text == "Venus Leaf" && text3.text == "Gold Powder" && text4.text == "Beargrass")//(text1.text == "Basic Plant" && text2.text == "Venus Leaf" && text3.text == "Gold Powder" && text4.text == "Humming Herb")
        {
            TextSettings(text5, "Strength Potion", 30, FontStyles.Normal, new Color32(4, 44, 112, 255),success);

        }
        else if (text1.text == "Basic Plant" && text2.text == "Leaf Of Obscurity" && text3.text == "Gold Powder" && text4.text == "Beargrass")
        {
            TextSettings(text5, "Truth Potion", 30, FontStyles.Normal, new Color32(153, 194, 19, 255), success);
   
        }
        else if (text1.text == "Basic Plant" && text2.text == "Ominous Leaf" && text3.text == "Gold Powder" && text4.text == "Beargrass")
        {
            TextSettings(text5, "Dead Poison", 30, FontStyles.Normal, new Color32(130, 12, 12, 255), success);

        }
        else if (text1.text == "Basic Plant" && text2.text == "Venus Leaf" && text3.text == "Silver Powder" && text4.text == "Beargrass")
        {
            TextSettings(text5, "Space Potion", 30, FontStyles.Normal, new Color32(4, 10, 64, 255), success);
  
        }
        else if (text1.text == "Basic Plant" && text2.text == "Leaf Of Obscurity" && text3.text == "Silver Powder" && text4.text == "Beargrass")
        {
            TextSettings(text5, "Invisibility Potion", 30, FontStyles.Normal, new Color32(145, 151, 207, 255), success);

        }
        else if (text1.text == "Basic Plant" && text2.text == "Ominous Leaf" && text3.text == "Silver Powder" && text4.text == "Beargrass")
        {
            TextSettings(text5, "Plague Poison", 30, FontStyles.Normal, new Color32(99, 27, 53, 255), success);

        }
        else // Kullanýlan eþyalar bir iksir oluþturmuyorsa...
        {
            TextSettings(text5, "Wrong Recipe", 30, FontStyles.Normal, new Color32(214, 34, 21, 255), fail);

        }
    }

}
