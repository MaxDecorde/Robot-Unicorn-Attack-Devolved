using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuParamScript : MonoBehaviour
{
    public AudioMixer audiMixer;
    public Dropdown resolutionDropdown;
    public Slider volumeSlider;

    private Resolution[] _resolutions;
    private const string AudioControllerName = "MasterVolume";
    public void Start()
    {
        //Init volume
        audiMixer.GetFloat(AudioControllerName, out var tmp);
        volumeSlider.value = tmp;
        
        //Init resolution
        resolutionDropdown.ClearOptions();
        
        _resolutions = Screen.resolutions
            .Select(resolution => new Resolution{width = resolution.width, height = resolution.height})
            .Distinct()
            .ToArray();

        var options = new List<string>();
        var currentVolumeIndex = 0;
        for (var i = 0 ; i < _resolutions.Length ; i++)
        {
            var option = _resolutions[i].width + "x" + _resolutions[i].height;
            options.Add(option);

            if (_resolutions[i].width == Screen.width && _resolutions[i].height == Screen.height)
                currentVolumeIndex = i;
        }

        resolutionDropdown.AddOptions(options);
        //resolutionDropdown.value = currentVolumeIndex;
        //resolutionDropdown.RefreshShownValue();
    }
    
    public void SetVolume(float volume)
    {
        audiMixer.SetFloat(AudioControllerName, volume);
    }

    public void SetResolution(int index)
    {
        var resolution = _resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
