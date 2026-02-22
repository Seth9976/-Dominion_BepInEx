using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000360 RID: 864
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x060033DF RID: 13279 RVA: 0x000D7350 File Offset: 0x000D5550
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeFieldInfoPtr__99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100669910);
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x000D73A0 File Offset: 0x000D55A0
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 11612, RefRangeEnd = 11627, XrefRangeStart = 11612, XrefRangeEnd = 11627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeStringHash(string s)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x00014494 File Offset: 0x00012694
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000C6A RID: 3178
	// (get) Token: 0x060033E2 RID: 13282 RVA: 0x000D73E4 File Offset: 0x000D55E4
	// (set) Token: 0x060033E3 RID: 13283 RVA: 0x0001449D File Offset: 0x0001269D
	public unsafe static global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique _99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92
	{
		get
		{
			global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique valueTypeNPrivateSealedUnique;
			IL2CPP.il2cpp_field_static_get_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92, (void*)(&valueTypeNPrivateSealedUnique));
			return valueTypeNPrivateSealedUnique;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(global::_PrivateImplementationDetails_.NativeFieldInfoPtr__99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92, (void*)(&value));
		}
	}

	// Token: 0x04003010 RID: 12304
	private static readonly IntPtr NativeFieldInfoPtr__99FDA5AE7863649A665A68C2AA2177309F30A9B232D0C35BFF96A25D3B2E1E92;

	// Token: 0x04003011 RID: 12305
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;

	// Token: 0x020003FE RID: 1022
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=32")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedUnique
	{
		// Token: 0x06003A77 RID: 14967 RVA: 0x000169F8 File Offset: 0x00014BF8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=32");
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00016A0E File Offset: 0x00014C0E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<global::_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, ref this));
		}
	}
}
