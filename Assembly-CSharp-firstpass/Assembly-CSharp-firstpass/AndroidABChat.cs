using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000F1 RID: 241
public class AndroidABChat : Object
{
	// Token: 0x06001112 RID: 4370 RVA: 0x00052E14 File Offset: 0x00051014
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidABChat()
	{
		Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidABChat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr);
		AndroidABChat.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr, "name");
		AndroidABChat.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr, "type");
		AndroidABChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr, 100665394);
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00052E80 File Offset: 0x00051080
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidABChat()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidABChat>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidABChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x000087F1 File Offset: 0x000069F1
	public AndroidABChat(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06001115 RID: 4373 RVA: 0x00052EBC File Offset: 0x000510BC
	// (set) Token: 0x06001116 RID: 4374 RVA: 0x000087FA File Offset: 0x000069FA
	public unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABChat.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABChat.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06001117 RID: 4375 RVA: 0x00052EE4 File Offset: 0x000510E4
	// (set) Token: 0x06001118 RID: 4376 RVA: 0x00008819 File Offset: 0x00006A19
	public unsafe string type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABChat.NativeFieldInfoPtr_type);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABChat.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D51 RID: 3409
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x04000D52 RID: 3410
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x04000D53 RID: 3411
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
