using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
using TMPro;
using UnityEngine.Video;

public class chairBoxUI : MonoBehaviour
{
    [SerializeField]
    private InteractionSourcePressType pressType = InteractionSourcePressType.None;

    [SerializeField]
    private List<GameObject> dialogues;

    [SerializeField]
    private bool teleMainGame = false;

    [SerializeField]
    private PositionChanger changer;

    [SerializeField]
    private GameObject dentalRoomBox;

    private GameObject dialogue;

    [SerializeField]
    private AudioSource currentAudio;

    public bool updateTextBool()
    {
        if (dialogues.Count == 0)
        {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.SetActive(false);
            return true;

        }
        else
        {
            dialogues[dialogues.Count - 1].SetActive(false);
            currentAudio.Stop();
            if (dialogues[dialogues.Count - 1].tag == "Text")
            {
                this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                this.gameObject.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().SetText(dialogues[dialogues.Count - 1].name);
                dialogues[dialogues.Count - 1].SetActive(true);


            }
            else if (dialogues[dialogues.Count - 1].GetComponent<VideoPlayer>() != null)
            {
                this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                this.gameObject.transform.GetChild(0).gameObject.GetComponent<VideoPlayer>().clip = dialogues[dialogues.Count - 1].GetComponent<VideoPlayer>().clip;
                this.gameObject.transform.GetChild(0).gameObject.GetComponent<VideoPlayer>().Play();
            }
            currentAudio = dialogues[dialogues.Count - 1].GetComponent<AudioSource>();
            dialogues.RemoveAt(dialogues.Count - 1);
        }
        return false;
    }
}
