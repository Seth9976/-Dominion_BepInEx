using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010C RID: 268
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		// Token: 0x06001F63 RID: 8035 RVA: 0x00079BE0 File Offset: 0x00077DE0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ExampleScript_01()
		{
			Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_ExampleScript_01");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr);
			TMP_ExampleScript_01.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, "ObjectType");
			TMP_ExampleScript_01.NativeFieldInfoPtr_isStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, "isStatic");
			TMP_ExampleScript_01.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, "m_text");
			TMP_ExampleScript_01.NativeFieldInfoPtr_k_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, "k_label");
			TMP_ExampleScript_01.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, "count");
			TMP_ExampleScript_01.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, 100665860);
			TMP_ExampleScript_01.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, 100665861);
			TMP_ExampleScript_01.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr, 100665862);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x00079CB0 File Offset: 0x00077EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256430, XrefRangeEnd = 256462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ExampleScript_01.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00079CE4 File Offset: 0x00077EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256462, XrefRangeEnd = 256465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ExampleScript_01.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00079D18 File Offset: 0x00077F18
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ExampleScript_01()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ExampleScript_01>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ExampleScript_01.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00013940 File Offset: 0x00011B40
		public TMP_ExampleScript_01(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00079D54 File Offset: 0x00077F54
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00013949 File Offset: 0x00011B49
		public unsafe TMP_ExampleScript_01.objectType ObjectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_ObjectType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_ObjectType)) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00079D7C File Offset: 0x00077F7C
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00013964 File Offset: 0x00011B64
		public unsafe bool isStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_isStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_isStatic)) = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00079DA4 File Offset: 0x00077FA4
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0001397F File Offset: 0x00011B7F
		public unsafe TMP_Text m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00079DD4 File Offset: 0x00077FD4
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x0001399E File Offset: 0x00011B9E
		public unsafe static string k_label
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_ExampleScript_01.NativeFieldInfoPtr_k_label, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_ExampleScript_01.NativeFieldInfoPtr_k_label, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00079DF4 File Offset: 0x00077FF4
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x000139B0 File Offset: 0x00011BB0
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ExampleScript_01.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeFieldInfoPtr_isStatic;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeFieldInfoPtr_k_label;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200022E RID: 558
		public enum objectType
		{
			// Token: 0x04001D71 RID: 7537
			TextMeshPro,
			// Token: 0x04001D72 RID: 7538
			TextMeshProUGUI
		}
	}
}
