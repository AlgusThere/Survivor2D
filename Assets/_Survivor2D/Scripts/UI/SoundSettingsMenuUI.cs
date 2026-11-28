using TMPro;
using UnityEngine;

public class SoundSettingsMenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _MusicValueText;
    [SerializeField] TextMeshProUGUI _SFXValueText;

    public void UpdateMusicValueText(float value)
    {
        _MusicValueText.text = Mathf.RoundToInt(value).ToString();
    }
    public void UpdateSFXValueText(float value)
    {
        _SFXValueText.text = Mathf.RoundToInt(value).ToString();
    }
}
