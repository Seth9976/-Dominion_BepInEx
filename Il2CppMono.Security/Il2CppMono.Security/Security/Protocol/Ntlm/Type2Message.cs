using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000016 RID: 22
	public class Type2Message : MessageBase
	{
		// Token: 0x0600013E RID: 318 RVA: 0x000081E0 File Offset: 0x000063E0
		// Note: this type is marked as 'beforefieldinit'.
		static Type2Message()
		{
			Il2CppClassPointerStore<Type2Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type2Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type2Message>.NativeClassPtr);
			Type2Message.NativeFieldInfoPtr__nonce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_nonce");
			Type2Message.NativeFieldInfoPtr__targetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_targetName");
			Type2Message.NativeFieldInfoPtr__targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, "_targetInfo");
			Type2Message.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663474);
			Type2Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663475);
			Type2Message.NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663476);
			Type2Message.NativeMethodInfoPtr_get_TargetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663477);
			Type2Message.NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663478);
			Type2Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663479);
			Type2Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type2Message>.NativeClassPtr, 100663480);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000082D8 File Offset: 0x000064D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8874, RefRangeEnd = 8875, XrefRangeStart = 8867, XrefRangeEnd = 8874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type2Message(Il2CppStructArray<byte> message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type2Message>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00008324 File Offset: 0x00006524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8875, XrefRangeEnd = 8879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe Il2CppStructArray<byte> Nonce
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 8882, RefRangeEnd = 8885, XrefRangeStart = 8879, XrefRangeEnd = 8882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000083A0 File Offset: 0x000065A0
		public unsafe string TargetName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_TargetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000083D8 File Offset: 0x000065D8
		public unsafe Il2CppStructArray<byte> TargetInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 8888, RefRangeEnd = 8891, XrefRangeStart = 8885, XrefRangeEnd = 8888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type2Message.NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008418 File Offset: 0x00006618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8891, XrefRangeEnd = 8905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008468 File Offset: 0x00006668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8905, XrefRangeEnd = 8907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type2Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000028A7 File Offset: 0x00000AA7
		public Type2Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000084B4 File Offset: 0x000066B4
		// (set) Token: 0x06000148 RID: 328 RVA: 0x000028B0 File Offset: 0x00000AB0
		public unsafe Il2CppStructArray<byte> _nonce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__nonce);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__nonce), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000084E4 File Offset: 0x000066E4
		// (set) Token: 0x0600014A RID: 330 RVA: 0x000028CF File Offset: 0x00000ACF
		public unsafe string _targetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000850C File Offset: 0x0000670C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x000028EE File Offset: 0x00000AEE
		public unsafe Il2CppStructArray<byte> _targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type2Message.NativeFieldInfoPtr__targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__nonce;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr__targetName;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr__targetInfo;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetName_Public_get_String_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetInfo_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
