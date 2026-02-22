using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000095 RID: 149
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x06000F40 RID: 3904 RVA: 0x0003F9D0 File Offset: 0x0003DBD0
		// Note: this type is marked as 'beforefieldinit'.
		static TextAreaAttribute()
		{
			Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAreaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr);
			TextAreaAttribute.NativeFieldInfoPtr_minLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "minLines");
			TextAreaAttribute.NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "maxLines");
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100664263);
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100664264);
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x0003FA50 File Offset: 0x0003DC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67899, XrefRangeEnd = 67900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAreaAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x0003FA8C File Offset: 0x0003DC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67900, XrefRangeEnd = 67901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAreaAttribute(int minLines, int maxLines)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLines;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLines;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00009AEC File Offset: 0x00007CEC
		public TextAreaAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x0003FAE4 File Offset: 0x0003DCE4
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00009AF5 File Offset: 0x00007CF5
		public unsafe int minLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines)) = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x0003FB0C File Offset: 0x0003DD0C
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x00009B10 File Offset: 0x00007D10
		public unsafe int maxLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines)) = value;
			}
		}

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeFieldInfoPtr_minLines;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_maxLines;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
