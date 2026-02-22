using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200009A RID: 154
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Object
{
	// Token: 0x060005CD RID: 1485 RVA: 0x00004E97 File Offset: 0x00003097
	// Note: this type is marked as 'beforefieldinit'.
	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "", "<PrivateImplementationDetails>");
		global::_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::_PrivateImplementationDetails_>.NativeClassPtr, 100664006);
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x000191C4 File Offset: 0x000173C4
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

	// Token: 0x060005CF RID: 1487 RVA: 0x00004EC6 File Offset: 0x000030C6
	public _PrivateImplementationDetails_(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040003E7 RID: 999
	private static readonly IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;
}
