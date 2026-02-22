using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E6 RID: 230
	public class RememberValueInputField : MonoBehaviour
	{
		// Token: 0x06001C58 RID: 7256 RVA: 0x0006ECFC File Offset: 0x0006CEFC
		// Note: this type is marked as 'beforefieldinit'.
		static RememberValueInputField()
		{
			Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "RememberValueInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr);
			RememberValueInputField.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr, "inputField");
			RememberValueInputField.NativeFieldInfoPtr_uniqueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr, "uniqueName");
			RememberValueInputField.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr, 100665517);
			RememberValueInputField.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr, 100665518);
			RememberValueInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr, 100665519);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0006ED90 File Offset: 0x0006CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253612, XrefRangeEnd = 253631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueInputField.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253631, XrefRangeEnd = 253632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEndEdit(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueInputField.NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0006EE08 File Offset: 0x0006D008
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RememberValueInputField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RememberValueInputField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000123A5 File Offset: 0x000105A5
		public RememberValueInputField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0006EE44 File Offset: 0x0006D044
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x000123AE File Offset: 0x000105AE
		public unsafe InputField inputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueInputField.NativeFieldInfoPtr_inputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueInputField.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0006EE74 File Offset: 0x0006D074
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x000123CD File Offset: 0x000105CD
		public unsafe string uniqueName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueInputField.NativeFieldInfoPtr_uniqueName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueInputField.NativeFieldInfoPtr_uniqueName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_inputField;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_uniqueName;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_OnEndEdit_Private_Void_String_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
