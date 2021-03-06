﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 56: PhotonUnityNetworking.Utilities.dll - Assembly: PhotonUnityNetworking.Utilities, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5605-5662

namespace Photon.Pun.UtilityScripts
{
	// [RequireComponent] // 0x0000000180147B00-0x0000000180147B50
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 5654
	{
		// Fields
		public Toggle toggle; // 0x18
		private UnityEngine.UI.Text _text; // 0x20
		public Color NormalOnColor; // 0x28
		public Color NormalOffColor; // 0x38
		public Color HoverOnColor; // 0x48
		public Color HoverOffColor; // 0x58
		private bool isHover; // 0x68
	
		// Constructors
		public TextToggleIsOnTransition() {} // 0x0000000181278FA0-0x0000000181279010
	
		// Methods
		public void OnEnable() {} // 0x00000001812838A0-0x00000001812839A0
		public void OnDisable() {} // 0x0000000181283800-0x00000001812838A0
		public void OnValueChanged(bool isOn) {} // 0x0000000181278F50-0x0000000181278FA0
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000181278E90-0x0000000181278EF0
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000181278EF0-0x0000000181278F50
	}
}
