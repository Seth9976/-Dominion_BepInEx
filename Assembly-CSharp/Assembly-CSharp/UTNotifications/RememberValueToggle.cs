using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E7 RID: 231
	public class RememberValueToggle : MonoBehaviour
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x0006EE9C File Offset: 0x0006D09C
		// Note: this type is marked as 'beforefieldinit'.
		static RememberValueToggle()
		{
			Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "RememberValueToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr);
			RememberValueToggle.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr, "toggle");
			RememberValueToggle.NativeFieldInfoPtr_uniqueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr, "uniqueName");
			RememberValueToggle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr, 100665520);
			RememberValueToggle.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr, 100665521);
			RememberValueToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr, 100665522);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0006EF30 File Offset: 0x0006D130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253632, XrefRangeEnd = 253651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueToggle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0006EF64 File Offset: 0x0006D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253651, XrefRangeEnd = 253652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueToggle.NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RememberValueToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RememberValueToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RememberValueToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000123EC File Offset: 0x000105EC
		public RememberValueToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0006EFE0 File Offset: 0x0006D1E0
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x000123F5 File Offset: 0x000105F5
		public unsafe Toggle toggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueToggle.NativeFieldInfoPtr_toggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueToggle.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0006F010 File Offset: 0x0006D210
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00012414 File Offset: 0x00010614
		public unsafe string uniqueName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueToggle.NativeFieldInfoPtr_uniqueName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RememberValueToggle.NativeFieldInfoPtr_uniqueName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_toggle;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_uniqueName;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_Boolean_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
