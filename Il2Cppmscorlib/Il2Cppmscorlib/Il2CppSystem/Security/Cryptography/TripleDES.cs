using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000310 RID: 784
	public class TripleDES : SymmetricAlgorithm
	{
		// Token: 0x060032FC RID: 13052 RVA: 0x000FB3D4 File Offset: 0x000F95D4
		// Note: this type is marked as 'beforefieldinit'.
		static TripleDES()
		{
			Il2CppClassPointerStore<TripleDES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "TripleDES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TripleDES>.NativeClassPtr);
			TripleDES.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, "s_legalBlockSizes");
			TripleDES.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, "s_legalKeySizes");
			TripleDES.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671234);
			TripleDES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671235);
			TripleDES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671236);
			TripleDES.NativeMethodInfoPtr_Create_Public_Static_TripleDES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671237);
			TripleDES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671238);
			TripleDES.NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671239);
			TripleDES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TripleDES>.NativeClassPtr, 100671240);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x000FB4B8 File Offset: 0x000F96B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341145, XrefRangeEnd = 341151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TripleDES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TripleDES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x000FB4F4 File Offset: 0x000F96F4
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x000FB540 File Offset: 0x000F9740
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341151, XrefRangeEnd = 341158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341158, XrefRangeEnd = 341167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TripleDES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x000FB590 File Offset: 0x000F9790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341180, RefRangeEnd = 341182, XrefRangeStart = 341167, XrefRangeEnd = 341180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TripleDES Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_Create_Public_Static_TripleDES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TripleDES>(intPtr3) : null;
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x000FB5C4 File Offset: 0x000F97C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 341192, RefRangeEnd = 341198, XrefRangeStart = 341182, XrefRangeEnd = 341192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x000FB608 File Offset: 0x000F9808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341198, RefRangeEnd = 341200, XrefRangeStart = 341198, XrefRangeEnd = 341198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualBytes(Il2CppStructArray<byte> rgbKey, int start1, int start2, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x000FB674 File Offset: 0x000F9874
		[CallerCount(0)]
		public unsafe static bool IsLegalKeySize(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TripleDES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00012300 File Offset: 0x00010500
		public TripleDES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x000FB6B8 File Offset: 0x000F98B8
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x00012309 File Offset: 0x00010509
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TripleDES.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TripleDES.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x000FB6E0 File Offset: 0x000F98E0
		// (set) Token: 0x06003308 RID: 13064 RVA: 0x0001231B File Offset: 0x0001051B
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TripleDES.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TripleDES.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TripleDES_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_EqualBytes_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0;
	}
}
