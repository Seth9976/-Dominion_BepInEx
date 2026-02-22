using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace SA.Foundation.PropertyDrawers.Attributes
{
	// Token: 0x0200035B RID: 859
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		// Token: 0x060033C7 RID: 13255 RVA: 0x000D6FD0 File Offset: 0x000D51D0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PD_HeaderDecoratorAttribute()
		{
			Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Foundation.PropertyDrawers.Attributes", "SA_PD_HeaderDecoratorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr);
			SA_PD_HeaderDecoratorAttribute.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr, "m_text");
			SA_PD_HeaderDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr, 100669902);
			SA_PD_HeaderDecoratorAttribute.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr, 100669903);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000D703C File Offset: 0x000D523C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_PD_HeaderDecoratorAttribute(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_PD_HeaderDecoratorAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HeaderDecoratorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x000D7088 File Offset: 0x000D5288
		public unsafe string Text
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PD_HeaderDecoratorAttribute.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00014363 File Offset: 0x00012563
		public SA_PD_HeaderDecoratorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x000D70C0 File Offset: 0x000D52C0
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x0001436C File Offset: 0x0001256C
		public unsafe string m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HeaderDecoratorAttribute.NativeFieldInfoPtr_m_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_PD_HeaderDecoratorAttribute.NativeFieldInfoPtr_m_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;
	}
}
