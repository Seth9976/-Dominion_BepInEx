using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000042 RID: 66
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x060003A4 RID: 932 RVA: 0x00002F17 File Offset: 0x00001117
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100663863);
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x0001265C File Offset: 0x0001085C
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

	// Token: 0x060003A6 RID: 934 RVA: 0x00002F46 File Offset: 0x00001146
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040002D5 RID: 725
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;
}
