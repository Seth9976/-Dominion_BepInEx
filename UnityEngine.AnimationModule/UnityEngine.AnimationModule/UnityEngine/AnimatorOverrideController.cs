using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class AnimatorOverrideController : RuntimeAnimatorController
	{
		// Token: 0x060001AE RID: 430 RVA: 0x000089BC File Offset: 0x00006BBC
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorOverrideController()
		{
			Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorOverrideController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr);
			AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirty");
			AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, 100663333);
			AnimatorOverrideController.Internal_CreateDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_CreateDelegate>("UnityEngine.AnimatorOverrideController::Internal_Create");
			AnimatorOverrideController.get_runtimeAnimatorControllerDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.get_runtimeAnimatorControllerDelegate>("UnityEngine.AnimatorOverrideController::get_runtimeAnimatorController");
			AnimatorOverrideController.set_runtimeAnimatorControllerDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.set_runtimeAnimatorControllerDelegate>("UnityEngine.AnimatorOverrideController::set_runtimeAnimatorController");
			AnimatorOverrideController.Internal_GetClipByNameDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_GetClipByNameDelegate>("UnityEngine.AnimatorOverrideController::Internal_GetClipByName");
			AnimatorOverrideController.Internal_SetClipByNameDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.Internal_SetClipByNameDelegate>("UnityEngine.AnimatorOverrideController::Internal_SetClipByName");
			AnimatorOverrideController.GetClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetClipDelegate>("UnityEngine.AnimatorOverrideController::GetClip");
			AnimatorOverrideController.SetClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.SetClipDelegate>("UnityEngine.AnimatorOverrideController::SetClip");
			AnimatorOverrideController.SendNotificationDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.SendNotificationDelegate>("UnityEngine.AnimatorOverrideController::SendNotification");
			AnimatorOverrideController.GetOriginalClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetOriginalClipDelegate>("UnityEngine.AnimatorOverrideController::GetOriginalClip");
			AnimatorOverrideController.GetOverrideClipDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.GetOverrideClipDelegate>("UnityEngine.AnimatorOverrideController::GetOverrideClip");
			AnimatorOverrideController.get_overridesCountDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.get_overridesCountDelegate>("UnityEngine.AnimatorOverrideController::get_overridesCount");
			AnimatorOverrideController.PerformOverrideClipListCleanupDelegateField = IL2CPP.ResolveICall<AnimatorOverrideController.PerformOverrideClipListCleanupDelegate>("UnityEngine.AnimatorOverrideController::PerformOverrideClipListCleanup");
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008AC8 File Offset: 0x00006CC8
		[CallerCount(0)]
		public unsafe static void OnInvalidateOverrideController(AnimatorOverrideController controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000031F2 File Offset: 0x000013F2
		public AnimatorOverrideController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00008B00 File Offset: 0x00006D00
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x000031FB File Offset: 0x000013FB
		public unsafe AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorOverrideController.NativeFieldInfoPtr_OnOverrideControllerDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000321A File Offset: 0x0000141A
		public static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller)
		{
			AnimatorOverrideController.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(controller));
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00008B30 File Offset: 0x00006D30
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00003232 File Offset: 0x00001432
		public RuntimeAnimatorController runtimeAnimatorController
		{
			get
			{
				IntPtr intPtr = AnimatorOverrideController.get_runtimeAnimatorControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeAnimatorController>(intPtr2) : null;
			}
			set
			{
				AnimatorOverrideController.set_runtimeAnimatorControllerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		public AnimationClip this[string name]
		{
			get
			{
				return this.Internal_GetClipByName(name, true);
			}
			set
			{
				this.Internal_SetClipByName(name, value);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008B78 File Offset: 0x00006D78
		public AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip)
		{
			IntPtr intPtr = AnimatorOverrideController.Internal_GetClipByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), returnEffectiveClip);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00003256 File Offset: 0x00001456
		public void Internal_SetClipByName(string name, AnimationClip clip)
		{
			AnimatorOverrideController.Internal_SetClipByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(clip));
		}

		// Token: 0x1700007E RID: 126
		public AnimationClip this[AnimationClip clip]
		{
			get
			{
				return this.GetClip(clip, true);
			}
			set
			{
				this.SetClip(clip, value, true);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip)
		{
			IntPtr intPtr = AnimatorOverrideController.GetClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip), returnEffectiveClip);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003281 File Offset: 0x00001481
		public void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify)
		{
			AnimatorOverrideController.SetClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip), IL2CPP.Il2CppObjectBaseToPtr(overrideClip), notify);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000032A0 File Offset: 0x000014A0
		public void SendNotification()
		{
			AnimatorOverrideController.SendNotificationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008BFC File Offset: 0x00006DFC
		public AnimationClip GetOriginalClip(int index)
		{
			IntPtr intPtr = AnimatorOverrideController.GetOriginalClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008C2C File Offset: 0x00006E2C
		public AnimationClip GetOverrideClip(AnimationClip originalClip)
		{
			IntPtr intPtr = AnimatorOverrideController.GetOverrideClipDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(originalClip));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000032B2 File Offset: 0x000014B2
		public int overridesCount
		{
			get
			{
				return AnimatorOverrideController.get_overridesCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008C60 File Offset: 0x00006E60
		public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			bool flag = overrides == null;
			if (flag)
			{
				throw new ArgumentNullException("overrides");
			}
			int overridesCount = this.overridesCount;
			bool flag2 = overrides.Capacity < overridesCount;
			if (flag2)
			{
				overrides.Capacity = overridesCount;
			}
			overrides.Clear();
			for (int i = 0; i < overridesCount; i++)
			{
				AnimationClip originalClip = this.GetOriginalClip(i);
				overrides.Add(new KeyValuePair<AnimationClip, AnimationClip>(originalClip, this.GetOverrideClip(originalClip)));
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008CD8 File Offset: 0x00006ED8
		public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides)
		{
			bool flag = overrides == null;
			if (flag)
			{
				throw new ArgumentNullException("overrides");
			}
			for (int i = 0; i < overrides.Count; i++)
			{
				KeyValuePair<AnimationClip, AnimationClip> keyValuePair = overrides[i];
				AnimationClip key = keyValuePair.Key;
				keyValuePair = overrides[i];
				this.SetClip(key, keyValuePair.Value, false);
			}
			this.SendNotification();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000032C4 File Offset: 0x000014C4
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000032D1 File Offset: 0x000014D1
		public Il2CppReferenceArray<AnimationClipPair> clips
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000032DE File Offset: 0x000014DE
		public void PerformOverrideClipListCleanup()
		{
			AnimatorOverrideController.PerformOverrideClipListCleanupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_OnOverrideControllerDirty;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_OnInvalidateOverrideController_Internal_Static_Void_AnimatorOverrideController_0;

		// Token: 0x04000117 RID: 279
		private static readonly AnimatorOverrideController.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly AnimatorOverrideController.get_runtimeAnimatorControllerDelegate get_runtimeAnimatorControllerDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly AnimatorOverrideController.set_runtimeAnimatorControllerDelegate set_runtimeAnimatorControllerDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly AnimatorOverrideController.Internal_GetClipByNameDelegate Internal_GetClipByNameDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly AnimatorOverrideController.Internal_SetClipByNameDelegate Internal_SetClipByNameDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly AnimatorOverrideController.GetClipDelegate GetClipDelegateField;

		// Token: 0x0400011D RID: 285
		private static readonly AnimatorOverrideController.SetClipDelegate SetClipDelegateField;

		// Token: 0x0400011E RID: 286
		private static readonly AnimatorOverrideController.SendNotificationDelegate SendNotificationDelegateField;

		// Token: 0x0400011F RID: 287
		private static readonly AnimatorOverrideController.GetOriginalClipDelegate GetOriginalClipDelegateField;

		// Token: 0x04000120 RID: 288
		private static readonly AnimatorOverrideController.GetOverrideClipDelegate GetOverrideClipDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly AnimatorOverrideController.get_overridesCountDelegate get_overridesCountDelegateField;

		// Token: 0x04000122 RID: 290
		private static readonly AnimatorOverrideController.PerformOverrideClipListCleanupDelegate PerformOverrideClipListCleanupDelegateField;

		// Token: 0x02000114 RID: 276
		public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
		{
			// Token: 0x060006C8 RID: 1736 RVA: 0x00005938 File Offset: 0x00003B38
			// Note: this type is marked as 'beforefieldinit'.
			static OnOverrideControllerDirtyCallback()
			{
				Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatorOverrideController>.NativeClassPtr, "OnOverrideControllerDirtyCallback");
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663334);
				AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr, 100663335);
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnOverrideControllerDirtyCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorOverrideController.OnOverrideControllerDirtyCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x0000D844 File Offset: 0x0000BA44
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorOverrideController.OnOverrideControllerDirtyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00005976 File Offset: 0x00003B76
			public OnOverrideControllerDirtyCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x0000597F File Offset: 0x00003B7F
			public static implicit operator AnimatorOverrideController.OnOverrideControllerDirtyCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<AnimatorOverrideController.OnOverrideControllerDirtyCallback>(A_0);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00005987 File Offset: 0x00003B87
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator +(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00005995 File Offset: 0x00003B95
			public static AnimatorOverrideController.OnOverrideControllerDirtyCallback operator -(AnimatorOverrideController.OnOverrideControllerDirtyCallback A_0, AnimatorOverrideController.OnOverrideControllerDirtyCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AnimatorOverrideController.OnOverrideControllerDirtyCallback>();
				}
				return delegate2;
			}

			// Token: 0x040003E6 RID: 998
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040003E7 RID: 999
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000115 RID: 277
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate void Internal_CreateDelegate(IntPtr self, IntPtr controller);

		// Token: 0x02000116 RID: 278
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate IntPtr get_runtimeAnimatorControllerDelegate(IntPtr @this);

		// Token: 0x02000117 RID: 279
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate void set_runtimeAnimatorControllerDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000118 RID: 280
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate IntPtr Internal_GetClipByNameDelegate(IntPtr @this, IntPtr name, bool returnEffectiveClip);

		// Token: 0x02000119 RID: 281
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate void Internal_SetClipByNameDelegate(IntPtr @this, IntPtr name, IntPtr clip);

		// Token: 0x0200011A RID: 282
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate IntPtr GetClipDelegate(IntPtr @this, IntPtr originalClip, bool returnEffectiveClip);

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate void SetClipDelegate(IntPtr @this, IntPtr originalClip, IntPtr overrideClip, bool notify);

		// Token: 0x0200011C RID: 284
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void SendNotificationDelegate(IntPtr @this);

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate IntPtr GetOriginalClipDelegate(IntPtr @this, int index);

		// Token: 0x0200011E RID: 286
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate IntPtr GetOverrideClipDelegate(IntPtr @this, IntPtr originalClip);

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate int get_overridesCountDelegate(IntPtr @this);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate void PerformOverrideClipListCleanupDelegate(IntPtr @this);
	}
}
