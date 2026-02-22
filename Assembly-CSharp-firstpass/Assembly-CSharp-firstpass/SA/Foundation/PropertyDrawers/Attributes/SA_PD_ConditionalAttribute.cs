using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x02000355 RID: 853
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		// Token: 0x0600338D RID: 13197 RVA: 0x000D6484 File Offset: 0x000D4684
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_ConditionalAttribute()
		{
			Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_ConditionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr);
			SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_conditionalSourceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, "m_conditionalSourceField");
			SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_hideInInspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, "m_hideInInspector");
			SA_PD_ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, 100669882);
			SA_PD_ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, 100669883);
			SA_PD_ConditionalAttribute.NativeMethodInfoPtr_get_ConditionalSourceField_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, 100669884);
			SA_PD_ConditionalAttribute.NativeMethodInfoPtr_get_HideInInspector_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr, 100669885);
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000D652C File Offset: 0x000D472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223753, XrefRangeEnd = 223756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_ConditionalAttribute(string conditionalSourceField)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(conditionalSourceField);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x000D6578 File Offset: 0x000D4778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223756, XrefRangeEnd = 223759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_ConditionalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(conditionalSourceField);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hideInInspector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_ConditionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x000D65D4 File Offset: 0x000D47D4
		public unsafe string ConditionalSourceField
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_ConditionalAttribute.NativeMethodInfoPtr_get_ConditionalSourceField_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06003391 RID: 13201 RVA: 0x000D660C File Offset: 0x000D480C
		public unsafe bool HideInInspector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_ConditionalAttribute.NativeMethodInfoPtr_get_HideInInspector_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x000141C2 File Offset: 0x000123C2
		public SA_PD_ConditionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003393 RID: 13203 RVA: 0x000D6648 File Offset: 0x000D4848
		// (set) Token: 0x06003394 RID: 13204 RVA: 0x000141CB File Offset: 0x000123CB
		public unsafe string m_conditionalSourceField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_conditionalSourceField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_conditionalSourceField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003395 RID: 13205 RVA: 0x000D6670 File Offset: 0x000D4870
		// (set) Token: 0x06003396 RID: 13206 RVA: 0x000141EA File Offset: 0x000123EA
		public unsafe bool m_hideInInspector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_hideInInspector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_ConditionalAttribute.NativeFieldInfoPtr_m_hideInInspector)) = value;
			}
		}

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeFieldInfoPtr_m_conditionalSourceField;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeFieldInfoPtr_m_hideInInspector;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr_get_ConditionalSourceField_Public_get_String_0;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr_get_HideInInspector_Public_get_Boolean_0;
	}
}
