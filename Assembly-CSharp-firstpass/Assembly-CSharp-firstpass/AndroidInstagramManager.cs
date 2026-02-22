using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class AndroidInstagramManager : Singleton<AndroidInstagramManager>
{
	// Token: 0x06000B7F RID: 2943 RVA: 0x0003F434 File Offset: 0x0003D634
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidInstagramManager()
	{
		Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidInstagramManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr);
		AndroidInstagramManager.NativeFieldInfoPtr_OnPostingCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, "OnPostingCompleteAction");
		AndroidInstagramManager.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_InstagramPostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664681);
		AndroidInstagramManager.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_InstagramPostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664682);
		AndroidInstagramManager.NativeMethodInfoPtr_Share_Public_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664683);
		AndroidInstagramManager.NativeMethodInfoPtr_Share_Public_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664684);
		AndroidInstagramManager.NativeMethodInfoPtr_OnPostSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664685);
		AndroidInstagramManager.NativeMethodInfoPtr_OnPostFailed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664686);
		AndroidInstagramManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, 100664687);
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x0003F504 File Offset: 0x0003D704
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174476, XrefRangeEnd = 174487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPostingCompleteAction(Action<InstagramPostResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_InstagramPostResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0003F53C File Offset: 0x0003D73C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174487, XrefRangeEnd = 174498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPostingCompleteAction(Action<InstagramPostResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_InstagramPostResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x0003F574 File Offset: 0x0003D774
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174498, XrefRangeEnd = 174506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Share(Texture2D texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_Share_Public_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174506, XrefRangeEnd = 174526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Share(Texture2D texture, string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_Share_Public_Void_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x0003F60C File Offset: 0x0003D80C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174526, XrefRangeEnd = 174534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_OnPostSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x0003F640 File Offset: 0x0003D840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174534, XrefRangeEnd = 174546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostFailed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr_OnPostFailed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x0003F684 File Offset: 0x0003D884
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174546, XrefRangeEnd = 174552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidInstagramManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x000069AB File Offset: 0x00004BAB
	public AndroidInstagramManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0003F6C0 File Offset: 0x0003D8C0
	// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000069B4 File Offset: 0x00004BB4
	public unsafe static Action<InstagramPostResult> OnPostingCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidInstagramManager.NativeFieldInfoPtr_OnPostingCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InstagramPostResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidInstagramManager.NativeFieldInfoPtr_OnPostingCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000919 RID: 2329
	private static readonly IntPtr NativeFieldInfoPtr_OnPostingCompleteAction;

	// Token: 0x0400091A RID: 2330
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_InstagramPostResult_0;

	// Token: 0x0400091B RID: 2331
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_InstagramPostResult_0;

	// Token: 0x0400091C RID: 2332
	private static readonly IntPtr NativeMethodInfoPtr_Share_Public_Void_Texture2D_0;

	// Token: 0x0400091D RID: 2333
	private static readonly IntPtr NativeMethodInfoPtr_Share_Public_Void_Texture2D_String_0;

	// Token: 0x0400091E RID: 2334
	private static readonly IntPtr NativeMethodInfoPtr_OnPostSuccess_Private_Void_0;

	// Token: 0x0400091F RID: 2335
	private static readonly IntPtr NativeMethodInfoPtr_OnPostFailed_Private_Void_String_0;

	// Token: 0x04000920 RID: 2336
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000381 RID: 897
	[ObfuscatedName("AndroidInstagramManager+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003581 RID: 13697 RVA: 0x000DCA24 File Offset: 0x000DAC24
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidInstagramManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr);
			AndroidInstagramManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr, "<>9");
			AndroidInstagramManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr, 100670128);
			AndroidInstagramManager.__c.NativeMethodInfoPtr___cctor_b__8_0_Internal_Void_InstagramPostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr, 100670129);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x000DCA8C File Offset: 0x000DAC8C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidInstagramManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x000DCAC8 File Offset: 0x000DACC8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__8_0(InstagramPostResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInstagramManager.__c.NativeMethodInfoPtr___cctor_b__8_0_Internal_Void_InstagramPostResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00014B9E File Offset: 0x00012D9E
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x000DCB08 File Offset: 0x000DAD08
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x00014BA7 File Offset: 0x00012DA7
		public unsafe static AndroidInstagramManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidInstagramManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidInstagramManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidInstagramManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__8_0_Internal_Void_InstagramPostResult_0;
	}
}
