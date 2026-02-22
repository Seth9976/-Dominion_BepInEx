using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000081 RID: 129
public class AndroidMessage : BaseAndroidPopup
{
	// Token: 0x0600092F RID: 2351 RVA: 0x00036758 File Offset: 0x00034958
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidMessage()
	{
		Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr);
		AndroidMessage.NativeFieldInfoPtr_ok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, "ok");
		AndroidMessage.NativeFieldInfoPtr_OnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, "OnComplete");
		AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664400);
		AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664401);
		AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664402);
		AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664403);
		AndroidMessage.NativeMethodInfoPtr_init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664404);
		AndroidMessage.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664405);
		AndroidMessage.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664406);
		AndroidMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, 100664407);
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00036850 File Offset: 0x00034A50
	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 170987, RefRangeEnd = 171015, XrefRangeStart = 170971, XrefRangeEnd = 170987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidMessage Create(string title, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidMessage>(intPtr3) : null;
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x000368A8 File Offset: 0x00034AA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171015, XrefRangeEnd = 171027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidMessage Create(string title, string message, AndroidDialogTheme theme)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidMessage>(intPtr3) : null;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x0003690C File Offset: 0x00034B0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171027, XrefRangeEnd = 171041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidMessage Create(string title, string message, string ok)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ok);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidMessage>(intPtr3) : null;
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00036974 File Offset: 0x00034B74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171041, XrefRangeEnd = 171051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidMessage Create(string title, string message, string ok, AndroidDialogTheme theme)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ok);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidMessage>(intPtr3) : null;
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x000369EC File Offset: 0x00034BEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171051, XrefRangeEnd = 171056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00036A20 File Offset: 0x00034C20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171056, XrefRangeEnd = 171057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(AndroidDialogTheme theme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref theme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00036A60 File Offset: 0x00034C60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171057, XrefRangeEnd = 171066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPopUpCallBack(string buttonIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00036AA4 File Offset: 0x00034CA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171066, XrefRangeEnd = 171081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidMessage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00005B19 File Offset: 0x00003D19
	public AndroidMessage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002EF RID: 751
	// (get) Token: 0x06000939 RID: 2361 RVA: 0x00036AE0 File Offset: 0x00034CE0
	// (set) Token: 0x0600093A RID: 2362 RVA: 0x00005B22 File Offset: 0x00003D22
	public unsafe string ok
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidMessage.NativeFieldInfoPtr_ok);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidMessage.NativeFieldInfoPtr_ok), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F0 RID: 752
	// (get) Token: 0x0600093B RID: 2363 RVA: 0x00036B08 File Offset: 0x00034D08
	// (set) Token: 0x0600093C RID: 2364 RVA: 0x00005B41 File Offset: 0x00003D41
	public unsafe Action OnComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidMessage.NativeFieldInfoPtr_OnComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidMessage.NativeFieldInfoPtr_OnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000762 RID: 1890
	private static readonly IntPtr NativeFieldInfoPtr_ok;

	// Token: 0x04000763 RID: 1891
	private static readonly IntPtr NativeFieldInfoPtr_OnComplete;

	// Token: 0x04000764 RID: 1892
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_0;

	// Token: 0x04000765 RID: 1893
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_AndroidDialogTheme_0;

	// Token: 0x04000766 RID: 1894
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_0;

	// Token: 0x04000767 RID: 1895
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidMessage_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000768 RID: 1896
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_0;

	// Token: 0x04000769 RID: 1897
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0;

	// Token: 0x0400076A RID: 1898
	private static readonly IntPtr NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0;

	// Token: 0x0400076B RID: 1899
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000379 RID: 889
	[ObfuscatedName("AndroidMessage+<>c")]
	[Serializable]
	public new sealed class __c : Object
	{
		// Token: 0x0600352D RID: 13613 RVA: 0x000DB914 File Offset: 0x000D9B14
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidMessage>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr);
			AndroidMessage.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr, "<>9");
			AndroidMessage.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr, "<>9__9_0");
			AndroidMessage.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr, 100670084);
			AndroidMessage.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr, 100670085);
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x000DB990 File Offset: 0x000D9B90
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidMessage.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x000DB9CC File Offset: 0x000D9BCC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidMessage.__c.NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00014A33 File Offset: 0x00012C33
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06003531 RID: 13617 RVA: 0x000DBA00 File Offset: 0x000D9C00
		// (set) Token: 0x06003532 RID: 13618 RVA: 0x00014A3C File Offset: 0x00012C3C
		public unsafe static AndroidMessage.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidMessage.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidMessage.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidMessage.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x000DBA28 File Offset: 0x000D9C28
		// (set) Token: 0x06003534 RID: 13620 RVA: 0x00014A4E File Offset: 0x00012C4E
		public unsafe static Action __9__9_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidMessage.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidMessage.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__9_0_Internal_Void_0;
	}
}
