using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042D RID: 1069
	[Serializable]
	public sealed class DecimalConstantAttribute : Attribute
	{
		// Token: 0x06004234 RID: 16948 RVA: 0x001310A0 File Offset: 0x0012F2A0
		// Note: this type is marked as 'beforefieldinit'.
		static DecimalConstantAttribute()
		{
			Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DecimalConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr);
			DecimalConstantAttribute.NativeFieldInfoPtr_dec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, "dec");
			DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100672927);
			DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr, 100672928);
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x0013110C File Offset: 0x0012F30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357108, XrefRangeEnd = 357109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecimalConstantAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref low;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06004236 RID: 16950 RVA: 0x0013118C File Offset: 0x0012F38C
		public unsafe Decimal Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecimalConstantAttribute.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00019411 File Offset: 0x00017611
		public DecimalConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06004238 RID: 16952 RVA: 0x001311C8 File Offset: 0x0012F3C8
		// (set) Token: 0x06004239 RID: 16953 RVA: 0x0001941A File Offset: 0x0001761A
		public unsafe Decimal dec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr_dec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecimalConstantAttribute.NativeFieldInfoPtr_dec)) = value;
			}
		}

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeFieldInfoPtr_dec;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_UInt32_UInt32_UInt32_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;
	}
}
