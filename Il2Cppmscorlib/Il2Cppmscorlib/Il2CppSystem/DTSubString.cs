using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AD RID: 173
	public sealed class DTSubString : ValueType
	{
		// Token: 0x06000C63 RID: 3171 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		// Note: this type is marked as 'beforefieldinit'.
		static DTSubString()
		{
			Il2CppClassPointerStore<DTSubString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DTSubString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DTSubString>.NativeClassPtr);
			DTSubString.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "s");
			DTSubString.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "index");
			DTSubString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "length");
			DTSubString.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "type");
			DTSubString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "value");
			DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, 100665402);
		}

		// Token: 0x1700024F RID: 591
		public unsafe char this[int relativeIndex]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285642, XrefRangeEnd = 285644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref relativeIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00005252 File Offset: 0x00003452
		public DTSubString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0000525B File Offset: 0x0000345B
		public DTSubString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DTSubString>.NativeClassPtr))
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe string s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0005ABE8 File Offset: 0x00058DE8
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x0000528C File Offset: 0x0000348C
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0005AC10 File Offset: 0x00058E10
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x000052A7 File Offset: 0x000034A7
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0005AC38 File Offset: 0x00058E38
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x000052C2 File Offset: 0x000034C2
		public unsafe DTSubStringType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0005AC60 File Offset: 0x00058E60
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x000052DD File Offset: 0x000034DD
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0;
	}
}
