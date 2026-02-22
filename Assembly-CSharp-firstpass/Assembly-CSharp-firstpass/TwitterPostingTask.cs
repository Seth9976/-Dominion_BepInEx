using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000AD RID: 173
public class TwitterPostingTask : AsyncTask
{
	// Token: 0x06000CA1 RID: 3233 RVA: 0x00043048 File Offset: 0x00041248
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterPostingTask()
	{
		Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterPostingTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr);
		TwitterPostingTask.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, "_status");
		TwitterPostingTask.NativeFieldInfoPtr__texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, "_texture");
		TwitterPostingTask.NativeFieldInfoPtr__controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, "_controller");
		TwitterPostingTask.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, "ActionComplete");
		TwitterPostingTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664805);
		TwitterPostingTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664806);
		TwitterPostingTask.NativeMethodInfoPtr_Cretae_Public_Static_TwitterPostingTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664807);
		TwitterPostingTask.NativeMethodInfoPtr_Post_Public_Void_String_Texture2D_TwitterManagerInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664808);
		TwitterPostingTask.NativeMethodInfoPtr_OnTWInited_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664809);
		TwitterPostingTask.NativeMethodInfoPtr_OnTWAuth_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664810);
		TwitterPostingTask.NativeMethodInfoPtr_OnPost_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664811);
		TwitterPostingTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, 100664812);
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x00043168 File Offset: 0x00041368
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175575, XrefRangeEnd = 175579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x000431AC File Offset: 0x000413AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175579, XrefRangeEnd = 175583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x000431F0 File Offset: 0x000413F0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 175593, RefRangeEnd = 175595, XrefRangeStart = 175583, XrefRangeEnd = 175593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TwitterPostingTask Cretae()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_Cretae_Public_Static_TwitterPostingTask_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask>(intPtr3) : null;
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00043224 File Offset: 0x00041424
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 175610, RefRangeEnd = 175612, XrefRangeStart = 175595, XrefRangeEnd = 175610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Post(string status, Texture2D texture, TwitterManagerInterface controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_Post_Public_Void_String_Texture2D_TwitterManagerInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x0004328C File Offset: 0x0004148C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175612, XrefRangeEnd = 175643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTWInited(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_OnTWInited_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000432D0 File Offset: 0x000414D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175665, RefRangeEnd = 175666, XrefRangeStart = 175643, XrefRangeEnd = 175665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTWAuth(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_OnTWAuth_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00043314 File Offset: 0x00041514
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175666, XrefRangeEnd = 175681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPost(TWResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr_OnPost_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x00043358 File Offset: 0x00041558
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175681, XrefRangeEnd = 175699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterPostingTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x000071E8 File Offset: 0x000053E8
	public TwitterPostingTask(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00043394 File Offset: 0x00041594
	// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000071F1 File Offset: 0x000053F1
	public unsafe string _status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__status);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__status), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000433BC File Offset: 0x000415BC
	// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00007210 File Offset: 0x00005410
	public unsafe Texture2D _texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000433EC File Offset: 0x000415EC
	// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x0000722F File Offset: 0x0000542F
	public unsafe TwitterManagerInterface _controller
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__controller);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterManagerInterface>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr__controller), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0004341C File Offset: 0x0004161C
	// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0000724E File Offset: 0x0000544E
	public unsafe Action<TWResult> ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterPostingTask.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009DA RID: 2522
	private static readonly IntPtr NativeFieldInfoPtr__status;

	// Token: 0x040009DB RID: 2523
	private static readonly IntPtr NativeFieldInfoPtr__texture;

	// Token: 0x040009DC RID: 2524
	private static readonly IntPtr NativeFieldInfoPtr__controller;

	// Token: 0x040009DD RID: 2525
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x040009DE RID: 2526
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_TWResult_0;

	// Token: 0x040009DF RID: 2527
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_TWResult_0;

	// Token: 0x040009E0 RID: 2528
	private static readonly IntPtr NativeMethodInfoPtr_Cretae_Public_Static_TwitterPostingTask_0;

	// Token: 0x040009E1 RID: 2529
	private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Void_String_Texture2D_TwitterManagerInterface_0;

	// Token: 0x040009E2 RID: 2530
	private static readonly IntPtr NativeMethodInfoPtr_OnTWInited_Private_Void_TWResult_0;

	// Token: 0x040009E3 RID: 2531
	private static readonly IntPtr NativeMethodInfoPtr_OnTWAuth_Private_Void_TWResult_0;

	// Token: 0x040009E4 RID: 2532
	private static readonly IntPtr NativeMethodInfoPtr_OnPost_Private_Void_TWResult_0;

	// Token: 0x040009E5 RID: 2533
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000386 RID: 902
	[ObfuscatedName("TwitterPostingTask+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060035CA RID: 13770 RVA: 0x000DD720 File Offset: 0x000DB920
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterPostingTask>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr);
			TwitterPostingTask.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr, "<>9");
			TwitterPostingTask.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr, "<>9__11_0");
			TwitterPostingTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr, 100670155);
			TwitterPostingTask.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr, 100670156);
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x000DD79C File Offset: 0x000DB99C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterPostingTask.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x000DD7D8 File Offset: 0x000DB9D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0(TWResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterPostingTask.__c.NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00014D63 File Offset: 0x00012F63
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x000DD81C File Offset: 0x000DBA1C
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x00014D6C File Offset: 0x00012F6C
		public unsafe static TwitterPostingTask.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterPostingTask.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterPostingTask.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060035D0 RID: 13776 RVA: 0x000DD844 File Offset: 0x000DBA44
		// (set) Token: 0x060035D1 RID: 13777 RVA: 0x00014D7E File Offset: 0x00012F7E
		public unsafe static Action<TWResult> __9__11_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterPostingTask.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterPostingTask.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Internal_Void_TWResult_0;
	}
}
