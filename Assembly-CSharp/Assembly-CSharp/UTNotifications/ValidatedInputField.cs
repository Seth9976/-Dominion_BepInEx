using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000EA RID: 234
	public class ValidatedInputField : MonoBehaviour
	{
		// Token: 0x06001C7A RID: 7290 RVA: 0x0006F31C File Offset: 0x0006D51C
		// Note: this type is marked as 'beforefieldinit'.
		static ValidatedInputField()
		{
			Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "ValidatedInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr);
			ValidatedInputField.NativeFieldInfoPtr_RequiredPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, "RequiredPattern");
			ValidatedInputField.NativeFieldInfoPtr_regex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, "regex");
			ValidatedInputField.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, "inputField");
			ValidatedInputField.NativeFieldInfoPtr_incorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, "incorrect");
			ValidatedInputField.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665529);
			ValidatedInputField.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665530);
			ValidatedInputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665531);
			ValidatedInputField.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665532);
			ValidatedInputField.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665533);
			ValidatedInputField.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665534);
			ValidatedInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr, 100665535);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0006F428 File Offset: 0x0006D628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253675, XrefRangeEnd = 253677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x0006F464 File Offset: 0x0006D664
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0006F49C File Offset: 0x0006D69C
		public unsafe string text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 253677, RefRangeEnd = 253679, XrefRangeStart = 253677, XrefRangeEnd = 253677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253679, XrefRangeEnd = 253681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253681, XrefRangeEnd = 253705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0006F514 File Offset: 0x0006D714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253705, XrefRangeEnd = 253708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0006F548 File Offset: 0x0006D748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253708, XrefRangeEnd = 253711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0006F58C File Offset: 0x0006D78C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatedInputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatedInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatedInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0001249E File Offset: 0x0001069E
		public ValidatedInputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0006F5C8 File Offset: 0x0006D7C8
		// (set) Token: 0x06001C84 RID: 7300 RVA: 0x000124A7 File Offset: 0x000106A7
		public unsafe string RequiredPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_RequiredPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_RequiredPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001C85 RID: 7301 RVA: 0x0006F5F0 File Offset: 0x0006D7F0
		// (set) Token: 0x06001C86 RID: 7302 RVA: 0x000124C6 File Offset: 0x000106C6
		public unsafe Regex regex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_regex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_regex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0006F620 File Offset: 0x0006D820
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x000124E5 File Offset: 0x000106E5
		public unsafe InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x0006F650 File Offset: 0x0006D850
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00012504 File Offset: 0x00010704
		public unsafe GameObject incorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_incorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatedInputField.NativeFieldInfoPtr_incorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_RequiredPattern;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeFieldInfoPtr_regex;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeFieldInfoPtr_incorrect;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
