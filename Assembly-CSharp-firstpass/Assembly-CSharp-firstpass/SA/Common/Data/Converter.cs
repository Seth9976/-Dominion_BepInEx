using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Common.Data
{
	// Token: 0x0200031E RID: 798
	public class Converter : Object
	{
		// Token: 0x06002F13 RID: 12051 RVA: 0x000C93B4 File Offset: 0x000C75B4
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Data", "Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Converter>.NativeClassPtr);
			Converter.NativeFieldInfoPtr_DATA_SPLITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "DATA_SPLITTER");
			Converter.NativeFieldInfoPtr_DATA_SPLITTER2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "DATA_SPLITTER2");
			Converter.NativeFieldInfoPtr_ARRAY_SPLITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "ARRAY_SPLITTER");
			Converter.NativeFieldInfoPtr_DATA_EOF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "DATA_EOF");
			Converter.NativeMethodInfoPtr_SerializeArray_Public_Static_String_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100669531);
			Converter.NativeMethodInfoPtr_SerializeArray_Public_Static_String_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100669532);
			Converter.NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100669533);
			Converter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100669534);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000C9484 File Offset: 0x000C7684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219449, XrefRangeEnd = 219459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeArray(List<string> array, string splitter = "%%%")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(splitter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_SerializeArray_Public_Static_String_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000C94D4 File Offset: 0x000C76D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219459, XrefRangeEnd = 219464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SerializeArray(Il2CppStringArray array, string splitter = "%%%")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(splitter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_SerializeArray_Public_Static_String_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000C9524 File Offset: 0x000C7724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219464, XrefRangeEnd = 219494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ParseArray(string arrayData, string splitter = "%%%")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(arrayData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(splitter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000C957C File Offset: 0x000C777C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Converter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Converter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00012029 File Offset: 0x00010229
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000C95B8 File Offset: 0x000C77B8
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00012032 File Offset: 0x00010232
		public unsafe static char DATA_SPLITTER
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_DATA_SPLITTER, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_DATA_SPLITTER, (void*)(&value));
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x000C95D4 File Offset: 0x000C77D4
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00012040 File Offset: 0x00010240
		public unsafe static string DATA_SPLITTER2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_DATA_SPLITTER2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_DATA_SPLITTER2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x000C95F4 File Offset: 0x000C77F4
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00012052 File Offset: 0x00010252
		public unsafe static string ARRAY_SPLITTER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_ARRAY_SPLITTER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_ARRAY_SPLITTER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x000C9614 File Offset: 0x000C7814
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00012064 File Offset: 0x00010264
		public unsafe static string DATA_EOF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_DATA_EOF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_DATA_EOF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002CE1 RID: 11489
		private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER;

		// Token: 0x04002CE2 RID: 11490
		private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER2;

		// Token: 0x04002CE3 RID: 11491
		private static readonly IntPtr NativeFieldInfoPtr_ARRAY_SPLITTER;

		// Token: 0x04002CE4 RID: 11492
		private static readonly IntPtr NativeFieldInfoPtr_DATA_EOF;

		// Token: 0x04002CE5 RID: 11493
		private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Public_Static_String_List_1_String_String_0;

		// Token: 0x04002CE6 RID: 11494
		private static readonly IntPtr NativeMethodInfoPtr_SerializeArray_Public_Static_String_Il2CppStringArray_String_0;

		// Token: 0x04002CE7 RID: 11495
		private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04002CE8 RID: 11496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
