using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F1 RID: 753
	public class MACTripleDES : KeyedHashAlgorithm
	{
		// Token: 0x0600313F RID: 12607 RVA: 0x000F4FC4 File Offset: 0x000F31C4
		// Note: this type is marked as 'beforefieldinit'.
		static MACTripleDES()
		{
			Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "MACTripleDES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr);
			MACTripleDES.NativeFieldInfoPtr_m_encryptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_encryptor");
			MACTripleDES.NativeFieldInfoPtr__cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_cs");
			MACTripleDES.NativeFieldInfoPtr__ts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "_ts");
			MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "m_bytesPerBlock");
			MACTripleDES.NativeFieldInfoPtr_des = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, "des");
			MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671027);
			MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671028);
			MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671029);
			MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671030);
			MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr, 100671031);
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000F50BC File Offset: 0x000F32BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339791, XrefRangeEnd = 339802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MACTripleDES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MACTripleDES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MACTripleDES.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000F50F8 File Offset: 0x000F32F8
		[CallerCount(0)]
		public unsafe override void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000F5134 File Offset: 0x000F3334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339802, XrefRangeEnd = 339811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HashCore(Il2CppStructArray<byte> rgbData, int ibStart, int cbSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ibStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000F51A0 File Offset: 0x000F33A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339811, XrefRangeEnd = 339822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> HashFinal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x000F51EC File Offset: 0x000F33EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339822, XrefRangeEnd = 339829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MACTripleDES.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000116DE File Offset: 0x0000F8DE
		public MACTripleDES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x000F5238 File Offset: 0x000F3438
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x000116E7 File Offset: 0x0000F8E7
		public unsafe ICryptoTransform m_encryptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_encryptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x000F5268 File Offset: 0x000F3468
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00011706 File Offset: 0x0000F906
		public unsafe CryptoStream _cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CryptoStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__cs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x000F5298 File Offset: 0x000F3498
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x00011725 File Offset: 0x0000F925
		public unsafe TailStream _ts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TailStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr__ts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x000F52C8 File Offset: 0x000F34C8
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00011744 File Offset: 0x0000F944
		public unsafe int m_bytesPerBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_m_bytesPerBlock)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x000F52F0 File Offset: 0x000F34F0
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x0001175F File Offset: 0x0000F95F
		public unsafe TripleDES des
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TripleDES>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MACTripleDES.NativeFieldInfoPtr_des), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptor;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeFieldInfoPtr__cs;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeFieldInfoPtr__ts;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeFieldInfoPtr_m_bytesPerBlock;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeFieldInfoPtr_des;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_HashCore_Protected_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_HashFinal_Protected_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
