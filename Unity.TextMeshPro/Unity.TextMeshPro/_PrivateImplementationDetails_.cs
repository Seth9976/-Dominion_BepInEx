using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000075 RID: 117
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x06000E7B RID: 3707 RVA: 0x00008CFF File Offset: 0x00006EFF
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB");
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00008D2E File Offset: 0x00006F2E
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0003A9E0 File Offset: 0x00038BE0
	// (set) Token: 0x06000E7E RID: 3710 RVA: 0x00008D37 File Offset: 0x00006F37
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

	// Token: 0x04000B7B RID: 2939
	private static readonly IntPtr NativeFieldInfoPtr__1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB;

	// Token: 0x020000B7 RID: 183
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedUnique
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x00009D56 File Offset: 0x00007F56
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00009D6C File Offset: 0x00007F6C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
		}
	}
}
