using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace UITTimeline
{
	/// <summary>
	/// A UI Toolkit timeline clip to set a VisualElement ti Display.None or Display.Flex.
	///
	/// <see cref="UITBackgroundBehaviour"/>
	/// </summary>
	[Serializable]
	public class UITBackgroundClip : PlayableAsset, ITimelineClipAsset
	{
		public UITBackgroundBehaviour _template = new();

		public ClipCaps clipCaps => ClipCaps.None;

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return ScriptPlayable<UITBackgroundBehaviour>.Create(graph, _template);
		}
	}
}