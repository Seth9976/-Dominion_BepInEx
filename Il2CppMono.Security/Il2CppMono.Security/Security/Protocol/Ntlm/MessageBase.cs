using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000011 RID: 17
	public class MessageBase : Object
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00007B14 File Offset: 0x00005D14
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBase()
		{
			Il2CppClassPointerStore<MessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "MessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBase>.NativeClassPtr);
			MessageBase.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "header");
			MessageBase.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "_type");
			MessageBase.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, "_flags");
			MessageBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663458);
			MessageBase.NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663459);
			MessageBase.NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663460);
			MessageBase.NativeMethodInfoPtr_get_Type_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663461);
			MessageBase.NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663462);
			MessageBase.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663463);
			MessageBase.NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663464);
			MessageBase.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBase>.NativeClassPtr, 100663465);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007C20 File Offset: 0x00005E20
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8590, XrefRangeEnd = 8591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBase(int messageType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00007C68 File Offset: 0x00005E68
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public unsafe NtlmFlags Flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00007CE4 File Offset: 0x00005EE4
		public unsafe int Type
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_get_Type_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00007D20 File Offset: 0x00005F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 8808, RefRangeEnd = 8811, XrefRangeStart = 8800, XrefRangeEnd = 8808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> PrepareMessage(int messageSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007D6C File Offset: 0x00005F6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 8819, RefRangeEnd = 8822, XrefRangeStart = 8811, XrefRangeEnd = 8819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Decode(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBase.NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007DBC File Offset: 0x00005FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8822, XrefRangeEnd = 8829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckHeader(Il2CppStructArray<byte> message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBase.NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00007E0C File Offset: 0x0000600C
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBase.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000027F8 File Offset: 0x000009F8
		public MessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00007E58 File Offset: 0x00006058
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002801 File Offset: 0x00000A01
		public unsafe static Il2CppStructArray<byte> header
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessageBase.NativeFieldInfoPtr_header, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBase.NativeFieldInfoPtr_header, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00007E80 File Offset: 0x00006080
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002813 File Offset: 0x00000A13
		public unsafe int _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00007EA8 File Offset: 0x000060A8
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000282E File Offset: 0x00000A2E
		public unsafe NtlmFlags _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBase.NativeFieldInfoPtr__flags)) = value;
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_get_NtlmFlags_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_set_Flags_Public_set_Void_NtlmFlags_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Int32_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_PrepareMessage_Protected_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_CheckHeader_Protected_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;
	}
}
