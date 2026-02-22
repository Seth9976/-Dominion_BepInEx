using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000E5 RID: 229
public class AndroidToast : Object
{
	// Token: 0x06001088 RID: 4232 RVA: 0x00051328 File Offset: 0x0004F528
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidToast()
	{
		Il2CppClassPointerStore<AndroidToast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidToast");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr);
		AndroidToast.NativeFieldInfoPtr_LENGTH_SHORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr, "LENGTH_SHORT");
		AndroidToast.NativeFieldInfoPtr_LENGTH_LONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr, "LENGTH_LONG");
		AndroidToast.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr, 100665343);
		AndroidToast.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr, 100665344);
		AndroidToast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr, 100665345);
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x000513BC File Offset: 0x0004F5BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181310, XrefRangeEnd = 181311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowToastNotification(string text)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidToast.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x000513F4 File Offset: 0x0004F5F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181312, RefRangeEnd = 181313, XrefRangeStart = 181311, XrefRangeEnd = 181312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowToastNotification(string text, int duration)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidToast.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00051438 File Offset: 0x0004F638
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidToast()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidToast>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidToast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x000083FD File Offset: 0x000065FD
	public AndroidToast(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x0600108D RID: 4237 RVA: 0x00051474 File Offset: 0x0004F674
	// (set) Token: 0x0600108E RID: 4238 RVA: 0x00008406 File Offset: 0x00006606
	public unsafe static int LENGTH_SHORT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AndroidToast.NativeFieldInfoPtr_LENGTH_SHORT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidToast.NativeFieldInfoPtr_LENGTH_SHORT, (void*)(&value));
		}
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x0600108F RID: 4239 RVA: 0x00051490 File Offset: 0x0004F690
	// (set) Token: 0x06001090 RID: 4240 RVA: 0x00008414 File Offset: 0x00006614
	public unsafe static int LENGTH_LONG
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AndroidToast.NativeFieldInfoPtr_LENGTH_LONG, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidToast.NativeFieldInfoPtr_LENGTH_LONG, (void*)(&value));
		}
	}

	// Token: 0x04000CFF RID: 3327
	private static readonly IntPtr NativeFieldInfoPtr_LENGTH_SHORT;

	// Token: 0x04000D00 RID: 3328
	private static readonly IntPtr NativeFieldInfoPtr_LENGTH_LONG;

	// Token: 0x04000D01 RID: 3329
	private static readonly IntPtr NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_0;

	// Token: 0x04000D02 RID: 3330
	private static readonly IntPtr NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0;

	// Token: 0x04000D03 RID: 3331
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
