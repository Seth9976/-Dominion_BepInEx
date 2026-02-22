using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000157 RID: 343
	[Serializable]
	public sealed class InternalDecoderBestFitFallback : DecoderFallback
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x0008B5E0 File Offset: 0x000897E0
		// Note: this type is marked as 'beforefieldinit'.
		static InternalDecoderBestFitFallback()
		{
			Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "InternalDecoderBestFitFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr);
			InternalDecoderBestFitFallback.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "encoding");
			InternalDecoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "arrayBestFit");
			InternalDecoderBestFitFallback.NativeFieldInfoPtr_cReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, "cReplacement");
			InternalDecoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100667208);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100667209);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100667210);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100667211);
			InternalDecoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr, 100667212);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x0008B6B0 File Offset: 0x000898B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309792, RefRangeEnd = 309793, XrefRangeStart = 309791, XrefRangeEnd = 309792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalDecoderBestFitFallback(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalDecoderBestFitFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0008B6FC File Offset: 0x000898FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309793, XrefRangeEnd = 309797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0008B73C File Offset: 0x0008993C
		public unsafe override int MaxCharCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0008B778 File Offset: 0x00089978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309797, XrefRangeEnd = 309799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0008B7C8 File Offset: 0x000899C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309799, XrefRangeEnd = 309800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalDecoderBestFitFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0000839B File Offset: 0x0000659B
		public InternalDecoderBestFitFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x0008B804 File Offset: 0x00089A04
		// (set) Token: 0x06001767 RID: 5991 RVA: 0x000083A4 File Offset: 0x000065A4
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0008B834 File Offset: 0x00089A34
		// (set) Token: 0x06001769 RID: 5993 RVA: 0x000083C3 File Offset: 0x000065C3
		public unsafe Il2CppStructArray<char> arrayBestFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_arrayBestFit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0008B864 File Offset: 0x00089A64
		// (set) Token: 0x0600176B RID: 5995 RVA: 0x000083E2 File Offset: 0x000065E2
		public unsafe char cReplacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_cReplacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalDecoderBestFitFallback.NativeFieldInfoPtr_cReplacement)) = value;
			}
		}

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeFieldInfoPtr_arrayBestFit;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeFieldInfoPtr_cReplacement;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
