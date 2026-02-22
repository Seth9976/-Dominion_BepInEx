using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Xml
{
	// Token: 0x02000013 RID: 19
	public class SmallXmlParserException : SystemException
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00024D44 File Offset: 0x00022F44
		// Note: this type is marked as 'beforefieldinit'.
		static SmallXmlParserException()
		{
			Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SmallXmlParserException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr);
			SmallXmlParserException.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, "line");
			SmallXmlParserException.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, "column");
			SmallXmlParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr, 100663409);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00024DB0 File Offset: 0x00022FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258790, XrefRangeEnd = 258799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmallXmlParserException(string msg, int line, int column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParserException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParserException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002371 File Offset: 0x00000571
		public SmallXmlParserException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00024E18 File Offset: 0x00023018
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000237A File Offset: 0x0000057A
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00024E40 File Offset: 0x00023040
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002395 File Offset: 0x00000595
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParserException.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
	}
}
