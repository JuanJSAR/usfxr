using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace usfxr
{
    [CreateAssetMenu(fileName = "SfxrClip", menuName = "usfxr/Clip", order = 1)]
    public class SfxrClip : ScriptableObject
    {
        public SfxrParams clip;

        //[OdinSerialize, SerializeField]
        //public Dictionary<string, SfxrParams> sfxClip = new Dictionary<string, SfxrParams>();

        public void PreCacheClip()
        {
            var s = new Stopwatch();
            s.Start();
            SfxrPlayerGlobal.CacheGet(clip);

            UnityEngine.Debug.Log($"Pre cached sfx found {s.Elapsed.TotalMilliseconds:F1} ms");
        }
    }

    [System.Serializable]
    public class Sfxr
    {
        public string id;
        public SfxrParams sfxrParams;
    }
}

