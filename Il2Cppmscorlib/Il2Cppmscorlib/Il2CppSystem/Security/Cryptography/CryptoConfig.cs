using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000313 RID: 787
	public class CryptoConfig : Object
	{
		// Token: 0x06003323 RID: 13091 RVA: 0x000FBED8 File Offset: 0x000FA0D8
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConfig()
		{
			Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr);
			CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671262);
			CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671263);
			CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671264);
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671265);
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671266);
			CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671267);
			CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100671268);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x000FBF94 File Offset: 0x000FA194
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 341383, RefRangeEnd = 341392, XrefRangeStart = 341354, XrefRangeEnd = 341383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeOID(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x000FBFD8 File Offset: 0x000FA1D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341399, RefRangeEnd = 341400, XrefRangeStart = 341392, XrefRangeEnd = 341399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeLongNumber(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003326 RID: 13094 RVA: 0x000FC018 File Offset: 0x000FA218
		public unsafe static bool AllowOnlyFipsAlgorithms
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x000FC048 File Offset: 0x000FA248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341401, RefRangeEnd = 341402, XrefRangeStart = 341400, XrefRangeEnd = 341401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x000FC08C File Offset: 0x000FA28C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341544, RefRangeEnd = 341545, XrefRangeStart = 341402, XrefRangeEnd = 341544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x000FC0F0 File Offset: 0x000FA2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341546, RefRangeEnd = 341548, XrefRangeStart = 341545, XrefRangeEnd = 341546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNameToOID(string name, Object arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x000FC140 File Offset: 0x000FA340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341596, RefRangeEnd = 341597, XrefRangeStart = 341548, XrefRangeEnd = 341596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNameToOID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00012351 File Offset: 0x00010551
		public static Object CreateFromName(string name, params Object[] args)
		{
			return CryptoConfig.CreateFromName(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x0001235F File Offset: 0x0001055F
		public CryptoConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeMethodInfoPtr_MapNameToOID_Internal_Static_String_String_Object_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0;
	}
}
