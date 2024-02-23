using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UIElements;

namespace UITTimeline
{
	/// <summary>
	/// The behaviour / data of the 
	/// 
	/// <see cref="UITBackgroundClip"/>
	/// </summary>
	[Serializable]
	public class UITBackgroundBehaviour : UITBehaviour
	{
		public Texture2D BackgroundImage;

		[HideInInspector] public List<VisualElement> Elements;

		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
			if (Elements == null) return;
			foreach (var e in Elements)
			{
				Debug.Log("UITBackgroundBehaviour.OnBehaviourPlay: " + e.name);
				e.style.backgroundImage = new StyleBackground(BackgroundImage);
			}
		}

		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
			if (Elements == null) return;
			foreach (var e in Elements)
			{
				e.style.backgroundImage = new StyleBackground();
			}
		}
	}
}