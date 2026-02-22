using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000315 RID: 789
	public sealed class DSACryptoServiceProvider : DSA
	{
		// Token: 0x06003351 RID: 13137 RVA: 0x000FC7E4 File Offset: 0x000FA9E4
		// Note: this type is marked as 'beforefieldinit'.
		static DSACryptoServiceProvider()
		{
			Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSACryptoServiceProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr);
			DSACryptoServiceProvider.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "store");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persistKey");
			DSACryptoServiceProvider.NativeFieldInfoPtr_persisted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "persisted");
			DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "privateKeyExportable");
			DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "m_disposed");
			DSACryptoServiceProvider.NativeFieldInfoPtr_dsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "dsa");
			DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, "useMachineKeyStore");
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671278);
			DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671279);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671280);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671281);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671282);
			DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671283);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671284);
			DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671285);
			DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671286);
			DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr, 100671287);
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x000FC968 File Offset: 0x000FAB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341803, XrefRangeEnd = 341805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x000FC9A4 File Offset: 0x000FABA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 341807, RefRangeEnd = 341810, XrefRangeStart = 341805, XrefRangeEnd = 341807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSACryptoServiceProvider(int dwKeySize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSACryptoServiceProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x000FC9EC File Offset: 0x000FABEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 341851, RefRangeEnd = 341854, XrefRangeStart = 341810, XrefRangeEnd = 341851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Common(int dwKeySize, bool parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwKeySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x000FCA38 File Offset: 0x000FAC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x000FCA6C File Offset: 0x000FAC6C
		public unsafe override int KeySize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341855, RefRangeEnd = 341856, XrefRangeStart = 341854, XrefRangeEnd = 341855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x000FCAA8 File Offset: 0x000FACA8
		public unsafe bool PublicOnly
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 341857, RefRangeEnd = 341859, XrefRangeStart = 341856, XrefRangeEnd = 341857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000FCAE4 File Offset: 0x000FACE4
		[CallerCount(0)]
		public unsafe override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000FCB28 File Offset: 0x000FAD28
		[CallerCount(0)]
		public unsafe override void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x000FCB70 File Offset: 0x000FAD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000FCBB0 File Offset: 0x000FADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341859, XrefRangeEnd = 341862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKeyGenerated(Object sender, EventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSACryptoServiceProvider.NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00012472 File Offset: 0x00010672
		public DSACryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x000FCC04 File Offset: 0x000FAE04
		// (set) Token: 0x0600335E RID: 13150 RVA: 0x0001247B File Offset: 0x0001067B
		public unsafe KeyPairPersistence store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyPairPersistence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x000FCC34 File Offset: 0x000FAE34
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x0001249A File Offset: 0x0001069A
		public unsafe bool persistKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persistKey)) = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x000FCC5C File Offset: 0x000FAE5C
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x000124B5 File Offset: 0x000106B5
		public unsafe bool persisted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_persisted)) = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x000FCC84 File Offset: 0x000FAE84
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x000124D0 File Offset: 0x000106D0
		public unsafe bool privateKeyExportable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_privateKeyExportable)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x000FCCAC File Offset: 0x000FAEAC
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x000124EB File Offset: 0x000106EB
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x000FCCD4 File Offset: 0x000FAED4
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x00012506 File Offset: 0x00010706
		public unsafe DSAManaged dsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSAManaged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSACryptoServiceProvider.NativeFieldInfoPtr_dsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000FCD04 File Offset: 0x000FAF04
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x00012525 File Offset: 0x00010725
		public unsafe static bool useMachineKeyStore
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DSACryptoServiceProvider.NativeFieldInfoPtr_useMachineKeyStore, (void*)(&value));
			}
		}

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeFieldInfoPtr_persistKey;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeFieldInfoPtr_persisted;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeFieldInfoPtr_privateKeyExportable;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeFieldInfoPtr_dsa;

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeFieldInfoPtr_useMachineKeyStore;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeMethodInfoPtr_Common_Private_Void_Int32_Boolean_0;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_get_Int32_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicOnly_Public_get_Boolean_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Virtual_DSAParameters_Boolean_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Virtual_Void_DSAParameters_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr_OnKeyGenerated_Private_Void_Object_EventArgs_0;
	}
}
