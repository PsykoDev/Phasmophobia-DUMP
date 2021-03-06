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
	public struct SteamItemInstanceID_t : IEquatable<Steamworks.SteamItemInstanceID_t>, IComparable<Steamworks.SteamItemInstanceID_t> // TypeDefIndex: 6527
	{
		// Fields
		public static readonly SteamItemInstanceID_t Invalid; // 0x00
		public ulong m_SteamItemInstanceID; // 0x00
	
		// Constructors
		public SteamItemInstanceID_t(ulong value) {
			m_SteamItemInstanceID = default;
		} // 0x0000000180004FE0-0x0000000180004FF0
		static SteamItemInstanceID_t() {
			Invalid = default;
		} // 0x00000001807A4060-0x00000001807A40A0
	
		// Methods
		public override string ToString() => default; // 0x0000000180004FD0-0x0000000180004FE0
		public override bool Equals(object other) => default; // 0x000000018002AE90-0x000000018002AF40
		public override int GetHashCode() => default; // 0x0000000180004FC0-0x0000000180004FD0
		public static bool operator ==(SteamItemInstanceID_t x, SteamItemInstanceID_t y) => default; // 0x00000001802A78A0-0x00000001802A78B0
		public static bool operator !=(SteamItemInstanceID_t x, SteamItemInstanceID_t y) => default; // 0x00000001807A40A0-0x00000001807A4100
		public static explicit operator SteamItemInstanceID_t(ulong value) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public static explicit operator ulong(SteamItemInstanceID_t that) => default; // 0x00000001802A78B0-0x00000001802A78C0
		public bool Equals(SteamItemInstanceID_t other) => default; // 0x0000000180004FB0-0x0000000180004FC0
		public int CompareTo(SteamItemInstanceID_t other) => default; // 0x0000000180004F10-0x0000000180004F20
	}
}
