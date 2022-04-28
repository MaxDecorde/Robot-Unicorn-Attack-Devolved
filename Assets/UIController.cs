using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private Player _player;
    private Text _distanceText;

    private GameObject _results;
    private Text _finalDistanceText;

    private void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
        _results = GameObject.Find("Results");
        _finalDistanceText = GameObject.Find("FinalDistanceText").GetComponent<Text>();

        _results.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        var distance = Mathf.FloorToInt(_player.distance);
        _distanceText.text = distance + " m";

        if (!_player.isDead) return;
        
        _results.SetActive(true);
        _finalDistanceText.text = _distanceText.text;
    }


    public void Quit()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
