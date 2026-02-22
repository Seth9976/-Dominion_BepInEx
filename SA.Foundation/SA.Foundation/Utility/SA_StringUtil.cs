using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace SA.Foundation.Utility
{
	// Token: 0x0200001A RID: 26
	public static class SA_StringUtil : Object
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00006AF0 File Offset: 0x00004CF0
		// Note: this type is marked as 'beforefieldinit'.
		static SA_StringUtil()
		{
			Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_StringUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr);
			SA_StringUtil.NativeFieldInfoPtr__stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, "_stringBuilder");
			SA_StringUtil.NativeFieldInfoPtr_SecondsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, "SecondsFormat");
			SA_StringUtil.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663428);
			SA_StringUtil.NativeMethodInfoPtr_Join_Public_Static_String_Object_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663429);
			SA_StringUtil.NativeMethodInfoPtr_Join_Public_Static_String_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663430);
			SA_StringUtil.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663431);
			SA_StringUtil.NativeMethodInfoPtr_SecondsToString_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663432);
			SA_StringUtil.NativeMethodInfoPtr_SecondsToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StringUtil>.NativeClassPtr, 100663433);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006BC0 File Offset: 0x00004DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99283, RefRangeEnd = 99284, XrefRangeStart = 99268, XrefRangeEnd = 99283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppReferenceArray<Object> objects)
		{
			if (objects == null)
			{
				objects = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006C0C File Offset: 0x00004E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99284, XrefRangeEnd = 99308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(Object separator, List<string> objects)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_Join_Public_Static_String_Object_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006C5C File Offset: 0x00004E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99308, XrefRangeEnd = 99331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(Object separator, [Optional] Il2CppReferenceArray<Object> objects)
		{
			if (objects == null)
			{
				objects = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_Join_Public_Static_String_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006CB8 File Offset: 0x00004EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99331, XrefRangeEnd = 99340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> objects)
		{
			if (objects == null)
			{
				objects = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006D14 File Offset: 0x00004F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99340, XrefRangeEnd = 99348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SecondsToString(float seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_SecondsToString_Public_Static_String_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006D4C File Offset: 0x00004F4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99372, RefRangeEnd = 99373, XrefRangeStart = 99348, XrefRangeEnd = 99372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SecondsToString(int seconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StringUtil.NativeMethodInfoPtr_SecondsToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000222E File Offset: 0x0000042E
		public static string Concat(params Object[] objects)
		{
			return SA_StringUtil.Concat(new Il2CppReferenceArray<Object>(objects));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000223B File Offset: 0x0000043B
		public static string Join(Object separator, params Object[] objects)
		{
			return SA_StringUtil.Join(separator, new Il2CppReferenceArray<Object>(objects));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002249 File Offset: 0x00000449
		public static string Format(string format, params Object[] objects)
		{
			return SA_StringUtil.Format(format, new Il2CppReferenceArray<Object>(objects));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002257 File Offset: 0x00000457
		public SA_StringUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00006D84 File Offset: 0x00004F84
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe static StringBuilder _stringBuilder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_StringUtil.NativeFieldInfoPtr__stringBuilder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_StringUtil.NativeFieldInfoPtr__stringBuilder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00006DAC File Offset: 0x00004FAC
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe static string SecondsFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_StringUtil.NativeFieldInfoPtr_SecondsFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_StringUtil.NativeFieldInfoPtr_SecondsFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr__stringBuilder;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_SecondsFormat;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Object_List_1_String_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_SecondsToString_Public_Static_String_Single_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_SecondsToString_Public_Static_String_Int32_0;
	}
}
