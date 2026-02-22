using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000083 RID: 131
public class BaseAndroidPopup : MonoBehaviour
{
	// Token: 0x0600094F RID: 2383 RVA: 0x0003701C File Offset: 0x0003521C
	// Note: this type is marked as 'beforefieldinit'.
	static BaseAndroidPopup()
	{
		Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BaseAndroidPopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr);
		BaseAndroidPopup.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, "title");
		BaseAndroidPopup.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, "message");
		BaseAndroidPopup.NativeFieldInfoPtr_ActionComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, "ActionComplete");
		BaseAndroidPopup.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, 100664416);
		BaseAndroidPopup.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, 100664417);
		BaseAndroidPopup.NativeMethodInfoPtr_onDismissed_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, 100664418);
		BaseAndroidPopup.NativeMethodInfoPtr_DispatchAction_Protected_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, 100664419);
		BaseAndroidPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, 100664420);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x000370EC File Offset: 0x000352EC
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 171170, RefRangeEnd = 171179, XrefRangeStart = 171166, XrefRangeEnd = 171170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionComplete(Action<AndroidDialogResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00037130 File Offset: 0x00035330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171179, XrefRangeEnd = 171183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionComplete(Action<AndroidDialogResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00037174 File Offset: 0x00035374
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171183, XrefRangeEnd = 171192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onDismissed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.NativeMethodInfoPtr_onDismissed_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x000371B8 File Offset: 0x000353B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171196, RefRangeEnd = 171197, XrefRangeStart = 171192, XrefRangeEnd = 171196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchAction(AndroidDialogResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.NativeMethodInfoPtr_DispatchAction_Protected_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x000371F8 File Offset: 0x000353F8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 171214, RefRangeEnd = 171217, XrefRangeStart = 171197, XrefRangeEnd = 171214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseAndroidPopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00005BE5 File Offset: 0x00003DE5
	public BaseAndroidPopup(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x06000956 RID: 2390 RVA: 0x00037234 File Offset: 0x00035434
	// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005BEE File Offset: 0x00003DEE
	public unsafe string title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x06000958 RID: 2392 RVA: 0x0003725C File Offset: 0x0003545C
	// (set) Token: 0x06000959 RID: 2393 RVA: 0x00005C0D File Offset: 0x00003E0D
	public unsafe string message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x0600095A RID: 2394 RVA: 0x00037284 File Offset: 0x00035484
	// (set) Token: 0x0600095B RID: 2395 RVA: 0x00005C2C File Offset: 0x00003E2C
	public unsafe Action<AndroidDialogResult> ActionComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_ActionComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidDialogResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseAndroidPopup.NativeFieldInfoPtr_ActionComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000778 RID: 1912
	private static readonly IntPtr NativeFieldInfoPtr_title;

	// Token: 0x04000779 RID: 1913
	private static readonly IntPtr NativeFieldInfoPtr_message;

	// Token: 0x0400077A RID: 1914
	private static readonly IntPtr NativeFieldInfoPtr_ActionComplete;

	// Token: 0x0400077B RID: 1915
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionComplete_Public_add_Void_Action_1_AndroidDialogResult_0;

	// Token: 0x0400077C RID: 1916
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionComplete_Public_rem_Void_Action_1_AndroidDialogResult_0;

	// Token: 0x0400077D RID: 1917
	private static readonly IntPtr NativeMethodInfoPtr_onDismissed_Public_Void_String_0;

	// Token: 0x0400077E RID: 1918
	private static readonly IntPtr NativeMethodInfoPtr_DispatchAction_Protected_Void_AndroidDialogResult_0;

	// Token: 0x0400077F RID: 1919
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200037A RID: 890
	[ObfuscatedName("BaseAndroidPopup+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003535 RID: 13621 RVA: 0x000DBA50 File Offset: 0x000D9C50
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseAndroidPopup>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr);
			BaseAndroidPopup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr, "<>9");
			BaseAndroidPopup.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr, "<>9__7_0");
			BaseAndroidPopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr, 100670087);
			BaseAndroidPopup.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr, 100670088);
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x000DBACC File Offset: 0x000D9CCC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseAndroidPopup.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x000DBB08 File Offset: 0x000D9D08
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__7_0(AndroidDialogResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseAndroidPopup.__c.NativeMethodInfoPtr___ctor_b__7_0_Internal_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00014A60 File Offset: 0x00012C60
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06003539 RID: 13625 RVA: 0x000DBB48 File Offset: 0x000D9D48
		// (set) Token: 0x0600353A RID: 13626 RVA: 0x00014A69 File Offset: 0x00012C69
		public unsafe static BaseAndroidPopup.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseAndroidPopup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseAndroidPopup.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseAndroidPopup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600353B RID: 13627 RVA: 0x000DBB70 File Offset: 0x000D9D70
		// (set) Token: 0x0600353C RID: 13628 RVA: 0x00014A7B File Offset: 0x00012C7B
		public unsafe static Action<AndroidDialogResult> __9__7_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BaseAndroidPopup.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidDialogResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BaseAndroidPopup.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003113 RID: 12563
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__7_0_Internal_Void_AndroidDialogResult_0;
	}
}
