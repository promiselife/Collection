using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public class PlayableAnim : MonoBehaviour
{

    public AnimationClip[] Clip;

    private PlayableGraph _playableGraph;

    private AnimationMixerPlayable mixer;

    private Dictionary<string,AnimationClipPlayable> _clipPlayables;

    private Playable _playable;

    private bool isPlaying = false; //是否正在播放

    private byte _lastAnimIndex;    //上一次在播放的动画索引

    private static int nameIndex = 1;
    void Start()
    {
        nameIndex += 1;
        _clipPlayables = new Dictionary<string,AnimationClipPlayable>();
        // 创建一个PlayableGraph并给它命名
        _playableGraph = PlayableGraph.Create(this.name + nameIndex); 
        
        // 创建一个Output节点，类型是Animation，名字是Animation，目标对象是物体上的Animator组件
        var playableOutput = AnimationPlayableOutput.Create(_playableGraph, "Animation", GetComponent<Animator>());

        //创建一个混合器，将output和混合器连接起来
        mixer = AnimationMixerPlayable.Create(_playableGraph, 3);
        playableOutput.SetSourcePlayable(mixer,0);

        for (int i = 0; i < Clip.Length; i++)
        {
            var clipAbles = AnimationClipPlayable.Create(_playableGraph, Clip[i]);
            _clipPlayables.Add(Clip[i].name,clipAbles);
            _playableGraph.Connect(clipAbles,0,mixer,i);
            mixer.SetInputWeight(i,0);
        }
    }

    public void PlayAnim(string animName)
    {
        _playableGraph.Play();
        
        if (!_playable.IsNull())
        {
            _playable.Pause();
            _playable.SetTime(0);
        }
        
        int index = 0;
        for (int i = 0; i < Clip.Length; i++)
        {
            if (animName == Clip[i].name)
            {
                index = i;
                var playAble = mixer.GetInput(i);
                if (playAble.IsNull())
                {
                    _playableGraph.Connect(_clipPlayables[animName],0,mixer,i);
                }
                mixer.SetInputWeight(i,1f);
            }
            else
            {
                mixer.SetInputWeight(i,0f);
            }
        }

        if (index == 0)
        {
            Debug.LogError("TargetPlayAnim Clip is Null");
            return;
        }
        _playable =  mixer.GetInput(index);
        isPlaying = true;
        if (_playable.IsNull()) return;
        _playable.SetTime(0); 
        _playable.Play();
        _lastAnimIndex = (byte)index;
    }

    private void OnDisable()
    {
        _playableGraph.Destroy();
    }

    public void StopAnim()
    {
        if (!_playable.IsNull())
        {
            _playable.Pause();
            _playable.SetTime(0);
        }
        mixer.DisconnectInput(_lastAnimIndex);
    }
}
