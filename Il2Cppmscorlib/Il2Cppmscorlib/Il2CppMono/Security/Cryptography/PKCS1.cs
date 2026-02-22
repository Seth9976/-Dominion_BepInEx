using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000030 RID: 48
	public sealed class PKCS1 : Object
	{
		// Token: 0x06000325 RID: 805 RVA: 0x0002E690 File Offset: 0x0002C890
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS1()
		{
			Il2CppClassPointerStore<PKCS1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "PKCS1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS1>.NativeClassPtr);
			PKCS1.NativeFieldInfoPtr_emptySHA1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA1");
			PKCS1.NativeFieldInfoPtr_emptySHA256 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA256");
			PKCS1.NativeFieldInfoPtr_emptySHA384 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA384");
			PKCS1.NativeFieldInfoPtr_emptySHA512 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, "emptySHA512");
			PKCS1.NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS1>.NativeClassPtr, 100663712);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0002E724 File Offset: 0x0002C924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262955, RefRangeEnd = 262956, XrefRangeStart = 262911, XrefRangeEnd = 262955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000327 RID: 807 RVA: 0x000034C3 File Offset: 0x000016C3
		public PKCS1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0002E768 File Offset: 0x0002C968
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000034CC File Offset: 0x000016CC
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0002E790 File Offset: 0x0002C990
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000034DE File Offset: 0x000016DE
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000034F0 File Offset: 0x000016F0
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

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003502 File Offset: 0x00001702
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

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA1;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA256;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA384;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_emptySHA512;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Internal_Static_HashAlgorithm_String_0;
	}
}
