using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace UTNotifications
{
	// Token: 0x020000E3 RID: 227
	public class MoreButton : MonoBehaviour
	{
		// Token: 0x06001C27 RID: 7207 RVA: 0x0006E3AC File Offset: 0x0006C5AC
		// Note: this type is marked as 'beforefieldinit'.
		static MoreButton()
		{
			Il2CppClassPointerStore<MoreButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "MoreButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoreButton>.NativeClassPtr);
			MoreButton.NativeFieldInfoPtr_PopupPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, "PopupPrefab");
			MoreButton.NativeFieldInfoPtr_MenuItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, "MenuItems");
			MoreButton.NativeFieldInfoPtr_popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, "popup");
			MoreButton.NativeMethodInfoPtr_FindInstance_Public_Static_MoreButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, 100665500);
			MoreButton.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, 100665501);
			MoreButton.NativeMethodInfoPtr_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, 100665502);
			MoreButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, 100665503);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0006E468 File Offset: 0x0006C668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253468, RefRangeEnd = 253469, XrefRangeStart = 253462, XrefRangeEnd = 253468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoreButton FindInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreButton.NativeMethodInfoPtr_FindInstance_Public_Static_MoreButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoreButton>(intPtr3) : null;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0006E49C File Offset: 0x0006C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253469, XrefRangeEnd = 253480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreButton.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0006E4D0 File Offset: 0x0006C6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253480, XrefRangeEnd = 253514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreButton.NativeMethodInfoPtr_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0006E504 File Offset: 0x0006C704
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoreButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000121F7 File Offset: 0x000103F7
		public MoreButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x0006E540 File Offset: 0x0006C740
		// (set) Token: 0x06001C2E RID: 7214 RVA: 0x00012200 File Offset: 0x00010400
		public unsafe GameObject PopupPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_PopupPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_PopupPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0006E570 File Offset: 0x0006C770
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x0001221F File Offset: 0x0001041F
		public unsafe Il2CppReferenceArray<MoreButton.PopupMenuItem> MenuItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_MenuItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MoreButton.PopupMenuItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_MenuItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0006E5A0 File Offset: 0x0006C7A0
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0001223E File Offset: 0x0001043E
		public unsafe GameObject popup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_popup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.NativeFieldInfoPtr_popup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeFieldInfoPtr_PopupPrefab;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeFieldInfoPtr_MenuItems;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeFieldInfoPtr_popup;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_FindInstance_Public_Static_MoreButton_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_OnClick_Private_Void_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000209 RID: 521
		public sealed class PopupMenuItem : ValueType
		{
			// Token: 0x0600294B RID: 10571 RVA: 0x00094E00 File Offset: 0x00093000
			// Note: this type is marked as 'beforefieldinit'.
			static PopupMenuItem()
			{
				Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoreButton>.NativeClassPtr, "PopupMenuItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr);
				MoreButton.PopupMenuItem.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr, "label");
				MoreButton.PopupMenuItem.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr, "action");
				MoreButton.PopupMenuItem.NativeMethodInfoPtr__ctor_Public_Void_String_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr, 100666544);
			}

			// Token: 0x0600294C RID: 10572 RVA: 0x00094E68 File Offset: 0x00093068
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 52612, RefRangeEnd = 52647, XrefRangeStart = 52612, XrefRangeEnd = 52647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PopupMenuItem(string label, UnityAction action)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreButton.PopupMenuItem.NativeMethodInfoPtr__ctor_Public_Void_String_UnityAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600294D RID: 10573 RVA: 0x000196B2 File Offset: 0x000178B2
			public PopupMenuItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600294E RID: 10574 RVA: 0x000196BB File Offset: 0x000178BB
			public PopupMenuItem()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreButton.PopupMenuItem>.NativeClassPtr))
			{
			}

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x0600294F RID: 10575 RVA: 0x00094ECC File Offset: 0x000930CC
			// (set) Token: 0x06002950 RID: 10576 RVA: 0x000196CD File Offset: 0x000178CD
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.PopupMenuItem.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.PopupMenuItem.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x06002951 RID: 10577 RVA: 0x00094EF4 File Offset: 0x000930F4
			// (set) Token: 0x06002952 RID: 10578 RVA: 0x000196EC File Offset: 0x000178EC
			public unsafe UnityAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.PopupMenuItem.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoreButton.PopupMenuItem.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C4E RID: 7246
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04001C4F RID: 7247
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001C50 RID: 7248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UnityAction_0;
		}
	}
}
