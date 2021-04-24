using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int macMessages = 25;

    [SerializeField]
    List<Message> messageList = new List<Message>();

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(keyCode.Space))
        {
            SendMessageToChat("You pressed space bar!");
            Debug.Log("Space");
        }
    }

    public void SendMessageToChat(string text)
    {
        if (messageList.Count >= maxMessages)
            messageList.Remove(messageList[0]);

        Message newMessage = new Message();

        newMessage.text = text;

        messageList.Add(newMessage);
    }
}

[System.Serializable]
public class Message
{
    public string text;
}