using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x020000F7 RID: 247
public class AndroidVideoPickResult : AndroidActivityResult
{
	// Token: 0x0600114A RID: 4426 RVA: 0x000536E8 File Offset: 0x000518E8
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidVideoPickResult()
	{
		Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidVideoPickResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr);
		AndroidVideoPickResult.NativeFieldInfoPtr_m_videoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr, "m_videoPath");
		AndroidVideoPickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr, 100665404);
		AndroidVideoPickResult.NativeMethodInfoPtr_get_VideoPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr, 100665405);
		AndroidVideoPickResult.NativeMethodInfoPtr_set_VideoPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr, 100665406);
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00053768 File Offset: 0x00051968
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181572, RefRangeEnd = 181573, XrefRangeStart = 181566, XrefRangeEnd = 181572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidVideoPickResult(string resultCode, string videoData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidVideoPickResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resultCode);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(videoData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidVideoPickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000525 RID: 1317
	// (get) Token: 0x0600114C RID: 4428 RVA: 0x000537C8 File Offset: 0x000519C8
	// (set) Token: 0x0600114D RID: 4429 RVA: 0x00053800 File Offset: 0x00051A00
	public unsafe string VideoPath
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidVideoPickResult.NativeMethodInfoPtr_get_VideoPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidVideoPickResult.NativeMethodInfoPtr_set_VideoPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00008A36 File Offset: 0x00006C36
	public AndroidVideoPickResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000524 RID: 1316
	// (get) Token: 0x0600114F RID: 4431 RVA: 0x00053844 File Offset: 0x00051A44
	// (set) Token: 0x06001150 RID: 4432 RVA: 0x00008A3F File Offset: 0x00006C3F
	public unsafe string m_videoPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidVideoPickResult.NativeFieldInfoPtr_m_videoPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidVideoPickResult.NativeFieldInfoPtr_m_videoPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D6C RID: 3436
	private static readonly IntPtr NativeFieldInfoPtr_m_videoPath;

	// Token: 0x04000D6D RID: 3437
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x04000D6E RID: 3438
	private static readonly IntPtr NativeMethodInfoPtr_get_VideoPath_Public_get_String_0;

	// Token: 0x04000D6F RID: 3439
	private static readonly IntPtr NativeMethodInfoPtr_set_VideoPath_Public_set_Void_String_0;
}
