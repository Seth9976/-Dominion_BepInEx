using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002E RID: 46
	public sealed class PKCS1 : Object
	{
		// Token: 0x0600024F RID: 591 RVA: 0x0000C36C File Offset: 0x0000A56C
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS1()
		{
			Il2CppClassPointerStore<PKCS1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "PKCS1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS1>.NativeClassPtr);
			PKCS1.NativeFieldInfoPtr_emptySHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA1");
			PKCS1.NativeFieldInfoPtr_emptySHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA256");
			PKCS1.NativeFieldInfoPtr_emptySHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA384");
			PKCS1.NativeFieldInfoPtr_emptySHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA512");
			PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663601);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000C400 File Offset: 0x0000A600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 10421, RefRangeEnd = 10422, XrefRangeStart = 10404, XrefRangeEnd = 10421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashAlgorithm CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00003018 File Offset: 0x00001218
		public PKCS1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000C444 File Offset: 0x0000A644
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00003021 File Offset: 0x00001221
		public unsafe static Il2CppStructArray<byte> emptySHA1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000C46C File Offset: 0x0000A66C
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00003033 File Offset: 0x00001233
		public unsafe static Il2CppStructArray<byte> emptySHA256
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA256, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA256, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0000C494 File Offset: 0x0000A694
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00003045 File Offset: 0x00001245
		public unsafe static Il2CppStructArray<byte> emptySHA384
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA384, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA384, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00003057 File Offset: 0x00001257
		public unsafe static Il2CppStructArray<byte> emptySHA512
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PKCS1.NativeFieldInfoPtr_emptySHA512, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS1.NativeFieldInfoPtr_emptySHA512, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA1;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA256;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA384;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA512;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0;
	}
}
