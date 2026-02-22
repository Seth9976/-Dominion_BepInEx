using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000158 RID: 344
	public sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x0008B88C File Offset: 0x00089A8C
		// Note: this type is marked as 'beforefieldinit'.
		static InternalDecoderBestFitFallbackBuffer()
		{
			Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalDecoderBestFitFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr);
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "cBestFit");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "iCount");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "iSize");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "oFallback");
			InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, "s_InternalSyncObject");
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667213);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667214);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667215);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667216);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667217);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667218);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667219);
			InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr, 100667220);
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0008B9C0 File Offset: 0x00089BC0
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309800, XrefRangeEnd = 309809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0008B9F4 File Offset: 0x00089BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309822, RefRangeEnd = 309823, XrefRangeStart = 309809, XrefRangeEnd = 309822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalDecoderBestFitFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0008BA40 File Offset: 0x00089C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309823, XrefRangeEnd = 309824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0008BA9C File Offset: 0x00089C9C
		[CallerCount(0)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0008BAD8 File Offset: 0x00089CD8
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0008BB14 File Offset: 0x00089D14
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0008BB48 File Offset: 0x00089D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0008BBA4 File Offset: 0x00089DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309825, RefRangeEnd = 309826, XrefRangeStart = 309824, XrefRangeEnd = 309825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char TryBestFit(Il2CppStructArray<byte> bytesCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallbackBuffer.NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000083FD File Offset: 0x000065FD
		public InternalDecoderBestFitFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0008BBF4 File Offset: 0x00089DF4
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x00008406 File Offset: 0x00006606
		public unsafe char cBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_cBestFit)) = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x0008BC1C File Offset: 0x00089E1C
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x00008421 File Offset: 0x00006621
		public unsafe int iCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iCount)) = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0008BC44 File Offset: 0x00089E44
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x0000843C File Offset: 0x0000663C
		public unsafe int iSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_iSize)) = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0008BC6C File Offset: 0x00089E6C
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x00008457 File Offset: 0x00006657
		public unsafe InternalDecoderBestFitFallback oFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalDecoderBestFitFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_oFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0008BC9C File Offset: 0x00089E9C
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00008476 File Offset: 0x00006676
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalDecoderBestFitFallbackBuffer.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeFieldInfoPtr_cBestFit;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeFieldInfoPtr_iCount;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeFieldInfoPtr_iSize;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeFieldInfoPtr_oFallback;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InternalDecoderBestFitFallback_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_TryBestFit_Private_Char_Il2CppStructArray_1_Byte_0;
	}
}
