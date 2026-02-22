using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace UTNotifications
{
	// Token: 0x020000E5 RID: 229
	public class Popup : MonoBehaviour
	{
		// Token: 0x06001C52 RID: 7250 RVA: 0x0006EBD0 File Offset: 0x0006CDD0
		// Note: this type is marked as 'beforefieldinit'.
		static Popup()
		{
			Il2CppClassPointerStore<Popup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "Popup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Popup>.NativeClassPtr);
			Popup.NativeFieldInfoPtr_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Popup>.NativeClassPtr, "ItemPrefab");
			Popup.NativeMethodInfoPtr_AddItem_Public_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup>.NativeClassPtr, 100665515);
			Popup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Popup>.NativeClassPtr, 100665516);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253597, XrefRangeEnd = 253612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(string label, UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup.NativeMethodInfoPtr_AddItem_Public_Void_String_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0006EC90 File Offset: 0x0006CE90
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Popup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Popup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Popup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0001237D File Offset: 0x0001057D
		public Popup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0006ECCC File Offset: 0x0006CECC
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x00012386 File Offset: 0x00010586
		public unsafe GameObject ItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup.NativeFieldInfoPtr_ItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Popup.NativeFieldInfoPtr_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_ItemPrefab;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_String_UnityAction_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
