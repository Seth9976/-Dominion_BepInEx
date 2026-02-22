using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000EB RID: 235
public class AN_PackageCheckResult : Result
{
	// Token: 0x060010D2 RID: 4306 RVA: 0x000521CC File Offset: 0x000503CC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PackageCheckResult()
	{
		Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PackageCheckResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr);
		AN_PackageCheckResult.NativeFieldInfoPtr__packageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr, "_packageName");
		AN_PackageCheckResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr, 100665372);
		AN_PackageCheckResult.NativeMethodInfoPtr__ctor_Public_Void_String_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr, 100665373);
		AN_PackageCheckResult.NativeMethodInfoPtr_get_packageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr, 100665374);
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x0005224C File Offset: 0x0005044C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40954, RefRangeEnd = 40956, XrefRangeStart = 40954, XrefRangeEnd = 40956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PackageCheckResult(string packId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PackageCheckResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00052298 File Offset: 0x00050498
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181440, RefRangeEnd = 181441, XrefRangeStart = 181439, XrefRangeEnd = 181440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PackageCheckResult(string packId, Error error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PackageCheckResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PackageCheckResult.NativeMethodInfoPtr__ctor_Public_Void_String_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000522F8 File Offset: 0x000504F8
	public unsafe string packageName
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PackageCheckResult.NativeMethodInfoPtr_get_packageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x000085F2 File Offset: 0x000067F2
	public AN_PackageCheckResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00052330 File Offset: 0x00050530
	// (set) Token: 0x060010D8 RID: 4312 RVA: 0x000085FB File Offset: 0x000067FB
	public unsafe string _packageName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PackageCheckResult.NativeFieldInfoPtr__packageName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_PackageCheckResult.NativeFieldInfoPtr__packageName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D2C RID: 3372
	private static readonly IntPtr NativeFieldInfoPtr__packageName;

	// Token: 0x04000D2D RID: 3373
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D2E RID: 3374
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Error_0;

	// Token: 0x04000D2F RID: 3375
	private static readonly IntPtr NativeMethodInfoPtr_get_packageName_Public_get_String_0;
}
