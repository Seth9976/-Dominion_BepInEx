using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015B RID: 347
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		// Token: 0x0600178E RID: 6030 RVA: 0x0008C090 File Offset: 0x0008A290
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallbackException()
		{
			Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr);
			DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "bytesUnknown");
			DecoderFallbackException.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "index");
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667231);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667232);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100667233);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0008C124 File Offset: 0x0008A324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309882, XrefRangeEnd = 309887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0008C160 File Offset: 0x0008A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309887, XrefRangeEnd = 309888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0008C1C4 File Offset: 0x0008A3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309889, RefRangeEnd = 309890, XrefRangeStart = 309888, XrefRangeEnd = 309889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(string message, Il2CppStructArray<byte> bytesUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0000849A File Offset: 0x0000669A
		public DecoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0008C230 File Offset: 0x0008A430
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x000084A3 File Offset: 0x000066A3
		public unsafe Il2CppStructArray<byte> bytesUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_bytesUnknown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0008C260 File Offset: 0x0008A460
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x000084C2 File Offset: 0x000066C2
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeFieldInfoPtr_bytesUnknown;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0;
	}
}
