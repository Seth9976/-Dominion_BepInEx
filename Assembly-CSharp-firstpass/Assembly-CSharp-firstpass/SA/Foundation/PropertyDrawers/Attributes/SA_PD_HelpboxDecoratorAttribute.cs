using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035C RID: 860
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		// Token: 0x060033CD RID: 13261 RVA: 0x000D70E8 File Offset: 0x000D52E8
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_HelpboxDecoratorAttribute()
		{
			Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_HelpboxDecoratorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr);
			SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr, "m_message");
			SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr, "m_type");
			SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr, 100669904);
			SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr, 100669905);
			SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr, 100669906);
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x000D717C File Offset: 0x000D537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223789, XrefRangeEnd = 223790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_HelpboxDecoratorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x000D71D8 File Offset: 0x000D53D8
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060033D0 RID: 13264 RVA: 0x000D7210 File Offset: 0x000D5410
		public unsafe SA_PD_MessageType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HelpboxDecoratorAttribute.NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x0001438B File Offset: 0x0001258B
		public SA_PD_HelpboxDecoratorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060033D2 RID: 13266 RVA: 0x000D724C File Offset: 0x000D544C
		// (set) Token: 0x060033D3 RID: 13267 RVA: 0x00014394 File Offset: 0x00012594
		public unsafe string m_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x000D7274 File Offset: 0x000D5474
		// (set) Token: 0x060033D5 RID: 13269 RVA: 0x000143B3 File Offset: 0x000125B3
		public unsafe SA_PD_MessageType m_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HelpboxDecoratorAttribute.NativeFieldInfoPtr_m_type)) = value;
			}
		}

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeFieldInfoPtr_m_message;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeFieldInfoPtr_m_type;

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SA_PD_MessageType_String_0;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_SA_PD_MessageType_0;
	}
}
