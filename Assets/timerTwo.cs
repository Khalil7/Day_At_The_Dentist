using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timerTwo : MonoBehaviour {
    [SerializeField]
    private Image fillImg;
    [SerializeField]
	private float timeAmt = 5;

	private float time;

    public bool countdown = false;

    private void Start(){
		fillImg = this.GetComponent<Image>();
		time = timeAmt;
	}
	private void Update() {

        if (time > 0 && countdown) {
            
			time -= Time.deltaTime;
			fillImg.fillAmount = time / timeAmt;
		}
	}

    public void BeginCountdown()
    {
        countdown = true;
    }

    public void RestartCountdown()
    {
        countdown = false;
        time = timeAmt;
        fillImg.fillAmount = 1f;
        
    }


}