using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000318 RID: 792
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x06003394 RID: 13204 RVA: 0x000FD4FC File Offset: 0x000FB6FC
		// Note: this type is marked as 'beforefieldinit'.
		static RNGCryptoServiceProvider()
		{
			Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RNGCryptoServiceProvider");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_lock");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_handle");
			RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671302);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671303);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671304);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671305);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671306);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671307);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671308);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671309);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100671310);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x000FD600 File Offset: 0x000FB800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341944, RefRangeEnd = 341946, XrefRangeStart = 341938, XrefRangeEnd = 341944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RNGCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000FD63C File Offset: 0x000FB83C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 341948, RefRangeEnd = 341951, XrefRangeStart = 341946, XrefRangeEnd = 341948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x000FD670 File Offset: 0x000FB870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304884, RefRangeEnd = 304885, XrefRangeStart = 304884, XrefRangeEnd = 304885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RngOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000FD6A0 File Offset: 0x000FB8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341951, XrefRangeEnd = 341952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngInitialize(Il2CppStructArray<byte> seed)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x000FD6E4 File Offset: 0x000FB8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341952, XrefRangeEnd = 341953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngGetBytes(IntPtr handle, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000FD734 File Offset: 0x000FB934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341953, XrefRangeEnd = 341954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RngClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x000FD768 File Offset: 0x000FB968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341954, XrefRangeEnd = 341970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetBytes(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x000FD7AC File Offset: 0x000FB9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341970, XrefRangeEnd = 341979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000FD7E0 File Offset: 0x000FB9E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000126A2 File Offset: 0x000108A2
		public RNGCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x000FD820 File Offset: 0x000FBA20
		// (set) Token: 0x060033A0 RID: 13216 RVA: 0x000126AB File Offset: 0x000108AB
		public unsafe static Object _lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x000FD848 File Offset: 0x000FBA48
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x000126BD File Offset: 0x000108BD
		public unsafe IntPtr _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle)) = value;
			}
		}

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_Check_Private_Void_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
