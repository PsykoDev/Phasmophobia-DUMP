﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 62: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5815-6837

namespace Steamworks
{
	[Serializable]
	public struct UGCUpdateHandle_t : IEquatable<Steamworks.UGCUpdateHandle_t>, IComparable<Steamworks.UGCUpdateHandle_t> // TypeDefIndex: 6562
	{
		// Fields
		public static readonly UGCUpdateHandle_t Invalid; // 0x00
		public ulong m_UGCUpdateHandle; // 0x00
	
		// Constructors
		public UGCUpdateHandle_t(ulong value) {
			m_UGCUpdateHandle = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static UGCUpdateHandle_t() {
			Invalid = default;
		} // 0x00000001808402C0-0x0000000180840300
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x0000000180030F30-0x0000000180032FF0
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y) => default; // 0x0000000180840300-0x0000000180840360
		public static explicit operator UGCUpdateHandle_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(UGCUpdateHandle_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(UGCUpdateHandle_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(UGCUpdateHandle_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
