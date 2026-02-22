using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E9 RID: 233
	public class ValidatedInputDependent : MonoBehaviour
	{
		// Token: 0x06001C6E RID: 7278 RVA: 0x0006F0F8 File Offset: 0x0006D2F8
		// Note: this type is marked as 'beforefieldinit'.
		static ValidatedInputDependent()
		{
			Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "ValidatedInputDependent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr);
			ValidatedInputDependent.NativeFieldInfoPtr_AllowWhenPushDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, "AllowWhenPushDisabled");
			ValidatedInputDependent.NativeFieldInfoPtr_ValidatedInputFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, "ValidatedInputFields");
			ValidatedInputDependent.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, "button");
			ValidatedInputDependent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, 100665525);
			ValidatedInputDependent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, 100665526);
			ValidatedInputDependent.NativeMethodInfoPtr_PushNotificationsEnabled_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, 100665527);
			ValidatedInputDependent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr, 100665528);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0006F1B4 File Offset: 0x0006D3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253666, XrefRangeEnd = 253669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputDependent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253669, XrefRangeEnd = 253675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputDependent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0006F21C File Offset: 0x0006D41C
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushNotificationsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputDependent.NativeMethodInfoPtr_PushNotificationsEnabled_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0006F258 File Offset: 0x0006D458
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatedInputDependent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatedInputDependent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputDependent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0001243C File Offset: 0x0001063C
		public ValidatedInputDependent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x0006F294 File Offset: 0x0006D494
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x00012445 File Offset: 0x00010645
		public unsafe bool AllowWhenPushDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_AllowWhenPushDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_AllowWhenPushDisabled)) = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x0006F2BC File Offset: 0x0006D4BC
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00012460 File Offset: 0x00010660
		public unsafe Il2CppReferenceArray<ValidatedInputField> ValidatedInputFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_ValidatedInputFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValidatedInputField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_ValidatedInputFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x0006F2EC File Offset: 0x0006D4EC
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0001247F File Offset: 0x0001067F
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputDependent.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_AllowWhenPushDisabled;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_ValidatedInputFields;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_PushNotificationsEnabled_Private_Boolean_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
