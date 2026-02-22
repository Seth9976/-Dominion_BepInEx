using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200009C RID: 156
public class FB_LikesRetrieveTask : MonoBehaviour
{
	// Token: 0x06000B51 RID: 2897 RVA: 0x0003EB7C File Offset: 0x0003CD7C
	// Note: this type is marked as 'beforefieldinit'.
	static FB_LikesRetrieveTask()
	{
		Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_LikesRetrieveTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr);
		FB_LikesRetrieveTask.NativeFieldInfoPtr__userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, "_userId");
		FB_LikesRetrieveTask.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, "ActionComplete");
		FB_LikesRetrieveTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664667);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664668);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_Create_Public_Static_FB_LikesRetrieveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664669);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_LoadLikes_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664670);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664671);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_get_userId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664672);
		FB_LikesRetrieveTask.NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664673);
		FB_LikesRetrieveTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, 100664674);
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x0003EC74 File Offset: 0x0003CE74
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 174257, RefRangeEnd = 174260, XrefRangeStart = 174253, XrefRangeEnd = 174257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action<FB_Result, FB_LikesRetrieveTask> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0003ECB8 File Offset: 0x0003CEB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174260, XrefRangeEnd = 174264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action<FB_Result, FB_LikesRetrieveTask> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0003ECFC File Offset: 0x0003CEFC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 174274, RefRangeEnd = 174277, XrefRangeStart = 174264, XrefRangeEnd = 174274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FB_LikesRetrieveTask Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_Create_Public_Static_FB_LikesRetrieveTask_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_LikesRetrieveTask>(intPtr3) : null;
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x0003ED30 File Offset: 0x0003CF30
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174298, RefRangeEnd = 174300, XrefRangeStart = 174277, XrefRangeEnd = 174298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLikes(string userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_LoadLikes_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x0003ED74 File Offset: 0x0003CF74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174321, RefRangeEnd = 174322, XrefRangeStart = 174300, XrefRangeEnd = 174321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLikes(string userId, string pageId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0003EDC8 File Offset: 0x0003CFC8
	public unsafe string userId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_get_userId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x0003EE00 File Offset: 0x0003D000
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174322, XrefRangeEnd = 174331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserLikesResult(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x0003EE44 File Offset: 0x0003D044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174331, XrefRangeEnd = 174348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_LikesRetrieveTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00006817 File Offset: 0x00004A17
	public FB_LikesRetrieveTask(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0003EE80 File Offset: 0x0003D080
	// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00006820 File Offset: 0x00004A20
	public unsafe string _userId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikesRetrieveTask.NativeFieldInfoPtr__userId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikesRetrieveTask.NativeFieldInfoPtr__userId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
	// (set) Token: 0x06000B5E RID: 2910 RVA: 0x0000683F File Offset: 0x00004A3F
	public unsafe Action<FB_Result, FB_LikesRetrieveTask> ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikesRetrieveTask.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result, FB_LikesRetrieveTask>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikesRetrieveTask.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040008F8 RID: 2296
	private static readonly IntPtr NativeFieldInfoPtr__userId;

	// Token: 0x040008F9 RID: 2297
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x040008FA RID: 2298
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0;

	// Token: 0x040008FB RID: 2299
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_2_FB_Result_FB_LikesRetrieveTask_0;

	// Token: 0x040008FC RID: 2300
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_FB_LikesRetrieveTask_0;

	// Token: 0x040008FD RID: 2301
	private static readonly IntPtr NativeMethodInfoPtr_LoadLikes_Public_Void_String_0;

	// Token: 0x040008FE RID: 2302
	private static readonly IntPtr NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0;

	// Token: 0x040008FF RID: 2303
	private static readonly IntPtr NativeMethodInfoPtr_get_userId_Public_get_String_0;

	// Token: 0x04000900 RID: 2304
	private static readonly IntPtr NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_0;

	// Token: 0x04000901 RID: 2305
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000380 RID: 896
	[ObfuscatedName("FB_LikesRetrieveTask+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003579 RID: 13689 RVA: 0x000DC8C8 File Offset: 0x000DAAC8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FB_LikesRetrieveTask>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr);
			FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr, "<>9");
			FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr, "<>9__10_0");
			FB_LikesRetrieveTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr, 100670125);
			FB_LikesRetrieveTask.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_FB_Result_FB_LikesRetrieveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr, 100670126);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x000DC944 File Offset: 0x000DAB44
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_LikesRetrieveTask.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x000DC980 File Offset: 0x000DAB80
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(FB_Result <p0>, FB_LikesRetrieveTask <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikesRetrieveTask.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_FB_Result_FB_LikesRetrieveTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00014B71 File Offset: 0x00012D71
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x000DC9D4 File Offset: 0x000DABD4
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x00014B7A File Offset: 0x00012D7A
		public unsafe static FB_LikesRetrieveTask.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_LikesRetrieveTask.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x000DC9FC File Offset: 0x000DABFC
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x00014B8C File Offset: 0x00012D8C
		public unsafe static Action<FB_Result, FB_LikesRetrieveTask> __9__10_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result, FB_LikesRetrieveTask>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_LikesRetrieveTask.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_FB_Result_FB_LikesRetrieveTask_0;
	}
}
