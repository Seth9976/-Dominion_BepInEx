using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x02000356 RID: 854
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		// Token: 0x06003397 RID: 13207 RVA: 0x000D6698 File Offset: 0x000D4898
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_HelpBoxAttribute()
		{
			Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_HelpBoxAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr);
			SA_PD_HelpBoxAttribute.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr, "m_type");
			SA_PD_HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr, 100669886);
			SA_PD_HelpBoxAttribute.NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr, 100669887);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000D6704 File Offset: 0x000D4904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_HelpBoxAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HelpBoxAttribute.NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06003399 RID: 13209 RVA: 0x000D674C File Offset: 0x000D494C
		public unsafe SA_PD_MessageType Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HelpBoxAttribute.NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00014205 File Offset: 0x00012405
		public SA_PD_HelpBoxAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x000D6788 File Offset: 0x000D4988
		// (set) Token: 0x0600339C RID: 13212 RVA: 0x0001420E File Offset: 0x0001240E
		public unsafe SA_PD_MessageType m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpBoxAttribute.NativeFieldInfoPtr_m_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpBoxAttribute.NativeFieldInfoPtr_m_type)) = value;
			}
		}

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_0;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0;
	}
}
