using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000015 RID: 21
	public class Type1Message : MessageBase
	{
		// Token: 0x06000133 RID: 307 RVA: 0x00007F74 File Offset: 0x00006174
		// Note: this type is marked as 'beforefieldinit'.
		static Type1Message()
		{
			Il2CppClassPointerStore<Type1Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "Type1Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Type1Message>.NativeClassPtr);
			Type1Message.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, "_host");
			Type1Message.NativeFieldInfoPtr__domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, "_domain");
			Type1Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663469);
			Type1Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663470);
			Type1Message.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663471);
			Type1Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663472);
			Type1Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Type1Message>.NativeClassPtr, 100663473);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00008030 File Offset: 0x00006230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8839, RefRangeEnd = 8840, XrefRangeStart = 8833, XrefRangeEnd = 8839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type1Message()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Type1Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006A RID: 106
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000806C File Offset: 0x0000626C
		public unsafe string Domain
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8843, RefRangeEnd = 8844, XrefRangeStart = 8840, XrefRangeEnd = 8843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (set) Token: 0x06000136 RID: 310 RVA: 0x000080B0 File Offset: 0x000062B0
		public unsafe string Host
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8847, RefRangeEnd = 8848, XrefRangeStart = 8844, XrefRangeEnd = 8847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Type1Message.NativeMethodInfoPtr_set_Host_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000080F4 File Offset: 0x000062F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8848, XrefRangeEnd = 8855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type1Message.NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008144 File Offset: 0x00006344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8855, XrefRangeEnd = 8867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Type1Message.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002860 File Offset: 0x00000A60
		public Type1Message(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002869 File Offset: 0x00000A69
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000081B8 File Offset: 0x000063B8
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002888 File Offset: 0x00000A88
		public unsafe string _domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Type1Message.NativeFieldInfoPtr__domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr__domain;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_set_Host_Public_set_Void_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
