﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace RootMotion.FinalIK
{
	[Serializable]
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 6674
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get => default; } // 0x0000000180524430-0x00000001805244D0 
	
		// Constructors
		public ConstraintRotationOffset() {} // 0x00000001802466A0-0x00000001802466B0
		public ConstraintRotationOffset(Transform transform) {} // 0x000000018024B380-0x000000018024B3B0
	
		// Methods
		public override void UpdateConstraint() {} // 0x00000001805241A0-0x0000000180524430
	}
}
