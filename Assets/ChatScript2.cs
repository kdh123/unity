using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine.Android;

public class ChatScript2 : MonoBehaviour
{
    public int cnt = 0, pressCnt = 0;

    public string prevText = "";

    //[SerializeField]
    public Transform SpawnPoint = null;

    //[SerializeField]
    public GameObject item = null;

    //[SerializeField]
    public RectTransform content = null;

    //[SerializeField]
    public int numberOfItems = 0;


    public InputField inputField = null;
    public Text inputText = null;

    List<string> chats = new List<string>();

    public ScrollRect scrollRect = null;

    public Button btn = null;

    public void ScrollToTop(ScrollRect scrollRect)
    {
        scrollRect.normalizedPosition = new Vector2(0, 1);
    }
    public void ScrollToBottom(ScrollRect scrollRect)
    {
        scrollRect.normalizedPosition = new Vector2(0, 0);
    }


    public void Update()
    {

        prevText = inputField.text;


    }


    // Use this for initialization
    public void Start()
    {




        content.sizeDelta = new Vector3(0, 0, 0);


        inputField.onEndEdit.AddListener(delegate
        {

            inputField.text = prevText;
        });

    }


    public void AddItem()
    {


        if (cnt < 1)
        {
            content.localScale = new Vector3(1, 1, 1);
            cnt++;
        }


        string word = inputField.text;

        chats.Add(word);




        int numberOfItems = chats.Count;

        content.sizeDelta = new Vector2(0, (numberOfItems + 1) * 25);

        // 60 width of item
        float spawnY = (chats.Count - 1) * 25;
        //newSpawn Position
        Vector3 pos = new Vector3(0, -spawnY, 0);
        //instantiate item
        GameObject SpawnedItem = Instantiate(item, pos, SpawnPoint.rotation);
        //setParent
        SpawnedItem.transform.SetParent(SpawnPoint, false);
        //get ItemDetails Component
        Item items = SpawnedItem.GetComponent<Item>();
        //set name
        items.text.text = word;

        prevText = "";
        inputField.text = "";




        ScrollToBottom(scrollRect);

    }


    public void Send()
    {
        if (inputField.text.Length > 0)
            AddItem();
        else
        {
            setVisibilityPopup(true);
        }

    }



}