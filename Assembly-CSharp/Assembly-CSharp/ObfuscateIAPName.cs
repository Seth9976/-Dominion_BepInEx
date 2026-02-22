using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200008C RID: 140
public class ObfuscateIAPName : Object
{
	// Token: 0x06001163 RID: 4451 RVA: 0x0004DE24 File Offset: 0x0004C024
	// Note: this type is marked as 'beforefieldinit'.
	static ObfuscateIAPName()
	{
		Il2CppClassPointerStore<ObfuscateIAPName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ObfuscateIAPName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscateIAPName>.NativeClassPtr);
		ObfuscateIAPName.NativeMethodInfoPtr_CreateHashString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscateIAPName>.NativeClassPtr, 100664610);
		ObfuscateIAPName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscateIAPName>.NativeClassPtr, 100664611);
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x0004DE7C File Offset: 0x0004C07C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 242429, RefRangeEnd = 242437, XrefRangeStart = 242424, XrefRangeEnd = 242429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateHashString(string text)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscateIAPName.NativeMethodInfoPtr_CreateHashString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001165 RID: 4453 RVA: 0x0004DEB8 File Offset: 0x0004C0B8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObfuscateIAPName()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscateIAPName>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscateIAPName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x0000BD66 File Offset: 0x00009F66
	public ObfuscateIAPName(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000C26 RID: 3110
	private static readonly IntPtr NativeMethodInfoPtr_CreateHashString_Public_Static_String_String_0;

	// Token: 0x04000C27 RID: 3111
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
