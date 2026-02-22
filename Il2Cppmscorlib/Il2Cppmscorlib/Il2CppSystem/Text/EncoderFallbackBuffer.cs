using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000168 RID: 360
	public class EncoderFallbackBuffer : Object
	{
		// Token: 0x06001847 RID: 6215 RVA: 0x0008EFAC File Offset: 0x0008D1AC
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr);
			EncoderFallbackBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charStart");
			EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "charEnd");
			EncoderFallbackBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "encoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "setEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bUsedEncoder");
			EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "bFallingBack");
			EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, "iRecursionCount");
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667324);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667325);
			EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667326);
			EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667327);
			EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667328);
			EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667329);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667330);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667331);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667332);
			EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667333);
			EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667334);
			EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr, 100667335);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0008F158 File Offset: 0x0008D358
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0008F1BC File Offset: 0x0008D3BC
		[CallerCount(0)]
		public unsafe virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0008F22C File Offset: 0x0008D42C
		[CallerCount(0)]
		public unsafe virtual char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0008F274 File Offset: 0x0008D474
		[CallerCount(0)]
		public unsafe virtual bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x0008F2BC File Offset: 0x0008D4BC
		public unsafe virtual int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0008F304 File Offset: 0x0008D504
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0008F340 File Offset: 0x0008D540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310475, RefRangeEnd = 310476, XrefRangeStart = 310475, XrefRangeEnd = 310475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0008F374 File Offset: 0x0008D574
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 310476, RefRangeEnd = 310501, XrefRangeStart = 310476, XrefRangeEnd = 310476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setEncoder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 310501, RefRangeEnd = 310517, XrefRangeStart = 310501, XrefRangeEnd = 310501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char InternalGetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0008F41C File Offset: 0x0008D61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310517, XrefRangeEnd = 310526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InternalFallback(char ch, ref char* chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chars = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0008F49C File Offset: 0x0008D69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310526, XrefRangeEnd = 310541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowLastCharRecursive(int charRecursive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charRecursive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0008F4DC File Offset: 0x0008D6DC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000886F File Offset: 0x00006A6F
		public EncoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0008F518 File Offset: 0x0008D718
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00008878 File Offset: 0x00006A78
		public unsafe char* charStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charStart)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x0008F53C File Offset: 0x0008D73C
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00008893 File Offset: 0x00006A93
		public unsafe char* charEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_charEnd)) = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x0008F560 File Offset: 0x0008D760
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x000088AE File Offset: 0x00006AAE
		public unsafe EncoderNLS encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x0008F590 File Offset: 0x0008D790
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x000088CD File Offset: 0x00006ACD
		public unsafe bool setEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_setEncoder)) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x0008F5B8 File Offset: 0x0008D7B8
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x000088E8 File Offset: 0x00006AE8
		public unsafe bool bUsedEncoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bUsedEncoder)) = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0008F5E0 File Offset: 0x0008D7E0
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x00008903 File Offset: 0x00006B03
		public unsafe bool bFallingBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_bFallingBack)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x0008F608 File Offset: 0x0008D808
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x0000891E File Offset: 0x00006B1E
		public unsafe int iRecursionCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackBuffer.NativeFieldInfoPtr_iRecursionCount)) = value;
			}
		}

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_charStart;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_charEnd;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_setEncoder;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_bUsedEncoder;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_bFallingBack;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_iRecursionCount;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Int32_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Char_Char_Int32_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_InternalReset_Internal_Void_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Char_ptr_Char_EncoderNLS_Boolean_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNextChar_Internal_Char_0;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Char_byref_ptr_Char_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLastCharRecursive_Internal_Void_Int32_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
