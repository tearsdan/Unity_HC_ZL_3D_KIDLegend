
using UnityEngine;

public class LearnArray : MonoBehaviour
{
    public int a = 50;
    public int b = 60;
    public int c = 70;

    // 陣列:儲存相同類型的資料
    // 陣列語法:練習[]
    public int[] numbers;
    public string[] names;
    public Color[] colors;
    public Vector3[] pos;
    public Player[] players;


    public float[] damages = new float[5];
    public string[] props = new string[3] {"紅水","藍水", "黃水" };
    public Vector2[] positions = { new Vector2(1, 2), new Vector2(3,4)};
    public int[] scores = { 99, 0 };
}
