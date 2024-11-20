using UnityEngine;

namespace WebbiFox.Tools
{
  public class SFXmanager : MonoBehaviour
  {
    ///<summary>
    /// 播放音效
    /// </summary>
    /// <param name="clip">音效</param>
    private void PlaySound(AudioClip clip)
    {
        SoundManager.Instance.PlaySound(clip);
    }
  }
}
