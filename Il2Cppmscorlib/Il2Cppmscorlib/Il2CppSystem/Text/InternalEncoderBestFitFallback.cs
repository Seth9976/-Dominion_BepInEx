using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000162 RID: 354
	[Serializable]
	public class InternalEncoderBestFitFallback : EncoderFallback
	{
		// Token: 0x060017FA RID: 6138 RVA: 0x0008DE60 File Offset: 0x0008C060
		// Note: this type is marked as 'beforefieldinit'.
		static InternalEncoderBestFitFallback()
		{
			Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalEncoderBestFitFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr);
			InternalEncoderBestFitFallback.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, "encoding");
			InternalEncoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, "arrayBestFit");
			InternalEncoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100667289);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100667290);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100667291);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100667292);
			InternalEncoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr, 100667293);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0008DF1C File Offset: 0x0008C11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310260, RefRangeEnd = 310261, XrefRangeStart = 310259, XrefRangeEnd = 310260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalEncoderBestFitFallback(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalEncoderBestFitFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalEncoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0008DF68 File Offset: 0x0008C168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310261, XrefRangeEnd = 310265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x0008DFB4 File Offset: 0x0008C1B4
		public unsafe override int MaxCharCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0008DFFC File Offset: 0x0008C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310265, XrefRangeEnd = 310267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0008E054 File Offset: 0x0008C254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InternalEncoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000086BC File Offset: 0x000068BC
		public InternalEncoderBestFitFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x0008E09C File Offset: 0x0008C29C
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x000086C5 File Offset: 0x000068C5
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0008E0CC File Offset: 0x0008C2CC
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x000086E4 File Offset: 0x000068E4
		public unsafe Il2CppStructArray<char> arrayBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalEncoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeFieldInfoPtr_arrayBestFit;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
