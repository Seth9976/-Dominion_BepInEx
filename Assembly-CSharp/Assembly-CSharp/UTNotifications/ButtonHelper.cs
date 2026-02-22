using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E1 RID: 225
	public class ButtonHelper : MonoBehaviour
	{
		// Token: 0x06001BFF RID: 7167 RVA: 0x0006DD1C File Offset: 0x0006BF1C
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonHelper()
		{
			Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "ButtonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr);
			ButtonHelper.NativeFieldInfoPtr_DisabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, "DisabledColor");
			ButtonHelper.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, "button");
			ButtonHelper.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, "text");
			ButtonHelper.NativeFieldInfoPtr_lastInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, "lastInteractable");
			ButtonHelper.NativeFieldInfoPtr_initialColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, "initialColor");
			ButtonHelper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, 100665492);
			ButtonHelper.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, 100665493);
			ButtonHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr, 100665494);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253385, XrefRangeEnd = 253392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonHelper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0006DE20 File Offset: 0x0006C020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253392, XrefRangeEnd = 253393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonHelper.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0006DE54 File Offset: 0x0006C054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253393, XrefRangeEnd = 253395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0001203F File Offset: 0x0001023F
		public ButtonHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0006DE90 File Offset: 0x0006C090
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x00012048 File Offset: 0x00010248
		public unsafe Color DisabledColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_DisabledColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_DisabledColor)) = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0006DEB8 File Offset: 0x0006C0B8
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00012063 File Offset: 0x00010263
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x0006DEE8 File Offset: 0x0006C0E8
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x00012082 File Offset: 0x00010282
		public unsafe Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x0006DF18 File Offset: 0x0006C118
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x000120A1 File Offset: 0x000102A1
		public unsafe bool lastInteractable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_lastInteractable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_lastInteractable)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x0006DF40 File Offset: 0x0006C140
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x000120BC File Offset: 0x000102BC
		public unsafe Color initialColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_initialColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonHelper.NativeFieldInfoPtr_initialColor)) = value;
			}
		}

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr_DisabledColor;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeFieldInfoPtr_lastInteractable;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeFieldInfoPtr_initialColor;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
