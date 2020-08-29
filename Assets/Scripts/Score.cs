using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    #region Variables
    public Transform player;
    public Text scoreDisplayed;
    #endregion

    void Update()
    {
        scoreDisplayed.text = player.position.z.ToString("0");
    }
}
