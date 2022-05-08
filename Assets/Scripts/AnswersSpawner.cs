using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswersSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] answers;

    private void Awake()
    {
        List<GameObject> temps = new List<GameObject>();
        List<int> numbers = new List<int>();

        int count = 0;

        while (count < 3)
        {
            int option = Random.Range(0, answers.Length);

            if(numbers.Count > 0)
            {
                while (numbers.Contains(option))
                {
                    option = Random.Range(0, answers.Length);
                }
            }

            GameObject temp  = Instantiate(answers[option], transform);
            temps.Add(temp);

            string text = temp.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text;

            if (count == 0)
            {
                temp.transform.localPosition = new Vector3(-3.32f, 0.04999924f, 0.0f);
                temp.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "a: " + text;
            }
            else
            {
                temp.transform.localPosition = new Vector3(temps[count - 1].transform.localPosition.x + 3.5f, 0.04999924f, 0.0f);

                if (count == 1)
                {
                    temp.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "b: " + text;
                }else if(count == 2)
                {
                    temp.transform.GetChild(0).GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "c: " + text;
                }
            }

            numbers.Add(option);

            count++;
        }
    }
}