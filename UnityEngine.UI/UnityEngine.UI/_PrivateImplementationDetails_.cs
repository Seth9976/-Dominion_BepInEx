using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000074 RID: 116
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06000B54 RID: 2900 RVA: 0x00006092 File Offset: 0x00004292
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB");
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x000060C1 File Offset: 0x000042C1
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00032BD4 File Offset: 0x00030DD4
	// (set) Token: 0x06000B57 RID: 2903 RVA: 0x000060CA File Offset: 0x000042CA
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique _1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB, (void*)(&valueTypeNPrivateSealedUnique));
			return valueTypeNPrivateSealedUnique;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB, (void*)(&value));
		}
	}

	// Token: 0x04000897 RID: 2199
	private static readonly IntPtr NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

	// Token: 0x020000D4 RID: 212
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedUnique
	{
		// Token: 0x06000D78 RID: 3448 RVA: 0x0000718D File Offset: 0x0000538D
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000071A3 File Offset: 0x000053A3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
		}
	}
}
