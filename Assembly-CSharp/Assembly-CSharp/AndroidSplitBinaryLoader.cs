using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x0200006E RID: 110
public class AndroidSplitBinaryLoader : MonoBehaviour
{
	// Token: 0x06000E4F RID: 3663 RVA: 0x00043928 File Offset: 0x00041B28
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidSplitBinaryLoader()
	{
		Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AndroidSplitBinaryLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr);
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_nextScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "nextScene");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "background");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_mySkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "mySkin");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_obbisok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "obbisok");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "loading");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_replacefiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "replacefiles");
		AndroidSplitBinaryLoader.NativeFieldInfoPtr_paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "paths");
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664295);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664296);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664297);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_StartApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664298);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_CheckSetUp_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664299);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr_PullStreamingAssetFromObb_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664300);
		AndroidSplitBinaryLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, 100664301);
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00043A70 File Offset: 0x00041C70
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00043AA4 File Offset: 0x00041CA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239204, XrefRangeEnd = 239224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00043AD8 File Offset: 0x00041CD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239224, XrefRangeEnd = 239263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00043B0C File Offset: 0x00041D0C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239267, RefRangeEnd = 239268, XrefRangeStart = 239263, XrefRangeEnd = 239267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_StartApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00043B40 File Offset: 0x00041D40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239268, XrefRangeEnd = 239272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckSetUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_CheckSetUp_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00043B80 File Offset: 0x00041D80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239272, XrefRangeEnd = 239276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PullStreamingAssetFromObb(string sapath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sapath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr_PullStreamingAssetFromObb_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00043BD0 File Offset: 0x00041DD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239276, XrefRangeEnd = 239563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidSplitBinaryLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0000A564 File Offset: 0x00008764
	public AndroidSplitBinaryLoader(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00043C0C File Offset: 0x00041E0C
	// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0000A56D File Offset: 0x0000876D
	public unsafe string nextScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_nextScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_nextScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00043C34 File Offset: 0x00041E34
	// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0000A58C File Offset: 0x0000878C
	public unsafe Texture2D background
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_background);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00043C64 File Offset: 0x00041E64
	// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0000A5AB File Offset: 0x000087AB
	public unsafe GUISkin mySkin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_mySkin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_mySkin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00043C94 File Offset: 0x00041E94
	// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0000A5CA File Offset: 0x000087CA
	public unsafe bool obbisok
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_obbisok);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_obbisok)) = value;
		}
	}

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00043CBC File Offset: 0x00041EBC
	// (set) Token: 0x06000E61 RID: 3681 RVA: 0x0000A5E5 File Offset: 0x000087E5
	public unsafe bool loading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_loading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_loading)) = value;
		}
	}

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00043CE4 File Offset: 0x00041EE4
	// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0000A600 File Offset: 0x00008800
	public unsafe bool replacefiles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_replacefiles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_replacefiles)) = value;
		}
	}

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00043D0C File Offset: 0x00041F0C
	// (set) Token: 0x06000E65 RID: 3685 RVA: 0x0000A61B File Offset: 0x0000881B
	public unsafe Il2CppStringArray paths
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_paths);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader.NativeFieldInfoPtr_paths), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009C9 RID: 2505
	private static readonly IntPtr NativeFieldInfoPtr_nextScene;

	// Token: 0x040009CA RID: 2506
	private static readonly IntPtr NativeFieldInfoPtr_background;

	// Token: 0x040009CB RID: 2507
	private static readonly IntPtr NativeFieldInfoPtr_mySkin;

	// Token: 0x040009CC RID: 2508
	private static readonly IntPtr NativeFieldInfoPtr_obbisok;

	// Token: 0x040009CD RID: 2509
	private static readonly IntPtr NativeFieldInfoPtr_loading;

	// Token: 0x040009CE RID: 2510
	private static readonly IntPtr NativeFieldInfoPtr_replacefiles;

	// Token: 0x040009CF RID: 2511
	private static readonly IntPtr NativeFieldInfoPtr_paths;

	// Token: 0x040009D0 RID: 2512
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040009D1 RID: 2513
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040009D2 RID: 2514
	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	// Token: 0x040009D3 RID: 2515
	private static readonly IntPtr NativeMethodInfoPtr_StartApp_Public_Void_0;

	// Token: 0x040009D4 RID: 2516
	private static readonly IntPtr NativeMethodInfoPtr_CheckSetUp_Public_IEnumerator_0;

	// Token: 0x040009D5 RID: 2517
	private static readonly IntPtr NativeMethodInfoPtr_PullStreamingAssetFromObb_Public_IEnumerator_String_0;

	// Token: 0x040009D6 RID: 2518
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018A RID: 394
	[ObfuscatedName("AndroidSplitBinaryLoader+<CheckSetUp>d__11")]
	public sealed class _CheckSetUp_d__11 : global::Il2CppSystem.Object
	{
		// Token: 0x0600242F RID: 9263 RVA: 0x00086CF8 File Offset: 0x00084EF8
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckSetUp_d__11()
		{
			Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "<CheckSetUp>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, "<>1__state");
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, "<>2__current");
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, "<>4__this");
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, "<i>5__2");
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666173);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666174);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666175);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666176);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666177);
			AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr, 100666178);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00086DEC File Offset: 0x00084FEC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckSetUp_d__11(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidSplitBinaryLoader._CheckSetUp_d__11>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00086E34 File Offset: 0x00085034
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00086E68 File Offset: 0x00085068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239183, XrefRangeEnd = 239185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x00086EA4 File Offset: 0x000850A4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00086EE4 File Offset: 0x000850E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239185, XrefRangeEnd = 239190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x00086F18 File Offset: 0x00085118
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00016897 File Offset: 0x00014A97
		public _CheckSetUp_d__11(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x00086F58 File Offset: 0x00085158
		// (set) Token: 0x06002438 RID: 9272 RVA: 0x000168A0 File Offset: 0x00014AA0
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06002439 RID: 9273 RVA: 0x00086F80 File Offset: 0x00085180
		// (set) Token: 0x0600243A RID: 9274 RVA: 0x000168BB File Offset: 0x00014ABB
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x0600243B RID: 9275 RVA: 0x00086FB0 File Offset: 0x000851B0
		// (set) Token: 0x0600243C RID: 9276 RVA: 0x000168DA File Offset: 0x00014ADA
		public unsafe AndroidSplitBinaryLoader __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidSplitBinaryLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x0600243D RID: 9277 RVA: 0x00086FE0 File Offset: 0x000851E0
		// (set) Token: 0x0600243E RID: 9278 RVA: 0x000168F9 File Offset: 0x00014AF9
		public unsafe int _i_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr__i_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._CheckSetUp_d__11.NativeFieldInfoPtr__i_5__2)) = value;
			}
		}

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200018B RID: 395
	[ObfuscatedName("AndroidSplitBinaryLoader+<PullStreamingAssetFromObb>d__12")]
	public sealed class _PullStreamingAssetFromObb_d__12 : global::Il2CppSystem.Object
	{
		// Token: 0x0600243F RID: 9279 RVA: 0x00087008 File Offset: 0x00085208
		// Note: this type is marked as 'beforefieldinit'.
		static _PullStreamingAssetFromObb_d__12()
		{
			Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidSplitBinaryLoader>.NativeClassPtr, "<PullStreamingAssetFromObb>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, "<>1__state");
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, "<>2__current");
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr_sapath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, "sapath");
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, "<>4__this");
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr__unpackerWWW_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, "<unpackerWWW>5__2");
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666179);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666180);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666181);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666182);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666183);
			AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr, 100666184);
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00087110 File Offset: 0x00085310
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PullStreamingAssetFromObb_d__12(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00087158 File Offset: 0x00085358
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0008718C File Offset: 0x0008538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239190, XrefRangeEnd = 239199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000871C8 File Offset: 0x000853C8
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00087208 File Offset: 0x00085408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239199, XrefRangeEnd = 239204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0008723C File Offset: 0x0008543C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00016914 File Offset: 0x00014B14
		public _PullStreamingAssetFromObb_d__12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0008727C File Offset: 0x0008547C
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x0001691D File Offset: 0x00014B1D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000872A4 File Offset: 0x000854A4
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x00016938 File Offset: 0x00014B38
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000872D4 File Offset: 0x000854D4
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x00016957 File Offset: 0x00014B57
		public unsafe string sapath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr_sapath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr_sapath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000872FC File Offset: 0x000854FC
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x00016976 File Offset: 0x00014B76
		public unsafe AndroidSplitBinaryLoader __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidSplitBinaryLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x0008732C File Offset: 0x0008552C
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x00016995 File Offset: 0x00014B95
		public unsafe WWW _unpackerWWW_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr__unpackerWWW_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidSplitBinaryLoader._PullStreamingAssetFromObb_d__12.NativeFieldInfoPtr__unpackerWWW_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeFieldInfoPtr_sapath;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr__unpackerWWW_5__2;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
