using UnityEngine;
using UnityEngine.Video;

public class HideObjectAfterVideoFinished : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject objectToHide;

    void Start()
    {
        // 動画再生が終了したときに、オブジェクトを非表示にするコールバックを登録する
        videoPlayer.loopPointReached += HideObject;
    }

    void HideObject(VideoPlayer vp)
    {
        // オブジェクトを非表示にする
        objectToHide.SetActive(false);
    }
}
