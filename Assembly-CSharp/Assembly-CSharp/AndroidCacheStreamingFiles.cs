using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x0200006D RID: 109
public class AndroidCacheStreamingFiles : MonoBehaviour
{
	// Token: 0x06000E3D RID: 3645 RVA: 0x000435E4 File Offset: 0x000417E4
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidCacheStreamingFiles()
	{
		Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AndroidCacheStreamingFiles");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr);
		AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_LaunchScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "m_LaunchScene");
		AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_ReplaceExistingFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "m_ReplaceExistingFiles");
		AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_FilenameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "m_FilenameList");
		AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bCopying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "m_bCopying");
		AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "m_bLoading");
		AndroidCacheStreamingFiles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664289);
		AndroidCacheStreamingFiles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664290);
		AndroidCacheStreamingFiles.NativeMethodInfoPtr_StartApp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664291);
		AndroidCacheStreamingFiles.NativeMethodInfoPtr_CopyStreamingFiles_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664292);
		AndroidCacheStreamingFiles.NativeMethodInfoPtr_CopyStreamingAssetFromBundle_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664293);
		AndroidCacheStreamingFiles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, 100664294);
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x000436F0 File Offset: 0x000418F0
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00043724 File Offset: 0x00041924
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239157, XrefRangeEnd = 239168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00043758 File Offset: 0x00041958
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239173, RefRangeEnd = 239174, XrefRangeStart = 239168, XrefRangeEnd = 239173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr_StartApp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x0004378C File Offset: 0x0004198C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239174, XrefRangeEnd = 239178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CopyStreamingFiles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr_CopyStreamingFiles_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x000437CC File Offset: 0x000419CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239178, XrefRangeEnd = 239182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CopyStreamingAssetFromBundle(string assetPath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr_CopyStreamingAssetFromBundle_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x0004381C File Offset: 0x00041A1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239182, XrefRangeEnd = 239183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidCacheStreamingFiles()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x0000A4CC File Offset: 0x000086CC
	public AndroidCacheStreamingFiles(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004D3 RID: 1235
	// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00043858 File Offset: 0x00041A58
	// (set) Token: 0x06000E46 RID: 3654 RVA: 0x0000A4D5 File Offset: 0x000086D5
	public unsafe string m_LaunchScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_LaunchScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_LaunchScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00043880 File Offset: 0x00041A80
	// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0000A4F4 File Offset: 0x000086F4
	public unsafe bool m_ReplaceExistingFiles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_ReplaceExistingFiles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_ReplaceExistingFiles)) = value;
		}
	}

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000438A8 File Offset: 0x00041AA8
	// (set) Token: 0x06000E4A RID: 3658 RVA: 0x0000A50F File Offset: 0x0000870F
	public unsafe Il2CppStringArray m_FilenameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_FilenameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_FilenameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000438D8 File Offset: 0x00041AD8
	// (set) Token: 0x06000E4C RID: 3660 RVA: 0x0000A52E File Offset: 0x0000872E
	public unsafe bool m_bCopying
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bCopying);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bCopying)) = value;
		}
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00043900 File Offset: 0x00041B00
	// (set) Token: 0x06000E4E RID: 3662 RVA: 0x0000A549 File Offset: 0x00008749
	public unsafe bool m_bLoading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bLoading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles.NativeFieldInfoPtr_m_bLoading)) = value;
		}
	}

	// Token: 0x040009BE RID: 2494
	private static readonly IntPtr NativeFieldInfoPtr_m_LaunchScene;

	// Token: 0x040009BF RID: 2495
	private static readonly IntPtr NativeFieldInfoPtr_m_ReplaceExistingFiles;

	// Token: 0x040009C0 RID: 2496
	private static readonly IntPtr NativeFieldInfoPtr_m_FilenameList;

	// Token: 0x040009C1 RID: 2497
	private static readonly IntPtr NativeFieldInfoPtr_m_bCopying;

	// Token: 0x040009C2 RID: 2498
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoading;

	// Token: 0x040009C3 RID: 2499
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040009C4 RID: 2500
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040009C5 RID: 2501
	private static readonly IntPtr NativeMethodInfoPtr_StartApp_Private_Void_0;

	// Token: 0x040009C6 RID: 2502
	private static readonly IntPtr NativeMethodInfoPtr_CopyStreamingFiles_Private_IEnumerator_0;

	// Token: 0x040009C7 RID: 2503
	private static readonly IntPtr NativeMethodInfoPtr_CopyStreamingAssetFromBundle_Private_IEnumerator_String_0;

	// Token: 0x040009C8 RID: 2504
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000188 RID: 392
	[ObfuscatedName("AndroidCacheStreamingFiles+<CopyStreamingFiles>d__8")]
	public sealed class _CopyStreamingFiles_d__8 : global::Il2CppSystem.Object
	{
		// Token: 0x06002408 RID: 9224 RVA: 0x000865D4 File Offset: 0x000847D4
		// Note: this type is marked as 'beforefieldinit'.
		static _CopyStreamingFiles_d__8()
		{
			Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "<CopyStreamingFiles>d__8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, "<>1__state");
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, "<>2__current");
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, "<>4__this");
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, "<i>5__2");
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666160);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666161);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666162);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666163);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666164);
			AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr, 100666165);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x000866C8 File Offset: 0x000848C8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CopyStreamingFiles_d__8(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingFiles_d__8>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00086710 File Offset: 0x00084910
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00086744 File Offset: 0x00084944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239083, XrefRangeEnd = 239085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x00086780 File Offset: 0x00084980
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000867C0 File Offset: 0x000849C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239085, XrefRangeEnd = 239090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x000867F4 File Offset: 0x000849F4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0001673C File Offset: 0x0001493C
		public _CopyStreamingFiles_d__8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x00086834 File Offset: 0x00084A34
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x00016745 File Offset: 0x00014945
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x0008685C File Offset: 0x00084A5C
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x00016760 File Offset: 0x00014960
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002414 RID: 9236 RVA: 0x0008688C File Offset: 0x00084A8C
		// (set) Token: 0x06002415 RID: 9237 RVA: 0x0001677F File Offset: 0x0001497F
		public unsafe AndroidCacheStreamingFiles __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidCacheStreamingFiles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x000868BC File Offset: 0x00084ABC
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x0001679E File Offset: 0x0001499E
		public unsafe int _i_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr__i_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingFiles_d__8.NativeFieldInfoPtr__i_5__2)) = value;
			}
		}

		// Token: 0x04001902 RID: 6402
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001903 RID: 6403
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001904 RID: 6404
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001905 RID: 6405
		private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

		// Token: 0x04001906 RID: 6406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000189 RID: 393
	[ObfuscatedName("AndroidCacheStreamingFiles+<CopyStreamingAssetFromBundle>d__9")]
	public sealed class _CopyStreamingAssetFromBundle_d__9 : global::Il2CppSystem.Object
	{
		// Token: 0x06002418 RID: 9240 RVA: 0x000868E4 File Offset: 0x00084AE4
		// Note: this type is marked as 'beforefieldinit'.
		static _CopyStreamingAssetFromBundle_d__9()
		{
			Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidCacheStreamingFiles>.NativeClassPtr, "<CopyStreamingAssetFromBundle>d__9");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<>1__state");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<>2__current");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr_assetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "assetPath");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<>4__this");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_file_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<target_streaming_file>5__2");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_directory_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<target_streaming_directory>5__3");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__uwr_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, "<uwr>5__4");
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666166);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666167);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666168);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666169);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666170);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666171);
			AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr, 100666172);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00086A28 File Offset: 0x00084C28
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CopyStreamingAssetFromBundle_d__9(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00086A70 File Offset: 0x00084C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239094, RefRangeEnd = 239095, XrefRangeStart = 239090, XrefRangeEnd = 239094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00086AA4 File Offset: 0x00084CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239095, XrefRangeEnd = 239149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00086AE0 File Offset: 0x00084CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239149, XrefRangeEnd = 239152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x00086B14 File Offset: 0x00084D14
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00086B54 File Offset: 0x00084D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239152, XrefRangeEnd = 239157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x00086B88 File Offset: 0x00084D88
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000167B9 File Offset: 0x000149B9
		public _CopyStreamingAssetFromBundle_d__9(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x00086BC8 File Offset: 0x00084DC8
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x000167C2 File Offset: 0x000149C2
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x00086BF0 File Offset: 0x00084DF0
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x000167DD File Offset: 0x000149DD
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x00086C20 File Offset: 0x00084E20
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x000167FC File Offset: 0x000149FC
		public unsafe string assetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr_assetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr_assetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x00086C48 File Offset: 0x00084E48
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0001681B File Offset: 0x00014A1B
		public unsafe AndroidCacheStreamingFiles __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidCacheStreamingFiles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x00086C78 File Offset: 0x00084E78
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0001683A File Offset: 0x00014A3A
		public unsafe string _target_streaming_file_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_file_5__2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_file_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x00086CA0 File Offset: 0x00084EA0
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x00016859 File Offset: 0x00014A59
		public unsafe string _target_streaming_directory_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_directory_5__3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__target_streaming_directory_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x00086CC8 File Offset: 0x00084EC8
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00016878 File Offset: 0x00014A78
		public unsafe UnityWebRequest _uwr_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__uwr_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCacheStreamingFiles._CopyStreamingAssetFromBundle_d__9.NativeFieldInfoPtr__uwr_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_assetPath;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr__target_streaming_file_5__2;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr__target_streaming_directory_5__3;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeFieldInfoPtr__uwr_5__4;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
