using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000015 RID: 21
	public class GD_LabelLocalizer : MonoBehaviour
	{
		// Token: 0x06000101 RID: 257 RVA: 0x000065C8 File Offset: 0x000047C8
		// Note: this type is marked as 'beforefieldinit'.
		static GD_LabelLocalizer()
		{
			Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_LabelLocalizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr);
			GD_LabelLocalizer.NativeFieldInfoPtr_m_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "m_token");
			GD_LabelLocalizer.NativeFieldInfoPtr_m_section = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "m_section");
			GD_LabelLocalizer.NativeFieldInfoPtr_m_textType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "m_textType");
			GD_LabelLocalizer.NativeFieldInfoPtr_m_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "m_prefix");
			GD_LabelLocalizer.NativeFieldInfoPtr_m_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "m_suffix");
			GD_LabelLocalizer.NativeFieldInfoPtr_LocalizableLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, "LocalizableLabel");
			GD_LabelLocalizer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, 100663429);
			GD_LabelLocalizer.NativeMethodInfoPtr_OnDestor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, 100663430);
			GD_LabelLocalizer.NativeMethodInfoPtr_UpdateLable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, 100663431);
			GD_LabelLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr, 100663432);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000066C0 File Offset: 0x000048C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126925, XrefRangeEnd = 126972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LabelLocalizer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000066F4 File Offset: 0x000048F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126972, XrefRangeEnd = 126993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LabelLocalizer.NativeMethodInfoPtr_OnDestor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006728 File Offset: 0x00004928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126993, XrefRangeEnd = 127009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LabelLocalizer.NativeMethodInfoPtr_UpdateLable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000675C File Offset: 0x0000495C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127009, XrefRangeEnd = 127015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_LabelLocalizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_LabelLocalizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LabelLocalizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002583 File Offset: 0x00000783
		public GD_LabelLocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006798 File Offset: 0x00004998
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000258C File Offset: 0x0000078C
		public unsafe string m_token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000067C0 File Offset: 0x000049C0
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000025AB File Offset: 0x000007AB
		public unsafe GD_LangSection m_section
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_section);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_section)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000067E8 File Offset: 0x000049E8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000025C6 File Offset: 0x000007C6
		public unsafe GD_TextType m_textType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_textType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_textType)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006810 File Offset: 0x00004A10
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000025E1 File Offset: 0x000007E1
		public unsafe string m_prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006838 File Offset: 0x00004A38
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe string m_suffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_suffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_m_suffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006860 File Offset: 0x00004A60
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe Text LocalizableLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_LocalizableLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_LabelLocalizer.NativeFieldInfoPtr_LocalizableLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_m_token;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_section;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_textType;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_m_prefix;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_m_suffix;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_LocalizableLabel;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_OnDestor_Private_Void_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLable_Private_Void_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
