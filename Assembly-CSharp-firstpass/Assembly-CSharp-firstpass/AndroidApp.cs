using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x020000DF RID: 223
public class AndroidApp : Singleton<AndroidApp>
{
	// Token: 0x06000FFF RID: 4095 RVA: 0x0004F978 File Offset: 0x0004DB78
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidApp()
	{
		Il2CppClassPointerStore<AndroidApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidApp");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr);
		AndroidApp.NativeFieldInfoPtr_OnActivityResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, "OnActivityResult");
		AndroidApp.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, 100665296);
		AndroidApp.NativeMethodInfoPtr_ActivateListner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, 100665297);
		AndroidApp.NativeMethodInfoPtr_onActivityResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, 100665298);
		AndroidApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, 100665299);
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0004FA0C File Offset: 0x0004DC0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181095, XrefRangeEnd = 181106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0004FA40 File Offset: 0x0004DC40
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateListner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.NativeMethodInfoPtr_ActivateListner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0004FA74 File Offset: 0x0004DC74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181106, XrefRangeEnd = 181132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onActivityResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.NativeMethodInfoPtr_onActivityResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181132, XrefRangeEnd = 181154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidApp()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00007F8C File Offset: 0x0000618C
	public AndroidApp(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004A4 RID: 1188
	// (get) Token: 0x06001005 RID: 4101 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
	// (set) Token: 0x06001006 RID: 4102 RVA: 0x00007F95 File Offset: 0x00006195
	public unsafe Action<AndroidActivityResult> OnActivityResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidApp.NativeFieldInfoPtr_OnActivityResult);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidActivityResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidApp.NativeFieldInfoPtr_OnActivityResult), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CA9 RID: 3241
	private static readonly IntPtr NativeFieldInfoPtr_OnActivityResult;

	// Token: 0x04000CAA RID: 3242
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CAB RID: 3243
	private static readonly IntPtr NativeMethodInfoPtr_ActivateListner_Public_Void_0;

	// Token: 0x04000CAC RID: 3244
	private static readonly IntPtr NativeMethodInfoPtr_onActivityResult_Private_Void_String_0;

	// Token: 0x04000CAD RID: 3245
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000396 RID: 918
	[ObfuscatedName("AndroidApp+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003680 RID: 13952 RVA: 0x000DF90C File Offset: 0x000DDB0C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidApp>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr);
			AndroidApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr, "<>9");
			AndroidApp.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr, "<>9__4_0");
			AndroidApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr, 100670230);
			AndroidApp.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr, 100670231);
		}

		// Token: 0x06003681 RID: 13953 RVA: 0x000DF988 File Offset: 0x000DDB88
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidApp.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003682 RID: 13954 RVA: 0x000DF9C4 File Offset: 0x000DDBC4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__4_0(AndroidActivityResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidApp.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003683 RID: 13955 RVA: 0x0001522A File Offset: 0x0001342A
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x000DFA08 File Offset: 0x000DDC08
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x00015233 File Offset: 0x00013433
		public unsafe static AndroidApp.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidApp.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06003686 RID: 13958 RVA: 0x000DFA30 File Offset: 0x000DDC30
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x00015245 File Offset: 0x00013445
		public unsafe static Action<AndroidActivityResult> __9__4_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidApp.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidActivityResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidApp.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_Void_AndroidActivityResult_0;
	}
}
