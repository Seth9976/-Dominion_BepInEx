using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000016 RID: 22
	public class Contraction : Object
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00025228 File Offset: 0x00023428
		// Note: this type is marked as 'beforefieldinit'.
		static Contraction()
		{
			Il2CppClassPointerStore<Contraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "Contraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contraction>.NativeClassPtr);
			Contraction.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Index");
			Contraction.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Source");
			Contraction.NativeFieldInfoPtr_Replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "Replacement");
			Contraction.NativeFieldInfoPtr_SortKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contraction>.NativeClassPtr, "SortKey");
			Contraction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contraction>.NativeClassPtr, 100663414);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000252BC File Offset: 0x000234BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 181353, RefRangeEnd = 181356, XrefRangeStart = 181353, XrefRangeEnd = 181356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contraction(int index, Il2CppStructArray<char> source, string replacement, Il2CppStructArray<byte> sortkey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contraction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(replacement);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sortkey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contraction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000249E File Offset: 0x0000069E
		public Contraction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0002533C File Offset: 0x0002353C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000024A7 File Offset: 0x000006A7
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00025364 File Offset: 0x00023564
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000024C2 File Offset: 0x000006C2
		public unsafe Il2CppStructArray<char> Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00025394 File Offset: 0x00023594
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000024E1 File Offset: 0x000006E1
		public unsafe string Replacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Replacement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_Replacement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000253BC File Offset: 0x000235BC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002500 File Offset: 0x00000700
		public unsafe Il2CppStructArray<byte> SortKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_SortKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contraction.NativeFieldInfoPtr_SortKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_Replacement;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_SortKey;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppStructArray_1_Char_String_Il2CppStructArray_1_Byte_0;
	}
}
