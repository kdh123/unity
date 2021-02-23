using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTabScript2 : MonoBehaviour
{
    public HorizontalLayoutGroup videoPanel;
    public VerticalLayoutGroup whiteboardPanel;

    public RawImage teacherView, myView;

    public Image videoTab, whiteboardTab;
    public Text videoTabText, whiteboardTabText;

    public RectTransform teacherPanel, myPanel;

    void Start()
    {
        whiteboardPanel.gameObject.SetActive(false);

    }

    public void ChangeVideoView()
    {
        videoTab.color = new Color32(242, 203, 97, 255);
        videoTabText.color = new Color32(0, 0, 0, 255);
        whiteboardTab.color = new Color32(0, 0, 0, 255);
        whiteboardTabText.color = new Color32(255, 255, 255, 255);


        whiteboardPanel.gameObject.SetActive(false);
        videoPanel.gameObject.SetActive(true);


        //teacherView.rectTransform.sizeDelta = new Vector2(300, 280);
        //myView.rectTransform.sizeDelta = new Vector2(300, 280);
        teacherPanel.localScale = new Vector3(1, 1, 1);
        myPanel.localScale = new Vector3(1, 1, 1);


        teacherPanel.transform.SetParent(videoPanel.gameObject.transform);
        myPanel.transform.SetParent(videoPanel.gameObject.transform);

    }


    public void ChangeWhiteboardView()
    {
        videoTab.color = new Color32(0, 0, 0, 255);
        videoTabText.color = new Color32(255, 255, 255, 255);
        whiteboardTab.color = new Color32(242, 203, 97, 255);
        whiteboardTabText.color = new Color32(0, 0, 0, 255);

        whiteboardPanel.gameObject.SetActive(true);
        videoPanel.gameObject.SetActive(false);

        //teacherView.rectTransform.sizeDelta = new Vector2(150, 120);
        //myView.rectTransform.sizeDelta = new Vector2(150, 120);
        teacherPanel.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        myPanel.localScale = new Vector3(0.5f, 0.5f, 0.5f);




        teacherPanel.transform.SetParent(whiteboardPanel.gameObject.transform);
        myPanel.transform.SetParent(whiteboardPanel.gameObject.transform);

    }



}
