using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x02000160 RID: 352
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x0008D638 File Offset: 0x0008B838
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderReplacementFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderReplacementFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr);
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "strDefault");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackCount");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackIndex");
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667273);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667274);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667275);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667276);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667277);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100667278);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0008D71C File Offset: 0x0008B91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310212, XrefRangeEnd = 310213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0008D768 File Offset: 0x0008B968
		[CallerCount(0)]
		public unsafe override bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0008D7C4 File Offset: 0x0008B9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310213, XrefRangeEnd = 310214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0008D800 File Offset: 0x0008BA00
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0008D83C File Offset: 0x0008BA3C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0008D870 File Offset: 0x0008BA70
		[CallerCount(0)]
		public unsafe override int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00008617 File Offset: 0x00006817
		public DecoderReplacementFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0008D8CC File Offset: 0x0008BACC
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00008620 File Offset: 0x00006820
		public unsafe string strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0008D8F4 File Offset: 0x0008BAF4
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000863F File Offset: 0x0000683F
		public unsafe int fallbackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0008D91C File Offset: 0x0008BB1C
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000865A File Offset: 0x0000685A
		public unsafe int fallbackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex)) = value;
			}
		}

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeFieldInfoPtr_strDefault;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeFieldInfoPtr_fallbackCount;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeFieldInfoPtr_fallbackIndex;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;
	}
}
